using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;

namespace Project_SP.Pages
{
    public class IndexModel : PageModel
    {
      
        // Book details
        public List<string> book_Name = new List<string>();
        public List<string> author_fname = new List<string>();
        public List<string> author_lname = new List<string>();
        public List<string> book_Price = new List<string>();
        

        //Category
        public List<string> book_Overview = new List<string>();

        //Get Bookdetails to udate 
        public int title_id;
        public string bookType;
        public string bookName;
        public string title;
        public string type;
      

        public void OnGet()
        {
        }//get()

        
        public void OnPostBookSearch(string findBook){

            using(SqlConnection myConn= new SqlConnection(Program.da.cs)){
                SqlCommand findDetails = new SqlCommand {Connection = myConn};

                myConn.Open();

                findDetails.Parameters.AddWithValue("@book_title", findBook);
              
                findDetails.CommandText="[spGetBookDetails]";
                findDetails.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = findDetails.ExecuteReader(); 

             while(reader.Read()){
                book_Name.Add(reader[0].ToString());  
                author_fname.Add(reader[1].ToString());
                author_lname.Add(reader[2].ToString());
                book_Price.Add(reader[3].ToString());
                }//while

            }//using
        }//OnPostBookSearch()



        public void OnPostBookCategory(string sortByCategory){

            using(SqlConnection myConn= new SqlConnection(Program.da.cs)){
                SqlCommand findDetails = new SqlCommand {Connection = myConn};

                myConn.Open();

                findDetails.Parameters.AddWithValue("@book_category", sortByCategory);
              
                findDetails.CommandText="[spListByCategories]";
                findDetails.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = findDetails.ExecuteReader(); 

                while(reader.Read()){
              
                    book_Name.Add(reader[0].ToString());  
                    book_Overview.Add(reader[1].ToString());
        
                }//while

            }//using
        }//OnPostBookCategory()

public void OnPostSearchBook(string bookToSearch) {
            
            using(SqlConnection myConn = new SqlConnection(Program.da.cs)) {
                
               string bookQuery = "SELECT title,type FROM titles WHERE title LIKE '%" + bookToSearch+ "%'";
               
               SqlCommand findBook = new SqlCommand(bookQuery, myConn);
               myConn.Open();

               SqlDataReader reader = findBook.ExecuteReader();

             
               int bookName = reader.GetOrdinal("title");
               int bookType = reader.GetOrdinal("type");

               reader.Read();

               
               title = reader.GetString(bookName);
              type = reader.GetString(bookType);
            } // using
        } // OnPostSearchBook()



        public void OnPostupdateB_Type(string update_bookName, string update_bookType){
        
        
            using(SqlConnection myConn = new SqlConnection(Program.da.cs)){
                SqlCommand Update_Type = new SqlCommand {Connection = myConn};

                myConn.Open();
           
                 Update_Type.Parameters.AddWithValue("@bookName", update_bookName);
                 Update_Type.Parameters.AddWithValue("@bookType", update_bookType);
            
                 Update_Type.CommandText = "[spUpdatetitleType]";
                 Update_Type.CommandType = System.Data.CommandType.StoredProcedure;

                 Update_Type.ExecuteNonQuery();
        
            }//using
        }//OnPostupdateB_Type()
    
    }//class
}//namespace




        