#pragma checksum "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1e5b4ee0b83b14c2dd837edf13f758fc25cf8e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Personal Projects\CameraDesription\Views\_ViewImports.cshtml"
using CameraDesription;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Personal Projects\CameraDesription\Views\_ViewImports.cshtml"
using CameraDesription.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1e5b4ee0b83b14c2dd837edf13f758fc25cf8e9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"900663fcd721e282e3551f546fd5c8c0a7f120ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CameraDesription.Models.CameraDetail>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1e5b4ee0b83b14c2dd837edf13f758fc25cf8e93237", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""initial-scale=1.0, user-scalable=no"">
    <meta charset=""utf-8"">
    <title>Infi | Security cameras Utrecht</title>
    <!-- Video camera Icon by Martz90 available at http://www.iconarchive.com/show/circle-icons-by-martz90/video-camera-icon.html under a Creative Commons Attribution-Noncommercial-No Derivate 4.0. Full terms at http://creativecommons.org/licenses/by-nc-nd/4.0 -->
    <link rel=""icon"" type=""image/x-icon"" href=""video-camera-icon.png"">
    <link href=""https://fonts.googleapis.com/css?family=Roboto"" rel=""stylesheet"">
    <style type=""text/css"">
        html, body {
            margin: 0;
            padding: 0;
            font-family: 'Roboto', sans-serif;
            font-size: 0.8em;
        }

        a {
            color: #ff6e00;
        }

        #source {
            background: rgba(27, 31, 35, 0.08);
            width: 290px;
            padding: 8px;
            border-radius: 20px;
            margin: 15px auto;
            ");
                WriteLiteral(@"text-align: center;
        }

            #source a {
                font-weight: bold;
            }

        table td {
            vertical-align: top;
        }

        table thead tr:nth-child(1) th {
            height: 75px;
            background-color: #272727;
            color: #7F7F7C;
            font-size: 3.0em;
        }

        table tr:nth-child(2) th {
            text-align: left;
            height: 25px;
        }

        h1 {
            padding: 20px 0 20px 55px;
            margin: 0 0 0 20px;
            background: url(""video-camera-icon.png"") no-repeat;
            background-size: 40px;
            background-position: 0 50%;
        }

        #cameraTableContainer {
            margin: 0 0 20px 0;
            width: 100%;
            padding: 0 20px;
            height: 100%;
            vertical-align: top;
        }

            #cameraTableContainer > td {
                width: 25%;
                text-align: center;
          ");
                WriteLiteral(@"  }

            #cameraTableContainer table {
                width: 450px;
                margin: auto;
                height: 100%;
                border-collapse: collapse;
            }

                #cameraTableContainer table tbody tr {
                    height: 25px;
                    vertical-align: middle;
                }

                #cameraTableContainer table tbody td {
                    padding: 5px 0;
                }

                #cameraTableContainer table td:nth-child(1) {
                    height: 15px !important;
                    margin-right: 15px;
                    font-weight: bold;
                    border-radius: 20px;
                }

                #cameraTableContainer table tr:last-child td {
                    height: 100%;
                }

        #map {
            margin: auto;
            height: 500px;
            width: 100%;
        }
    </style>
    <script type=""text/javascript"" src=""https://code.j");
                WriteLiteral("query.com/jquery-3.2.1.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1e5b4ee0b83b14c2dd837edf13f758fc25cf8e97451", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 111 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
      
        int counter = 0;


    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <h1>Security cameras Utrecht</h1>
    <div id=""map""></div>
    <div id=""source"">
        source:
        <a href=""https://data.overheid.nl/dataset/camera-s"">https://data.overheid.nl/dataset/camera-s</a>
    </div>
    <main>
        <table id=""cameraTableContainer"">
            <tbody>
                <tr>
                    <td>
                        <table id=""column3"">
                            <thead>
                                <tr>
                                    <th colspan=""4"">Cameras 3</th>
                                </tr>
");
#nullable restore
#line 132 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                 foreach (var item in Model)
                                {
                                    if (item.Index % 3 ==0 && item.Index % 5 !=0)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <th>");
#nullable restore
#line 138 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Index);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 139 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 140 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 141 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        </tr>\r\n");
#nullable restore
#line 143 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </td>
                    <td>
                        <table id=""column5"">
                            <thead>
                                <tr>
                                    <th colspan=""4"">Cameras 5</th>
                                </tr>
");
#nullable restore
#line 156 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                 foreach (var item in Model)
                                {
                                    if (item.Index % 5 == 0 && item.Index % 3 != 0)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <th>");
#nullable restore
#line 162 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Index);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 163 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 164 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 165 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        </tr>\r\n");
#nullable restore
#line 167 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </td>
                    <td>
                        <table id=""column15"">
                            <thead>
                                <tr>
                                    <th colspan=""4"">Cameras 3 &amp; 5</th>
                                </tr>
");
#nullable restore
#line 180 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                 foreach (var item in Model)
                                {
                                    if (item.Index % 3 == 0 && item.Index % 5 == 0)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <th>");
#nullable restore
#line 186 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Index);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 187 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 188 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 189 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        </tr>\r\n");
#nullable restore
#line 191 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </td>
                    <td>
                        <table id=""columnOther"">
                            <thead>
                                <tr>
                                    <th colspan=""4"">Cameras Overig</th>
                                </tr>
");
#nullable restore
#line 204 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                 foreach (var item in Model)
                                {
                                    if (item.Index % 3 != 0 && item.Index % 5 != 0)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <th>");
#nullable restore
#line 210 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Index);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 211 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 212 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 213 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                           Write(item.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        </tr>\r\n");
#nullable restore
#line 215 "D:\Personal Projects\CameraDesription\Views\Home\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </thead>\r\n                            <tbody>\r\n                            </tbody>\r\n                        </table>\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </main>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CameraDesription.Models.CameraDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
