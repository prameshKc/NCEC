#pragma checksum "A:\NCECPROJ\UI\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "503820b845eade0f7545ee5f6a342cded4f3d3ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "A:\NCECPROJ\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\NCECPROJ\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "A:\NCECPROJ\UI\Views\_ViewImports.cshtml"
using DomainModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"503820b845eade0f7545ee5f6a342cded4f3d3ad", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2c0005b440293f82e98fe5685a1fda69c7346d4", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DomainModel.Headline>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "A:\NCECPROJ\UI\Views\About\Index.cshtml"
        
              var firstHead= Model.Where(p=>p.HeadLine=="NCEC").SingleOrDefault();
              

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"glimpse container\">\r\n     \r\n     \r\n      <div class=\"Gnece TAJ MRB\">\r\n        <h1><em>aglimpse into \r\n            who we are …</em>\r\n        </h1>\r\n\r\n      </div>\r\n\r\n");
#nullable restore
#line 22 "A:\NCECPROJ\UI\Views\About\Index.cshtml"
  
    foreach(var item in Model) 
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"Heritage TAJ MRB\">\r\n          <div class=\"heri\">\r\n            <h2>");
#nullable restore
#line 27 "A:\NCECPROJ\UI\Views\About\Index.cshtml"
           Write(item.HeadLine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            ");
#nullable restore
#line 28 "A:\NCECPROJ\UI\Views\About\Index.cshtml"
       Write(Html.Raw(@item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n      </div>\r\n");
#nullable restore
#line 31 "A:\NCECPROJ\UI\Views\About\Index.cshtml"

  }

#line default
#line hidden
#nullable disable
            WriteLiteral("     \r\n\r\n\r\n    </section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DomainModel.Headline>> Html { get; private set; }
    }
}
#pragma warning restore 1591
