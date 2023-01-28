#pragma checksum "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\SyncedProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6ae0539163c9b575fdd812210ecfbf7f1e2d0a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LocalProduct_SyncedProducts), @"mvc.1.0.view", @"/Views/LocalProduct/SyncedProducts.cshtml")]
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
#line 1 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\SyncedProducts.cshtml"
using JumpsellerSync.BusinessLogic.Core.Dtos.Main;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6ae0539163c9b575fdd812210ecfbf7f1e2d0a6", @"/Views/LocalProduct/SyncedProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b27d2a0ea49bd94697963583de6c925a82212984", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LocalProduct_SyncedProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductDetailsDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<table class=\"table\">\n   <thead>\n      <tr>\n         <th></th>\n         <th>SKU</th>\n         <th>Nombre</th>\n         <th>Precio</th>\n         <th>Stock</th>\n      </tr>\n   </thead>\n   <tbody>\n");
#nullable restore
#line 15 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\SyncedProducts.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"         <tr>
            <td>
               <div class=""d-flex align-items-center justify-content-center add-product-cbox-container"">
                  <label class=""form-check-label"">
                     <input class=""form-check-input no-margin"" type=""checkbox"" data-product-id=""");
#nullable restore
#line 21 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\SyncedProducts.cshtml"
                                                                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\n                  </label>\n               </div>\n            </td>\n            <td>");
#nullable restore
#line 25 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\SyncedProducts.cshtml"
           Write(Html.DisplayFor(modelItem => item.SKU));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 26 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\SyncedProducts.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n               <input type=\"number\"");
            BeginWriteAttribute("name", " name=\"", 865, "\"", 886, 2);
            WriteAttributeValue("", 872, "Price_", 872, 6, true);
#nullable restore
#line 28 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\SyncedProducts.cshtml"
WriteAttributeValue("", 878, item.Id, 878, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                      data-price=\"");
#nullable restore
#line 29 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\SyncedProducts.cshtml"
                             Write(Html.Raw(Json.Serialize(Math.Round(item.Price, 2))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n                      class=\"form-control\" />\n            </td>\n            <td>\n               <input type=\"number\"");
            BeginWriteAttribute("name", " name=\"", 1092, "\"", 1113, 2);
            WriteAttributeValue("", 1099, "Stock_", 1099, 6, true);
#nullable restore
#line 33 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\SyncedProducts.cshtml"
WriteAttributeValue("", 1105, item.Id, 1105, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\n                      value=\"", 1114, "\"", 1155, 1);
#nullable restore
#line 34 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\SyncedProducts.cshtml"
WriteAttributeValue("", 1144, item.Stock, 1144, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                      class=\"form-control\" />\n            </td>\n         </tr>\n");
#nullable restore
#line 38 "C:\Users\PabloGallar\Developer\JumpsellerSync\JumpsellerSync.RestApi.Frontend\Views\LocalProduct\SyncedProducts.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductDetailsDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
