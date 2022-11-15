using QualityShims.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityShims
{
    public static class LoggedUser
    {
        public static int Id { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static bool IsAdministrator { get; set; }
    }
}
