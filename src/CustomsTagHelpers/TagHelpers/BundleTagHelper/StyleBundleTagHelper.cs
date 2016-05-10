using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;
using Microsoft.Extensions.PlatformAbstractions;

namespace BundleHelpers
{
    [HtmlTargetElement("style-bundle", Attributes = AttributeFile)]
    public class StyleBundleTagHelper : BundleTagHelper
    {
        protected override bool AppendVersion
        {
            get
            {
                return true;
            }
        }

        protected override string Extension
        {
            get
            {
                return ".css";
            }
        }

        protected override string MinExtension
        {
            get
            {
                return ".min.css";
            }
        }

        public StyleBundleTagHelper(IApplicationEnvironment applicationEnvironment, IHostingEnvironment hostingEnvironment)
            : base(applicationEnvironment, hostingEnvironment)
        {
        }

        protected override string BuildTag(string file)
        {
            return $"<link type=\"text/css\" rel=\"stylesheet\" href=\"{file}\" />";
        }
    }
}
