#pragma checksum "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133601a2ac55e3f3a90348e789a8d13ef8c8a08c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
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
#line 1 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\_ViewImports.cshtml"
using Exemplo01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\_ViewImports.cshtml"
using Exemplo01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133601a2ac55e3f3a90348e789a8d13ef8c8a08c", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"996a0ecc41efb2828077845b1d4be233591f866a", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\Produto\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
#nullable restore
#line 7 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\Produto\Index.cshtml"
 if(TempData["msg"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\">");
#nullable restore
#line 9 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\Produto\Index.cshtml"
                                Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 10 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\Produto\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "133601a2ac55e3f3a90348e789a8d13ef8c8a08c4479", async() => {
                WriteLiteral("Cadastrar Produto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th>Preço</th>\r\n        <th>Quantidade</th>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\Produto\Index.cshtml"
     if(ViewBag.produtos == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>erro</td>\r\n            <td>erro</td>\r\n            <td>erro</td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\Produto\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\Produto\Index.cshtml"
     foreach (Produto p in ViewBag.produtos)
    {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 33 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\Produto\Index.cshtml"
           Write(p.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\Produto\Index.cshtml"
           Write(p.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\Produto\Index.cshtml"
           Write(p.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>    \n");
#nullable restore
#line 37 "C:\Users\caicangussu\Documents\GitHub\CS-FourCamp\CS-FourCamp\Exemplo01\Views\Produto\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
