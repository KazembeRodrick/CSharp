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
    public partial class frmLogin : Form
    {

        #region Private Methods
            private bool verify_user()
            {
                string sql_stmt = "SELECT * FROM users WHERE UserId = '" + txtUserId.Text + "' AND Password = '" + clsPublicMethods.md5 ( txtPassword.Text) + "';";
                return clsPublicMethods.record_exists(sql_stmt);
            }

            private void open_db()
            {
                clsPublicMethods.DBUtilies.password = txtPassword.Text;

                if (clsPublicMethods.Init() == false)
                {
                    MessageBox.Show(clsPublicMethods.DBUtilies.get_last_err_msg(),"LOGIN Failed",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
            }
        #endregion

        #region Form Init Method and Control Events
            public frmLogin()
            {
                InitializeComponent();
            }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Process.Start("http://www.kazemberodrick.com/tutorials/c-sharp.html");
            }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                if (txtUserId.Text == string.Empty)
                {
                    clsPublicMethods.required_field_msg("User Id");
                    txtUserId.Focus();
                    return;
                }

                if (txtPassword.Text == string.Empty)
                {
                    clsPublicMethods.required_field_msg("Password");
                    txtPassword.Focus();
                    return;
                }

                open_db();

                if (clsSettings.APP_LOGIN == true)
                {
                    Close();
                }

            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                clsSettings.APP_LOGIN = true;
                Close();
            }
        #endregion

            private void frmLogin_Load(object sender, EventArgs e)
            {

            }

            private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Process.Start("http://www.kazemberodrick.com/movies-library-system.html");
            }
    }
}
