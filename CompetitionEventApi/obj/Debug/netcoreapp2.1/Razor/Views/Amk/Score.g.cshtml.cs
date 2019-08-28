#pragma checksum "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\Score.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee3df53989e4342bd7fbafd28b52b65322a6ef0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amk_Score), @"mvc.1.0.view", @"/Views/Amk/Score.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Amk/Score.cshtml", typeof(AspNetCore.Views_Amk_Score))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee3df53989e4342bd7fbafd28b52b65322a6ef0b", @"/Views/Amk/Score.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8191ba417a071fffad630f155b6e97b9dcf5b61", @"/Views/_ViewImports.cshtml")]
    public class Views_Amk_Score : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\Score.cshtml"
  
    ViewData["Title"] = "Score";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 128, true);
            WriteLiteral("\r\n<div id=\"app\">\r\n    <div class=\"contestants\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4 col-md-offset-1\">\r\n");
            EndContext();
            BeginContext(256, 481, true);
            WriteLiteral(@"            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4"">
                <p v-bind:class=""{'bg-danger':error, 'bg-success':!error}"" style=""font-size:22px;font-weight:bold;color:#000000"">{{ msg }}</p>
            </div>
        </div>
        <div class=""row push-top-20"">
            <div class=""col-md-4"">
                <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
");
            EndContext();
            BeginContext(812, 96, true);
            WriteLiteral("                            <td>Natjecanje</td>\r\n                            <td>Rezultat</td>\r\n");
            EndContext();
            BeginContext(981, 193, true);
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n                        <tr v-bind:key=\"index\" v-for=\"(competitionScore,index) in competitionScores\">\r\n");
            EndContext();
            BeginContext(1270, 145, true);
            WriteLiteral("                            <td>{{competitionScore.competitionName}}</td>\r\n                            <td>{{competitionScore.finalScore}}</td>\r\n");
            EndContext();
            BeginContext(1613, 519, true);
            WriteLiteral(@"                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""form-group row"">
                    <label for=""competitions"" class=""col-sm-2 col-form-label"">Natjecanje</label>
                    <div class=""col-sm-10"">
                        <select class=""form-control"" id=""competitions"" v-model=""scoreSaveViewModel.CompetitionId"">
                            ");
            EndContext();
            BeginContext(2132, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "180a28502f764caabc12d1ce9898a267", async() => {
                BeginContext(2196, 82, true);
                WriteLiteral("\r\n                                {{ option.title }}\r\n                            ");
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
            BeginContext(2287, 6266, true);
            WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""form-group row"">
                    <label for=""score"" class=""col-sm-2 col-form-label"">Rezultat</label>
                    <div class=""col-sm-10"" v-if=""mainCompetitionId != 1"">
                        <input type=""text"" v-model=""scoreSaveViewModel.Score"" class=""form-control"" id=""score"">
                    </div>
                    <div class=""col-sm-10"" v-else>
                        <input type=""text"" v-model=""scoreSaveViewModel.Round1"" class=""form-control"" id=""round1"">
                        <input type=""text"" v-model=""scoreSaveViewModel.Round2"" class=""form-control"" id=""round2"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <div class=""col-sm-10"">
                        <button type=""button"" class=""btn btn-primary"" v-on:click.prevent=""save"">Spremi</button>
                    </div>
                </div");
            WriteLiteral(@">
                <div class=""form-group row "">
                    <div class=""col-sm-10 push-top-10"">
                        <button type=""button"" class=""btn btn-warning"" v-on:click.prevent=""done"">Gotovo!</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    var app = new Vue({
        name: 'Score',
        el: '#app',
        data() {
            return {
                selectedMinor: 0,
                title: 'Ocjenjivanje',
                competitionScores: [],
                mainCompetitionId: 0,
                scoreSaveViewModel: {},
                competitions: [],
                msg: '',
                error: false
            }
        },
        created() {

            this.load();
        },
        methods: {
            load: function (e) {
                axios.get(_siteUrl + 'api/scores/' + getUrlVars()[""Id""])
                    .then(response => {
                        this.c");
            WriteLiteral(@"ompetitionScores = response.data.competitionScores;

                        var mainComeptitionId = response.data.mainCompetitionId
                        this.mainCompetitionId = mainComeptitionId;

                        axios.get(_siteUrl + 'api/competitions')
                            .then(response => {
                                if (mainComeptitionId == 1 || mainComeptitionId == 2 || mainComeptitionId == 4) {
                                    this.competitions = response.data.filter(function (e) {
                                        return e.relatedCompetitionId == mainComeptitionId;
                                    })
                                } else {
                                    this.competitions = response.data.filter(function (e) {
                                        return e.id == mainComeptitionId;
                                    })
                                }
                            })
                            .catch(e => {
 ");
            WriteLiteral(@"                               console.log(e)
                            });

                    })
                    .catch(e => {
                        console.log(e)
                    });
            },
            done: function () {

                axios({
                    method: 'put',
                    url: _siteUrl + 'api/scores/' + getUrlVars()[""Id""]
                }).then(response => {
                    this.msg = ""Gotovo"";
                    this.error = false;
                    window.location.href = ""/Amk/scoring"";
                })
                    .catch(e => {
                        console.log(e)
                    })
            },
            save: function () {

                var saveModel = this.scoreSaveViewModel;
                saveModel.CompetitionApplicationId = getUrlVars()[""Id""];

                var chkCompScore = this.competitionScores.filter(function (e) {
                    return e.competitionId == saveModel.Competition");
            WriteLiteral(@"Id;
                })

                var chkMainCompScore = this.competitionScores.filter(function (e) {
                    return (saveModel.CompetitionId == 7 || saveModel.CompetitionId == 8 || saveModel.CompetitionId == 9)
                        && (e.competitionId == 7 || e.competitionId == 8 || e.competitionId == 9); //begginer, pro, extreme
                })

                var chkMainCompScoreLow = this.competitionScores.filter(function (e) {
                    return (saveModel.CompetitionId == 33 || saveModel.CompetitionId == 34 || saveModel.CompetitionId == 35)
                        && (e.competitionId == 33 || e.competitionId == 34 || e.competitionId == 35);
                })

                if (chkMainCompScoreLow.length > 0) {
                    this.msg = ""Možeš odabrati samo jednu kategoriju za lowest"";
                    this.error = true;
                    return;
                } else {
                    this.msg = """";
                    this.error = fa");
            WriteLiteral(@"lse;
                }


                if (chkMainCompScore.length > 0) {
                    this.msg = ""Možeš odabrati samo jednu nad-kategoriju"";
                    this.error = true;
                    return;
                } else {
                    this.msg = """";
                    this.error = false;
                }

                if (chkCompScore.length > 0) {
                    this.msg = ""Ovo je natjecanje već uneseno"";
                    this.error = true;
                    return;
                }
                else {
                    this.msg = """";
                    this.error = false;
                }

                axios({
                    method: 'post',
                    url: _siteUrl + 'api/scores/',
                    data: saveModel
                }).then(response => {
                    this.msg = ""Spremljeno"";
                    this.error = false;
                    this.load();
                })
                    ");
            WriteLiteral(".catch(e => {\r\n                        console.log(e)\r\n                    })\r\n            }\r\n        }\r\n    })\r\n</script>");
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
