#pragma checksum "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b18ea3180c8f879b3598f2fa3d390592e6221af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\_ViewImports.cshtml"
using ShopStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\_ViewImports.cshtml"
using ShopStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b18ea3180c8f879b3598f2fa3d390592e6221af", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f059c99349fb5d5d69ee974f48909e03648896ef", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopStore.Models.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:2px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml"
 foreach (var category in Model.CategoryList.OrderBy(o => o.DisplayOrder))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml"
     if (Model.ServiceList.Where(c => c.CategoryId == category.Id).Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row container pb-3 backgroundWhite\">\r\n            <div class=\"col-12\">\r\n                <div class=\"row\">\r\n                    <h2 class=\"text-success\"><b>");
#nullable restore
#line 10 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml"
                                           Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n\r\n                    <div class=\"col-12\">\r\n                        <div class=\"row my-3\">\r\n");
#nullable restore
#line 14 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml"
                             foreach (var service in Model.ServiceList.Where(c => c.CategoryId == category.Id))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-4 col-xl-3 col-md-6 pb-4"">
                                    <div class=""card"" style=""border:2px solid #43ac6a;border-radius:5px; background:url('/images/leaves.png')"">
                                        <div class=""pl-3 pt-1 text-center"">
                                            <h3 class=""card-title text-primary""><b>");
#nullable restore
#line 19 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml"
                                                                              Write(service.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h3>
                                        </div>
                                        <div class=""d-flex justify-content-between "">
                                            <div class=""pl-1 text-muted"">Price per service</div>
                                            <div class=""pr-1 text-danger h5"">$");
#nullable restore
#line 23 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml"
                                                                         Write(service.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        </div>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1488, "\"", 1511, 1);
#nullable restore
#line 25 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1494, service.ImageUrl, 1494, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top p-2 rounded\" />\r\n\r\n                                        <div class=\"text-muted text-center pb-2\">");
#nullable restore
#line 27 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml"
                                                                            Write(service.Frequency.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b18ea3180c8f879b3598f2fa3d390592e6221af8040", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml"
                                                                                                                     WriteLiteral(service.Id);

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
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 31 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Home\source\Repos\ShopStore\ShopStore\ShopStore\Areas\Customer\Views\Home\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopStore.Models.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591