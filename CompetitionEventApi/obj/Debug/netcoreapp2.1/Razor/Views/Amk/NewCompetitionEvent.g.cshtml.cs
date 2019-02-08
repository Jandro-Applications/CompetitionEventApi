#pragma checksum "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\NewCompetitionEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33bd070294c47b0e9eb6b9e784bb7040ed8a475a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amk_NewCompetitionEvent), @"mvc.1.0.view", @"/Views/Amk/NewCompetitionEvent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Amk/NewCompetitionEvent.cshtml", typeof(AspNetCore.Views_Amk_NewCompetitionEvent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33bd070294c47b0e9eb6b9e784bb7040ed8a475a", @"/Views/Amk/NewCompetitionEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8191ba417a071fffad630f155b6e97b9dcf5b61", @"/Views/_ViewImports.cshtml")]
    public class Views_Amk_NewCompetitionEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\NewCompetitionEvent.cshtml"
  
    ViewData["Title"] = "NewCompetitionEvent";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(104, 214, true);
            WriteLiteral("\r\n<div id=\"app\">\r\n    <div class=\"events\">\r\n        <div class=\"row\">\r\n            <h1>{{title}}</h1>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6 col-md-offset-3\">\r\n                ");
            EndContext();
            BeginContext(318, 2416, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51700f16c1234bed96f5aec900ad4598", async() => {
                BeginContext(324, 1605, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""eventName"">Naziv događaja</label>
                        <input type=""text"" class=""form-control"" id=""eventName"" v-model=""competitionEvent.Title"" placeholder=""Unesite naziv događaja"">
                    </div>
                    <div class=""form-group"">
                        <label for=""description"">Opis događaja</label>
                        <textarea class=""form-control"" id=""description"" rows=""3"" v-model=""competitionEvent.Description"" aria-describedby=""eventDescription""></textarea>
                        <small id=""eventDescription"" class=""form-text text-muted"">Opisati o čemu je ovaj događaj</small>
                    </div>
                    <div class=""form-group"">
                        <label for=""eventStartDate"">Početak događaja</label>
                        <input type=""date"" class=""form-control"" id=""eventStartDate"" v-model=""competitionEvent.StartDate"" placeholder=""Unesite datum početka događaja""");
                WriteLiteral(@">
                    </div>
                    <div class=""form-group"">
                        <label for=""eventEndDate"">Kraj događaja</label>
                        <input type=""date"" class=""form-control"" id=""eventEndDate"" v-model=""competitionEvent.EndDate"" placeholder=""Unesite datum kraja događaja"">
                    </div>
                    <div class=""form-group"">
                        <label for=""event-ddl"">Status</label>
                        <select class=""form-control"" v-model=""competitionEvent.Status"" id=""event-ddl"">
                            ");
                EndContext();
                BeginContext(1929, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cb1f4318c2949f0be817c1ea94d50e8", async() => {
                    BeginContext(1947, 7, true);
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
                BeginContext(1963, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1993, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "631a2108558146ccb93fab8883d44744", async() => {
                    BeginContext(2011, 9, true);
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
                BeginContext(2029, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2059, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7a07e5c28cc42c7919bbbdd97aa40a3", async() => {
                    BeginContext(2077, 7, true);
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
                BeginContext(2093, 634, true);
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
            BeginContext(2734, 918, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<script>

var app = new Vue({
    name: 'NewCompetitionEvent',
    el:'#app',  
    data () {
    return {
      title: 'Novi događaj',
      competitions: [],
      relatedCompetitionIds: [],
      competitionEvent: {}
    }
  },
  created () {
    axios.get('https://localhost:44345/api/competitions')
      .then(response => {
        this.competitions = response.data
      })
      .catch(e => {
          console.log(e)
      })
  },
  methods: {
    saveEvent: function () {
      this.competitionEvent.RelatedCompetitionIds = this.relatedCompetitionIds

      axios({
        method: 'post',
        url: 'https://localhost:44345/api/competitionEvents/',
        data: this.competitionEvent
      })
        .then(response => {})
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