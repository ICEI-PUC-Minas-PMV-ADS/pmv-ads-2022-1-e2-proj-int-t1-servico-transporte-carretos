#pragma checksum "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd8dbc54dc6eb1ecd876d2ebd301c9a1b962e721"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_RelatorioUserStatusPendente), @"mvc.1.0.view", @"/Views/Pedidos/RelatorioUserStatusPendente.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd8dbc54dc6eb1ecd876d2ebd301c9a1b962e721", @"/Views/Pedidos/RelatorioUserStatusPendente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8197a9b78a03eb2e0bb5fc09137c9cbac3fa0c99", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_RelatorioUserStatusPendente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClickExpress.Models.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #2B2D42; background-color: white; font-size: 1vw; font-weight: 500;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsResposta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
  
    ViewData["Title"] = "RelatorioUserStatusPendente";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div style=""padding: 0px 25px 0px 25px"">
    <div class=""container m-0 p-0 mw-100"" style=""font-size: 1.0vw; "">
        <div>
            <br /><br />
            <h4 class=""table text-white"">Pedidos Solicitados</h4>
            <br /><br />
            <div class=""table-responsive"">
                <table class=""table text-white"">
                    <thead>
                        <tr>
                            <th style=""vertical-align: middle; text-align: center"">
                                Status
                            </th>
                            <th style=""vertical-align: middle; text-align: center"">
                                Nº da Solicitação
                            </th>
                            <th style=""vertical-align: middle; text-align: center"">
                                Tipo de Serviço
                            </th>
                            <th style=""vertical-align: middle; text-align: center"">
                                Dat");
            WriteLiteral(@"a Agendada
                            </th>
                            <th style=""vertical-align: middle; text-align: center"">
                                Cidade de Origem
                            </th>
                            <th style=""vertical-align: middle; text-align: center"">
                                Estado de Origem
                            </th>
                            <th style=""vertical-align: middle; text-align: center"">
                                Cidade de Destino
                            </th>
                            <th style=""vertical-align: middle; text-align: center"">
                                Estado de Destino
                            </th>
                            <th style=""vertical-align: middle; text-align: center"">
                                Serviço de Descarga
                            </th>
                            <th style=""vertical-align: middle; text-align: center"">
                                Servi");
            WriteLiteral(@"ço de Montagem
                            </th>
                            <th style=""vertical-align: middle; text-align: center"">
                                + Info
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 54 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
                         foreach (var item in Model)
                        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
             if (item.Status == (StatusServico)0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<tr>
    <td style=""vertical-align: middle; text-align: center"">
        <div class=""text-white"" style=""background-color: #D90429; border-radius: 30px; padding: 1px 5px 1px 5px; vertical-align: middle; text-align: center"">Pendente</div>
    </td>
    <td style=""vertical-align: middle; text-align: center"">
        ");
#nullable restore
#line 63 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Id_contrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 66 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 69 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Dt_agendamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 72 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Cidade_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 75 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.UF_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 78 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Cidade_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 81 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.UF_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 84 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Serv_descarrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 87 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Serv_montagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8dbc54dc6eb1ecd876d2ebd301c9a1b962e72111855", async() => {
                WriteLiteral("Detalhes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
                                                                                                                                         WriteLiteral(item.Id_contrato);

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
            WriteLiteral("\r\n    </td>\r\n</tr> ");
#nullable restore
#line 92 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
      }
                else if (item.Status == (StatusServico)1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<tr>
    <td style=""vertical-align: middle; text-align: center"">
        <div class=""text-dark"" style=""background-color: #A5FFD6; border-radius: 30px; padding: 1px 5px 1px 5px; vertical-align: middle; text-align: center"">Respondido</div>
    </td>
    <td style=""vertical-align: middle; text-align: center"">
        ");
#nullable restore
#line 100 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Id_contrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 103 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 106 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Dt_agendamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 109 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Cidade_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 112 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.UF_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 115 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Cidade_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 118 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.UF_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 121 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Serv_descarrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
#nullable restore
#line 124 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
   Write(Html.DisplayFor(modelItem => item.Serv_montagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"vertical-align: middle; text-align: center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8dbc54dc6eb1ecd876d2ebd301c9a1b962e72118738", async() => {
                WriteLiteral("Detalhes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
                                                                                                                                         WriteLiteral(item.Id_contrato);

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
            WriteLiteral("\r\n    </td>\r\n</tr>");
#nullable restore
#line 129 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatusPendente.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            <br /><br />\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClickExpress.Models.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
