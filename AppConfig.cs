namespace ImmichGoGui
{
    internal class AppConfig
    {
        public string immichURL { get; set; }
        public string APIKey { get; set; }



        public AppConfig() { }

        public AppConfig(string immichURL, string aPIKey)
        {
            this.immichURL = immichURL;
            this.APIKey = aPIKey;
        }


    }
}
