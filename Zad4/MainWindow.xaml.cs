using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zad4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UserDlg userDlg;
        public UserView userView;
        public List<User> users = new List<User>();
        public int sel = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Dodaj(object sender, RoutedEventArgs e)
        {
            userDlg = new UserDlg();
            Hide();
            userDlg.ShowDialog();
            Show();

            if (userDlg.userAdded)
            {
                usersList.Items.Add(userDlg.user.getUser());
                usersList.Items.Refresh();
                users.Add(userDlg.user);
            }
        }
        private void Zamknij(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Usuń(object sender, RoutedEventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result;
            result = System.Windows.Forms.MessageBox.Show("Czy na pewno chcesz usunąć użytkownika?", "Uwaga", button);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
            users.Remove(users[sel]);
            usersList.Items.Remove(usersList.SelectedItem);
            usersList.Items.Refresh();
            }

            if (users.Count == 0 || usersList.Items.Count == 0)
            {
                delButton.IsEnabled = false;
                editButton.IsEnabled = false;
                viewButton.IsEnabled = false;
            }
        }
        private void Edytuj(object sender, RoutedEventArgs e)
        {
            userDlg = new UserDlg();
            Hide();
            userDlg.userEdited = true;
            userDlg.openEdition(users[sel].fName, users[sel].lName, users[sel].eMail);
            userDlg.ShowDialog();
            Show();
            usersList.SelectedIndex = sel;

            if (userDlg.userEditDone)
            {
                users[sel].fName = userDlg.user.fName;
                users[sel].lName = userDlg.user.lName;
                users[sel].eMail = userDlg.user.eMail;
                usersList.Items.Insert(usersList.SelectedIndex, userDlg.user.getUser());
                usersList.Items.Remove(usersList.SelectedItem);
            }
            usersList.Items.Refresh();
        }
        private void Podgląd(object sender, RoutedEventArgs e)
        {
            userView = new UserView(this);
            userView.Show();
            userView.openEdition(users[sel].fName, users[sel].lName, users[sel].eMail);
        }
        private void UsersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (usersList.SelectedItem == null)
            {
                delButton.IsEnabled = false;
                editButton.IsEnabled = false;
                viewButton.IsEnabled = false;
            }
            else
            {
                delButton.IsEnabled = true;
                editButton.IsEnabled = true;
                viewButton.IsEnabled = true;
            }
                sel = usersList.SelectedIndex;
                if (sel > usersList.Items.Count) sel = usersList.Items.Count;
                if (sel < 0) sel = 0;
            if (userView != null && userView.opened)
            {
                userView.openEdition(users[sel].fName, users[sel].lName, users[sel].eMail);
            }
        }
    }
}
