#pragma checksum "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2b26ed0621c41c35404c98147f93446266e0130"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Details), @"mvc.1.0.view", @"/Views/Usuarios/Details.cshtml")]
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
#line 1 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\_ViewImports.cshtml"
using ClickExpress;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\_ViewImports.cshtml"
using ClickExpress.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b26ed0621c41c35404c98147f93446266e0130", @"/Views/Usuarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8197a9b78a03eb2e0bb5fc09137c9cbac3fa0c99", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClickExpress.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-white\">\r\n    <h1>Details</h1>\r\n</div>\r\n    <div class=\"text-white\">\r\n        <h4>Usuario</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 15 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 18 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 21 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 24 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 27 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 30 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayFor(model => model.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 33 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 36 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayFor(model => model.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 39 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 42 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 45 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Logradouro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 48 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayFor(model => model.Logradouro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 51 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 54 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 57 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.UF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 60 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayFor(model => model.UF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 63 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Num_endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 66 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayFor(model => model.Num_endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 69 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Cpf_Cnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 72 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
           Write(Html.DisplayFor(model => model.Cpf_Cnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b26ed0621c41c35404c98147f93446266e013012007", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\Details.cshtml"
                               WriteLiteral(Model.Id_usuario);

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
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b26ed0621c41c35404c98147f93446266e013014215", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClickExpress.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
