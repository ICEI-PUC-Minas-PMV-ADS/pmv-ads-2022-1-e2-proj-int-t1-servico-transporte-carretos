#pragma checksum "C:\Users\Thamara\Desktop\ADS\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d77f2b6803e7c93f8992f3dcb3c32f85e298696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Itens_ListarItens), @"mvc.1.0.view", @"/Views/Itens/ListarItens.cshtml")]
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
#line 1 "C:\Users\Thamara\Desktop\ADS\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\_ViewImports.cshtml"
using ClickExpress;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thamara\Desktop\ADS\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\_ViewImports.cshtml"
using ClickExpress.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d77f2b6803e7c93f8992f3dcb3c32f85e298696", @"/Views/Itens/ListarItens.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03807d6414b1344179fede2f5e809c4754724f25", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Itens_ListarItens : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClickExpress.Models.Item>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-white"">

    <div class=""formulario"">
        <br />
        <h6><span style=""color: white; font-weight: bold;"">Item</span></h6>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-sm-auto""><label class=""control-label col-md-2"">Descrição:</label></div>
                <div class=""col-sm-3""><input style=""width: 100%;"" class=""form-control"" type=""text"" id=""descricao"" name=""Descrição"" /></div>
                <div class=""col-sm-auto""><label class=""control-label col-md-2"">Quantidade:</label></div>
                <div class=""col-sm-1""><input style=""width: 100%;"" class=""form-control"" type=""number"" id=""quantidade"" name=""Quantidade"" /></div>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <a href=""#"" onclick=""SalvarItens();"" class=""btn btn-danger"">Adicionar Item</a>
            </div>
        </div>
    </div>

    <input type=""hidden"" id=""Id_contrato""");
            BeginWriteAttribute("value", " value=\"", 1050, "\"", 1073, 1);
#nullable restore
#line 24 "C:\Users\Thamara\Desktop\ADS\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
WriteAttributeValue("", 1058, ViewBag.Pedido, 1058, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    <br />
    <h6><span style=""color: white; font-weight: bold;"">Itens Adicionados:</span></h6>
    <table class=""table table-hover table-dark"" style=""border-radius: 10px; width:100%;"">
        <thead>
            <tr>

                <th>
                    ");
#nullable restore
#line 32 "C:\Users\Thamara\Desktop\ADS\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
               Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    \n                </th>\n                <th>\n                    ");
#nullable restore
#line 36 "C:\Users\Thamara\Desktop\ADS\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
               Write(Html.DisplayNameFor(model => model.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody style=\"width: 100%\">\n");
#nullable restore
#line 42 "C:\Users\Thamara\Desktop\ADS\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr style=\"width: 100%\">\n\n    <td>\n        ");
#nullable restore
#line 47 "C:\Users\Thamara\Desktop\ADS\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
   Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        \n    </td>\n    <td>\n        ");
#nullable restore
#line 51 "C:\Users\Thamara\Desktop\ADS\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
   Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n\n</tr>");
#nullable restore
#line 54 "C:\Users\Thamara\Desktop\ADS\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClickExpress.Models.Item>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591