#pragma checksum "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\Contestant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3726d4e8ffa3eca9a8b1ebd52ea1414032c30a83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amk_Contestant), @"mvc.1.0.view", @"/Views/Amk/Contestant.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Amk/Contestant.cshtml", typeof(AspNetCore.Views_Amk_Contestant))]
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
#line 1 "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\_ViewImports.cshtml"
using CompetitionEventApi;

#line default
#line hidden
#line 2 "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\_ViewImports.cshtml"
using CompetitionEventApi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3726d4e8ffa3eca9a8b1ebd52ea1414032c30a83", @"/Views/Amk/Contestant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8191ba417a071fffad630f155b6e97b9dcf5b61", @"/Views/_ViewImports.cshtml")]
    public class Views_Amk_Contestant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\Contestant.cshtml"
  
    ViewData["Title"] = "Contestant";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(95, 295, true);
            WriteLiteral(@"
<div id=""app"">
    <div class=""contestants"">
        <div class=""row"">
            <div class=""col-md-4 col-md-offset-1"">
                <h1>{{title}}</h1>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 col-md-offset-3"">
                ");
            EndContext();
            BeginContext(390, 2562, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21f17c471a9f40329e75db450177a68c", async() => {
                BeginContext(396, 1919, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""firstName"">Ime natjecatelja</label>
                        <input type=""text"" v-model=""contestant.firstName"" class=""form-control"" id=""firstName"" placeholder=""Unesite ime natjecatelja"">
                    </div>
                    <div class=""form-group"">
                        <label for=""lastName"">Prezime natjecatelja</label>
                        <input type=""text"" v-model=""contestant.lastName"" class=""form-control"" id=""lastName"" placeholder=""Unesite prezime natjecatelja"">
                    </div>
                    <div class=""form-group"">
                        <label for=""uniqueId"">Registracija</label>
                        <input type=""text"" v-model=""contestant.uniqueId"" class=""form-control"" id=""uniqueId"" placeholder=""Unesite registraciju"">
                    </div>
                    <div class=""form-group"">
                        <label for=""club"">Klub</label>
                        <input t");
                WriteLiteral(@"ype=""text"" v-model=""contestant.clubName"" class=""form-control"" id=""club"" placeholder=""Unesite klub ako je član"">
                    </div>
                    <div class=""form-group"">
                        <label for=""mail"">E-mail</label>
                        <input type=""text"" class=""form-control"" v-model=""contestant.email"" id=""mail"" placeholder=""Mail za kontakt"">
                    </div>
                    <div class=""form-group"">
                        <label for=""mob"">Mobitel</label>
                        <input type=""text"" class=""form-control"" v-model=""contestant.mob"" id=""mob"" placeholder=""Mobitel"">
                    </div>
                    <div class=""form-group"">
                        <label for=""event-ddl"">Status</label>
                        <select class=""form-control"" id=""event-ddl"" v-model=""contestant.status"">
                            ");
                EndContext();
                BeginContext(2315, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "359344e4d0c74b7f9c6980aa0b0e2627", async() => {
                    BeginContext(2333, 7, true);
                    WriteLiteral("Aktivan");
                    EndContext();
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
                EndContext();
                BeginContext(2349, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2379, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66d0d4e94b854f89bb97ca678efdf5a8", async() => {
                    BeginContext(2397, 9, true);
                    WriteLiteral("Neaktivan");
                    EndContext();
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
                EndContext();
                BeginContext(2415, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2445, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a60eeac1e084561a5918ffb7f2cd98b", async() => {
                    BeginContext(2463, 7, true);
                    WriteLiteral("Obrisan");
                    EndContext();
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
                EndContext();
                BeginContext(2479, 466, true);
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-check"">
                        <input type=""checkbox"" v-model=""contestant.paid"" class=""form-check-input"" id=""paid"">
                        <label for=""paid"" class=""form-check-label"">Plaćeno natjecanje?</label>
                    </div>
                    <button class=""btn btn-success"" v-on:click.prevent=""saveContestant"">Spremi</button>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2952, 1099, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<script>
    var app = new Vue({
        name: 'ContestantDetails',
        el: '#app',
        data() {
            return {
                title: 'Natjecatelj',
                contestant: {}
            }
        },
        created() {

            axios.get(_siteUrl + 'api/contestants/' + getUrlVars()[""id""])
                .then(response => {
                    this.contestant = response.data
                })
                .catch(e => {
                    console.log(e)
                })
        },
        methods: {
            saveContestant: function () {

                axios({
                    method: 'post',
                    url: _siteUrl + 'api/contestants/',
                    data: this.contestant
                })
                    .then(response => {
                        window.location = ""/"";
                    })
                    .catch(e => {
                        console.");
            WriteLiteral("log(e)\r\n                    })\r\n            }\r\n        }\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
