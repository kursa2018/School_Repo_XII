#pragma checksum "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abfe458e5f4aaf8624695000f10fb9c19a3519ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Index), @"mvc.1.0.view", @"/Views/Patient/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patient/Index.cshtml", typeof(AspNetCore.Views_Patient_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
#line 4 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\_ViewImports.cshtml"
using HospitalWeb;

#line default
#line hidden
#line 2 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\_ViewImports.cshtml"
using HospitalWeb.Models;

#line default
#line hidden
#line 3 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\_ViewImports.cshtml"
using HospitalDb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abfe458e5f4aaf8624695000f10fb9c19a3519ec", @"/Views/Patient/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9dcbbee920d92cb5b1ef7dbe97c873501149eea", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PatientViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(25, 39, true);
            WriteLiteral("\r\n<h2>Списък с пациенти</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(64, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89ade5ae9135418e8dd95993007c95d6", async() => {
                BeginContext(87, 14, true);
                WriteLiteral("Добави пациент");
                EndContext();
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
            EndContext();
            BeginContext(105, 331, true);
            WriteLiteral(@"
</p>
<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>Име</th>
            <th>ЕГН</th>
            <th>Лекуващ лекар</th>
            <th>Лечение</th>
            <th>Резултат</th>
            <th>Цена</th>
            <th>Опции</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
         foreach (var p in Model.patients)
        {

#line default
#line hidden
            BeginContext(491, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
#line 23 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
                   Doctor d = Model.doctors.FirstOrDefault(x => x.Id == p.DoctorId);

#line default
#line hidden
            BeginContext(596, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(617, 6, false);
#line 24 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
               Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(623, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(651, 5, false);
#line 25 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
               Write(p.Egn);

#line default
#line hidden
            EndContext();
            BeginContext(656, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 26 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
                 if (d != null)
                {                    

#line default
#line hidden
            BeginContext(735, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(760, 6, false);
#line 28 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
                   Write(d.Name);

#line default
#line hidden
            EndContext();
            BeginContext(766, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 29 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(833, 32, true);
            WriteLiteral("                    <td>-</td>\r\n");
            EndContext();
#line 33 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(884, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(905, 10, false);
#line 34 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
               Write(p.Lechenie);

#line default
#line hidden
            EndContext();
            BeginContext(915, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(943, 8, false);
#line 35 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
               Write(p.Result);

#line default
#line hidden
            EndContext();
            BeginContext(951, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(979, 7, false);
#line 36 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
               Write(p.Price);

#line default
#line hidden
            EndContext();
            BeginContext(986, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1035, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcbe72afe49c406ea100eabdbb2e6c4e", async() => {
                BeginContext(1086, 10, true);
                WriteLiteral("Информация");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
                                              WriteLiteral(p.DoctorId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1100, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1124, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46291123652645f49647e0c0367eba9d", async() => {
                BeginContext(1172, 9, true);
                WriteLiteral("Редатирай");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
                                           WriteLiteral(p.DoctorId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1185, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1209, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a77f9e9dede4e388795bc175b21eee3", async() => {
                BeginContext(1259, 6, true);
                WriteLiteral("Изтрий");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
                                             WriteLiteral(p.DoctorId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1269, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 43 "C:\Users\АлишАлишов\Desktop\GIT Projects\School_Repo_XII\HospitalDb\HospitalWeb\Views\Patient\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1324, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PatientViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
