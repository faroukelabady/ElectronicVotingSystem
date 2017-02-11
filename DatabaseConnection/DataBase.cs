using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace VotingSystemVer2.DatabaseConnection
{
    /// <summary>
    /// interface work as a contract between the application forms
    /// and the underlying database classes
    /// </summary>
    public interface DataBase
    {
        bool connect();
        void disConnect();
        int countChoice(string Choice);
        bool insertData(string ID, string motherName, List<string> choice);
        bool createDB();
        bool clearData();
    }
}
