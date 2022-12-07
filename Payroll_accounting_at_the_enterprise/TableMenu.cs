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
    public partial class TableMenu : Form
    {
        public TableMenu()
        {
            InitializeComponent();
        }

        private void TableMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accountingDataSet.Tariff_schedule". При необходимости она может быть перемещена или удалена.
            this.tariff_scheduleTableAdapter.Fill(this.payroll_accountingDataSet.Tariff_schedule);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accountingDataSet.working_days". При необходимости она может быть перемещена или удалена.
            this.working_daysTableAdapter.Fill(this.payroll_accountingDataSet.working_days);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accountingDataSet.Allowances". При необходимости она может быть перемещена или удалена.
            this.allowancesTableAdapter.Fill(this.payroll_accountingDataSet.Allowances);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accountingDataSet.Deductions". При необходимости она может быть перемещена или удалена.
            this.deductionsTableAdapter.Fill(this.payroll_accountingDataSet.Deductions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accountingDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.payroll_accountingDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accountingDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.payroll_accountingDataSet.Positions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accountingDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.payroll_accountingDataSet.Departments);

        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }


        private void departmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payroll_accountingDataSet);

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payroll_accountingDataSet);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
