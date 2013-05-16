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
    public partial class frmIssueMovie : Form
    {
        #region Private Variables
            string sql_stmt = string.Empty; 
            string ref_number = string.Empty;
            double rental_price = 0;
            int number_of_days = 0;
            double total_charges = 0;
        #endregion

        #region Private Methods
            private void generate_ref_no()
            {
                if (txtCustomerName.Text != string.Empty && txtMovieTitle.Text != string.Empty)
                {
                    ref_number = (cboCustomerID.Text + "-" + cboMovieCode.Text + "-" + DateTime.Now.Day + "-" + DateTime.Now.Month).ToUpper();

                    sql_stmt = "SELECT * FROM issued_movies WHERE RefNo = '" + ref_number + "';";

                    if (clsPublicMethods.record_exists(sql_stmt) == true)
                    {
                        cboMovieCode.Text = string.Empty;
                        MessageBox.Show(txtCustomerName.Text + " has already rented the movie " + txtMovieTitle.Text + " today.", "Movie Already Rented", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                    else
                    {
                        txtRefNumber.Text = ref_number;
                    }
                }
                else
                {
                    txtRefNumber.Text = string.Empty;
                }
            }

            private void calculate_charges()
            {
                number_of_days = (dtpReturnDate.Value.Date - dtpIssueDate.Value.Date).Days;

                if (number_of_days > 0)
                {
                    txtTotalDays.Text = number_of_days.ToString();
                    total_charges = (number_of_days * rental_price);
                    txtTotalCharges.Text = total_charges.ToString("N");
                }
                else
                {
                    txtTotalDays.Text = string.Empty;
                    txtTotalCharges.Text = string.Empty;
                }
            }

            private void load_customers()
            {
                sql_stmt = "SELECT * FROM customers;";
                DataTable dtCustomers = clsPublicMethods.DBUtilies.get_data_table(sql_stmt);
                cboCustomerID.DataSource = dtCustomers;
                cboCustomerID.ValueMember = "CustomerID";
            }

            private void display_customer_details()
            {
                sql_stmt = "SELECT * FROM customers WHERE CustomerID = '" + cboCustomerID.Text + "';";
                DataTable dtCustomerDetails = clsPublicMethods.DBUtilies.get_data_table(sql_stmt);
                if (dtCustomerDetails.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtCustomerDetails.Rows)
                    {
                        txtCustomerName.Text  = dr["CustomerName"].ToString();
                        txtAddress.Text = dr["PhysicalAddress"].ToString();
                    }
                }
                else
                {
                    txtCustomerName.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                }
            }

            private void load_movies()
            {
                sql_stmt = "SELECT * FROM movies;";
                DataTable dtMovies = clsPublicMethods.DBUtilies.get_data_table(sql_stmt);
                cboMovieCode.DataSource = dtMovies;
                cboMovieCode.ValueMember = "MovieCode";
                //cboMovieCode.DisplayMember = "MovieCode";
            }

            private void display_movie_details()
            {
                sql_stmt = "SELECT * FROM movies WHERE MovieCode = '" + cboMovieCode.Text + "';";
                DataTable dtMovieDetails = clsPublicMethods.DBUtilies.get_data_table(sql_stmt);
                if (dtMovieDetails.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtMovieDetails.Rows)
                    {
                        txtMovieTitle.Text = dr["MovieTitle"].ToString();
                        rental_price = double.Parse(dr["RentalPrice"].ToString());
                        txtRentingPrice.Text = rental_price.ToString("N");
                        txtCategory.Text = dr["Category"].ToString();
                    }
                }
                else
                {
                    txtMovieTitle.Text = string.Empty;
                    txtRentingPrice.Text = string.Empty;
                    txtCategory.Text = string.Empty;
                }
            }
        #endregion

        #region Form Init Method and Control Events
            public frmIssueMovie()
            {
                InitializeComponent();
            }

            private void frmIssueMovie_Load(object sender, EventArgs e)
            {
                load_movies();
                load_customers();

                cboCustomerID.Text = string.Empty;
                cboMovieCode.Text = string.Empty;
            }

            private void cboMovieCode_TextChanged(object sender, EventArgs e)
            {
                display_movie_details();
                generate_ref_no();
            }

            private void cboCustomerID_TextChanged(object sender, EventArgs e)
            {
                display_customer_details();
                generate_ref_no();
            }

            private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
            {
                calculate_charges();
            }

            private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
            {
                calculate_charges();
            }

            private void btnIssueMovie_Click(object sender, EventArgs e)
            {
                if (txtCustomerName.Text == string.Empty)
                {
                    clsPublicMethods.required_field_msg("Valid Customer Id");
                    cboCustomerID.Focus();
                    return;
                }

                if (txtMovieTitle.Text == string.Empty)
                {
                    clsPublicMethods.required_field_msg("Valid Movie Code");
                    cboMovieCode.Focus();
                    return;
                }

                if (txtTotalDays.Text == string.Empty)
                {
                    clsPublicMethods.required_field_msg("Number of Days > 0");
                    dtpReturnDate.Focus();
                    return;
                }

                if (clsPublicMethods.confirm_save_update() == DialogResult.Yes)
                {
                    sql_stmt = "INSERT INTO issued_movies ( RefNo, CustomerID, MovieCode, DateIssued, ReturnDate, TotalCharges, NumberOfDays, RentalPrice) ";
                    sql_stmt += "VALUES ('" + txtRefNumber.Text + "','" + cboCustomerID.Text + "','" + cboMovieCode.Text + "'," + clsPublicMethods.DBUtilies.sql_date_format(dtpIssueDate.Value) + "," + clsPublicMethods.DBUtilies.sql_date_format(dtpReturnDate.Value) + "," + total_charges + "," + number_of_days + "," + rental_price + ");";

                    clsPublicMethods.DBUtilies.execute_sql_statement(sql_stmt);

                    clsPublicMethods.saved_updated_msg();
                }
            }
        #endregion
    }
}
