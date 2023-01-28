#pragma checksum "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\AddLocalProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc155a19d5946a8fc9bb625b9944d81f7935ce94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LocalProduct_AddLocalProducts), @"mvc.1.0.view", @"/Views/LocalProduct/AddLocalProducts.cshtml")]
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
#line 1 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\_ViewImports.cshtml"
using JumpsellerSync.RestApi.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\_ViewImports.cshtml"
using JumpsellerSync.RestApi.Core.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\AddLocalProducts.cshtml"
using JumpsellerSync.BusinessLogic.Core.Dtos.Main;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc155a19d5946a8fc9bb625b9944d81f7935ce94", @"/Views/LocalProduct/AddLocalProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b27d2a0ea49bd94697963583de6c925a82212984", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LocalProduct_AddLocalProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PrefetchedBrandDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("local-products-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-start align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""modal fade"" id=""addLocalProductModal""
     data-backdrop=""static"" data-keyboard=""false""
     tabindex=""-1"" aria-labelledby=""addLocalProductTitle""
     aria-hidden=""true"">
   <div class=""modal-dialog mw-100 w-75"">
      <div class=""modal-content"">
         <div class=""modal-header"">
            <h5 class=""modal-title"" id=""addLocalProductTitle"">Agregar Producto Local</h5>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
               <span aria-hidden=""true"">&times;</span>
            </button>
         </div>

         <div class=""modal-body"">
            <div class=""row search-row no-margin d-flex align-items-center"">
               <h5>Filtros:&nbsp;</h5>
               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc155a19d5946a8fc9bb625b9944d81f7935ce945389", async() => {
                WriteLiteral("\n                  <div class=\"form-group\">\n                     <select class=\"form-control\"\n                             name=\"brand\" placeholder=\"Marcas\">\n");
#nullable restore
#line 24 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\AddLocalProducts.cshtml"
                         foreach (var brand in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc155a19d5946a8fc9bb625b9944d81f7935ce946157", async() => {
#nullable restore
#line 26 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\AddLocalProducts.cshtml"
                                                Write(brand.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\AddLocalProducts.cshtml"
                              WriteLiteral(brand.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 27 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\AddLocalProducts.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                     </select>
                  </div>
                  &nbsp;
                  <div class=""form-group"">
                     <input type=""text"" class=""form-control"" name=""sku-or-name""
                            placeholder=""SKU o Nombre"" />
                  </div>
                  &nbsp;
                  <div class=""form-group"">
                     <button type=""button"" class=""btn btn-primary btn-search-products"">
                        <i class=""fa fa-search"" aria-label=""hidden""></i>
                        Buscar
                     </button>
                  </div>
               ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
               &nbsp;
               <div class=""spinner-border text-primary"" role=""status"" id=""synced-products-loading"">
                  <span class=""sr-only"">Cargando...</span>
               </div>
            </div>

            <div id=""synced-products"" class=""row""></div>
         </div>

         <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-primary"" id=""add-local-product"">
               <i class=""fa fa-plus"" aria-label=""hidden""></i>
               Agregar
            </button>

            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">
               <i class=""fa fa-remove"" aria-label=""hidden""></i>
               Cancelar
            </button>

         </div>
      </div>
   </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PrefetchedBrandDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
