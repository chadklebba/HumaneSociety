using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class SQLCommand
    {
        DBDataContext context = new DBDataContext();
        Adopter dopter = new Adopter();
        public SQLCommand()
        {
            //dopter.Address = "3652a s kansas ave";
            //dopter.First_Name = "Nathan";
            //dopter.Last_Name = "Rogers";
            //context.Adopters.InsertOnSubmit(dopter);
            //context.SubmitChanges();
            List<Adopter> nathan = (from data in context.Adopters where data.First_Name == "Nathan" select data).ToList();
            
        }
    }
}
