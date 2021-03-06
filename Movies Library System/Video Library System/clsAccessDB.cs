﻿/* Program Name: Movies Library System
 * 
 * Author: Kazembe Rodrick
 * 
 * Author Description: Freelancer software/web developer & Technical writter. Has over 7 years experience developing software
 *                     in Languages such as VB 6.0, C#.Net,Java, PHP and JavaScript & HTML. Services offered include custom
 *                     development, writting technical articles,tutorials and books.
 * Website: http://www.kazemberodrick.com
 * 
 * Project URL: http://www.kazemberodrick.com/movies-library-system.html
 * 
 * Email Address: kr@kazemberodrick.
 * 
 * Purpose: Fairly complex Movies Library System For Educational purposes. Demonstrates how to develop complete database powered
 *          Applications that Create and Update data in the database. The system also demonstrates how to create reports from
 *          the database. 
 *          
 * Limitations: The system is currently a standalone. It does not support multiple users. This will be implemented in future
 *              versions. 
 *              The system does not have a payments module. This can be developed upon request. Just sent an email to kr@kazemberodrick.com
 *              The system does not have keep track of the number of movies to check for availability. This can be developed upon request.
 * 
 * Movies Library System Road Map: This system is for educational purposes. I will be writting step-by-step tutorials on my
 *                                 website http://www.kazemberodrick.com that explain;
 *                                      -System Specifications for Movies Library System
 *                                      -System Design Considerations
 *                                      -System Database ERD
 *                                      -System Class Diagram
 *                                      -Explainations of the codes in each window
 *                                      -Multiple-database support. The Base class BaseDBUtilities will be extended to create
 *                                       classes that will support client-server database engines such as MySQL, MS SQL Server etc.
 *                                       
 *  Support Movies Library System: The System is completely free. Please support it by visiting http://www.kazemberodrick.com/c-sharp.html and recommending the site to
 *                                 your friends. Share the tutorials on social media such as twitter and facebook.
 *  
 * Github account: https://github.com/KazembeRodrick I regulary post and update sources on my Github account.Make sure to follow me
 *                 and never miss an update.
 * Facebook page: http://www.facebook.com/pages/Kazembe-Rodrick/487855197902730 Please like my page and get updates on latest articles
 *                and source codes. You can get to ask questions too about the system and I will answer them.
 *                
 * Twitter account: https://twitter.com/KazembeRodrick Spread the news. Tweet the articles and source code links on twitter.
 */
using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movies_Library_System
{
    class clsAccessDB : BaseDBUtilities
    {
        #region private variables
            private OleDbConnection CN = new OleDbConnection();
        #endregion

        #region overriden methods
            public override bool connect()
            {
                conn_string = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + server_name + database_name + ";Persist Security Info=False;Jet OLEDB:Database Password=" + password;
                CN.ConnectionString = conn_string;
                try
                {
                    CN.Open();
                    state = true;
                }
                catch (Exception ex)
                {
                    err_msg = ex.Message;
                    state = false;
                }

                return state;
            }

            public override DataTable get_data_table(string sql_stmt)
            {
                DataTable dt = new DataTable();
                if (clsPublicMethods.DBUtilies.state == true)
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(sql_stmt, CN);
                    
                    da.Fill(dt); 
                }
                else
                {
                    MessageBox.Show("You are not connected to the database. Make sure you entered the correct user id and password.\nVisit www.kazemberodrick.com/movies-library-system.html for help.", "DB Connection Closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return dt;
            }

            public override DataSet get_data_set(string sql_stmt, string name)
            {
                DataSet ds = new DataSet();

                if (clsPublicMethods.DBUtilies.state == true)
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(sql_stmt, CN);
                
                    da.Fill(ds,name);
                }
                else
                {
                    MessageBox.Show("You are not connected to the database. Make sure you entered the correct user id and password.\nVisit www.kazemberodrick.com/movies-library-system.html for help.", "DB Connection Closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return ds;
            }

            public override bool execute_sql_statement(string sql_stmt)
            {
                bool my_result = false;

                if (clsPublicMethods.DBUtilies.state == true)
                {
                    try
                    {
                        //oledb command
                        OleDbCommand cmdExecute = CN.CreateCommand();
                        cmdExecute.CommandText = sql_stmt;
                        cmdExecute.ExecuteNonQuery();
                        my_result = true;
                    }
                    catch (Exception ex)
                    {
                        err_msg = ex.Message;
                        my_result = false;
                    }
                }
                else
                {
                    MessageBox.Show("You are not connected to the database. Make sure you entered the correct user id and password.\nVisit www.kazemberodrick.com/movies-library-system.html for help.", "DB Connection Closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return my_result;
            }

            public override string sql_date_format(DateTime value)
            {
                return "'" + value.Date.ToString("MM/dd/yyyy") + "'";
            }
        #endregion
    }
}
