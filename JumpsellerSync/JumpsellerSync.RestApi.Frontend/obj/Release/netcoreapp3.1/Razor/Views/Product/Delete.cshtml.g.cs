#pragma checksum "/home/ubuntu/JumpsellerSync/JumpsellerSync.RestApi.Frontend/Views/Product/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0e71426caa508c135d635d8c54c481379234998"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Delete), @"mvc.1.0.view", @"/Views/Product/Delete.cshtml")]
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
#line 1 "/home/ubuntu/JumpsellerSync/JumpsellerSync.RestApi.Frontend/Views/_ViewImports.cshtml"
using JumpsellerSync.RestApi.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ubuntu/JumpsellerSync/JumpsellerSync.RestApi.Frontend/Views/_ViewImports.cshtml"
using JumpsellerSync.RestApi.Core.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0e71426caa508c135d635d8c54c481379234998", @"/Views/Product/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b27d2a0ea49bd94697963583de6c925a82212984", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JumpsellerSync.BusinessLogic.Core.Dtos.Main.ProductDetailsDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/ubuntu/JumpsellerSync/JumpsellerSync.RestApi.Frontend/Views/Product/Delete.cshtml"
  
   ViewData["Title"] = "Desincronizar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Desincronizar</h1>\n\n<h3>¿Está seguro que desea dejar de sincronizar este producto?</h3>\n<div>\n   <hr />\n   <dl class=\"row\">\n      <dt class=\"col-sm-2\">Nombre</dt>\n      <dd class=\"col-sm-10\">");
#nullable restore
#line 14 "/home/ubuntu/JumpsellerSync/JumpsellerSync.RestApi.Frontend/Views/Product/Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n      <dt class=\"col-sm-2\">Precio</dt>\n      <dd class=\"col-sm-10\">");
#nullable restore
#line 17 "/home/ubuntu/JumpsellerSync/JumpsellerSync.RestApi.Frontend/Views/Product/Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n      <dt class=\"col-sm-2\">Stock</dt>\n      <dd class=\"col-sm-10\">");
#nullable restore
#line 20 "/home/ubuntu/JumpsellerSync/JumpsellerSync.RestApi.Frontend/Views/Product/Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n      <dt class=\"col-sm-2\">SKU</dt>\n      <dd class=\"col-sm-10\">");
#nullable restore
#line 23 "/home/ubuntu/JumpsellerSync/JumpsellerSync.RestApi.Frontend/Views/Product/Delete.cshtml"
                       Write(Html.DisplayFor(model => model.SKU));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n      <dt class=\"col-sm-2\">Margen</dt>\n      <dd class=\"col-sm-10\">");
#nullable restore
#line 26 "/home/ubuntu/JumpsellerSync/JumpsellerSync.RestApi.Frontend/Views/Product/Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Margin));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n   </dl>\n\n   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0e71426caa508c135d635d8c54c4813792349986117", async() => {
                WriteLiteral("\n      ");
#nullable restore
#line 30 "/home/ubuntu/JumpsellerSync/JumpsellerSync.RestApi.Frontend/Views/Product/Delete.cshtml"
 Write(Html.HiddenFor(p => p.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n      <input type=\"submit\" value=\"Sí, estoy seguro\" class=\"btn btn-danger\" /> |\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0e71426caa508c135d635d8c54c4813792349986704", async() => {
                    WriteLiteral("Regresar al listado");
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
                WriteLiteral("\n   ");
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
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JumpsellerSync.BusinessLogic.Core.Dtos.Main.ProductDetailsDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
