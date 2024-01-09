namespace ImmichGoGui
{
    internal class AppConfig
    {
        public string ImmichURL { get; set; }
        public string APIKey { get; set; }



        public AppConfig() { }

        public AppConfig(string immichURL, string aPIKey)
        {
            this.ImmichURL = immichURL;
            this.APIKey = aPIKey;
        }


    }
}
