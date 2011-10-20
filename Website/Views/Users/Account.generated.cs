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

namespace NuGetGallery.Views.Users
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
    using NuGetGallery;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Users/Account.cshtml")]
    public class Account : System.Web.Mvc.WebViewPage<User>
    {
        public Account()
        {
        }
        public override void Execute()
        {


            
            #line 2 "..\..\Views\Users\Account.cshtml"
  
    ViewBag.Tab = "Contribute";


            
            #line default
            #line hidden
WriteLiteral("\r\n<h1 class=\"page-heading\">My Account</h1>\r\n");


            
            #line 7 "..\..\Views\Users\Account.cshtml"
 if (TempData.ContainsKey("Message")) {

            
            #line default
            #line hidden
WriteLiteral("    <p class=\"message\">\r\n        ");


            
            #line 9 "..\..\Views\Users\Account.cshtml"
   Write(TempData["Message"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n");


            
            #line 11 "..\..\Views\Users\Account.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<section id=\"actions\">\r\n    <h1>Actions</h1>\r\n    <ul>\r\n        <li id=\"uploa" +
"dPackage\">\r\n            <h2><a href=\"");


            
            #line 18 "..\..\Views\Users\Account.cshtml"
                    Write(Url.UploadPackage());

            
            #line default
            #line hidden
WriteLiteral(@""">Upload Package</a></h2>
            <p>
                Upload and publish your package for other NuGet users to download and enjoy. 
                You can upload multiple revisions of the same package, as long as the version 
                is different.
            </p>
        </li>
        <li id=""managePackages"">
            <h2><a href=""");


            
            #line 26 "..\..\Views\Users\Account.cshtml"
                    Write(Url.Action(MVC.Users.Packages()));

            
            #line default
            #line hidden
WriteLiteral("\">Manage My Packages</a></h2>\r\n            <p>Edit package details or Remove pack" +
"ages that you have previously uploaded.</p>\r\n        </li>\r\n        <li id=\"edit" +
"Profile\">\r\n            <h2><a href=\"");


            
            #line 30 "..\..\Views\Users\Account.cshtml"
                    Write(Url.Action(MVC.Users.Edit()));

            
            #line default
            #line hidden
WriteLiteral("\">Edit Profile</a></h2>\r\n            <p>Edit your public profile.</p>\r\n        </" +
"li>\r\n        <li id=\"changePassword\">\r\n            <h2><a href=\"");


            
            #line 34 "..\..\Views\Users\Account.cshtml"
                    Write(Url.Action(MVC.Users.ChangePassword()));

            
            #line default
            #line hidden
WriteLiteral(@""">Change Password</a></h2>
            <p>Change your password.</p>
        </li>
    </ul>
</section>



<section id=""apiKey"">
<h1>API Key</h1>
    <p>
        Your API key provides you with a token that identifies you to the gallery. 
        Keep this a secret. You can always regenerate your key at any time (invaldating 
        previous keys) if your token is accidentally revealed. The 
        <a href=""http://nuget.codeplex.com/"">NuGet</a> command-line utility allows you to 
        submit a nuget package to the gallery, and you would pass you token like this:
    </p>
    
    <div id=""generateKey"">
        <h2><a id=""tooglePivateData"" href=""#"" title=""Show/Hide your API Key"">Your API key is: </a></h2>
        
        <div id=""privateData"">
            <p>");


            
            #line 56 "..\..\Views\Users\Account.cshtml"
          Write(Model.ApiKey);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\r\n            <fieldset class=\"form\">\r\n                <legend>Generate New" +
" API Key</legend>\r\n");


            
            #line 60 "..\..\Views\Users\Account.cshtml"
                 using(Html.BeginForm("GenerateApiKey", "Users", FormMethod.Post)){
                    
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Users\Account.cshtml"
               Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Users\Account.cshtml"
                                            

            
            #line default
            #line hidden
WriteLiteral("                    <input type=\"submit\" value=\"Generate New API Key\" />\r\n");


            
            #line 63 "..\..\Views\Users\Account.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </fieldset>\r\n\r\n            <h2>Example useage:</h2>\r\n            <p><" +
"code>nuget.exe push MyPackage.1.0.nupkg ");


            
            #line 67 "..\..\Views\Users\Account.cshtml"
                                                   Write(Model.ApiKey);

            
            #line default
            #line hidden
WriteLiteral("</code></p>\r\n        \r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");


DefineSection("BottomScripts", () => {

WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            $(\"#tooglePivateData\").click" +
"(function () {\r\n                $(\"#privateData\").slideToggle();\r\n              " +
"  return false;\r\n            });\r\n        });\r\n    </script>\r\n");


});


        }
    }
}
#pragma warning restore 1591
