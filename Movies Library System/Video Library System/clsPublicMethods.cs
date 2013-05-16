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
using System.Security.Cryptography;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movies_Library_System
{
    class clsPublicMethods
    {
        #region Database Abstract Layer Variables and Methods
            public static clsAccessDB DBUtilies = new clsAccessDB();
            public static bool Init()
            {
                DBUtilies.server_name = AppDomain.CurrentDomain.BaseDirectory;
                DBUtilies.database_name = "movies_db.mdb";
                if (DBUtilies.connect() == true)
                {
                    clsSettings.APP_LOGIN = true;
                }
                else
                {
                    clsSettings.APP_LOGIN = false;
                }

                return clsSettings.APP_LOGIN;
            }
        
            public static bool record_exists(string sql_stmt)
            {
                DataTable dtRecord = clsPublicMethods.DBUtilies.get_data_table(sql_stmt);

                if(dtRecord.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        #endregion

        #region Message Box Methods
        public static void duplicate_msg(string field)
        {
            MessageBox.Show("The " + field + " entered already exists. Please enter a different one.", "Duplicate " + field, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void required_field_msg(string field)
        {
            MessageBox.Show("The " + field + " is required.", "Required Field - " + field, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult confirm_save_update()
        {
            return MessageBox.Show("Are you sure you want to update/save this record?", "Update/Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void saved_updated_msg()
        {
            MessageBox.Show("The record has been updated/saved sucessfully.", "Record updated/saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Security Methods 
        public static string md5(string input)
        {
            MD5 md5Hash = MD5.Create();

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
        #endregion
    }
}
