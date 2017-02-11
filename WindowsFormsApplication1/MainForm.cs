using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AForge.Imaging.Filters;
using VotingSystemVer2.CoreFunctions;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using UserInfo;
namespace VotingSystemVer2.VotingForms
{
    public partial class MainForm : Form
    {
        private DatabaseConnection.DataBase database = null;
        TcpServerChannel serverChannel;
        user.Info info;
        public DatabaseConnection.DataBase Database
        {
            get { return database; }
            set { database = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            // Create the server channel.
            serverChannel = new TcpServerChannel("server",9090);
            // Register the server channel.
            ChannelServices.RegisterChannel(serverChannel, false);
            // Expose an object for remote calls.
            WellKnownServiceTypeEntry RemObj = new WellKnownServiceTypeEntry(typeof(ChooseList),
                "Chooselist", WellKnownObjectMode.SingleCall); 
            RemotingConfiguration.RegisterWellKnownServiceType(RemObj);
            serverChannel.StopListening(0);
        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            
            //MessageBox.Show(e.FullPath);
            DirectoryInfo di = new DirectoryInfo(e.FullPath);
            //MessageBox.Show(di.Parent.Name);
            Bitmap b = new Bitmap(e.FullPath);            
            // create grayscale filter (BT709)
            Grayscale g = new Grayscale(0.2125, 0.7154, 0.0721);
            // apply the filter
            Bitmap i = g.Apply(b);
            // create filter
            Threshold t = new Threshold(128);
            // apply the filter
            t.ApplyInPlace(i);
            // create filter
            int startX = i.Width * 44 / 100;
            int startY = i.Height * 75 / 100;
            int endX = i.Width * 98 / 100;
            int endY  = i.Height * 88 / 100; 
            Crop filter = new Crop(new Rectangle(startX, startY, endX - startX, endY - startY));
            // apply the filter            
            Bitmap newImage = filter.Apply(i);
            //newImage.Save("i:\\testimage.gif", ImageFormat.Gif);
            NumExtraction ne = new NumExtraction(newImage);
            ne.startExtraction();
            List<int> result = ne.readNumbers();
            string id = "";
            foreach (int j in result)
                id += j;

            TcpClientChannel ClientChannel = new TcpClientChannel();
            ChannelServices.RegisterChannel(ClientChannel, false);
            info = (user.Info)Activator.GetObject(typeof(user.Info), "tcp://192.168.1.102:9089/user");
            //info.setIDpic(b);
            MemoryStream ms = new MemoryStream();
            b.Save(ms, ImageFormat.Bmp);
            byte[] bitmapData = ms.ToArray();
            info.setIDpic(bitmapData);
            info.setId(id);
            info.setstatus(true);
            timer1.Start();
        }

        private void chooseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigureListForm config = new ConfigureListForm();
            config.ShowDialog(this);
        }

        private void chooseDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigureDatabaseForm config = new ConfigureDatabaseForm();
            config.ShowDialog(this);
        }

        private void StartServerBtn_Click(object sender, EventArgs e)
        {
            if (StartServerBtn.Text.Equals("Start Server"))
            {
                fileSystemWatcher1.Path = @imagesTxt.Text;
                fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(fileSystemWatcher1_Created);
                StartServerBtn.Text = "Stop Server";
                serverChannel.StartListening(0);
            }
            else if (StartServerBtn.Text.Equals("Stop Server"))
            {
                //fileSystemWatcher1.Path = "";
                fileSystemWatcher1.Created -= fileSystemWatcher1_Created;
                StartServerBtn.Text = "Start Server";
                serverChannel.StopListening(0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (info.resultready())
            {
                database.insertData(info.getID(), "test", info.getresults());
                timer1.Stop();
            }
        }
        
    }
}
