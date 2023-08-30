using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_FOR_WEBSITE.Models
{
     class Work_with_db
    {
        public void getCategories(int Categories)
        {
            
                if (Categories == 1)
                {
                }
                else if (Categories == 2)
                {
                }
            

        }
        public void editeDB(int Categories, int ID)
        {

                if (Categories == 1)
                {
                }
                else if (Categories == 2)
                {
                   
                }
            
        }
        public void deleteFromDB(int Categories, int ID)
        {
           
                if (Categories == 1)
                {
                  
                }
                else if (Categories == 2)
                {
                   
                }
            
        }
        public void insertToDB(int Categories, int ID, List<string> info)
        {

           
                if (Categories == 1)
                {}
                else if (Categories == 2)
                { }
            
        }
        public void CreateNew(int Categories, List<string> content, string[] HadImgPath_and_Name, List<string> ImgsPath, string[] ImgsName)
        {


            int IDM, id;
           
            
                if (Categories == 1)
                {          
                }
                else if (Categories == 2)
                {            }
        }
        public void FindByName(string Name, int Categories)
        {

           
                if (Categories == 1)
                {
                    

                }
                else if (Categories == 2)
                {
                    
                }
            
        }
        public void FindByType(string Type, int Categories)
        {

          
                if (Categories == 1)
                {
                  
                }
                else if (Categories == 2)
                {
                   
                }
            
        }
    }
}
