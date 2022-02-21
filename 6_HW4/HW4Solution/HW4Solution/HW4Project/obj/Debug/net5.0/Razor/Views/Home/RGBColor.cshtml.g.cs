#pragma checksum "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\6_HW4\HW4Solution\HW4Solution\HW4Project\Views\Home\RGBColor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e19d744cf61a9460d840a6aa8bbb7f7d0cf087dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RGBColor), @"mvc.1.0.view", @"/Views/Home/RGBColor.cshtml")]
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
#line 1 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\6_HW4\HW4Solution\HW4Solution\HW4Project\Views\_ViewImports.cshtml"
using HW4Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\6_HW4\HW4Solution\HW4Solution\HW4Project\Views\_ViewImports.cshtml"
using HW4Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e19d744cf61a9460d840a6aa8bbb7f7d0cf087dd", @"/Views/Home/RGBColor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b1cdd2716792226651f4a594fd2ffbf9da1b75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_RGBColor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HW4Project.Models.Color>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RGBColor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\6_HW4\HW4Solution\HW4Solution\HW4Project\Views\Home\RGBColor.cshtml"
  
    ViewData["Title"] = "CS 366 HW4";
    string hexCode = @Model.RGBToHex();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-title\">\r\n    <h1>Enter an RGB Color to see what it looks like!</h1>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e19d744cf61a9460d840a6aa8bbb7f7d0cf087dd4512", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-4"">

            <div class = ""row form-group"">
                <label for=""red"" class=""text-label col-form-label"">R</label>
                <input type=""number"" id=""red"" name=""red"" class=""input-box"" min=0 max=255 />
            </div>

            <div class = ""row form-group"">
                <label for=""green"" class=""text-label col-form-label"">G</label>
                <input type=""number"" id=""green"" name=""green"" class=""input-box"" min=0 max=255 />
            </div>

            <div class = ""row form-group"">
                <label for=""blue"" class=""text-label col-form-label"">B</label>
                <input type=""number"" id=""blue"" name=""blue"" class=""input-box"" min=0 max=255 />
            </div>

            <div class = ""row form-group"">
                <button class=""rounded btn-primary"" type=""submit"">Display</button>
            </div>

        </div>

        <div class=""col-md-2 current-color""");
                BeginWriteAttribute("style", " style= \"", 1251, "\"", 1288, 4);
                WriteAttributeValue("", 1260, "background-color:", 1260, 17, true);
                WriteAttributeValue(" ", 1277, "#", 1278, 2, true);
#nullable restore
#line 37 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\6_HW4\HW4Solution\HW4Solution\HW4Project\Views\Home\RGBColor.cshtml"
WriteAttributeValue("", 1279, hexCode, 1279, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1287, ";", 1287, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"hex-code\">\r\n        #");
#nullable restore
#line 46 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\6_HW4\HW4Solution\HW4Solution\HW4Project\Views\Home\RGBColor.cshtml"
    Write(hexCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HW4Project.Models.Color> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591