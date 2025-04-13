using System;

namespace simplelogin  // Make sure this matches your project's namespace
{
    public static class UserSession
    {
        private static string _username;
        private static string _email;
        private static DateTime _loginTime;

        public static void StartSession(string username, string email)
        {
            _username = username;
            _email = email;
            _loginTime = DateTime.Now;
        }

        public static void EndSession()
        {
            _username = null;
            _email = null;
            _loginTime = DateTime.MinValue;
        }

        public static string GetUsername()
        {
            return _username;
        }

        public static string GetEmail()
        {
            return _email;
        }

        public static DateTime GetLoginTime()
        {
            return _loginTime;
        }

        public static bool IsSessionActive()
        {
            return !string.IsNullOrEmpty(_username);
        }
    }
}
