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
    public partial class frmMovies : Form
    {
        #region Public Static Variables
            public static bool ADD_NEW = false;
            public static string key = string.Empty;
        #endregion

        #region Private Variables
            string sql_stmt = string.Empty;
            double rental_price = 0;
        #endregion

        #region Private Methods
            private void display_record()
            {
                sql_stmt = "SELECT * FROM movies WHERE MovieCode = '" + key + "';";
                DataTable dtCustomer = clsPublicMethods.DBUtilies.get_data_table(sql_stmt);
                if (dtCustomer.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtCustomer.Rows)
                    {
                        txtMovieCode.Text = dr["MovieCode"].ToString();
                        txtMovieTitle.Text = dr["MovieTitle"].ToString();
                        cboCategory.Text = dr["Category"].ToString();
                        txtRentalPrice.Text = dr["RentalPrice"].ToString();
                        txtYear.Text = dr["YearReleased"].ToString();
                        txtMovieDirector.Text = dr["Director"].ToString();
                    }
                }
            }
        #endregion

        #region Form Init Method and Control Events
            public frmMovies()
            {
                InitializeComponent();
            }

            private void frmMovies_Load(object sender, EventArgs e)
            {
                if (ADD_NEW == false)
                {
                    txtMovieCode.Enabled = false;
                    display_record();
                    txtMovieTitle.Focus();
                }
            }

            private void txtMovieCode_Leave(object sender, EventArgs e)
            {
                if (txtMovieCode.Text != string.Empty)
                {
                    sql_stmt = "SELECT * FROM movies WHERE MovieCode = '" + txtMovieCode.Text + "';";
                    if (clsPublicMethods.record_exists(sql_stmt) == true)
                    {
                        clsPublicMethods.duplicate_msg("Movie Code");
                    }
                }
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                if (txtMovieCode.Text == string.Empty)
                {
                    clsPublicMethods.required_field_msg("Movie Code");
                    txtMovieCode.Focus();
                    return;
                }

                if (txtMovieTitle.Text == string.Empty)
                {
                    clsPublicMethods.required_field_msg("Movie Title");
                    txtMovieTitle.Focus();
                    return;
                }

                if (clsPublicMethods.confirm_save_update() == DialogResult.Yes)
                {
                    if (ADD_NEW == true)
                    {
                        sql_stmt = "INSERT INTO movies (MovieCode, MovieTitle, Category, RentalPrice, Director,YearReleased) ";
                        sql_stmt += "VALUES ('" + txtMovieCode.Text + "','" + txtMovieTitle.Text + "','" + cboCategory.Text + "'," + rental_price + ",'" + txtMovieDirector.Text + "','" + txtYear.Text + "');";
                    }
                    else
                    {
                        sql_stmt = "UPDATE movies SET MovieTitle = '" + txtMovieTitle.Text + "',Category = '" + cboCategory.Text + "', RentalPrice = " + rental_price + ", Director = '" + txtMovieDirector.Text + "', YearReleased = '" + txtYear.Text + "' WHERE MovieCode = '" + txtMovieCode.Text + "';";
                    }

                    clsPublicMethods.DBUtilies.execute_sql_statement(sql_stmt);

                    ADD_NEW = false;
                    txtMovieCode.Enabled = false;

                    clsPublicMethods.saved_updated_msg();
                }
            }

            private void btnClose_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void txtRentalPrice_TextChanged(object sender, EventArgs e)
            {
                if (txtRentalPrice.Text != string.Empty)
                {
                    try
                    {
                        rental_price = double.Parse(txtRentalPrice.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("We have detected a non numeric character. please check the value you entered.", "Non-numeric character", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        #endregion
    }
}
