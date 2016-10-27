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

namespace PostingQueueMonitoring_V2
{
    public partial class MainForm : Form
    {
        private string connString;

        public MainForm()
        {
            InitializeComponent();
        }

        private void production_radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            environment_comboBox1.Items.Clear();

            try
            {
                SqlConnection connDatabase = new SqlConnection("Data Source=GlobalSql.Traxtech.com;Initial Catalog=CentralConfigRepl;Trusted_Connection=True");
                SqlDataAdapter cmdDatabase = new SqlDataAdapter("select EnvName from fps.WorkGroup wrk (nolock) " +
                                                         "inner join fps.Environment env (nolock) on wrk.WorkGroupID = env.WorkGroupID " +
                                                         "where Purpose = 'Production' " +
                                                         "order by EnvName", connDatabase);
                DataTable dt = new DataTable();
                cmdDatabase.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    environment_comboBox1.Items.Add(dr["EnvName"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void test_radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            environment_comboBox1.Items.Clear();

            try
            {
                SqlConnection connDatabase = new SqlConnection("Data Source=GlobalSql.Traxtech.com;Initial Catalog=CentralConfigRepl;Trusted_Connection=True");
                SqlDataAdapter cmdDatabase = new SqlDataAdapter("select EnvName from fps.WorkGroup wrk (nolock) " +
                                                         "inner join fps.Environment env (nolock) on wrk.WorkGroupID = env.WorkGroupID " +
                                                         "where Purpose = 'Test' " +
                                                         "order by EnvName", connDatabase);
                DataTable dt = new DataTable();
                cmdDatabase.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    environment_comboBox1.Items.Add(dr["EnvName"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void all_radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            environment_comboBox1.Items.Clear();

            try
            {
                SqlConnection connDatabase = new SqlConnection("Data Source=GlobalSql.Traxtech.com;Initial Catalog=CentralConfigRepl;Trusted_Connection=True");
                SqlDataAdapter cmdDatabase = new SqlDataAdapter("select EnvName from fps.WorkGroup wrk (nolock) " +
                                                         "inner join fps.Environment env (nolock) on wrk.WorkGroupID = env.WorkGroupID " +
                                                         "order by EnvName", connDatabase);
                DataTable dt = new DataTable();
                cmdDatabase.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    environment_comboBox1.Items.Add(dr["EnvName"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void environment_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connDatabase = new SqlConnection("Data Source=GlobalSql.Traxtech.com;Initial Catalog=CentralConfigRepl;Trusted_Connection=True");
                SqlCommand cmdDatabase = new SqlCommand("select EnvName, Purpose, EnvId, wrk.WorkGroupID, SqlDns, DatabaseName from fps.WorkGroup wrk (nolock) " +
                                                         "inner join fps.Environment env (nolock) on wrk.WorkGroupID = env.WorkGroupID " +
                                                         "where EnvName = '" + environment_comboBox1.Text + "' " +
                                                         "order by EnvName", connDatabase);
                SqlDataReader dreader;

                connDatabase.Open();
                dreader = cmdDatabase.ExecuteReader();

                while (dreader.Read())
               {
                   Guid sSqlGUID = dreader.GetGuid(dreader.GetOrdinal("EnvId"));
                   string sSqlDNS = dreader.GetString(dreader.GetOrdinal("SqlDns"));
                   string sDatabaseName = dreader.GetString(dreader.GetOrdinal("DatabaseName"));

                   textBox2_GUID.Text = (dreader["EnvId"].ToString().ToUpper());
                   textBox3_DNS.Text = (dreader["SqlDns"].ToString());
                   textBox4_DB.Text = (dreader["DatabaseName"].ToString());

                   connString = "Data Source=" + sSqlDNS + ";Initial Catalog=" + sDatabaseName + ";Trusted_Connection=True";
               }
               connDatabase.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQueryQueue = "select * from process_queue where process_priority_high = 1 and process_stat in ('Queued', 'Executing') " +
                                       "order by Process_Priority_Low desc";
                string sqlQueryStatus = "select Process_Stat, count(*) as RecordCount, " +
                                        "case when Process_stat = 'Executing' then max(datediff(minute, start_dtm, getdate()))" +
                                        "else '' end as MinutesExecuting from dbo.process_queue where process_priority_high in (1, 0)" +
                                        "group by process_stat";

                SqlConnection connectionQueue = new SqlConnection(connString);
                SqlDataAdapter dataadapterQueue = new SqlDataAdapter(sqlQueryQueue, connectionQueue);
                DataSet dsQueue = new DataSet();

                connectionQueue.Open();
                dataadapterQueue.Fill(dsQueue, "ProcessQueue_Table");
                connectionQueue.Close();
                dataGridView1.DataSource = dsQueue;
                dataGridView1.DataMember = "ProcessQueue_Table";


                SqlConnection connectionStatus = new SqlConnection(connString);
                SqlDataAdapter dataadapterStatus = new SqlDataAdapter(sqlQueryStatus, connectionStatus);
                DataSet dsStatus = new DataSet();

                connectionStatus.Open();
                dataadapterStatus.Fill(dsStatus, "ProcessQueue_Table");
                connectionStatus.Close();
                dataGridView2.DataSource = dsStatus;
                dataGridView2.DataMember = "ProcessQueue_Table";
            }
            catch(Exception)
            {
                MessageBox.Show("SELECT A CUSTOMER / ENVIRONMENT.", ("NOTIFICATION!!!"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           try
           {
                string sqlQuery = "select process_labl, func_memo from process_queue (nolock) where process_priority_high = 1 and process_stat = 'Executing'";

                SqlConnection con = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            string entryExecuting = reader.GetFieldValue<string>(0);
                            MessageBox.Show("PROCESS_LABL: " + reader.GetValue(0) + Environment.NewLine + Environment.NewLine + "FUNC_MEMO: " + reader.GetValue(1), ("EXECUTING!!!"));
                        }
                        reader.Close();
                    }
                    con.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("SELECT A CUSTOMER / ENVIRONMENT...", ("NOTIFICATION!!!"));
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from process_queue (nolock) where process_priority_high = 1 and func_memo like '%" + textBox1.Text + "%' and process_stat <> 'Complete'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("SELECT A CUSTOMER / ENVIRONMENT...", ("NOTIFICATION!!!"));
            }
        }

        private void helper_button3_Click(object sender, EventArgs e)
        {
            Helper newForm = new Helper();
            newForm.Show();
        }

        private void ics_button3_Click(object sender, EventArgs e)
        {
            OpenICSMonitoring newForm = new OpenICSMonitoring();
            newForm.Show();
        }

    }
}
