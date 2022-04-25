using DataAccess.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;
public class UserData
{
   private readonly ISqlDataAccess _db;
   public UserData(ISqlDataAccess db)
   {
      _db = db;
   }

}
