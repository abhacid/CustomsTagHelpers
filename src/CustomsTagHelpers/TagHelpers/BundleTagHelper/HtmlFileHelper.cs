using System.Globalization;

namespace BundleHelpers
{
    public static class HtmlFileHelper
    {
        public static string ReplaceCultureTag(string input)
        {
            input = ReplaceLongCultureInPath(input);
            input = ReplaceShortCultureInPath(input);

            return input;
        }

        private static string ReplaceLongCultureInPath(string path)
        {
            string cultureTag = "{culture}";

            if (path.Contains(cultureTag))
            {
                path = path.Replace(cultureTag, CultureInfo.CurrentCulture.Name);
            }

            return path;
        }

        private static string ReplaceShortCultureInPath(string path)
        {
            string cultureTag = "{shortculture}";

            if (path.Contains(cultureTag))
            {
                path = path.Replace(cultureTag, CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToLowerInvariant());
            }

            return path;
        }
    }
}
