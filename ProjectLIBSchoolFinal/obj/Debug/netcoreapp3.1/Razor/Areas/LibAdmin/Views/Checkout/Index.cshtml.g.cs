#pragma checksum "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4593fd5fd246c30f5d1cb57a79be550eaada8315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_LibAdmin_Views_Checkout_Index), @"mvc.1.0.view", @"/Areas/LibAdmin/Views/Checkout/Index.cshtml")]
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
#line 3 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\_ViewImports.cshtml"
using ProjectLIBSchoolFinal.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\_ViewImports.cshtml"
using LIBSchool_FinalProjectBackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\_ViewImports.cshtml"
using LIBSchool_FinalProjectBackEnd.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4593fd5fd246c30f5d1cb57a79be550eaada8315", @"/Areas/LibAdmin/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58376c07774bbd881e5e93958d200681c359c694", @"/Areas/LibAdmin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_LibAdmin_Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive"">
    <table class=""table mt-5"">
        <thead>
            <tr>
                <th scope=""col"">Number <i style=""font-size:14px"" class=""fa-solid fa-arrow-down""></i></th>
                <th scope=""col"">Fullname <i style=""font-size:14px"" class=""fa-solid fa-arrow-down""></i></th>
                <th scope=""col"">Date <i style=""font-size:14px"" class=""fa-solid fa-arrow-down""></i></th>
                <th scope=""col"">Phone <i style=""font-size:14px"" class=""fa-solid fa-arrow-down""></i></th>
                <th scope=""col"">Location <i style=""font-size:14px"" class=""fa-solid fa-arrow-down""></i></th>

                <th scope=""col"">Total Price <i style=""font-size:14px"" class=""fa-solid fa-arrow-down""></i></th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
             foreach (Order order in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                   \r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
                   Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
                   Write(order.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
                                       Write(order.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
                   Write(order.Date.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
                   Write(order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
                   Write(order.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
                   Write(order.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<div class=\"d-flex justify-content-center\">\r\n    ");
#nullable restore
#line 41 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Checkout\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Index",new {page}),new X.PagedList.Web.Common.PagedListRenderOptionsBase
    {
    LiElementClasses=new[] {"page-item"},
    PageClasses = new[] {"page-link"}
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
