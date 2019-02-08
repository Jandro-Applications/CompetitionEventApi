#pragma checksum "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\CompetitionEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9d10abc84cd7bd9fd2ce4081e94b5cde66238ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amk_CompetitionEvent), @"mvc.1.0.view", @"/Views/Amk/CompetitionEvent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Amk/CompetitionEvent.cshtml", typeof(AspNetCore.Views_Amk_CompetitionEvent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d10abc84cd7bd9fd2ce4081e94b5cde66238ec", @"/Views/Amk/CompetitionEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8191ba417a071fffad630f155b6e97b9dcf5b61", @"/Views/_ViewImports.cshtml")]
    public class Views_Amk_CompetitionEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 165, true);
            WriteLiteral("<div id=\"app\">\r\n    <div class=\"events\">\r\n        <h1>{{title}}</h1>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6 col-md-offset-3\">\r\n                ");
            EndContext();
            BeginContext(165, 2297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9208fcaf7c4879bfdb126b49905fcb", async() => {
                BeginContext(171, 1485, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""eventName"">Naziv događaja</label>
                        <input type=""text"" class=""form-control"" v-model=""competitionEvent.title"" id=""eventName"" placeholder=""Unesite naziv događaja"">
                    </div>
                    <div class=""form-group"">
                        <label for=""description"">Opis događaja</label>
                        <textarea class=""form-control"" v-model=""competitionEvent.description"" id=""description"" rows=""3"" aria-describedby=""eventDescription""></textarea>
                    </div>
                    <div class=""form-group"">
                        <label for=""eventStartDate"">Početak događaja</label>
                        <input type=""text"" v-model=""competitionEvent.startDate"" class=""form-control"" id=""eventStartDate"" placeholder=""Unesite datum početka događaja"">
                    </div>
                    <div class=""form-group"">
                        <label for=""eventEndD");
                WriteLiteral(@"ate"">Kraj događaja</label>
                        <input type=""text"" v-model=""competitionEvent.endDate"" class=""form-control"" id=""eventEndDate"" placeholder=""Unesite datum kraja događaja"">
                    </div>
                    <div class=""form-group"">
                        <label for=""status-ddl"">Status</label>
                        <select class=""form-control"" id=""status-ddl"" v-model=""competitionEvent.status"">
                            ");
                EndContext();
                BeginContext(1656, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a2489d401e7471ea47244750ece904b", async() => {
                    BeginContext(1674, 7, true);
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
                BeginContext(1690, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1720, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3015c27fc9d34e6893268d303a8834be", async() => {
                    BeginContext(1738, 9, true);
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
                BeginContext(1756, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1786, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "475c40e6db7b44c8809a03c5e2b53f3b", async() => {
                    BeginContext(1804, 7, true);
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
                BeginContext(1820, 635, true);
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""event-ddl"">Odaberite natjecanja</label>
                        <br />
                        <span v-bind:key=""index"" v-for=""(c,index) in allCompetitions"">
                            <input type=""checkbox"" v-bind:value=""c.id"" v-model=""checkedCompetitions"">{{c.title}}
                            <br />
                        </span>
                    </div>
                    <button class=""btn btn-success"" v-on:click.prevent=""saveEvent"">Spremi</button>
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
            BeginContext(2462, 1694, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""row push-top-20"">
            <div class=""col-md-6 col-md-offset-3"">
                <!-- <Posts/> -->
            </div>
        </div>
    </div>
</div>

<script>

    var app = new Vue({
        el: '#app',
        name: 'CompetitionEventDetails',
        data() {
            return {
                title: 'Detalji događaja',
                allCompetitions: [],
                checkedCompetitions: [],
                competitionEvent: {}
            }
        },
        created() {
            axios.get('https://localhost:44345/api/competitions')
                .then(response => {
                    this.allCompetitions = response.data
                })
                .catch(e => {
                    console.log(e)
                })

            axios.get('https://localhost:44345/api/competitionEvents/' + getUrlVars()[""id""])
                .then(response => {
                    this.competitionEvent = respon");
            WriteLiteral(@"se.data
                })
                .catch(e => {
                    console.log(e)
                })
        },
        methods: {
            saveEvent: function () {

                this.competitionEvent.relatedCompetitionIds = this.checkedCompetitions;
                axios({
                    method: 'post',
                    url: 'https://localhost:44345/api/competitionEvents/',
                    data: this.competitionEvent
                })
                    .then(response => { })
                    .catch(e => {
                        console.log(e)
                    })
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