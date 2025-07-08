using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    /// <summary>
    /// A simple static class to hold information about the current application session,
    /// like the name of the user who is logged in.
    /// </summary>
    public static class SessionManager
    {
        // We set this property after a user successfully logs in.
        // It can then be accessed from anywhere in the application.
        public static string CurrentUser { get; set; } = "Vendeur"; // Default value
        public static int CurrentUserId { get; set; } = 1; // Default value
    }
}
