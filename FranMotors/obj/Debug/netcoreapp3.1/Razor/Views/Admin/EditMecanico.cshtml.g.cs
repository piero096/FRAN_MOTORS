#pragma checksum "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "157cf1879f6d7098cf463df7753e53b515cf784c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditMecanico), @"mvc.1.0.view", @"/Views/Admin/EditMecanico.cshtml")]
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
#line 1 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\_ViewImports.cshtml"
using FranMotors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\_ViewImports.cshtml"
using FranMotors.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157cf1879f6d7098cf463df7753e53b515cf784c", @"/Views/Admin/EditMecanico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"621fbfbe086711c09711af1a9b1f047b160d890c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditMecanico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Activo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Inactivo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157cf1879f6d7098cf463df7753e53b515cf784c4757", async() => {
                WriteLiteral("\r\n        <div class=\"mb-2\">\r\n            <input class=\"form-control\" type=\"text\" name=\"Nombre\"");
                BeginWriteAttribute("value", " value=\"", 207, "\"", 228, 1);
#nullable restore
#line 8 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml"
WriteAttributeValue("", 215, Model.Nombre, 215, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Ingrese Nombre\" />\r\n        </div>\r\n        <span class=\"text-danger\">");
#nullable restore
#line 10 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml"
                             Write(Html.ValidationMessage("Nombre"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <div class=\"mt-2 mb-2\">\r\n            <input class=\"form-control\" type=\"text\" name=\"Apellidos\"");
                BeginWriteAttribute("value", " value=\"", 456, "\"", 480, 1);
#nullable restore
#line 12 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml"
WriteAttributeValue("", 464, Model.Apellidos, 464, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Ingrese Apellido\" />\r\n        </div>\r\n        <span class=\"text-danger\">");
#nullable restore
#line 14 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml"
                             Write(Html.ValidationMessage("Apellidos"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <div class=\"mt-2 mb-2\">\r\n            <input class=\"form-control\" type=\"text\" name=\"Dni\"");
                BeginWriteAttribute("value", " value=\"", 707, "\"", 725, 1);
#nullable restore
#line 16 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml"
WriteAttributeValue("", 715, Model.Dni, 715, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Ingrese DNI\" />\r\n        </div>\r\n        <span class=\"text-danger\">");
#nullable restore
#line 18 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml"
                             Write(Html.ValidationMessage("Dni"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <div class=\"mt-2 mb-2\">\r\n            <input class=\"form-control\" type=\"text\" name=\"Correo\"");
                BeginWriteAttribute("value", " value=\"", 944, "\"", 965, 1);
#nullable restore
#line 20 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml"
WriteAttributeValue("", 952, Model.Correo, 952, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Ingrese Correo\" />\r\n        </div>\r\n        <span class=\"text-danger\">");
#nullable restore
#line 22 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml"
                             Write(Html.ValidationMessage("Correo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <div class=\"mt-2 mb-2\">\r\n            <input class=\"form-control\" type=\"text\" name=\"Telefono\"");
                BeginWriteAttribute("value", " value=\"", 1192, "\"", 1215, 1);
#nullable restore
#line 24 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml"
WriteAttributeValue("", 1200, Model.Telefono, 1200, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Ingrese Teléfono\" />\r\n        </div>\r\n        <span class=\"text-danger\">");
#nullable restore
#line 26 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml"
                             Write(Html.ValidationMessage("Telefono"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <div class=\"mt-2 mb-2\">\r\n            <select class=\"form-control\" name=\"estado\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157cf1879f6d7098cf463df7753e53b515cf784c9386", async() => {
                    WriteLiteral("----Elija Opción----");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157cf1879f6d7098cf463df7753e53b515cf784c10639", async() => {
                    WriteLiteral("Activo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157cf1879f6d7098cf463df7753e53b515cf784c11879", async() => {
                    WriteLiteral("Inactivo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <div class=\"mt-2 mb-2 modal-footer\">\r\n            <button class=\"btn btn-primary form-control\">Editar</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 72, "/admin/edit?id=", 72, 15, true);
#nullable restore
#line 6 "D:\CODE\FranMotors\Proyecto-Calidad\FranMotors\Views\Admin\EditMecanico.cshtml"
AddHtmlAttributeValue("", 87, Model.Id, 87, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
