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

        //   UserModel model = new UserModel();

        public ChallengeForm()
        {
            InitializeComponent();

            WireUpDropDown();

            //   ListBoxPopulator();

        }

        private void ListBoxPopulator()
        //reference https://docs.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=netframework-4.7.2
        {

            try
            {
                using (System.IO.StreamReader file =
                    new System.IO.StreamReader(@"StandardDataSet.csv"))
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
            localUserModel.FirstName = firstNameText.Text;
            localUserModel.LastName = lastNameText.Text;
            localUserModel.Age = Convert.ToInt32(agePicker.Text);
            localUserModel.IsAlive = isAliveCheckbox.Checked;
            users.Add(localUserModel);
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {

            var userList = new List<string>();

            userList.Add("FirstName,LastName,Age,IsAlive");
            foreach (var user in users)
            {
                var isalive = user.IsAlive ? "1" : "0";// ternery operator worth learning!
                userList.Add($"{user.FirstName},{user.LastName},{user.Age},{isalive}");
            }
            
            File.WriteAllLines(@"StandardDataSet.csv",userList);
        }

        private void ChallengeForm_Load(object sender, EventArgs e)
        {
            string filePath = @"StandardDataSet.csv";

            usersListBox.DataSource = users;
            List<string> lines = File.ReadAllLines(filePath).Skip(1).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                var newUserModel = new UserModel();
                newUserModel.FirstName = entries[0];
                newUserModel.LastName = entries[1];
                newUserModel.Age = Convert.ToInt32(entries[2]);
                newUserModel.IsAlive = Convert.ToInt32(entries[3]) == 1;
                users.Add(newUserModel);
            }
        }
    }
}





