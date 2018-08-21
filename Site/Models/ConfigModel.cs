namespace Site.Models
{
    public class ConfigModel
    {
        public string AppName { get; set; }

        public string TituloSistema { get; set; }

        public string NoFollowLink { get; set; }

        public SmtpModel SmtpConfig { get; set; }
    }
}
