using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShop.Models;
using System.Data;

namespace BookShop.Models
{
    public class BALBookShop
    {
 DataSet dt = new DataSet();
        
        public DataSet BgetLogin(string user,string password)
        {
             DAL _dt = new DAL();
            dt= _dt.dbgetlogin(user, password);
            return dt;
        }
    }
}