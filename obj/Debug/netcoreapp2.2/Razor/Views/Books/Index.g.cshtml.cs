#pragma checksum "/home/jiwanicki/Documents/dotnet_put/Views/Books/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e611abc19553494dbe81fb6fa12978a739549ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Index.cshtml", typeof(AspNetCore.Views_Books_Index))]
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
#line 1 "/home/jiwanicki/Documents/dotnet_put/Views/_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "/home/jiwanicki/Documents/dotnet_put/Views/_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#line 1 "/home/jiwanicki/Documents/dotnet_put/Views/Books/Index.cshtml"
using WebApplication1.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e611abc19553494dbe81fb6fa12978a739549ad", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637209e7eeedf13d00f2cccd93a350b795d01eb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BookListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(61, 37, false);
#line 4 "/home/jiwanicki/Documents/dotnet_put/Views/Books/Index.cshtml"
Write(await Component.InvokeAsync("Navbar"));

#line default
#line hidden
            EndContext();
            BeginContext(98, 242, true);
            WriteLiteral("\n\n<section class=\"d-flex justify-content-center flex-column\">\n  <table class=\"table\">\n    <thead>\n    <tr>\n      <th scope=\"col\">Name</th>\n      <th scope=\"col\">Authors</th>\n      <th scope=\"col\">Owned</th>\n    </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 16 "/home/jiwanicki/Documents/dotnet_put/Views/Books/Index.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
            BeginContext(387, 31, true);
            WriteLiteral("          <tr>\n            <td>");
            EndContext();
            BeginContext(419, 9, false);
#line 19 "/home/jiwanicki/Documents/dotnet_put/Views/Books/Index.cshtml"
           Write(book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(428, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(451, 30, false);
#line 20 "/home/jiwanicki/Documents/dotnet_put/Views/Books/Index.cshtml"
           Write(string.Join(",", book.Authors));

#line default
#line hidden
            EndContext();
            BeginContext(481, 37, true);
            WriteLiteral("</td>\n            <td>\n              ");
            EndContext();
            BeginContext(518, 305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e611abc19553494dbe81fb6fa12978a739549ad5487", async() => {
                BeginContext(558, 37, true);
                WriteLiteral("\n                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 595, "\"", 611, 1);
#line 23 "/home/jiwanicki/Documents/dotnet_put/Views/Books/Index.cshtml"
WriteAttributeValue("", 603, book.Id, 603, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(612, 35, true);
                WriteLiteral(" name=\"Id\">\n                <button");
                EndContext();
                BeginWriteAttribute("disabled", " disabled=\"", 647, "\"", 675, 1);
#line 24 "/home/jiwanicki/Documents/dotnet_put/Views/Books/Index.cshtml"
WriteAttributeValue("", 658, book.IsUserOwner, 658, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(676, 24, true);
                WriteLiteral(" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 700, "\"", 716, 1);
#line 24 "/home/jiwanicki/Documents/dotnet_put/Views/Books/Index.cshtml"
WriteAttributeValue("", 708, book.Id, 708, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(717, 20, true);
                WriteLiteral(">\n                  ");
                EndContext();
                BeginContext(739, 35, false);
#line 25 "/home/jiwanicki/Documents/dotnet_put/Views/Books/Index.cshtml"
              Write(@book.IsUserOwner ? "Owned" : "Add");

#line default
#line hidden
                EndContext();
                BeginContext(775, 41, true);
                WriteLiteral("\n                </button>\n              ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(823, 35, true);
            WriteLiteral("\n            </td>\n          </tr>\n");
            EndContext();
#line 30 "/home/jiwanicki/Documents/dotnet_put/Views/Books/Index.cshtml"
    
        }

#line default
#line hidden
            BeginContext(873, 37, true);
            WriteLiteral("    </tbody>\n\n  </table>\n\n</section>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BookListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
