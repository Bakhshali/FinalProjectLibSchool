#pragma checksum "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fc0dd7dda06bbcf8925d78208b5592676f7a863"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_LibAdmin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/LibAdmin/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fc0dd7dda06bbcf8925d78208b5592676f7a863", @"/Areas/LibAdmin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58376c07774bbd881e5e93958d200681c359c694", @"/Areas/LibAdmin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_LibAdmin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    decimal? totalprices = 0;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Dashboard\Index.cshtml"
     foreach (var item in Model.Orderses)
    {
        totalprices += item.TotalPrice;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    main #chart h3 {
        font-family: Nunito, ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, ""Segoe UI"", Roboto, ""Helvetica Neue"", Arial, ""Noto Sans"", sans-serif, ""Apple Color Emoji"", ""Segoe UI Emoji"", ""Segoe UI Symbol"", ""Noto Color Emoji"";
        font-size: 50px;
        font-weight: 700;
        line-height: 75px;
        color: white;
    }

    main #chart .box {
        width: 100%;
        background-color: white;
        border-radius: 5px;
    }

        main #chart .box h5 {
            font-family: Nunito, ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, ""Segoe UI"", Roboto, ""Helvetica Neue"", Arial, ""Noto Sans"", sans-serif, ""Apple Color Emoji"", ""Segoe UI Emoji"", ""Segoe UI Symbol"", ""Noto Color Emoji"";
            font-size: 50px;
            font-weight: 700;
            color: black;
            line-height: 75px;
        }

        main #chart .box p {
            font-family: Nunito, ui-sans-serif, system-ui, -apple-system, BlinkMacSy");
            WriteLiteral(@"stemFont, ""Segoe UI"", Roboto, ""Helvetica Neue"", Arial, ""Noto Sans"", sans-serif, ""Apple Color Emoji"", ""Segoe UI Emoji"", ""Segoe UI Symbol"", ""Noto Color Emoji"";
            font-size: 16px;
            font-weight: 700;
            margin-top: 20px;
        }
</style>

<main>
    <section id=""chart"">
        <div class=""container"">
            <div class=""row mt-5 text-center d-flex justify-content-center"">
                <div>
                    <h3 style=""color:black"" class=""mt-4"">LibSchool saytının reytinqi</h3>
                </div>
                <div class=""col-lg-12 p-4 text-center d-flex justify-content-center"" style=""background-color:#8E44AD;border-radius: 8px;"">

                    <div class=""col-lg-3 mt-5"">
                        <div class=""box p-1"">
                            <h5 class=""counter"" data-target=""");
#nullable restore
#line 54 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Dashboard\Index.cshtml"
                                                        Write(Model.AppUsers.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""></h5>
                            <p> <i class=""fa-solid fa-users""></i> İstifadəçi</p>
                        </div>
                    </div>
                    <div class=""col-lg-3 mt-5"">
                        <div class=""box p-1"">
                            <h5 class=""counter"" data-target=""");
#nullable restore
#line 60 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Dashboard\Index.cshtml"
                                                        Write(Model.Orderses.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""></h5>
                            <p> <i class=""fa-solid fa-calendar-check""></i> Aylıq sifarişlər</p>
                        </div>
                    </div>
                    <div class=""col-lg-3 mt-5"">
                        <div class=""box p-1"">
                            <h5 class=""counter"" data-target=""");
#nullable restore
#line 66 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Areas\LibAdmin\Views\Dashboard\Index.cshtml"
                                                        Write(totalprices);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></h5> \r\n                            <p> <i class=\"fa-solid fa-right-to-bracket\"></i> Budget</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
        const counters = document.querySelectorAll('.counter');
    counters.forEach((counter) => {
        counter.innerText = `0`;
        const updateCounter = () => {
            const target = +counter.getAttribute
                (`data-target`);
            const c = + counter.innerText;

            const increment = target / 500;

            if (c < target) {
                counter.innerText = `${Math.ceil(c + increment)}`;
                setTimeout(updateCounter, 1);
            } else {
                counter.innerText = target;
            }

        };
        updateCounter();
    })
</script>
<script>
    const countEl = document.getElementById(""count"");
    countvisits();
    function countvisits(){
        fetch('https://api.countapi.xyz/update/laptop/mause/?amount=1')
        .then((res)=>res.json())
        .then((res)=>{
            countEl.innerHTML = res.value;
        });
    }
</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
