#pragma checksum "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9808bf61f7acc850878bd2d343214e04588d26bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_Index), @"mvc.1.0.view", @"/Views/Location/Index.cshtml")]
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
#line 1 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\_ViewImports.cshtml"
using LIBSchool_FinalProjectBackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\_ViewImports.cshtml"
using LIBSchool_FinalProjectBackEnd.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9808bf61f7acc850878bd2d343214e04588d26bd", @"/Views/Location/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"298e283026df8415d3b26844e1c045bbb115164e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Location_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    <section id=\"title-service\" class=\"mt-3 p-5\">\r\n        <h1>FİLİALLAR</h1>\r\n    </section>\r\n\r\n    <section class=\"branchinfos\">\r\n        <div class=\"container\">\r\n            <div class=\"row mt-5\">\r\n");
#nullable restore
#line 15 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
                 foreach (Branch branch in Model.Branches)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"text mt-5\">\r\n                        <h2>");
#nullable restore
#line 18 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
                       Write(branch.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p class=\"mt-4\">");
#nullable restore
#line 19 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
                                   Write(branch.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 20 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
                      Write(branch.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
                                           Write(branch.OfficeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-lg-12\">\r\n                        <div class=\"map mt-4\">\r\n                            <iframe");
            BeginWriteAttribute("src", " src=\"", 732, "\"", 749, 1);
#nullable restore
#line 24 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
WriteAttributeValue("", 738, branch.Map, 738, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"600\" height=\"250\" style=\"border:0;\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 793, "\"", 811, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 27 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"socials d-flex mt-4\">\r\n                <div class=\"facebooks mt-4 ms-4\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1102, "\"", 1187, 1);
#nullable restore
#line 31 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
WriteAttributeValue("", 1109, layoutservice.GetDatas().Result.FirstOrDefault(i=>i.Key=="facebookShare").URL, 1109, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 1191, "\"", 1279, 1);
#nullable restore
#line 31 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
WriteAttributeValue("", 1199, layoutservice.GetDatas().Result.FirstOrDefault(i=>i.Key=="facebookShare").Value, 1199, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                </div>\r\n                <div class=\"facebooks mt-4 ms-4 pinter\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1395, "\"", 1481, 1);
#nullable restore
#line 34 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
WriteAttributeValue("", 1402, layoutservice.GetDatas().Result.FirstOrDefault(i=>i.Key=="pinterestShare").URL, 1402, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 1485, "\"", 1574, 1);
#nullable restore
#line 34 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
WriteAttributeValue("", 1493, layoutservice.GetDatas().Result.FirstOrDefault(i=>i.Key=="pinterestShare").Value, 1493, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                </div>\r\n                <div class=\"facebooks mt-4 ms-4 insta\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1689, "\"", 1770, 1);
#nullable restore
#line 37 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
WriteAttributeValue("", 1696, layoutservice.GetDatas().Result.FirstOrDefault(i=>i.Key=="instagram").URL, 1696, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 1774, "\"", 1858, 1);
#nullable restore
#line 37 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
WriteAttributeValue("", 1782, layoutservice.GetDatas().Result.FirstOrDefault(i=>i.Key=="instagram").Value, 1782, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                </div>\r\n                <div class=\"facebooks mt-4 ms-4 twit\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1972, "\"", 2053, 1);
#nullable restore
#line 40 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
WriteAttributeValue("", 1979, layoutservice.GetDatas().Result.FirstOrDefault(i=>i.Key=="twitShare").URL, 1979, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2057, "\"", 2141, 1);
#nullable restore
#line 40 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Location\Index.cshtml"
WriteAttributeValue("", 2065, layoutservice.GetDatas().Result.FirstOrDefault(i=>i.Key=="twitShare").Value, 2065, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n</main>\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LIBSchool_FinalProjectBackEnd.Service.LayoutService layoutservice { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
