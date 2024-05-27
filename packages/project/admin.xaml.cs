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
using project;
using System.Xml.Linq;

namespace project
{
    /// <summary>
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        examdeskEntities exe = new examdeskEntities();
        public admin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            admin admin = new admin();
            var adm = exe.adminns.FirstOrDefault(x => x.username == usernameee.Text);
            var adm2 = exe.adminns.FirstOrDefault(x=>x.admin_password==passworddd.Password);
            if (adm != null && adm2!=null)
            {
                employeees1 employee = new employeees1();
                this.NavigationService.Navigate(employee);
                MessageBox.Show("welcome to you");
            }
            else
                MessageBox.Show("check in your information!");
        }
    }
}