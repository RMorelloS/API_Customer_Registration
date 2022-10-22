using API_Customer_Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Customer_Registration.Models
{
    public class DBInitializer
    {
        public static void Initialize(CustomerContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
