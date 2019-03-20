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

namespace DBMS_Lab01
{
    public partial class Form1 : Form
    {
        private static String connectionString = @"Data Source=DESKTOP-AFL01LP;Initial Catalog=Lab01;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        //TODO - Binding Source, DataSet and this (right below) adapter
        SqlDataAdapter adapter;
        BindingSource bs = new BindingSource();
        DataSet ds = new DataSet();

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
        }

        private void updateViewRequests(int id)
        {
            viewRequests.DataSource = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Requests WHERE requests_doctor = @request_id";
            cmd.Parameters.AddWithValue("@request_id", id);

            DataSet dts = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dts, "Requests");
            viewRequests.DataSource = dts.Tables["Requests"];
        }

        private void updateViewDoctors()
        {
            adapter = new SqlDataAdapter("SELECT * FROM Doctors", connection);
            adapter.Fill(ds, "Doctors");
            bs.DataSource = ds.Tables["Doctors"];
            viewDoctors.DataSource = bs;

            int id;
            int.TryParse(viewDoctors.CurrentRow.Cells[0].Value.ToString(), out id);
            updateViewRequests(id);
        }

        private void viewDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int doctorId;
            int.TryParse(viewDoctors.CurrentRow.Cells[0].Value.ToString(), out doctorId);

            updateViewRequests(doctorId);
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            int doctorId;
            int.TryParse(this.viewDoctors.CurrentRow.Cells[0].Value.ToString(), out doctorId);

            String name = tbName.Text;

            DateTime date;
            date = dateTimePicker.Value.Date;
            String birthDate = date.Day.ToString() + "/" + date.Month.ToString() + "/" + date.Year.ToString();

            //DateTime birthDate;
            //DateTime.TryParse(this.tbBirthDate.Text, out birthDate);
            //birthDate = birthDate.Date;

            long CNP;
            long.TryParse(this.tbCNP.Text, out CNP);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into Doctors VALUES (@doctor_id, @name, @birth_date, @CNP)";
                cmd.Parameters.AddWithValue("@doctor_id", doctorId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@birth_date", birthDate);
                cmd.Parameters.AddWithValue("@CNP", CNP);
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

            tbName.Clear();
            tbBirthDate.Clear();
            tbCNP.Clear();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            int quantity;
            int.TryParse(tbQuantity.Text, out quantity);

            String rh = tbRH.Text;

            String bloodGroup = tbBloodGroup.Text;

            int doctorId;
            int.TryParse(tbDoctorID.Text, out doctorId);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into Requests VALUES (@quantity, @rh, @blood_group, @requests_doctor)";
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@rh", rh);
                cmd.Parameters.AddWithValue("@blood_group", bloodGroup);
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
            tbRH.Clear();
            tbBloodGroup.Clear();
            tbDoctorID.Clear();
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
                MessageBox.Show(err.ToString());
            } catch (Exception err)
            {
                MessageBox.Show("SQLError: " + err.ToString());
            }

            tbQuantity.Clear();
            tbRH.Clear();
            tbBloodGroup.Clear();
            tbDoctorID.Clear();
        }

        private void btnUpdateRequest_Click(object sender, EventArgs e)
        {
            int requestId;
            int.TryParse(viewRequests.CurrentRow.Cells[0].Value.ToString(), out requestId);

            int quantity;
            int.TryParse(tbQuantity.Text, out quantity);

            String rh = tbRH.Text;

            String bloodGroup = tbBloodGroup.Text;

            int doctorId;
            int.TryParse(tbDoctorID.Text, out doctorId);


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Requests SET requests_doctor = @requests_doctor, quantity = @quantity, rh = @rh, blood_group = @blood_group " +
                                "WHERE request_id = @request_id";
            cmd.Parameters.AddWithValue("@request_id", requestId);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@rh", rh);
            cmd.Parameters.AddWithValue("@blood_group", bloodGroup);
            cmd.Parameters.AddWithValue("@requests_doctor", doctorId);
            cmd.ExecuteNonQuery();

            updateViewRequests(doctorId);

            tbQuantity.Clear();
            tbRH.Clear();
            tbBloodGroup.Clear();
            tbDoctorID.Clear();
        }
    }
}
