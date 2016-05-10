using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;
using Microsoft.Extensions.PlatformAbstractions;
//using Microsoft.Framework.Runtime;

namespace BundleHelpers
{
    [HtmlTargetElement("script-bundle", Attributes = AttributeFile)]
    public class ScriptBundleHelper : BundleTagHelper
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
                return ".js";
            }
        }

        protected override string MinExtension
        {
            get
            {
                return ".min.js";
            }
        }

        public ScriptBundleHelper(IApplicationEnvironment applicationEnvironment, IHostingEnvironment hostingEnvironment)
            : base(applicationEnvironment, hostingEnvironment)
        {
        }

        protected override string BuildTag(string file)
        {
            return $"<script type=\"text/javascript\" src=\"{file}\"></script>";
        }
    }
}
