using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Collections;

namespace Postgres03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection dbConnection;
        ArrayList custid = new ArrayList();

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
                    custid.Add(dr["custid"]);
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
            //get the custid of the currently selected customer name
            int id = Convert.ToInt32(custid[lbCust.SelectedIndex]);

            //create SQL instruction
            string sendSQL = "SELECT accid, acctyp, accbal"
                            + " FROM bog.account"
                            + " WHERE custid = @id";

            //create a command object, using this SQL and connection
            NpgsqlCommand cmd2 = new NpgsqlCommand(sendSQL, dbConnection);

            //fill the parameter placeholders
            cmd2.Parameters.AddWithValue("id", id);

            //execute the command
            dbConnection.Open();
            NpgsqlDataReader dr = cmd2.ExecuteReader();
            lbAcc.Items.Clear();
            while (dr.Read())
            {
                string s = dr["accid"].ToString() + " : " + dr["acctyp"].ToString()
                    + " : £" + dr["accbal"].ToString();
                lbAcc.Items.Add(s);
            }
            dbConnection.Close();
        }

        private void lbCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAcc.Items.Clear();
        }
    }
}
