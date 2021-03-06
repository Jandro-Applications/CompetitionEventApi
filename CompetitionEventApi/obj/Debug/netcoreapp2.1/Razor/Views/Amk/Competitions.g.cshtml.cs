#pragma checksum "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\Competitions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c19203582695657df61a4a9c5ecad90e18d75ce8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amk_Competitions), @"mvc.1.0.view", @"/Views/Amk/Competitions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Amk/Competitions.cshtml", typeof(AspNetCore.Views_Amk_Competitions))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c19203582695657df61a4a9c5ecad90e18d75ce8", @"/Views/Amk/Competitions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8191ba417a071fffad630f155b6e97b9dcf5b61", @"/Views/_ViewImports.cshtml")]
    public class Views_Amk_Competitions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\Competitions.cshtml"
  
    ViewData["Title"] = "Competitions";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(97, 1760, true);
            WriteLiteral(@"
<div id=""app"">
    <div class=""competitions"">
        <h1>{{title}}</h1>
        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <td>Id</td>
                    <td>Naziv</td>
                    <td>Broj rundi</td>
                    <td>Maksimalni broj bodova</td>
                    <td>Povezano natjecanje</td>
                    <td>Status</td>
                    <td></td>
                </tr>
            </thead>
            <tbody>
                <tr v-bind:key=""index"" v-for=""(competition, index) in competitions"">
                    <td>{{competition.id}}</td>
                    <td>{{competition.title}}</td>
                    <td>{{competition.numberOfRounds}}</td>
                    <td>{{competition.maxScore}}</td>
                    <td>{{competition.relatedCompetition}}</td>
                    <td>{{competition.status}}</td>
                    <td>
                        <a v-bind:href=""'/amk/com");
            WriteLiteral(@"petition?id='+ competition.id"" type=""button"" class=""btn btn-default"">Detalji</a>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>

<script>

var app = new Vue({
    name: 'Competitions',
    el: '#app',
    data: function () {
    return {
      title: 'Natjecanja za događaj',
      competitions: []
    }
  },
  created () {
    axios.get(_siteUrl + 'api/competitions')
      .then(response => {
        this.competitions = response.data
      })
      .catch(e => {
          console.log(e)
      })
  },
  methods: {
    details: function (id) {
      this.$router.push({name: 'competition-details', params: {id: id}})
    }
  }
})
</script>
");
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
