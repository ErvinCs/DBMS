using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace DBMS_Lab01
{
    public partial class Form1 : Form
    {
        private static String connectionString = @"Data Source=DESKTOP-AFL01LP;Initial Catalog=Lab01;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        string parent = ConfigurationManager.AppSettings["Parent"];
        string child = ConfigurationManager.AppSettings["Child"];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MessageBox.Show(connection.State.ToString());

            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message.ToString());
            }
            updateViewDoctors();
            initComboBoxes();
        }

        private void updateViewRequests(int id)
        {
            viewRequests.DataSource = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Requests WHERE requests_doctor = @request_id";
            cmd.Parameters.AddWithValue("@request_id", id);

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "Requests");
            viewRequests.DataSource = ds.Tables["Requests"];
        }

        private void updateViewDoctors()
        {
            SqlDataAdapter adapter;
            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();

            adapter = new SqlDataAdapter("SELECT * FROM Doctors", connection);
            adapter.Fill(ds, "Doctors");
            bs.DataSource = ds.Tables["Doctors"];
            viewDoctors.DataSource = bs;

            int id;
            int.TryParse(viewDoctors.CurrentRow.Cells[0].Value.ToString(), out id);
            updateViewRequests(id);
        }

        private void initComboBoxes()
        {
            var rhs = new string[2];
            rhs[0] = "rh+";
            rhs[1] = "rh-";

            DataSet rhSet = new DataSet();
            DataTable rhTable = new DataTable("rhs");
            DataColumn rhColumn = new DataColumn("rh", typeof(string));
            rhTable.Columns.Add(rhColumn);

            for (int i = 0; i < rhs.Length; i++)
            {
                DataRow row = rhTable.NewRow();
                row["rh"] = rhs[i];
                rhTable.Rows.Add(row);
            }
            rhSet.Tables.Add(rhTable);
            cbRH.DataSource = rhSet.Tables["rhs"].DefaultView;
            cbRH.DisplayMember = "rh";
            cbRH.BindingContext = this.BindingContext;

            var blood_groups = new string[4];
            blood_groups[0] = "O1";
            blood_groups[1] = "A2";
            blood_groups[2] = "B3";
            blood_groups[3] = "AB4";

            DataSet groupSet = new DataSet();
            DataTable groupTable = new DataTable("blood_groups");
            DataColumn groupColumn = new DataColumn("blood_group", typeof(string));           
            groupTable.Columns.Add(groupColumn);
    
            for(int i = 0; i < blood_groups.Length; i++)
            {
                DataRow row = groupTable.NewRow();
                row["blood_group"] = blood_groups[i];
                groupTable.Rows.Add(row);
            }

            groupSet.Tables.Add(groupTable);
            cbGroup.DataSource = groupSet.Tables["blood_groups"].DefaultView;
            cbGroup.DisplayMember = "blood_group";
            cbGroup.BindingContext = this.BindingContext;
        }

        private void viewDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int doctorId;
            int.TryParse(viewDoctors.CurrentRow.Cells[0].Value.ToString(), out doctorId);

            updateViewRequests(doctorId);
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            String name = tbName.Text;

            long CNP;
            long.TryParse(this.tbCNP.Text, out CNP);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into Doctors ([name],[birth_date],[CNP]) VALUES (@name, @birth_date, @CNP)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@birth_date", dateTimePicker.Value.Date);
                cmd.Parameters.AddWithValue("@CNP", CNP);
                cmd.ExecuteNonQuery();

                updateViewDoctors();
            }
            catch (SqlException err)
            {
                MessageBox.Show("SQLException: " + err.ToString());
            } catch (Exception err)
            {
                MessageBox.Show("Exception: " + err.ToString());
            }

            tbName.Clear();
            tbCNP.Clear();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            int quantity;
            int.TryParse(tbQuantity.Text, out quantity);

            String rh = cbRH.Text.ToString();

            String bloodGroup = cbGroup.Text.ToString();

            int doctorId;
            int.TryParse(viewDoctors.CurrentRow.Cells[0].Value.ToString(), out doctorId);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into Requests ([blood_group],[rh],[quantity],[requests_doctor]) VALUES (@blood_group, @rh, @quantity, @requests_doctor)";
                cmd.Parameters.AddWithValue("@blood_group", bloodGroup);
                cmd.Parameters.AddWithValue("@rh", rh);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@requests_doctor", doctorId);
                cmd.ExecuteNonQuery();

                updateViewRequests(doctorId);
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.ToString());
            } catch (Exception err)
            {
                MessageBox.Show("SQLError: " + err.ToString());
            }

            tbQuantity.Clear();
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            int doctorId;
            int.TryParse(viewDoctors.CurrentRow.Cells[0].Value.ToString(), out doctorId);

            try
            {
                int requestId;
                int.TryParse(viewRequests.CurrentRow.Cells[0].Value.ToString(), out requestId);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Requests WHERE request_id = @request_id";
                cmd.Parameters.AddWithValue("@request_id", requestId);
                cmd.ExecuteNonQuery();

                updateViewRequests(doctorId);
            }
            catch (SqlException err)
            {
                MessageBox.Show("SQLException: " + err.ToString());
            } catch (Exception err)
            {
                MessageBox.Show("Exception: " + err.ToString());
            }

            tbQuantity.Clear();
        }

        private void btnUpdateRequest_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            int requestId;
            int.TryParse(viewRequests.CurrentRow.Cells[0].Value.ToString(), out requestId);

            int doctorId;
            int.TryParse(viewDoctors.CurrentRow.Cells[0].Value.ToString(), out doctorId);

            String rh = cbRH.Text.ToString();   //cbRH.SelectedItem.ToString();

            String bloodGroup = cbGroup.Text.ToString();    // cbGroup.SelectedValue.ToString();

            String cmdString = "UPDATE Requests SET rh = @rh, blood_group = @blood_group, requests_doctor = @requests_doctor";

            //If quantity empty
            int quantity;
            if (!tbQuantity.Text.Equals(""))
            {
                cmdString += ", quantity = @quantity";
                int.TryParse(tbQuantity.Text, out quantity);
                cmd.Parameters.AddWithValue("@quantity", quantity);
            }

            cmdString += " WHERE request_id = @request_id";


            cmd.CommandText = cmdString;
            cmd.Parameters.AddWithValue("@requests_doctor", doctorId);
            cmd.Parameters.AddWithValue("@request_id", requestId);
            cmd.Parameters.AddWithValue("@rh", rh);
            cmd.Parameters.AddWithValue("@blood_group", bloodGroup);

            cmd.ExecuteNonQuery();

            updateViewRequests(doctorId);

            tbQuantity.Clear();
        }
    }
}
