namespace Site.Models
{
    public class SmtpModel
    {
        public string Host { get; set; }

        public int Port { get; set; }

        public bool Ssl { get; set; }

        public Credential EmailCredential { get; set; }

        public class Credential
        {
            public string User { get; set; }

            public string Password { get; set; }
        }
    }
}