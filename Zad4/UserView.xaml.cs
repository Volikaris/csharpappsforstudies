using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Zad4
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class UserView : Window
    {
        public MainWindow window;
        public User user;
        public bool opened, wasEdited = false;
        public string dataToPass = "", startData = "";
        public UserView(MainWindow window)
        {
            this.window = window;
            opened = true;
            InitializeComponent();
        }
        private void Zamknij(object sender, RoutedEventArgs e)
        {
            opened = false;
            closeEdition();
            Close();
        }
        public void FName1_TextChanged(object sender, TextChangedEventArgs e)
        {
            wasEdited = true;
            user.setUserData(getFirstName(), getLastName(), getMailAddress());
            dataToPass = user.getUser();
            if (startData.Equals(dataToPass)) { wasEdited = false; }
        }
        public void LName1_TextChanged(object sender, TextChangedEventArgs e)
        {
            wasEdited = true;
            user.setUserData(getFirstName(), getLastName(), getMailAddress());
            dataToPass = user.getUser();
            if (startData.Equals(dataToPass)) { wasEdited = false; }
        }
        public void EMail1_TextChanged(object sender, TextChangedEventArgs e)
        {
            wasEdited = true;
            user.setUserData(getFirstName(), getLastName(), getMailAddress());
            dataToPass = user.getUser();
            if (startData.Equals(dataToPass)) { wasEdited = false; }
        }
        public void openEdition(string fName, string lName, string eMail)
        {
            wasEdited = false;
            user = new User(fName, lName, eMail);
            dataToPass = user.getUser();
            startData = user.getUser();
            fName1.Text = fName;
            lName1.Text = lName;
            eMail1.Text = eMail;
        }
        public void closeEdition()
        {
            if (wasEdited)
            {
                Console.WriteLine("TEST WEJSCIA DO WAS EDITED");
                window.users[window.sel].setUserData(user.fName, user.lName, user.eMail);
                window.usersList.Items.Insert(window.sel, user.getUser());
                window.usersList.Items.Remove(window.usersList.SelectedItem);
                Console.WriteLine("\nUsers"); 
                for (int i = 0; i < window.users.Count; i++)
                    Console.WriteLine(window.users[i].getUser());
                Console.WriteLine("\nUsersList");
                for (int i = 0; i < window.usersList.Items.Count; i++)
                    Console.WriteLine(window.usersList.Items[i]);
            }
            window.usersList.Items.Refresh();
        }
        private string getFirstName()
        {
            return fName1.Text;
        }
        private string getLastName()
        {
            return lName1.Text;
        }
        private string getMailAddress()
        {
            return eMail1.Text;
        }
    }
}
