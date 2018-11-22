using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextFileChallenge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChallengeForm());

            

            //string filePath = @"C:\Users\ja122756\Documents\Visual Studio 2015\Projects\TextFileChallengeStarterCode\TextFileChallenge\StandardDataSet.csv";

            //List<UserModel> People = new List<UserModel>();
            //List<string> lines = File.ReadAllLines(filePath).ToList();
            //foreach (var line in lines)
            //{
            //    string[] entries = line.Split(',');

            //    UserModel newUserModel = new UserModel();
            //    string Ages = newUserModel.Age.ToString();
            //    string IsAliveStatus = newUserModel.IsAlive.ToString();

            //    newUserModel.FirstName = entries[0];
            //    newUserModel.LastName = entries[1];
            //    Ages = entries[2];
            //    IsAliveStatus = entries[3];
            //}
            //foreach (var UserModel in People)
            //{

            //}
        }
    }
}
