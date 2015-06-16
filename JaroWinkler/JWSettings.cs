using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace JaroWinkler
{
    public static class JWSettings
    {
        public static bool     CaseSensitiveComparison { get; set; }
        public static bool     RemoveNoiseWords        { get; set; }
        public static string[] NoiseWords              { get; set; }
        public static string   NoiseWordsFile          { get; set; }
        public static float    Threshold               { get; set; }
        public static bool     TrimSpaces              { get; set; }
        public static bool     RemovePunctuation       { get; set; }
        public static char[]   PunctuationCharacters   { get; set; }

        public static void LoadSettings()
        {
            bool CaseSensitiveComparison = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["CaseSensitiveComparison"]);
            bool RemoveNoiseWords        = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["RemoveNoiseWords"]);
            string[] NoiseWords          = System.Configuration.ConfigurationManager.AppSettings["NoiseWords"].Split(',');
            string NoiseWordsFile        = System.Configuration.ConfigurationManager.AppSettings["NoiseWordsFile"];
            double Threshold             = Convert.ToDouble(System.Configuration.ConfigurationManager.AppSettings["Threshold"]);
            bool TrimSpaces              = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["TrimSpaces"]);
            bool RemovePunctuation       = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["RemovePunctuation"]);
            char[] PunctuationCharacters = System.Configuration.ConfigurationManager.AppSettings["PunctuationCharacters"].ToCharArray();
        }          

        public static void UpdateSettings()
        {

        }
    }
}
