#pragma checksum "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3e94d5bd4fbd58515c1df48b70c4de625405f7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e94d5bd4fbd58515c1df48b70c4de625405f7b", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"298e283026df8415d3b26844e1c045bbb115164e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/basket.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Index";

    List<BasketItem> basketItems = await layoutservice.GetBasket(User.Identity.Name);
    decimal total = default;
    decimal totalprice = default;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
     foreach (BasketItem item in basketItems)
    {
        total += item.Count * @Math.Ceiling(@item.Course.Price - (item.Course.Price * item.Course.Discount.Percent / 100));
        totalprice = total;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main>
    <section id=""title-service"" class=""mt-3 p-5"">
        <h1>SƏBƏT</h1>
    </section>

    <section id=""table"">
        <div class=""container"">
            <div class=""row mt-5"">
                <div class=""col-lg-12 col-md-6 col-sm-12"">
");
#nullable restore
#line 23 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                     if (basketItems.Count != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Sil</th>
                                    <th scope=""col"">Kursun adı</th>
                                    <th scope=""col"">Tədris formatı</th>
                                    <th scope=""col"">Qiymət</th>
                                    <th scope=""col"">Sayı</th>
                                    <th scope=""col"">Ümumi</th>
                                </tr>
                            </thead>
                            <tbody>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e94d5bd4fbd58515c1df48b70c4de625405f7b9200", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                     foreach (BasketItem item in basketItems)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <th>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e94d5bd4fbd58515c1df48b70c4de625405f7b9876", async() => {
                    WriteLiteral("<i class=\"fa-solid fa-xmark mt-5\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                                                                                   WriteLiteral(item.Course.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</th>\r\n                                        <td>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c3e94d5bd4fbd58515c1df48b70c4de625405f7b12549", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1948, "~/assets/img/courses/", 1948, 21, true);
#nullable restore
#line 44 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
AddHtmlAttributeValue("", 1969, item.Course.Image, 1969, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<span class=\"ms-3\"><a href=\"#\">");
#nullable restore
#line 45 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                                                          Write(item.Course.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a></span>
                                        </td>
                                        <td>
                                            <div class=""info"">
                                                <span>Qrup şəklində hazırlıq</span>
                                            </div>
                                        </td>
                                        <td>
                                            <div class=""info"">
                                                <span>");
#nullable restore
#line 54 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                                 Write(Math.Ceiling(@item.Course.Price - (item.Course.Price * item.Course.Discount.Percent / 100)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@".00AZN</span>
                                            </div>
                                        </td>
                                         <td>
                                            <div class=""info ms-2"">
                                                <span>");
#nullable restore
#line 59 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                                 Write(item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                            </div>
                                        </td>
                                        <td>
                                            <div class=""info"">
                                                <span style=""color: #2C75E4; ""> ");
#nullable restore
#line 64 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                                                            Write(total=item.Count * @Math.Ceiling(@item.Course.Price - (item.Course.Price * item.Course.Discount.Percent / 100)));

#line default
#line hidden
#nullable disable
                WriteLiteral(".00 AZN</span>\r\n                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 68 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n");
#nullable restore
#line 72 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""d-flex"">
                            <span> <i class=""fa-solid fa-basket-shopping d-flex justify-content-center align-items-center"" style=""color:#F27A1A;font-size:18px;background-color:#FFF1E6;width:50px;height:50px;border-radius:50%;""></i></span>
                            <span class=""mt-2 ms-2"" style=""font-size:22px;font-family:Verdana, Geneva, Tahoma, sans-serif;font-weight:700;color:#212529;""> Sizin səbətiniz boşdur.</span>
                        </div>
");
#nullable restore
#line 79 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </section>

    <section id=""order"">
        <div class=""container"">
            <div class=""row mt-5"">
                <div class=""col-1"">
                    <div class=""shortline mt-4 ms-2""></div>
                </div>
                <div class=""col-11"">
                    <div class=""longline mt-4""></div>
                </div>

                <div class=""col-lg-8 mt-4"">
                    <h2>Endirimdə olan kurslar..</h2>

                    <div class=""owl-carousel owl-theme"">
");
#nullable restore
#line 100 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                         foreach (Course course in Model.Courses.Where(c=>c.DiscountId!=1))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""item"">
                                <div data-aos=""zoom-in-up"" data-aos-delay=""50"" class=""box mt-4"">
                                    <div class=""price"">
                                        <p style=""font-family:Arial;font-weight:500;font-size:14px;"">Endirim</p>
                                    </div>
                                    <div class=""image"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e94d5bd4fbd58515c1df48b70c4de625405f7b21021", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c3e94d5bd4fbd58515c1df48b70c4de625405f7b21321", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5595, "~/assets/img/courses/", 5595, 21, true);
#nullable restore
#line 109 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
AddHtmlAttributeValue("", 5616, course.Image, 5616, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                                                                        WriteLiteral(course.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"textbox\">\r\n                                        <div class=\"title ms-3 mt-3\">\r\n                                            <span>");
#nullable restore
#line 115 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                             Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                        <div class=\"btn mt-3\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e94d5bd4fbd58515c1df48b70c4de625405f7b25873", async() => {
                WriteLiteral("DAHA ƏTRAFLI");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                                                                            WriteLiteral(course.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""comment"">
                                        <div class=""icons mt-2"">
                                            <span class=""me-2 ms-3""><i class=""fa-solid fa-comment me-1""></i>0</span>
                                            <span><i class=""fa-solid fa-user me-1""></i>0</span>
                                        </div>
                                        <div class=""monthly d-flex justify-content-end me-3"">
");
#nullable restore
#line 127 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                             if (@course.DiscountId == 1)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span style=\"font-family:SanFranciscoRegular, Arial, serif;font-weight: 700;font-size:23px;color:#e9284b\">₼");
#nullable restore
#line 130 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                                                                                                                                       Write(course.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 131 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span style=\"font-family:SanFranciscoRegular, Arial, serif;font-weight: 700;font-size:23px;color:#e9284b\"> ₼");
#nullable restore
#line 134 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                                                                                                                                        Write(Math.Ceiling(course.Price - (course.Price * course.Discount.Percent / 100)));

#line default
#line hidden
#nullable disable
            WriteLiteral(".00</span> <span style=\"font-family:SanFranciscoRegular, Arial, serif;font-weight: 700;font-size:20px;color:#a4abb5\"><del>₼");
#nullable restore
#line 134 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                                                Write(course.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></span>\r\n");
#nullable restore
#line 135 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 140 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 143 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                 if (basketItems.Count != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-4 mt-4"">
                        <h3 class=""text-center"">
                            Ümumi ödəniş məbləği
                        </h3>
                        <div class=""paybox ms-3"">
                            <div class=""totalprice m-5"">
                                <p>Cəmi<span class=""ms-5"">");
#nullable restore
#line 151 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                                     Write(totalprice);

#line default
#line hidden
#nullable disable
            WriteLiteral(".00 AZN</span></p>\r\n                                <p>Ümumi<span class=\"ms-5\">");
#nullable restore
#line 152 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                                                      Write(totalprice);

#line default
#line hidden
#nullable disable
            WriteLiteral(".00 AZN</span></p>\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n                        <div class=\"btn mt-3 ms-1\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e94d5bd4fbd58515c1df48b70c4de625405f7b33732", async() => {
                WriteLiteral("İndi sifariş edin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 161 "C:\Users\Ali\source\repos\ProjectLIBSchoolFinal\ProjectLIBSchoolFinal\Views\Basket\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n    </section>\r\n</main>\r\n\r\n<style>\r\n    .owl-carousel .owl-dots{\r\n        display:none;\r\n    }\r\n</style>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e94d5bd4fbd58515c1df48b70c4de625405f7b35722", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js"" integrity=""sha512-bPs7Ae6pVvhOSiIcyUClR7/q2OAsRiovw4vAkX+zJbw3ShAeeqezq50RIIcIURq7Oa20rW2n2q+fyXBNcU9lrw=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
<script>
        $('.owl-carousel').owlCarousel({
        loop: true,
        margin: 10,
        responsive: {
            0: {
                items: 2
            },
            600: {
                items: 2
            },
            1000: {
                items: 3
            }
        }
    })
</script>
");
            }
            );
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
