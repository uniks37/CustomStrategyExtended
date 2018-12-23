namespace LoggingLayer
{
    public class Log
    {
        private string message;
        public Log(string message)
        {
            message = message;
        }
        public string Message { get => message; }

        public override string ToString()
        {
            return message;
        }
    }

    public class LoginLog : Log
    {
        private string uname;

        public LoginLog(string message, string uname)
            :base(message)
        {
            this.Uname = uname;
        }

        public string Uname { get => uname; set => uname = value; }

        public override string ToString()
        {
            return string.Format("Login attempt by {0} : {1}", Uname, Message);
        }
    }


    public class RegistrationLog : Log
    {
        private string uname;

        public RegistrationLog(string message, string uname)
            : base(message)
        {
            this.Uname = uname;
        }

        public string Uname { get => uname; set => uname = value; }

        public override string ToString()
        {
            return string.Format("Registration attempt by {0} : {1}", Uname, Message);
        }
    }
}