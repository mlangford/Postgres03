using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Postgres03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection dbConnection;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (rbHome.Checked)
                {
                    dbConnection = new NpgsqlConnection(dbSource.home);
                }
                else
                {
                    dbConnection = new NpgsqlConnection(dbSource.work);
                }

                //create SQL instruction
                string sendSQL = "SELECT custid, lastnm"
                                    + " FROM bog.customer"
                                    + " ORDER BY lastnm";
                //create a command object, using this SQL and connection
                NpgsqlCommand cmd = new NpgsqlCommand(sendSQL, dbConnection);

                //execute the command
                dbConnection.Open();
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lbCust.Items.Add(dr["lastnm"].ToString());
                }

                if (lbCust.Items.Count > 0)
                    lbCust.SelectedIndex = 0;

                dbConnection.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Error");
            }
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {

        }

    }
}
