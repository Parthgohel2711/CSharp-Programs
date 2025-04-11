using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Navigation
{
    public partial class Navigate: Form
    {
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Crud&Navigate.mdf;Integrated Security=True");
        int Rp = 0, Tr = 0, id = 0;
        
        public Navigate()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            String SelectQuery = "Select * From Course";
            SqlDataAdapter DA = new SqlDataAdapter(SelectQuery,Con);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            if(DT.Rows.Count > 0)
            {
                Cou.DataSource = DT;
            }
            Cou.DisplayMember = "Cou1";
            Cou.Text = "--Select Course--";

            String SelectQuery1 = "Select * From UserDetails";
            SqlDataAdapter DA1 = new SqlDataAdapter(SelectQuery1, Con);
            DataTable DT1 = new DataTable();
            DA1.Fill(DT1);
            UserData.DataSource = DT1;
            Tr = DT1.Rows.Count - 1;
        }

        private void Clear()
        {
            Unm.Text = String.Empty;
            Cou.Text = "--Select Course--";
            Unm.Focus();
        }

        private void Navigation()
        {
            String SelectQuery1 = "Select * From UserDetails";
            SqlDataAdapter DA1 = new SqlDataAdapter(SelectQuery1, Con);
            DataTable DT1 = new DataTable();
            DA1.Fill(DT1);
            id = Convert.ToInt32(DT1.Rows[Rp][0].ToString());
            Unm.Text = DT1.Rows[Rp][1].ToString();
            Cou.Text = DT1.Rows[Rp][2].ToString();
        }

        private void Enable()
        {
            BtnUpdate.Enabled = true;
            BtnUpdate.BackColor = Color.RoyalBlue;
            BtnDelete.Enabled = true;
            BtnDelete.BackColor = Color.RoyalBlue;
            BtnInsert.Enabled = false;
            BtnInsert.BackColor = Color.Gray;
        }

        private void Disable()
        {
            BtnUpdate.Enabled = false;
            BtnUpdate.BackColor = Color.Gray;
            BtnDelete.Enabled = false;
            BtnDelete.BackColor = Color.Gray;
            BtnInsert.Enabled = true;
            BtnInsert.BackColor = Color.RoyalBlue;
        }

        private void Navigate_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            if(Tr >= 0)
            {
                Rp = 0;
                Navigation();
                Enable();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if(Rp < Tr)
            {
                Rp++;
                Navigation();
                Enable();
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if(Rp > 0)
            {
                Rp--;
                Navigation();
                Enable();
            }
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            if(Tr >= 0)
            {
                Rp = Tr;
                Navigation();
                Enable();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
            Disable();
        }

        

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (Unm.Text != "" && Cou.Text != "--Select Course--")
            {
                String InsertQuery = "Insert Into UserDetails Values('" + Unm.Text + "' , '" + Cou.Text + "')";
                SqlDataAdapter DA = new SqlDataAdapter(InsertQuery, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                Clear();
                LoadData();
            }
            else
            {
                MessageBox.Show("Enter Value In All Feilds !", "Crud&Navigation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Unm.Text != "" && Cou.Text != "--Select Course--")
            {
                String UpdateQuery = "Update UserDetails Set Unm='"+Unm.Text+"' , Cou='"+Cou.Text+"' where id='"+id+"'";
                SqlDataAdapter DA = new SqlDataAdapter(UpdateQuery, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                Clear();
                LoadData();
            }
            else
            {
                MessageBox.Show("Enter Value In All Feilds !", "Crud&Navigation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are You Sure You Want To Delete ?","Crud&Navigation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(DR == DialogResult.Yes)
            {
                String UpdateQuery = "Delete From UserDetails where id='" + id + "'";
                SqlDataAdapter DA = new SqlDataAdapter(UpdateQuery, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                Clear();
                LoadData();
            }
        }
    }
}
