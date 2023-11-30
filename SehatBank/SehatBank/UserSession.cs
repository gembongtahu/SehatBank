using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehatBank
{
    public static class UserSession
    {
        public static int UserId = 0;
        public static string constring = "Host=localhost;Port=5432;Username=postgres;Password=FateGrandOrder1;Database=SehatBank";
        public static void SetUserId(int userId)
        {
            UserId = userId;
        }

        public static void ClearUserId()
        {
            UserId = 0;
        }
    }
}
