#pragma checksum "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26113d1654ceb976c4f4a84178c7519e284e77e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amk_Results), @"mvc.1.0.view", @"/Views/Amk/Results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Amk/Results.cshtml", typeof(AspNetCore.Views_Amk_Results))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26113d1654ceb976c4f4a84178c7519e284e77e3", @"/Views/Amk/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8191ba417a071fffad630f155b6e97b9dcf5b61", @"/Views/_ViewImports.cshtml")]
    public class Views_Amk_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("option in competitions"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-bind:value", new global::Microsoft.AspNetCore.Html.HtmlString("option.id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\Results.cshtml"
  
    ViewData["Title"] = "Results";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\Results.cshtml"
  
    ViewData["Title"] = "Scoring";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(186, 327, true);
            WriteLiteral(@"
<div id=""app"">
    <div class=""contestants"">
        <div class=""row"">
            <div class=""col-md-4 col-md-offset-1"">
                <h1>{{title}}</h1>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <select v-model=""selected"" class=""form-control"" ");
            EndContext();
            BeginContext(514, 64, true);
            WriteLiteral("@change=\"onHeadCompetitionChange($event)\">\r\n                    ");
            EndContext();
            BeginContext(578, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa6f26508c9b4b4cabc64c1df6b99947", async() => {
                BeginContext(642, 66, true);
                WriteLiteral("\r\n                        {{ option.title }}\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(717, 2544, true);
            WriteLiteral(@"
                </select>
            </div>
        </div>
        <div class=""row push-top-20"">
            <div class=""col-md-4"">
                <table class=""table table-bordered table-striped push-top-20"">
                    <thead>
                        <tr>
                            <td>#</td>
                            <td>Ime i prezime</td>
                            <td>Registracija</td>
                            <td>Rezultat</td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-bind:key=""index"" v-for=""(score,index) in filteredScores"">
                            <td>{{index + 1}}</td>
                            <td>{{score.firstAndLastName}}</td>
                            <td>{{score.registration}}</td>
                            <td>{{score.finalScore}}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</di");
            WriteLiteral(@"v>

<script>
    var app = new Vue({
        name: 'Results',
        el: '#app',
        data() {
            return {
                selected: 1,
                title: 'Rezultati',
                competitions: [],
                scores: [],
                filteredScores:[]
            }
        },
        created() {
            axios.get(_siteUrl + 'api/scores')
                .then(response => {
                    this.scores = response.data;
                    var selectedOption = this.selected;
                    this.filteredScores = this.scores.filter(function (e) {
                        return e.competitionId == selectedOption;
                    });
                })
                .catch(e => {
                    console.log(e)
                })

            axios.get(_siteUrl + 'api/competitions')
                .then(response => {
                    this.competitions = response.data
                })
                .catch(e => {
               ");
            WriteLiteral(@"     console.log(e)
                })
        },
        methods: {
            onHeadCompetitionChange: function (e) {
                var selectedOption = this.selected;
                this.filteredScores = this.scores.filter(function (e) {
                    return e.competitionId == selectedOption;
                });

                if (selectedOption == 4) {
                    this.filteredScores.reverse();
                }
            }
        }
    })
</script>");
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
