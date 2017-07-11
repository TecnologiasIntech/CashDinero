using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashDinero
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            sqlQueryService querys = new sqlQueryService();

            List<string> columnas = new List<string>();
            columnas.Add("usr_Username");

            var listValuesTerms = new List<valuesWhere>();
            listValuesTerms.Add(querys.createListValuesWhere(true, "usr_Username", usernameTextBox.Text, "AND"));
            listValuesTerms.Add(querys.createListValuesWhere(true, "usr_Password", PasswordtextBox.Text, ""));

            DataTable dataTable = querys.selectData(columnas, "users", listValuesTerms);


            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("El usuario no existe o la contraseña está mal escrita");
            }
            else
            {
                MessageBox.Show("Correcto!");
                /*MainWindow mainWindow = new MainWindow();
                mainWindow.Show();*/
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            
            
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
