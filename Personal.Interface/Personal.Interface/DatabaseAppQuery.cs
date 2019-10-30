using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;

namespace Personal.Interface
{
    class DatabaseAppQuery
    {
        public static List<string> QueryAppDistinct()
        {
            // Connection string and SQL query  
            string strSQL = "SELECT DISTINCT AppName FROM Applications";
            // Create a command and set its connection  
            OleDbCommand command = new OleDbCommand(strSQL,DataBaseConnection());
            List<string> AppValues_list = new List<string>();
            // Open the connection and execute the select command.  
            try
            {
                // Execute command  
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AppValues_list.Add(reader["AppName"].ToString());
                    }
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Dispose();
                System.Environment.Exit(1);
            }
            return AppValues_list;
        }

        //Query App Version based on selected application in the App  Combobox
        public static List<string> QueryAppVersion(string AppName)
        {
            // Connection string and SQL query  
            string strSQL = "SELECT Version FROM Applications Where AppName = '" + AppName + "'" ;
            // Create a command and set its connection  
            OleDbCommand command = new OleDbCommand(strSQL, DataBaseConnection());
            List<string> AppVersions_list = new List<string>();
            try
            {
                // Execute command  
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AppVersions_list.Add(reader["Version"].ToString());
                    }
                }
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Dispose();
                System.Environment.Exit(1);
            }
                
            return AppVersions_list;
        }

        public static string QueryLogo(string AppVersion)
        {
            string ImgPath = " ";
            string strSQL = "SELECT LogoPath, LogoFileName FROM Applications Where Version = '" + AppVersion + "'";
            
            // Create a command and set its connection  
            OleDbCommand command = new OleDbCommand(strSQL, DataBaseConnection());
            // Open the connection and execute the select command.  
            try
            {
                // Execute command  
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ImgPath = reader["LogoPath"].ToString() + "\\" + reader["LogoFileName"].ToString();
                    }
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Picture " + ex.ToString());
                command.Dispose();
                return null;
            }
            return ImgPath;
        }   

        public static string QueryAppCommandLine(string AppName, string AppVersion)
        {
            string CommandLine = "";
            string strSQL = "SELECT CommandLine FROM Applications Where Version = '" + AppVersion + "'" + " and AppName = '" + AppName + "'";
            
            // Create a command and set its connection  
            OleDbCommand command = new OleDbCommand(strSQL, DataBaseConnection());
            try
            {
                // Execute command  
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CommandLine = reader["CommandLine"].ToString();
                    }
                    command.Dispose();
                }
                return CommandLine;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Retreving the AppPath: " + ex.ToString());
                command.Dispose();
                return null;
            }
        }

        public static void QueryAll()
        {
            //List<App> AppFullInfo = new List<App>();
            List<App> AppFullInfo = new List<App>();
            string strSQL = "SELECT * FROM Applications";
            // Create a command and set its connection  
            OleDbCommand command = new OleDbCommand(strSQL, DataBaseConnection());
            try
            {
                int ID;
                string AppName;
                string Version;
                string LogoFileName;
                string LogoPath;
                string CommandLine;
                string Type;

                // Execute command  
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //Table schema -> ID||AppName||Version||LogoFileName||LogoPath||CommandLine||Type
                        ID = reader.GetInt32(0);
                        AppName = reader.GetString(1);
                        Version = reader.GetString(2);
                        LogoFileName = reader.GetString(3);
                        LogoPath = reader.GetString(4);
                        CommandLine = reader.GetString(5);
                        Type = reader.GetString(6);
                        AppFullInfo.Add(new App { ID = ID, AppName = AppName, Version = Version, LogoFileName = LogoFileName, LogoPath = LogoPath, CommandLine = CommandLine, Type = Type });
                    }
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Retreving the AppPath: " + ex.ToString());
                command.Dispose();
            }
        }

        // --- //
        // --- Start Methods to read/write data into the SQL Server --- //
        // --- //

        public static void SqlAccountInfo()
        {
            // Connection string and SQL query  
            string strSQL = "SELECT * FROM dbo.USTAMM Where U_NAME = 'leandro.ferraro'";
            // Create a command and set its connection  
            SqlCommand command = new SqlCommand(strSQL, SqlDataBaseConnection());
            List<string> Users_list = new List<string>();
            // Open the connection and execute the select command.  
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
        
                    while (reader.Read())
                    {
                        Users_list.Add(reader.GetValue(0).ToString());
                    }
                    reader.Close();
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error unable to access the Database. " + ex);
            }
        }

        // --- //
        // --- End --- //
        // --- //

        // --- //
        // --- Start Methods to Connect into the SQL Server and MS Access --- //
        // --- //
        
        //Create connection with MS Access DB  
        protected static OleDbConnection DataBaseConnection()
        {
            try
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Repository\Developments\Support.Interface\src\DB\Interface.accdb";
                OleDbConnection Conn = new OleDbConnection(connectionString);
                Conn.Open();
                return Conn;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error unable to access the Database. " + ex);
                return null;
            }
        }

        //Create connection with SQL Server
        protected static SqlConnection SqlDataBaseConnection()
        {
            string SqlConnString;
            SqlConnection cnn;

            SqlConnString = @"Data Source=PLMTEST02;Initial Catalog=EpicorPLM_V8_TEST;Integrated Security=True";
            cnn = new SqlConnection(SqlConnString);

            try
            {
                cnn.Open();
                return cnn;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error unable to access the Database. " + ex);
                return null;
            }
        }

        // --- //
        // --- End --- //
        // --- //
    }
}