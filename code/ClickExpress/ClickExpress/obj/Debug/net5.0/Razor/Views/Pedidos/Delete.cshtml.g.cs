#pragma checksum "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e29ae415020e81e38b04725617306b8655c62409"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_Delete), @"mvc.1.0.view", @"/Views/Pedidos/Delete.cshtml")]
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
#line 1 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\_ViewImports.cshtml"
using ClickExpress;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\_ViewImports.cshtml"
using ClickExpress.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e29ae415020e81e38b04725617306b8655c62409", @"/Views/Pedidos/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8197a9b78a03eb2e0bb5fc09137c9cbac3fa0c99", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClickExpress.Models.Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Pedido</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cep_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cep_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Logradouro_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Logradouro_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Complemento_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Complemento_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bairro_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bairro_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Estado_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cep_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cep_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Logradouro_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Logradouro_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Complemento_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Complemento_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bairro_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bairro_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Estado_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Dt_agendamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dt_agendamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 89 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 92 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 95 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Serv_descarrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 98 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Serv_descarrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 101 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Serv_montagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 104 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Serv_montagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 107 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 110 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Usuario.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29ae415020e81e38b04725617306b8655c6240915560", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e29ae415020e81e38b04725617306b8655c6240915827", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 115 "D:\werlon\ClickExpress_clonado\code\ClickExpress\ClickExpress\Views\Pedidos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_contrato);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29ae415020e81e38b04725617306b8655c6240917634", async() => {
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClickExpress.Models.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
