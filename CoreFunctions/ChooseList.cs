using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using common;
namespace VotingSystemVer2.CoreFunctions
{
    /// <summary>
    /// Handels the choosing list and store the question and choose list values
    /// </summary>
    public class ChooseList : MarshalByRefObject, Remote.commonlist
    {
        public static String question = null;

        public String Question
        {
            get { return ChooseList.question; }
            set { ChooseList.question = value; }
        }

        public static bool multiChoice = false;
        public static Dictionary<string, byte[]> choiceList = new Dictionary<string, byte[]>();

        public static Dictionary<string, byte[]> ChoiceList
        {
            get { return ChooseList.choiceList; }
            set { ChooseList.choiceList = value; }
        }

        public Dictionary<string, byte[]>  getlist()
        {
            return choiceList;
        }

        public bool multichoice()
        {
            return multiChoice;
        }
    }
}
