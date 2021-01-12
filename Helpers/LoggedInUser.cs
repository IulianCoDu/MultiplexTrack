using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplexTrack.Helpers
{
    public static class LoggedInUser
    {
        public static DatabaseAccess.User CurrentUser { get; set; }
    }
}
