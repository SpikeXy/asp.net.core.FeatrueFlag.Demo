#pragma checksum "C:\Users\Administrator\source\repos\FeatrueFlagsDemo\FeatrueFlagsDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1570310a2ca2eaaff69c11e50a0261a765f0c342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1570310a2ca2eaaff69c11e50a0261a765f0c342", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "EnableWebApi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "EnableAudit, EnableWebApi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.FeatureManagement.Mvc.TagHelpers.FeatureTagHelper __Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1570310a2ca2eaaff69c11e50a0261a765f0c3423594", async() => {
                WriteLiteral("\r\n    <title></title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1570310a2ca2eaaff69c11e50a0261a765f0c3424583", async() => {
                WriteLiteral("\r\n    测试功能开关\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("feature", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1570310a2ca2eaaff69c11e50a0261a765f0c3424863", async() => {
                    WriteLiteral("\r\n\r\n        <p>This can only be seen if \'EnableWebApi\' is enabled.</p>\r\n\r\n    ");
                }
                );
                __Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper = CreateTagHelper<global::Microsoft.FeatureManagement.Mvc.TagHelpers.FeatureTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper);
                __Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("feature", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1570310a2ca2eaaff69c11e50a0261a765f0c3426212", async() => {
                    WriteLiteral("\r\n        <p>这个是EnableWebApi关闭了才显示的内容</p>\r\n        <p>This will be shown if \'FeatureA\' is disabled.</p>\r\n\r\n    ");
                }
                );
                __Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper = CreateTagHelper<global::Microsoft.FeatureManagement.Mvc.TagHelpers.FeatureTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper);
                __Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 28 "C:\Users\Administrator\source\repos\FeatrueFlagsDemo\FeatrueFlagsDemo\Views\Home\Index.cshtml"
__Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper.Negate = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("negate", __Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper.Negate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("feature", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1570310a2ca2eaaff69c11e50a0261a765f0c3428079", async() => {
                    WriteLiteral("\r\n\r\n        <p>This can only be seen if \'EnableAudit\' and \'EnableWebApi\' are enabled.</p>\r\n\r\n    ");
                }
                );
                __Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper = CreateTagHelper<global::Microsoft.FeatureManagement.Mvc.TagHelpers.FeatureTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper);
                __Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 35 "C:\Users\Administrator\source\repos\FeatrueFlagsDemo\FeatrueFlagsDemo\Views\Home\Index.cshtml"
__Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper.Requirement = global::Microsoft.FeatureManagement.RequirementType.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("requirement", __Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper.Requirement, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("feature", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1570310a2ca2eaaff69c11e50a0261a765f0c3429996", async() => {
                    WriteLiteral("\r\n        EnableAudit\', \'EnableWebApi\', or both are enabled.</p>\r\n\r\n    ");
                }
                );
                __Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper = CreateTagHelper<global::Microsoft.FeatureManagement.Mvc.TagHelpers.FeatureTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper);
                __Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 41 "C:\Users\Administrator\source\repos\FeatrueFlagsDemo\FeatrueFlagsDemo\Views\Home\Index.cshtml"
__Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper.Requirement = global::Microsoft.FeatureManagement.RequirementType.Any;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("requirement", __Microsoft_FeatureManagement_Mvc_TagHelpers_FeatureTagHelper.Requirement, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
