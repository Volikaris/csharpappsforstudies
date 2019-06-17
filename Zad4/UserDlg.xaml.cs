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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zad4
{
    /// <summary>
    /// Interaction logic for UserDlg.xaml
    /// </summary>
    public partial class UserDlg : Window
    {
        public User user;
        public bool userAdded = false, userEdited = false, userEditDone = false;
        public UserDlg()
        {
            InitializeComponent();
        }
        private void OK(object sender, RoutedEventArgs e)
        {
            if(getFirstName() == "" || getLastName() == "" || getMailAddress() == "")
            {
                MessageBox.Show("Please fill out the form correctly to create/edit user");
                return;
            }
            try
            {
                if(!userEdited)
                {
                    user = new User(getFirstName(), getLastName(), getMailAddress());
                    userAdded = true;
                }
                else if(userEdited)
                {
                    user = new User(getFirstName(), getLastName(), getMailAddress());
                    userEditDone = true;
                }
            }
            catch
            {
                userAdded = false;
                userEditDone = false;
                userEdited = false;
                throw new NotImplementedException();
            }
            Close();
        }
        private void Anuluj(object sender, RoutedEventArgs e)
        {
            Close();
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
        public void openEdition(string fName, string lName, string eMail)
        {
            fName1.Text = fName;
            lName1.Text = lName;
            eMail1.Text = eMail;
        }
    }
}
