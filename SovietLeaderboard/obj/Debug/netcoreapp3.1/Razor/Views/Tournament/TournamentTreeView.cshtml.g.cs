#pragma checksum "C:\Users\danil\Source\Repos\SovietLeaderboard\SovietLeaderboard\Views\Tournament\TournamentTreeView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b599ae13bc40077bc8987308cfe43d8b78c7864"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournament_TournamentTreeView), @"mvc.1.0.view", @"/Views/Tournament/TournamentTreeView.cshtml")]
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
#nullable restore
#line 1 "C:\Users\danil\Source\Repos\SovietLeaderboard\SovietLeaderboard\Views\_ViewImports.cshtml"
using SovietLeaderboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danil\Source\Repos\SovietLeaderboard\SovietLeaderboard\Views\_ViewImports.cshtml"
using SovietLeaderboard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b599ae13bc40077bc8987308cfe43d8b78c7864", @"/Views/Tournament/TournamentTreeView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac39b4ea0ffcf975679b624ac26ddb5b1e3a8c43", @"/Views/_ViewImports.cshtml")]
    public class Views_Tournament_TournamentTreeView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <style type=\text/css\>
        .thd {
            background: rgb(220,220,220);
            font: bold 10pt Arial;
            text-align: center;
        }

        .team {
            color: white;
            background: rgb(100,100,100);
            font: bold 10pt Arial;
            border-right: solid 2px black;
        }

        .winner {
            color: white;
            background: rgb(60,60,60);
            font: bold 10pt Arial;
        }

        .vs {
            font: bold 7pt Arial;
            border-right: solid 2px black;
        }

        td, th {
            padding: 3px 15px;
            border-right: dotted 2px rgb(200,200,200);
            text-align: right;
        }

        h1 {
            font: bold 14pt Arial;
            margin-top: 24pt;
        }
    </style>
");
#nullable restore
#line 41 "C:\Users\danil\Source\Repos\SovietLeaderboard\SovietLeaderboard\Views\Tournament\TournamentTreeView.cshtml"
;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Tournament Results</h1>\r\n    <table border=0\r\n        cellspacing=0>\r\n\r\n\r\n      \r\n    </table>\r\n");
            WriteLiteral("    <h1>Third Place Results</h1>\r\n");
#nullable restore
#line 52 "C:\Users\danil\Source\Repos\SovietLeaderboard\SovietLeaderboard\Views\Tournament\TournamentTreeView.cshtml"
;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table border=0 cellspacing=0>
        <tr>
            <th class=\thd\>Round 1</th>
            <th class=\thd\>Third Place</th>
        </tr>
        <tr>
            <td class=\white_span\>&nbsp;</td>
            <td class=\white_span\ rowspan=2>&nbsp;</td>
        </tr>
        <tr>
            <td class=\team\>Team  + tournament.ThirdPlaceMatch.teamid1 + </td>
        </tr>
        <tr>
            <td class=\vs\>VS</td>
            <td class=\winner\>Team  + tournament.ThirdPlaceMatch.winner + </td>
        </tr>
        <tr>
            <td class=\team\>Team  + tournament.ThirdPlaceMatch.teamid2 + ""</td>
            <td class=\white_span\>&nbsp;</td>
        </tr>
    </table>
");
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
