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

namespace project
{
    /// <summary>
    /// Interaction logic for employeees1.xaml
    /// </summary>
    public partial class employeees1 : Page
    {
        examdeskEntities exe = new examdeskEntities();

        public employeees1()
        {
            InitializeComponent();
        }

        private void searchbut_Click(object sender, RoutedEventArgs e)
        {
            employeees1 employeees1 = new employeees1();
            datagrid.ItemsSource = exe.employees.Where(x => x.employee_id.ToString().Contains(search.Text)).ToList();
        }
    }
}
