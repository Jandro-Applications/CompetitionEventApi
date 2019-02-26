#pragma checksum "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\NewContestant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f9671753b8455d4e0bac96b2e6c2a1d2488a60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amk_NewContestant), @"mvc.1.0.view", @"/Views/Amk/NewContestant.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Amk/NewContestant.cshtml", typeof(AspNetCore.Views_Amk_NewContestant))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f9671753b8455d4e0bac96b2e6c2a1d2488a60", @"/Views/Amk/NewContestant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8191ba417a071fffad630f155b6e97b9dcf5b61", @"/Views/_ViewImports.cshtml")]
    public class Views_Amk_NewContestant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\NewContestant.cshtml"
  
    ViewData["Title"] = "NewContestant";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(98, 295, true);
            WriteLiteral(@"
<div id=""app"">
    <div class=""contestants"">
        <div class=""row"">
            <div class=""col-md-4 col-md-offset-1"">
                <h1>{{title}}</h1>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 col-md-offset-1"">
                ");
            EndContext();
            BeginContext(393, 2961, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7016cdfc7754aae8c324d8a9dff258f", async() => {
                BeginContext(399, 1891, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""firstName"">Ime natjecatelja</label>
                        <input type=""text"" class=""form-control"" v-model=""contestant.FirstName"" id=""firstName"" placeholder=""Unesite ime natjecatelja"">
                    </div>
                    <div class=""form-group"">
                        <label for=""lastName"">Prezime natjecatelja</label>
                        <input type=""text"" class=""form-control"" v-model=""contestant.LastName"" id=""lastName"" placeholder=""Unesite prezime natjecatelja"">
                    </div>
                    <div class=""form-group"">
                        <label for=""uniqueId"">Registracija</label>
                        <input type=""text"" class=""form-control"" v-model=""contestant.UniqueId"" id=""uniqueId"" placeholder=""Unesite registraciju"">
                    </div>
                    <div class=""form-group"">
                        <label for=""club"">Klub</label>
                        <input t");
                WriteLiteral(@"ype=""text"" class=""form-control"" v-model=""contestant.ClubName"" id=""club"" placeholder=""Unesite klub ako je član"">
                    </div>
                    <div class=""form-group"">
                        <label for=""mail"">E-mail</label>
                        <input type=""text"" class=""form-control"" v-model=""contestant.Email"" id=""mail"" placeholder=""Mail za kontakt"">
                    </div>
                    <div class=""form-group"">
                        <label for=""mob"">Mobitel</label>
                        <input type=""text"" class=""form-control"" v-model=""contestant.Mob"" id=""mob"" placeholder=""Mobitel"">
                    </div>
                    <div class=""form-group"">
                        <label for=""event-ddl"">Status</label>
                        <select class=""form-control"" id=""event-ddl"">
                            ");
                EndContext();
                BeginContext(2290, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61892c31c0f94ca5bd5156058990bc83", async() => {
                    BeginContext(2308, 7, true);
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
                BeginContext(2324, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2354, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "daee3e814c994e8c9c6ebd1671321b2a", async() => {
                    BeginContext(2372, 9, true);
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
                BeginContext(2390, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2420, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "809ab626ff1d4538933f476cb787ca6e", async() => {
                    BeginContext(2438, 7, true);
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
                BeginContext(2454, 893, true);
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""event-ddl"">Odaberite natjecanja</label>
                        <br />
                        <span v-bind:key=""index"" v-for=""(c,index) in competitions"">
                            <input type=""checkbox"" v-bind:value=""c.id"" v-model=""relatedCompetitionIds"">{{c.title}}
                            <br />
                        </span>
                    </div>
                    <div class=""form-check"">
                        <input type=""checkbox"" class=""form-check-input"" id=""paid"">
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
            BeginContext(3354, 1279, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<script>

    var app = new Vue({
        name: 'NewContestant',
        el: '#app',
        data() {
            return {
                title: 'Novi natjecatelj',
                contestant: {},
                relatedCompetitionIds: [],
                competitions: [
                    { id: 1, title: 'Style' },
                    { id: 2, title: 'Db' },
                    { id: 3, title: 'Car limbo' },
                    { id: 4, title: 'Lowest car' },
                    { id: 5, title: 'Intake' },
                    { id: 6, title: 'Exhaust' }
                ]
            }
        },
        methods: {
            saveContestant: function () {

                this.contestant.RelatedCompetitionIds = this.relatedCompetitionIds

                axios({
                    method: 'post',
                    url: _siteUrl + 'api/contestants/',
                    data: this.contestant
                })
     ");
            WriteLiteral("               .then(response => {\r\n                        window.location = \"/\";\r\n                    })\r\n                    .catch(e => {\r\n                        this.errors.push(e)\r\n                    })\r\n            }\r\n        }\r\n    })\r\n</script>");
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
