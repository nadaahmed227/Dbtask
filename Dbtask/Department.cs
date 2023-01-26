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
    public partial class Department : Form
        function Con;
    {

        public Department()
        {
            InitializeComponent();
            Con = new function();
            ShowDepartments();
        }


        private void ShowDepartment()
        {
            string Query = "Select *from  DepartmentTb1";
            Deplist.DataSourc = Con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");

                }
            }
            else
            {
                string Dep = DepNameTb.Text;
                string Query = "insert into DepertmentTb1 Values('{0}')";
                Query = string.Format(DepNameTb.Text);
                Con.StateData(Query);
                ShowDepartment();
                MessageBox.Show("Department  Added!!!");
                DepNameTb.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int key = 0;

        private void DepList_CellConttectClick(object sender,DataGridViewCellEventArgs e)
        {

        }

        }

   
        

        }
    }

