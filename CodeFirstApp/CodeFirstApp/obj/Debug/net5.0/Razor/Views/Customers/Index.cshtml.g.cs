#pragma checksum "C:\Users\lenovo1\RiderProjects\CodeFirstApp\CodeFirstApp\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c2bed9e7d6032f9ceab9a6add6a0ad1c9247e06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
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
#line 1 "C:\Users\lenovo1\RiderProjects\CodeFirstApp\CodeFirstApp\Views\_ViewImports.cshtml"
using CodeFirstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo1\RiderProjects\CodeFirstApp\CodeFirstApp\Views\_ViewImports.cshtml"
using CodeFirstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2bed9e7d6032f9ceab9a6add6a0ad1c9247e06", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a68217598546f22d774e997c69ebafdfeca2bfc", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lenovo1\RiderProjects\CodeFirstApp\CodeFirstApp\Views\Customers\Index.cshtml"
  
    List<CustomerModel> customers = (List<CustomerModel>) ViewData["Customers"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c2bed9e7d6032f9ceab9a6add6a0ad1c9247e063532", async() => {
                WriteLiteral("\r\n    <title>title</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c2bed9e7d6032f9ceab9a6add6a0ad1c9247e064526", async() => {
                WriteLiteral("\r\n<div>\r\n\r\n    <table>\r\n        <thead>\r\n        <tr>\r\n        <td> ID </td>\r\n        <td> First Name </td>\r\n        <td> Last Name </td>\r\n        <td> Email </td>\r\n        </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\lenovo1\RiderProjects\CodeFirstApp\CodeFirstApp\Views\Customers\Index.cshtml"
         foreach (var Customer in customers)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 27 "C:\Users\lenovo1\RiderProjects\CodeFirstApp\CodeFirstApp\Views\Customers\Index.cshtml"
                Write(Customer.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 28 "C:\Users\lenovo1\RiderProjects\CodeFirstApp\CodeFirstApp\Views\Customers\Index.cshtml"
                Write(Customer.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td> \r\n                <td> ");
#nullable restore
#line 29 "C:\Users\lenovo1\RiderProjects\CodeFirstApp\CodeFirstApp\Views\Customers\Index.cshtml"
                Write(Customer.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 30 "C:\Users\lenovo1\RiderProjects\CodeFirstApp\CodeFirstApp\Views\Customers\Index.cshtml"
                Write(Customer.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\lenovo1\RiderProjects\CodeFirstApp\CodeFirstApp\Views\Customers\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
