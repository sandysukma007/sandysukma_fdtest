#pragma checksum "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "488474f061ab780f3bb54b0331a3e55f69569f67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Edit), @"mvc.1.0.view", @"/Views/Book/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"488474f061ab780f3bb54b0331a3e55f69569f67", @"/Views/Book/Edit.cshtml")]
    public class Views_Book_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sandysukma_fdtest.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
  
    ViewData["Title"] = "Edit Buku";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit Buku</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "488474f061ab780f3bb54b0331a3e55f69569f674294", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 237, "\"", 254, 1);
#nullable restore
#line 11 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
WriteAttributeValue("", 245, Model.Id, 245, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Judul Buku</label>\r\n        <input type=\"text\" name=\"Title\"");
                BeginWriteAttribute("value", " value=\"", 377, "\"", 397, 1);
#nullable restore
#line 14 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
WriteAttributeValue("", 385, Model.Title, 385, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Penulis</label>\r\n        <input type=\"text\" name=\"Author\"");
                BeginWriteAttribute("value", " value=\"", 551, "\"", 572, 1);
#nullable restore
#line 18 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
WriteAttributeValue("", 559, Model.Author, 559, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Deskripsi</label>\r\n        <textarea name=\"Description\" class=\"form-control\" rows=\"4\">");
#nullable restore
#line 22 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
                                                              Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Cover Saat Ini</label><br />\r\n        <img");
                BeginWriteAttribute("src", " src=\"", 898, "\"", 923, 1);
#nullable restore
#line 26 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
WriteAttributeValue("", 904, Model.ThumbnailUrl, 904, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""Cover Buku"" width=""100"" />
    </div>
    <div class=""mb-3"">
        <label class=""form-label"">Ganti Cover (opsional)</label>
        <input type=""file"" name=""ThumbnailUrl"" class=""form-control"" />
    </div>
    <div class=""mb-3"">
        <label class=""form-label"">Rating (1-5)</label>
        <input type=""number"" name=""Rating""");
                BeginWriteAttribute("value", " value=\"", 1266, "\"", 1287, 1);
#nullable restore
#line 34 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
WriteAttributeValue("", 1274, Model.Rating, 1274, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" min=\"1\" max=\"5\" />\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "488474f061ab780f3bb54b0331a3e55f69569f677735", async() => {
                    WriteLiteral("Batal");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/sweetalert2@11\"></script>\r\n\r\n");
#nullable restore
#line 43 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
     if (ViewBag.SuccessMessage != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            Swal.fire({\r\n                icon: \'success\',\r\n                title: \'Berhasil!\',\r\n                text: \'");
#nullable restore
#line 49 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
                  Write(ViewBag.SuccessMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                confirmButtonColor: \'#3085d6\'\r\n            });\r\n        </script>\r\n");
#nullable restore
#line 53 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 55 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
     if (ViewBag.ErrorMessage != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            Swal.fire({\r\n                icon: \'error\',\r\n                title: \'Gagal!\',\r\n                text: \'");
#nullable restore
#line 61 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
                  Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                confirmButtonColor: \'#d33\'\r\n            });\r\n        </script>\r\n");
#nullable restore
#line 65 "E:\Test Fan\sandysukma_fdtest\Views\Book\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sandysukma_fdtest.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
