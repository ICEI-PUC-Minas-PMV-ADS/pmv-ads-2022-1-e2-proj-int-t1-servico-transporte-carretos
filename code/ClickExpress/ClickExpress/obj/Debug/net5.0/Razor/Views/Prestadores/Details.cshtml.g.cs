#pragma checksum "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d201b9119d8164fe620ee4dd4176c481ff5b6936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prestadores_Details), @"mvc.1.0.view", @"/Views/Prestadores/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d201b9119d8164fe620ee4dd4176c481ff5b6936", @"/Views/Prestadores/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8197a9b78a03eb2e0bb5fc09137c9cbac3fa0c99", @"/Views/_ViewImports.cshtml")]
    public class Views_Prestadores_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClickExpress.Models.Prestador>
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
#line 3 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Prestador</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id_prestador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id_prestador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Veiculo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Veiculo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Logradouro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Logradouro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.UF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Num_endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Num_endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cpf_Cnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cpf_Cnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d201b9119d8164fe620ee4dd4176c481ff5b693613957", async() => {
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
#line 94 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Prestadores\Details.cshtml"
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d201b9119d8164fe620ee4dd4176c481ff5b693616160", async() => {
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClickExpress.Models.Prestador> Html { get; private set; }
    }
}
#pragma warning restore 1591
