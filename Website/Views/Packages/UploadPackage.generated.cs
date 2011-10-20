﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery.Views.Packages
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Microsoft.Web.Helpers;
    
    #line 1 "..\..\Views\Packages\UploadPackage.cshtml"
    using NuGetGallery;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Packages/UploadPackage.cshtml")]
    public class UploadPackage : System.Web.Mvc.WebViewPage<SubmitPackageRequest>
    {
        public UploadPackage()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\Packages\UploadPackage.cshtml"
  
    ViewBag.Tab = "Upload";
    Layout = "~/Views/Shared/TwoColumnLayout.cshtml";


            
            #line default
            #line hidden
WriteLiteral("\r\n");


DefineSection("SideColumn", () => {

WriteLiteral("\r\n    <img src=\"");


            
            #line 9 "..\..\Views\Packages\UploadPackage.cshtml"
         Write(Links.Content.Images.contribGraphic_png);

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Contribute\" />\r\n    <p>Submit your package for others to enjoy.</p>\r\n");


});

WriteLiteral("    \r\n\r\n\r\n<h1>Upload a Package</h1>\r\n\r\n");


            
            #line 16 "..\..\Views\Packages\UploadPackage.cshtml"
Write(ViewHelpers.UploadSequence(1));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n\r\n\r\n");


            
            #line 21 "..\..\Views\Packages\UploadPackage.cshtml"
 using(Html.BeginForm("UploadPackage", "Packages", FormMethod.Post, new { enctype="multipart/form-data"})){

            
            #line default
            #line hidden
WriteLiteral("    <fieldset class=\"form\">\r\n        <legend>Upload a Package</legend>\r\n        ");


            
            #line 24 "..\..\Views\Packages\UploadPackage.cshtml"
   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n        ");


            
            #line 25 "..\..\Views\Packages\UploadPackage.cshtml"
   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
WriteLiteral(@"
        <p>Your package file will be uploaded and hosted on the NuGet Gallary server (NuGet.org).</p>
        <div class=""form-field"">
            <label for=""PackageFile"">Choose a package...</label>
            <input type=""file"" name=""PackageFile"" />
        </div>

        <input type=""submit"" value=""Upload"" title=""Upload the package."" />
    </fieldset>
");


            
            #line 34 "..\..\Views\Packages\UploadPackage.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
