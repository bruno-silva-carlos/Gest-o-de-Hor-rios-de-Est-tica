#pragma checksum "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "554081d24072dc635b4dee8f5155df0ef5683737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Perfil), @"mvc.1.0.view", @"/Views/Home/Perfil.cshtml")]
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
#line 1 "C:\Users\bruno\Desktop\indra\indra.Web\Views\_ViewImports.cshtml"
using indra.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bruno\Desktop\indra\indra.Web\Views\_ViewImports.cshtml"
using indra.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"554081d24072dc635b4dee8f5155df0ef5683737", @"/Views/Home/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2309f8cfdd8d8928d8dc794011e368e9c8586e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Atribuicao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Servico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("botaoResponsivo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btnAzul pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #00bcd4;border: 0px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarPerfil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TelaPrincipal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btnCinza pull-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Painel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
  
    ViewData["Title"] = "Perfil";
    var usuario = login.GetUsuario();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
 if (TempData["S_ATUA_PERFIL"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Error Alert -->\r\n    <div class=\"alert alert-success alert-dismissible fade show text-center\" id=\"alert\">\r\n        <strong>Sucesso!</strong> ");
#nullable restore
#line 12 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                             Write(TempData["S_ATUA_PERFIL"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
 if (TempData["S_ATRI_SER"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Warning Alert -->\r\n    <div class=\"alert alert-success alert-dismissible fade show text-center\" id=\"alert\">\r\n        ");
#nullable restore
#line 19 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
   Write(TempData["S_ATRI_SER"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""card"">
                    <div class=""card-header card-header-primary titulo"">
                        <h3 class=""card-title""><i class=""fa fa-user-circle""></i> Perfil</h3>
                    </div>

                    <div class=""card-body"">

                        <div class=""row"">
                            <div class=""col col-xs-12"">

");
#nullable restore
#line 37 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                                 if (login.GetUsuario().Pessoa.Tipo == indra.Models.Enums.eTipo.Profissional)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "554081d24072dc635b4dee8f5155df0ef56837379008", async() => {
                WriteLiteral("\r\n                                        <i class=\"fa fa-plus-circle\"></i>\r\n                                        Atribuição de Serviço\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <br />\r\n");
#nullable restore
#line 45 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>

                        <div class=""row"">
                            <div id=""tipo"" class=""col col-xs-12"">
                                <label class=""label"">Tipo de Usuário: </label>
                                <div class=""dadosUsuario"">
");
            WriteLiteral("                                    <span id=\"perfil\" class=\"col col-xs-12\">  ");
#nullable restore
#line 54 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                                                                         Write(ViewBag.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div id=""nome"" class=""row"">
                            <div class=""col col-xs-12"">
                                <label class=""label"">Nome: </label>
                                <div class=""dadosUsuario"">
");
            WriteLiteral("                                    <span id=\"perfil\" class=\"col col-xs-12\">  ");
#nullable restore
#line 64 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                                                                         Write(ViewBag.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div id=""dtNascimento"" class=""row"">
                            <div class=""col col-xs-12"">
                                <label class=""label"">Data de Nascimento: </label>
                                <div class=""dadosUsuario"">
");
            WriteLiteral("                                    <span id=\"perfil\" class=\"col col-xs-12\">  ");
#nullable restore
#line 74 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                                                                         Write(ViewBag.DtNascimento);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div id=""sexo"" class=""row"">
                            <div class=""col col-xs-12"">
                                <label class=""label"">Sexo: </label>
                                <div class=""dadosUsuario"">
");
            WriteLiteral("                                    <span id=\"perfil\" class=\"col col-xs-12\">  ");
#nullable restore
#line 84 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                                                                         Write(ViewBag.Sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div id=""cpf"" class=""row"">
                            <div class=""col col-xs-12"">
                                <label class=""label"">CPF: </label>
                                <div class=""dadosUsuario"">
");
            WriteLiteral("                                    <span id=\"perfil\" class=\"col col-xs-12\">  ");
#nullable restore
#line 94 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                                                                         Write(ViewBag.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div id=""celular"" class=""row"">
                            <div class=""col col-xs-12"">
                                <label class=""label"">Celular: </label>
                                <div class=""dadosUsuario"">
");
            WriteLiteral("                                    <span id=\"perfil\" class=\"col col-xs-12\">  ");
#nullable restore
#line 104 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                                                                         Write(ViewBag.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div id=""email"" class=""row"">
                            <div class=""col col-xs-12"">
                                <label class=""label"">Email: </label>
                                <div class=""dadosUsuario"">
");
            WriteLiteral("                                    <span id=\"perfil\" class=\"col col-xs-12\">  ");
#nullable restore
#line 114 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                                                                         Write(ViewBag.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <br />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "554081d24072dc635b4dee8f5155df0ef568373716690", async() => {
                WriteLiteral("\r\n                            <i class=\"fa fa-refresh\"></i>\r\n                            Atualizar Perfil\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 125 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                         if (login.GetUsuario().Pessoa.Tipo == indra.Models.Enums.eTipo.Cliente)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "554081d24072dc635b4dee8f5155df0ef568373718768", async() => {
                WriteLiteral("\r\n                                <i class=\"fa fa-arrow-left\"></i>\r\n                                Voltar\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 131 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                        }
                        else if (login.GetUsuario().Pessoa.Tipo == indra.Models.Enums.eTipo.Profissional)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "554081d24072dc635b4dee8f5155df0ef568373720717", async() => {
                WriteLiteral("\r\n                                <i class=\"fa fa-arrow-left\"></i>\r\n                                Voltar\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 138 "C:\Users\bruno\Desktop\indra\indra.Web\Views\Home\Perfil.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"clearfix\"></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<style>\r\n    #wrapper #content-wrapper #content {\r\n        flex: 0 0 auto;\r\n    }\r\n    ");
            WriteLiteral(@"@media (max-width: 768px) {
        #botaoResponsivo {
            float: left;
        }

        .pull-right {
            float: left;
        }

        .pull-left {
            float: right;
        }

        .btn {
            display: block;
            width: 100%;
        }
    }

    #perfil {
        margin-left: -15px;
        font-family: 'Arial','sans-serif';
        color: #36b9cc;
    }

    .dadosUsuario {
        margin-left: 3px;
        font-weight: 700;
        font-size: larger;
    }

    .col-md label {
        color: black;
    }

    .form-check, label {
        font-size: 14px;
        line-height: 1.42857;
        color: #000000;
        font-weight: bold;
    }

    .footer {
        position: absolute;
        bottom: 0;
        width: 100%;
        white-space: nowrap;
        line-height: 10px;
    }

    element.style {
        background-color: #00bcd4;
        border: 0px;
    }

    .btn:not(:disabled):not(.disabled) {");
            WriteLiteral(@"
        cursor: pointer;
    }

    [type=button]:not(:disabled), [type=reset]:not(:disabled), [type=submit]:not(:disabled), button:not(:disabled) {
        cursor: pointer;
    }

    .btn {
        display: inline-block;
        font-weight: 400;
        color: #fcfcfd;
        text-align: center;
        vertical-align: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
        border: 1px solid transparent;
        padding: .375rem .75rem;
        font-size: 1rem;
        line-height: 1.5;
        border-radius: .35rem;
        transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,box-shadow .15s ease-in-out;
    }

    .btn-link {
        display: inline-block;
        font-weight: 400;
        color: #000000;
        text-align: center;
        vertical-align: middle;
        -webkit-user-select: none;
    }

    body {
        margin: 0;
  ");
            WriteLiteral(@"      font-family: Nunito,-apple-system,BlinkMacSystemFont,""Segoe UI"",Roboto,""Helvetica Neue"",Arial,sans-serif,""Apple Color Emoji"",""Segoe UI Emoji"",""Segoe UI Symbol"",""Noto Color Emoji"";
        font-size: 1rem;
        font-weight: 400;
        line-height: 1.5;
        color: #ffffff;
        text-align: left;
        background-color: #fff;
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
        public indra.Web.Bibliotecas.LoginPessoa login { get; private set; }
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
