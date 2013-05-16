/* Program Name: Movies Library System
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movies_Library_System
{
    public partial class frmReturnMovie : Form
    {
        #region Private Variables
            string sql_stmt = string.Empty;
        #endregion

        #region Private Methods
            private void load_issued_movies()
            {
                sql_stmt = "SELECT * FROM query_issued_movies;";
                DataTable dtCustomers = clsPublicMethods.DBUtilies.get_data_table(sql_stmt);
                cboRefNumber.DataSource = dtCustomers;
                cboRefNumber.ValueMember = "RefNo";
            }

            private void display_details()
            {
                sql_stmt = "SELECT * FROM query_issued_movies WHERE RefNo = '" + cboRefNumber.Text + "';";
                DataTable dtDetails = clsPublicMethods.DBUtilies.get_data_table(sql_stmt);
                if (dtDetails.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtDetails.Rows)
                    {
                        txtCustomerName.Text = dr["CustomerName"].ToString();
                        txtMovieTitle.Text = dr["MovieTitle"].ToString();
                        dtpIssueDate.Value  = DateTime.Parse( dr["DateIssued"].ToString());
                        dtpReturnDate.Value = DateTime.Parse(  dr["ReturnDate"].ToString());
                    }
                }
                else
                {
                    txtCustomerName.Text = string.Empty;
                    txtMovieTitle.Text = string.Empty;
                    dtpIssueDate.Value = DateTime.Now.Date;
                    dtpReturnDate.Value = DateTime.Now.Date;
                }
            }
        #endregion

        #region Form Init Method and Control Events
            public frmReturnMovie()
            {
                InitializeComponent();
            }

            private void frmReturnMovie_Load(object sender, EventArgs e)
            {
                load_issued_movies();
                cboRefNumber.Text = string.Empty;
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                if (txtCustomerName.Text == string.Empty)
                {
                    clsPublicMethods.required_field_msg("Valid Ref Number");
                    cboRefNumber.Focus();
                    return;
                }

                if (clsPublicMethods.confirm_save_update() == DialogResult.Yes)
                {
                    sql_stmt = "UPDATE issued_movies SET ReturnDate = " + clsPublicMethods.DBUtilies.sql_date_format(dtpReturnDate.Value) + ",Returned = 1 WHERE RefNo = '" + cboRefNumber.Text + "';";

                    clsPublicMethods.DBUtilies.execute_sql_statement(sql_stmt);

                    load_issued_movies();

                    cboRefNumber.Text = string.Empty;

                    clsPublicMethods.saved_updated_msg();
                }
            }

            private void cboRefNumber_TextChanged(object sender, EventArgs e)
            {
                display_details();
            }
        #endregion 
    }
}
