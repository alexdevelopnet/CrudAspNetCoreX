#pragma checksum "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ae80fc16e910b91711f11a791cf99c9b9e4362299a9663feadb78c0743200250"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\_ViewImports.cshtml"
using CrudAspNetCoreX

#nullable disable
    ;
#nullable restore
#line 2 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\_ViewImports.cshtml"
using CrudAspNetCoreX.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ae80fc16e910b91711f11a791cf99c9b9e4362299a9663feadb78c0743200250", @"/Views/Contato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7a24a2188a3178608c75833a06d0d3151429bcd8c2644e483769378e3d004fbe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContatoModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Criar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Apagar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
  
    ViewData["Title"] = "Listagem de Contatos";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div class=\"text-center\">\r\n\r\n    <div class=\"d-grid gap-2 d-md-flex justify-content-md-start\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae80fc16e910b91711f11a791cf99c9b9e4362299a9663feadb78c07432002505847", async() => {
                WriteLiteral("Adicionar novo contato");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <br />\r\n\r\n");
#nullable restore
#line 14 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
      if (TempData["MensagemSucesso"] != null)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n    <button type=\"button\" class=\"btn btn-danger btn-sm close-alert\" data-bs-dismiss=\"alert\" aria-label=\"Close\">X</button>\r\n    ");
            Write(
#nullable restore
#line 18 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
     TempData["MensagemSucesso"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 20 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
#nullable restore
#line 22 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
     if (TempData["MensagemErro"] != null)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n    <button type=\"button\" class=\"btn btn-danger btn-sm close-alert\" data-bs-dismiss=\"alert\" aria-label=\"Close\">X</button>\r\n    ");
            Write(
#nullable restore
#line 26 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
     TempData["MensagemErro"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 28 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"   
    <br />

    <h1 class=""display-4"">Listagem de contatos</h1>

    <table id=""table-contatos"" class=""display"" style=""width:100%"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Celular</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 45 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
             if (Model != null && Model.Any())
            {
                foreach (var contato in Model)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            Write(
#nullable restore
#line 50 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
                                         contato.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                        <td>");
            Write(
#nullable restore
#line 51 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
                             contato.Nome

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 52 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
                             contato.Email

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 53 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
                             contato.Celular

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>\r\n                            <div class=\"btn-group\" role=\"group\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae80fc16e910b91711f11a791cf99c9b9e4362299a9663feadb78c074320025011506", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 56 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
                                                                                                             contato.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae80fc16e910b91711f11a791cf99c9b9e4362299a9663feadb78c074320025014185", async() => {
                WriteLiteral("Apagar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 57 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
                                                                                                             contato.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 61 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr class=\"odd\"><td valign=\"top\" colspan=\"5\">Nenhum contato encontrado</td></tr>\r\n");
#nullable restore
#line 66 "D:\Aulas\2024\ASPNET\CrudAspNetCoreX\CrudAspNetCoreX\Views\Contato\Index.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContatoModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
