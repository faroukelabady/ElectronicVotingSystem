using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using AForge.Imaging.Filters;

namespace VotingSystemVer2.CoreFunctions
{
    public class NumExtraction
    {

        Bitmap image;
        List<Bitmap> extractedNums;
        /// <summary>
        /// The downsample width for the application.
        /// </summary>
        const int DOWNSAMPLE_WIDTH = 10;
        /// <summary>
        /// The down sample height for the application.
        /// </summary>
        const int DOWNSAMPLE_HEIGHT = 13;

        private bool[] downsampled;
        private Dictionary<int, bool[]> numbersData = new Dictionary<int, bool[]>();

        private static int redVal = 110;

        public int RedVal
        {
            get { return redVal; }
            set { redVal = value; }
        }
        private static int greenVal = 117;

        public int GreenVal
        {
            get { return greenVal; }
            set { greenVal = value; }
        }
        private static int blueVal = 130;

        public int BlueVal
        {
            get { return blueVal; }
            set { blueVal = value; }
        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="image"></param>
        public NumExtraction(Bitmap image)
        {
            this.image = image;
        }

        public void startExtraction()
        {
            // convert image into binary image and store it in another bitmap object in 1bppindexed format
            //Bitmap tempimage = Img2BW(image).Clone(new Rectangle(0, 0, image.Width, image.Height),
            //    PixelFormat.Format1bppIndexed);
            //tempimage.Save("i:\\hero2.gif", ImageFormat.Gif);
            Bitmap tempimage = removeLonelyBlack(image);
            extractedNums = removeWidthBorder(tempimage);
            getSampleData();
        }

        /// <summary>
        /// get the binary data of images stored in template folder and store it 
        /// to compare the image that we get from the webcam to the stored values
        /// </summary>
        private void getSampleData()
        {
            string path;
            for (int i = 0; i < 10; i++)
            {
                path = "i:\\Templates\\" + i + ".gif";
                //path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.
                //    GetExecutingAssembly().Location) + "\\Templates\\" + i + ".jpg";
                
                Bitmap image = new Bitmap(path);
                // create filter
                ResizeBicubic filter = new ResizeBicubic(DOWNSAMPLE_WIDTH, DOWNSAMPLE_HEIGHT);
                image = filter.Apply(image);

                DownSample ds = new DownSample(image.Clone(new Rectangle(0, 0, DOWNSAMPLE_WIDTH, DOWNSAMPLE_HEIGHT),
                    System.Drawing.Imaging.PixelFormat.Format1bppIndexed));
                downsampled = ds.PerformDownSample(DOWNSAMPLE_WIDTH, DOWNSAMPLE_HEIGHT);
                numbersData.Add(i, downsampled);
            }
        }

        public List<int> readNumbers()
        {
            Bitmap image;
            List<int> numbers = new List<int>();
            for (int i = 0; i < extractedNums.Count; i++)
            {
                // create filter
                ResizeBicubic filter = new ResizeBicubic(DOWNSAMPLE_WIDTH, DOWNSAMPLE_HEIGHT);
                // resize all images to make them equal in size
                if (extractedNums[i] == null) continue;
                image = filter.Apply(extractedNums[i]);
                // down sample each image in other words get a binary representation of the image and compare it with
                // with images in templates folder
                DownSample ds = new DownSample(image.Clone(new Rectangle(0, 0, DOWNSAMPLE_WIDTH, DOWNSAMPLE_HEIGHT),
                    System.Drawing.Imaging.PixelFormat.Format1bppIndexed));
                downsampled = ds.PerformDownSample(DOWNSAMPLE_WIDTH, DOWNSAMPLE_HEIGHT);
                // the logic here goes as follows
                // first downsample (get binary data) of each image that inside extractednum list
                // then compare this data to all the samples that we have inside numbersData dicitionary
                // and get the nearest similar data in numberData and hence the number that we try to seek
                int sampleSize = DOWNSAMPLE_HEIGHT * DOWNSAMPLE_WIDTH;
                int similar = 0;
                List<double> result = new List<double>();
                int bestNumber = 0;
                // loop for each numberData
                foreach (int num in numbersData.Keys)
                {
                    similar = 0;
                    bool[] data = numbersData[num]; // get the binary represenation of the current numberData

                    for (int k = 0; k < downsampled.Length; k++)
                    {
                        // compare the current binary data to the data we got from the extracted image
                        // and for each binary similar we increase the similarty
                        if (data[k] == downsampled[k])
                            similar++;
                    }
                    // get the average in other words convert it to perecent %
                    double average = ((double)similar / (double)sampleSize);
                    result.Add(average);
                }
                // get the location of the nearest similarty
                bestNumber = MaxValue(result.ToArray());
                numbers.Add(bestNumber); // store the number that we got inside a list
                result.Clear();
            }
            // return the list of extracted numbers from the image
            return numbers;
        }

        /// <summary>
        /// get the max value location in a double array
        /// </summary>
        /// <param name="doubleArray">
        /// double[]
        /// </param>
        /// <returns>
        /// max value location
        /// </returns>
        static int MaxValue(double[] doubleArray)
        {
            double maxVal = doubleArray[0];
            int location = 0;
            for (int i = 0; i < doubleArray.Length; i++)
            {
                if (doubleArray[i] > maxVal)
                {
                    maxVal = doubleArray[i];
                    location = i;
                }
            }
            return location;
        }

        /// <summary>
        /// convert color image into binary image using threshold technique
        /// here the threshold will focus on RGB values that corresponds to colors
        /// near the black color so any color near the black color will be black 
        /// other colors will be white
        /// </summary>
        /// <param name="imgSrc">
        /// an image to convert
        /// </param>
        /// <returns>
        /// Bitmap binary image
        /// </returns>
        public Bitmap Img2BW(Bitmap imgSrc)
        {
            int width = imgSrc.Width;
            int height = imgSrc.Height;

            Color pixel;
            Bitmap imgOut = new Bitmap(imgSrc);
            for (int row = 0; row < height - 1; row++)
            {
                for (int col = 0; col < width - 1; col++)
                {
                    pixel = imgSrc.GetPixel(col, row);

                    if (pixel.R < redVal & pixel.G < greenVal & pixel.B < blueVal)
                        imgOut.SetPixel(col, row, Color.Black);
                    else
                        imgOut.SetPixel(col, row, Color.White);
                }
            }
            return imgOut;
        }
        /// <summary>
        /// Removes indivdual black pixels leaving only the numbers
        /// </summary>
        /// <param name="image">
        /// ID number binary image
        /// </param>
        /// <returns>
        /// image contains the ID Numbers only
        /// </returns>
        private Bitmap removeLonelyBlack(Bitmap image)
        {
            Bitmap temp = image.Clone(new Rectangle(0,0, image.Width, image.Height), PixelFormat.Format24bppRgb);                                             
            for (int i = 0; i < temp.Width; i++)
            {                
                for (int j = 0; j < temp.Height; j++)
                {                    
                    try
                    {
                        if (temp.GetPixel(i - 1, j - 1).R == 255 & temp.GetPixel(i - 1, j).R == 255 &
                            temp.GetPixel(i - 1, j + 1).R == 255 & temp.GetPixel(i, j + 1).R == 255 &
                            temp.GetPixel(i + 1, j + 1).R == 255 & temp.GetPixel(i + 1, j).R == 255 &
                            temp.GetPixel(i + 1, j - 1).R == 255 & temp.GetPixel(i, j - 1).R == 255 &
                            temp.GetPixel(i, j).R == 0)
                        {
                            temp.SetPixel(i, j, Color.White);                            
                            
                        }

                    }
                    catch (ArgumentOutOfRangeException aore)
                    {

                    }
                }
                
            }
            return temp;
        }

        /// <summary>
        /// a method for extarting number horizontaly the logic in this method is as follows
        /// we first claculate the sum values of white pixel column and when we find column
        /// whose value is less than the maximum then this column marks the start of the number
        /// and when we hit a white column again then we get the end of the number and store
        /// number that we extracted into an array
        /// </summary>
        /// <param name="image">
        /// ID number binary image
        /// </param>
        /// <returns>
        /// list of bitmaps containing extracted number each number individualy
        /// </returns>
        private List<Bitmap> removeWidthBorder(Bitmap image)
        {
            Bitmap temp;
            List<Bitmap> numbers = new List<Bitmap>();
            int max = image.Height * 3 * 255; // max value of a column with all white pixels
            Color c;
            int Cb, Cg, Cr, NumStart = 0, NumEnd = 0;
            bool start = false;
            int[] ret = new int[image.Width];

            for (int i = 0; i < image.Width; i++)
            {
                Cb = 0; Cg = 0; Cr = 0;
                for (int j = 0; j < image.Height; j++)
                {
                    c = image.GetPixel(i, j);
                    Cb += c.B;
                    Cr += c.R;
                    Cg += c.G;

                }
                ret[i] = Cb + Cr + Cg;
                if (ret[i] < max & !start)
                {
                    start = true;
                    NumStart = i;
                }
                if (ret[i] == max & NumStart != 0)
                {
                    NumEnd = i;
                    temp = image.Clone(new Rectangle(NumStart - 1, 0, ((NumEnd - NumStart)) + 2, image.Height),
                        image.PixelFormat);
                    numbers.Add(RemoveHeightBorder(temp));
                    NumStart = 0;
                    NumEnd = 0;
                    start = false;
                }
            }

            return numbers;

        }

        /// <summary>
        /// refer for removewidthborder method summary for basic understanding of the logic
        /// in this method
        /// </summary>
        /// <param name="image">
        /// ID number binary image
        /// </param>
        /// <returns>
        /// bitmap extracted number
        /// </returns>
        private Bitmap RemoveHeightBorder(Bitmap image)
        {
            Bitmap temp = null;
            int max = image.Width * 3 * 255; // max value of row with all white pixels
            Color c;
            int Cb, Cg, Cr, NumStart = 0, NumEnd = 0;
            bool start = false;
            int[] ret = new int[image.Height];

            for (int i = 0; i < image.Height; i++)
            {
                Cb = 0; Cg = 0; Cr = 0;
                for (int j = 0; j < image.Width; j++)
                {
                    c = image.GetPixel(j, i);
                    Cb += c.B;
                    Cr += c.R;
                    Cg += c.G;

                }
                ret[i] = Cb + Cr + Cg;
                if (ret[i] < max & !start)
                {
                    start = true;
                    NumStart = i;

                }
                if (ret[i] == max & NumStart != 0)
                {
                    NumEnd = i;
                    temp = image.Clone(new Rectangle(0, NumStart - 1, image.Width, (NumEnd - NumStart) + 2),
                        PixelFormat.Format8bppIndexed);
                    NumStart = 0;
                    NumEnd = 0;
                    start = false;
                    break;
                }
            }

            return temp;
        }
    }
}
