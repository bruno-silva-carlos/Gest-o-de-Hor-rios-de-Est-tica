#pragma checksum "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adcd1fb7faa677c24d6d27089b9cc801f48e0f28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Desativar), @"mvc.1.0.view", @"/Views/Clientes/Desativar.cshtml")]
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
#line 1 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\_ViewImports.cshtml"
using indra.Web.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\_ViewImports.cshtml"
using indra.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adcd1fb7faa677c24d6d27089b9cc801f48e0f28", @"/Views/Clientes/Desativar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7f7aecdeaf77e4e686e937e54f46b2c26e52b4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Desativar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<indra.Models.PessoaFisica>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmarDesativacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
  
    ViewData["Title"] = "Cliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Desativar Cliente</h1>\r\n\r\n<h3>Deseja realmente desativar esse cliente?</h3>\r\n<div>\r\n\r\n    <hr />\r\n");
#nullable restore
#line 13 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
     if (TempData["ERRO_CLIENTE_DESATIVAR"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- Error Alert -->\r\n        <div class=\"alert alert-danger alert-dismissible fade show text-center\" id=\"alert\">\r\n            <strong>Erro! </strong> ");
#nullable restore
#line 17 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
                               Write(TempData["ERRO_CLIENTE_DESATIVAR"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 23 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 26 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 29 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
       Write(Html.DisplayNameFor(model => model.DtNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 32 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
       Write(Html.DisplayFor(model => model.DtNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 35 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
       Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 38 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
       Write(Html.DisplayFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 41 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 44 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 47 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
       Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 50 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
       Write(Html.DisplayFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 53 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
       Write(Html.DisplayNameFor(model => model.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 56 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
       Write(Html.DisplayFor(model => model.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adcd1fb7faa677c24d6d27089b9cc801f48e0f2810996", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "adcd1fb7faa677c24d6d27089b9cc801f48e0f2811263", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 61 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Clientes\Desativar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Desativar\" class=\"btn btn-danger\" class=\"form-control\" />\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adcd1fb7faa677c24d6d27089b9cc801f48e0f2814328", async() => {
                WriteLiteral("\r\n        <button class=\"btn btn-primary mt-2\" style=\"background: linear-gradient( 60deg, #00bcd4, #216cca);border: 0px\">Cancelar</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<style>

    .col-md label {
        color: black;
    }

    .form-control {
        background-image: linear-gradient(to top, #00bcd4 2px, rgba(156, 39, 176, 0) 2px), linear-gradient(to top, #333333 1px, rgba(210, 210, 210, 0) 1px);
    }

    .form-control, .is-focused .form-control {
        background-image: linear-gradient(to top, #00bcd4 2px, rgba(156, 39, 176, 0) 2px), linear-gradient(to top, #333333 1px, rgba(210, 210, 210, 0) 1px);
    }

    .is-focused [class^='bmd-label'], .is-focused [class*=' bmd-label'] {
        color: #00bcd4;
    }

    select.form-control:not([size]):not([multiple]) {
        height: calc(2.4375rem + 2px);
    }

    select.form-control:not([size]):not([multiple]) {
        height: calc(2.4375rem + 2px);
    }

    .form-control:read-only {
        background-image: linear-gradient(to top, #00bcd4 1px, rgba(210, 210, 210, 0) 1px), linear-gradient(to top, #333333 1px, rgba(210, 210, 210, 0) 1px);
    }

    .form-control:read-only {");
            WriteLiteral(@"
        background-image: linear-gradient(to top, #00bcd4 1px, rgba(210, 210, 210, 0) 1px), linear-gradient(to top, #333333 1px, rgba(210, 210, 210, 0) 1px);
    }

    .footer {
        position: absolute;
        bottom: 0;
        width: 100%;
        white-space: nowrap;
        line-height: 10px;
    }
</style>

<script>
    $(document).ready(function () {
        $(""#alert"").hide();
        $(""#alert"").fadeTo(3000, 600).slideUp(600, function () {
            $(""#alert"").slideUp(600);
        });
    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<indra.Models.PessoaFisica> Html { get; private set; }
    }
}
#pragma warning restore 1591
