using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_accounting_at_the_enterprise
{
    public partial class MainMenu : Form
    {

        DataBase dataBase = new DataBase();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableMenu tableMenu = new TableMenu();
            tableMenu.Show();
        }
    }
}
