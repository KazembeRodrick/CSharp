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
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movies_Library_System
{
    public partial class frmMain : Form
    {
        #region private variables
            private string key = string.Empty;
            enum ListOptions { Customers, Movies, IssuedMovies, ReturnedMovies };
            ListOptions current_list = ListOptions.Customers;
        #endregion

        #region methods
            private void load_customers()
            {
                string sql_stmt = "SELECT CustomerID, CustomerName, Occupation, PhysicalAddress, Telephone FROM customers;";
                DataTable dtCustomers = clsPublicMethods.DBUtilies.get_data_table(sql_stmt);

                dgvList.DataSource = dtCustomers;

                lblDataGridCaption.Text = "Customers Listing";
                btnPrintPreview.ToolTipText = "Customers Listing Report Print Preview";
                current_list = ListOptions.Customers;
            }

            private void load_movies()
            {
                string sql_stmt = "SELECT * FROM movies;";
                DataTable dtMovies = clsPublicMethods.DBUtilies.get_data_table(sql_stmt);

                dgvList.DataSource = dtMovies;

                lblDataGridCaption.Text = "Movies Listing";
                btnPrintPreview.ToolTipText = "Movies Listing Report Print Preview";
                current_list = ListOptions.Movies;
            }

            private void load_issued_movies()
            {
                string sql_stmt = "SELECT RefNo, CustomerName, MovieTitle, DateIssued, ReturnDate, NumberOfDays, RentalPrice, TotalCharges FROM query_issued_movies;";
                DataTable dtIssuedMovies = clsPublicMethods.DBUtilies.get_data_table(sql_stmt);

                dgvList.DataSource = dtIssuedMovies;

                lblDataGridCaption.Text = "Issued Movies Listing";
                btnPrintPreview.ToolTipText = "Issued Movies Listing Report Print Preview";
                current_list = ListOptions.IssuedMovies;
            }

            private void load_returned_movies()
            {
                string sql_stmt = "SELECT RefNo, CustomerName, MovieTitle, DateIssued, ReturnDate, NumberOfDays, RentalPrice, TotalCharges FROM query_returned_movies;";
                DataTable dtIssuedMovies = clsPublicMethods.DBUtilies.get_data_table(sql_stmt);

                dgvList.DataSource = dtIssuedMovies;

                lblDataGridCaption.Text = "Returned Movies Listing";
                btnPrintPreview.ToolTipText = "Returned Movies Listing Report Print Preview";
                current_list = ListOptions.ReturnedMovies;
            } 

            private void refresh_list()
            {
                switch (current_list)
                {
                    case ListOptions.Customers :
                        load_customers();
                        break;

                    case ListOptions.Movies:
                        load_movies();
                        break;

                    case ListOptions.IssuedMovies:
                        load_issued_movies();
                        break;

                    case ListOptions.ReturnedMovies:
                        load_returned_movies();
                        break;
                }
            }
        #endregion

        #region Form Init Method and Control Events
            public frmMain()
            {
                InitializeComponent();
            }

            private void toolStripStatusLabel_Click(object sender, EventArgs e)
            {
                Process.Start("http://www.kazemberodrick.com/tutorials/c-sharp.html");
            }

            private void frmMain_Load(object sender, EventArgs e)
            {
                load_customers();
            }

            private void btnCustomers_Click(object sender, EventArgs e)
            {
                load_customers();
            }

            private void btnMovies_Click(object sender, EventArgs e)
            {
                load_movies();
            }

            private void indexToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Process.Start("http://www.kazemberodrick.com/tutorials/c-sharp.html");
            }

            private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmAbout sfAbout = new frmAbout();
                sfAbout.ShowDialog();
            }

            private void toolStripLabel1_Click(object sender, EventArgs e)
            {
                Process.Start("http://www.kazemberodrick.com/tutorials/c-sharp.html");
            }

            private void btnHelp_Click(object sender, EventArgs e)
            {
                Process.Start("http://www.kazemberodrick.com/tutorials/c-sharp.html");
            }

            private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            
            }

            private void btnAddNewCustomer_Click(object sender, EventArgs e)
            {
                frmCustomers.ADD_NEW = true;
                frmCustomers sCustomers = new frmCustomers();
                sCustomers.ShowDialog();
                refresh_list();
            }

            private void btnEditCustomer_Click(object sender, EventArgs e)
            {
                frmCustomers.ADD_NEW = false;
                frmCustomers.key = key;
                frmCustomers sCustomers = new frmCustomers();
                sCustomers.ShowDialog();
                refresh_list();
            }

            private void dgvList_Click(object sender, EventArgs e)
            {
                key = dgvList.CurrentRow.Cells[0].Value.ToString();
            }

            private void btnAddNewMovie_Click(object sender, EventArgs e)
            {
                frmMovies.ADD_NEW = true;
                frmMovies sMovies = new frmMovies();
                sMovies.ShowDialog();
                refresh_list();
            }

            private void btnEditMovie_Click(object sender, EventArgs e)
            {
                frmMovies.ADD_NEW = false;
                frmMovies.key = key;
                frmMovies sMovies = new frmMovies();
                sMovies.ShowDialog();
                refresh_list();
            }

            private void btnCustomers_ButtonClick(object sender, EventArgs e)
            {

            }

            private void btnIssueMovie_Click(object sender, EventArgs e)
            {
                frmIssueMovie sIssueMovie = new frmIssueMovie();
                sIssueMovie.ShowDialog();
                refresh_list();
            }

            private void btnIssueMovies_Click(object sender, EventArgs e)
            {
                load_issued_movies();
            }

            private void btnReturnMovies_Click(object sender, EventArgs e)
            {
                load_returned_movies();
            }

            private void customersMenuItem_Click(object sender, EventArgs e)
            {
                btnAddNewCustomer_Click(sender, e);
            }

            private void moviesMenuItem_Click(object sender, EventArgs e)
            {
                btnAddNewMovie_Click(sender, e);
            }

            private void issueMovieMenuItem_Click(object sender, EventArgs e)
            {
                btnIssueMovie_Click(sender, e);
            }

            private void returnMovieMenuItem_Click(object sender, EventArgs e)
            {
                btnReturnMovie_Click(sender, e);
            }

            private void btnReturnMovie_Click(object sender, EventArgs e)
            {
                frmReturnMovie sReturnMovie = new frmReturnMovie();
                sReturnMovie.ShowDialog();
                refresh_list();
            }

            private void btnPrintPreview_Click(object sender, EventArgs e)
            {
                switch(current_list){
                    case ListOptions.Customers:
                        frmReportViewer.REPORT_NAME = frmReportViewer.ReportOptions.Customers;
                        frmReportViewer sCustomers = new frmReportViewer();
                        sCustomers.Show();
                        break;

                    case ListOptions.Movies:
                        frmReportViewer.REPORT_NAME = frmReportViewer.ReportOptions.Movies;
                        frmReportViewer sMovies = new frmReportViewer();
                        sMovies.Show();
                        break;

                    case ListOptions.IssuedMovies:
                        frmReportViewer.REPORT_NAME = frmReportViewer.ReportOptions.IssuedMovies;
                        frmReportViewer sIssuedMovies = new frmReportViewer();
                        sIssuedMovies.Show();
                        break;

                    case ListOptions.ReturnedMovies:
                        frmReportViewer.REPORT_NAME = frmReportViewer.ReportOptions.ReturnedMovies;
                        frmReportViewer sReturnedMovies = new frmReportViewer();
                        sReturnedMovies.Show();
                        break;
                }
            }

            private void rptCustomersMenuItem_Click(object sender, EventArgs e)
            {
                btnCustomers_Click(sender,e);
                btnPrintPreview_Click(sender, e);
            }

            private void rptMoviesMenuItem_Click(object sender, EventArgs e)
            {
                btnMovies_Click(sender, e);
                btnPrintPreview_Click(sender, e);
            }

            private void rptIssuedMoviesMenuItem_Click(object sender, EventArgs e)
            {
                btnIssueMovies_Click(sender, e);
                btnPrintPreview_Click(sender, e);
            }

            private void rptReturnedMovieMenuItem_Click(object sender, EventArgs e)
            {
                btnReturnMovies_Click(sender, e);
                btnPrintPreview_Click(sender, e);
            }
        #endregion
    }
}
