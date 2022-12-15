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

namespace Управляющая_компания_ЖКХ
{
    /// <summary>
    /// Логика взаимодействия для Услуги.xaml
    /// </summary>
    public partial class Услуги : Page
    {
        public Услуги()
        {
            InitializeComponent();
        }

        private void DobZ_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=43П_ЖКХ;User ID=33П;Password=12357"))
            {
                sqlConnection.Open();
                IdS = ID_Services.Text;
                IdSt = ID_Staff.Text;
                countServ = CountServ.Text;
                comm = Comm.Text;
                dateServ = DateServ.Text;
                int id1 = Convert.ToInt32(IdS);
                int id2 = Convert.ToInt32(IdI);
                DataTable sqlCommand = Select($"UPDATE [dbo].[Услуги] SET [ID_Staff] = '{id2}',[count] = '{countServ}' ,[Text] = '{comm}' ,[date] = '{dateServ}' WHERE [ID_Services] = '{id1}';");
                sqlConnection.Close();
            }
            Close();
        }
    }
}