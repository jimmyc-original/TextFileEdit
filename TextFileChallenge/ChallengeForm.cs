using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using static System.Net.WebRequestMethods;

namespace TextFileChallenge
{
    public partial class ChallengeForm : Form
    {
        BindingList<UserModel> users = new BindingList<UserModel>();

        UserModel model = new UserModel();

        public ChallengeForm()
        {
            InitializeComponent();

            WireUpDropDown();

            ListBoxPopulator();
            
        }

        private void ListBoxPopulator()
        //reference https://docs.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=netframework-4.7.2
        {
         
            try
            {
                using (System.IO.StreamReader file =
                    new System.IO.StreamReader(@"C:\Users\ja122756\Documents\Visual Studio 2015\Projects\TextFileChallengeStarterCode\TextFileChallenge\StandardDataSet.csv"))
                {
                    string line;
                    //read and display lines from the file until the end of that file is reached.
                    while ((line = file.ReadLine()) != null)
                    {
                        //this allows you to see whats going on in the diagnostic debugger below.
                        System.Diagnostics.Debug.WriteLine(line);
                        //this fills the user list box
                        usersListBox.Items.Add(line);
                        
                        ////set the listbox to display items in multiple columns
                        //usersListBox.MultiColumn = true;
                        ////set the selection mode to multiple and extend but we dont want that as it higlights multiple users
                        //usersListBox.SelectionMode = SelectionMode.MultiExtended;
                    }
                }
            }
            catch (Exception ex)
            {
                //Let the user know what went wrong
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }

        }


        private void WireUpDropDown()
        {
           
           
        }
        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var localUserModel = new UserModel();
            
            File.Write(localUserModel.FirstName + ",");
            File.Write(localUserModel.LastName + ",");
            file.Write(localUserModel.Age + ",");
            file.Write(localUserModel.IsAlive + ",");
            
            //List<UserModel> people = new List<UserModel>();
            //localUserModel.FirstName = firstNameText.ToString();
            //localUserModel.LastName = lastNameText.ToString();
            //localUserModel.Age = agePicker
            //localUserModel.IsAlive = isAliveCheckbox.ToString();



            people.Add(new UserModel { FirstName = localUserModel.FirstName, LastName = localUserModel.LastName, Age = localUserModel.Age, IsAlive = localUserModel.IsAlive });
           
            
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {



        }
        //var localUserModel = new UserModel();

        // using (System.IO.StreamWriter file =
        //     new System.IO.StreamWriter(@"C:\Users\ja122756\Documents\Visual Studio 2015\Projects\TextFileChallengeStarterCode\TextFileChallenge\StandardDataSet.csv", true))
        // {
        //     localUserModel.FirstName = firstNameText.Text.Trim();
        //     localUserModel.LastName = lastNameText.Text.Trim();

        //     try
        //     {
        //         //neeed to add in a loop if nothing is added.

        //         file.WriteLine();
        //         file.Write(localUserModel.FirstName + ",");
        //         file.Write(localUserModel.LastName + ",");
        //         file.Write(localUserModel.Age + ",");
        //         file.Write(localUserModel.IsAlive + ",");                                   
        //     }
        //     catch
        //     {
        //         MessageBox.Show("There was an error");
        //     }                
        // }            
    }

        //private void saveListButton_Click(object sender, EventArgs e)
        //{

        //    MessageBox.Show("Saved to file");

        //}

    }





