#pragma checksum "C:\Programmering\Projekt\CoreWithDB\CoreWithDB\CoreWithDB\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d623408a88b5446faae1c5d990fee67945bea64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d623408a88b5446faae1c5d990fee67945bea64", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""main-wrapper"">
    <!-- Start service Area -->
    <section class=""service-area pt-100"" id=""feature"">
        <div class=""container"">           
            <div class=""row"">
                <div class=""col-lg-4 col-md-6"">
                    <div class=""single-service"">
                        <h4><span class=""lnr lnr-user""></span>List of employees</h4>                      
");
#nullable restore
#line 9 "C:\Programmering\Projekt\CoreWithDB\CoreWithDB\CoreWithDB\Views\Home\Index.cshtml"
                             foreach (var employee in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>");
#nullable restore
#line 11 "C:\Programmering\Projekt\CoreWithDB\CoreWithDB\CoreWithDB\Views\Home\Index.cshtml"
                              Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Programmering\Projekt\CoreWithDB\CoreWithDB\CoreWithDB\Views\Home\Index.cshtml"
                            }                                               

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>              \r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n<!-- End service Area -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
