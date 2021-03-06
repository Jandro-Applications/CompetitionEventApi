#pragma checksum "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\Contestants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07bdce671284e8ece2073a714146b9e555973890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amk_Contestants), @"mvc.1.0.view", @"/Views/Amk/Contestants.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Amk/Contestants.cshtml", typeof(AspNetCore.Views_Amk_Contestants))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07bdce671284e8ece2073a714146b9e555973890", @"/Views/Amk/Contestants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8191ba417a071fffad630f155b6e97b9dcf5b61", @"/Views/_ViewImports.cshtml")]
    public class Views_Amk_Contestants : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Projects\CompetitionEventApi\CompetitionEventApi\Views\Amk\Contestants.cshtml"
  
    ViewData["Title"] = "Contestants";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(96, 1785, true);
            WriteLiteral(@"
<div id=""app"">
    <div class=""contestants"">
        <h1>{{title}}</h1>
        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <td>Id</td>
                    <td>Ime</td>
                    <td>Prezime</td>
                    <td>Registracija auta</td>
                    <td>Klub</td>
                    <td>Plaćeno natjecanje?</td>
                    <td>Status</td>
                    <td></td>
                </tr>
            </thead>
            <tbody>
                <tr v-bind:key=""index"" v-for=""(contestant,index) in contestants"">
                    <td>{{contestant.id}}</td>
                    <td>{{contestant.firstName}}</td>
                    <td>{{contestant.lastName}}</td>
                    <td>{{contestant.uniqueId}}</td>
                    <td>{{contestant.club}}</td>
                    <td>{{contestant.paid}}</td>
                    <td>{{contestant.status}}</td>
                    <td>
");
            WriteLiteral(@"                        <a v-bind:href=""'/amk/contestant?id='+ contestant.id"" type=""button"" class=""btn btn-default"">Detalji</a>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>

<script>

var app = new Vue({
    name: 'Contestants',
    el:'#app',
    data () {
    return {
      title: 'Natjecatelji',
      contestants: []
    }
  },
  created () {
    axios.get(_siteUrl + 'api/contestants')
      .then(response => {
        this.contestants = response.data
      })
      .catch(e => {
        this.errors.push(e)
      })
  },
  methods: {
    details: function (id) {
      this.$router.push({name: 'contestant-details', params: {id: id}})
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
