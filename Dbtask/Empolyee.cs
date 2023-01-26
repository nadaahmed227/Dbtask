using EmployeeMgmt1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbtask
{
    public partial class Empolyee : Form
    {
        public Empolyee()
        {
            function Con;
            InitializeComponent();
            Con = new Functions();
            ShowEmpolyee();
            GetDepartment();
;        }
        private void ShowEmpolyee()
        {
            string Query = "Select * from EmpolyeeTb1";
            EmpolyeeList.DataSource = Con.GetData(Query);
        }
        private void GetDepartment = Con.GetData(Query); {
        string Query = "Select *from Department"; 
        Depcb.DisplayMember =Con.GetData(Query).Colums["DepName"].Tostring();
        Depcb.ValueMember =Con.GetData(Query).Colums["DepId"].Tostring(); 
        Depc..DataSource = Con.GetData(Query);
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpolyeeTb.Text == "" || GenCb.Select )
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTb1 values('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }

        private void Empolyee_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
