﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevTrends.MvcDonutCaching;
    
    #line 12 "..\..\Views\Account\PasswordRecovery.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 14 "..\..\Views\Account\PasswordRecovery.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 13 "..\..\Views\Account\PasswordRecovery.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/PasswordRecovery.cshtml")]
    public partial class _Views_Account_PasswordRecovery_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage <Omnicx.WebStore.Models.Commerce.ForgotPasswordViewModel>
    {
        public _Views_Account_PasswordRecovery_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\PasswordRecovery.cshtml"
  
/*
    Name: Password Recovery
    Purpose: Password Recovery View
    Structure: /Views/Account/ReturnRequest.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/_Layout.cshtml.cshtml   (For base Structure)

    Contained In (Where we Use this View):        
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Account\PasswordRecovery.cshtml"
  
    var forgotPassword = Html.Angular().ModelFor("am.model");
    ViewBag.Title = "PasswordRecovery";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 dataContainer\"");

WriteLiteral(" ng-controller=\"accountCtrl as am\"");

WriteLiteral(">\r\n    <h2>Password Recovery</h2>\r\n    <form");

WriteLiteral(" name=\"recoveryPasswordForm\"");

WriteLiteral("  novalidate");

WriteLiteral(" ng-submit=\"am.recoverPassword(am.model)\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n            <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"am.errorMessage != null\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" ng-repeat=\"err in am.errorMessage track by $index\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i>&nbsp;<span");

WriteLiteral(" ng-bind=\"err\"");

WriteLiteral("></span>\r\n                </div>\r\n            </div>\r\n            <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"am.tokeExpired\"");

WriteLiteral(">\r\n                <div>\r\n                    <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i>&nbsp;<span>");

            
            #line 33 "..\..\Views\Account\PasswordRecovery.cshtml"
                                                       Write(LT("PasswordRecovery.Message.TokenExpired", "Token Expired"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <div ng-cloak");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" ng-show=\"am.passwordChange\"");

WriteLiteral(">\r\n                <div>\r\n                    <i");

WriteLiteral(" class=\"fa fa-check\"");

WriteLiteral("></i>&nbsp;<span>");

            
            #line 38 "..\..\Views\Account\PasswordRecovery.cshtml"
                                                      Write(LT("PasswordRecovery.Message.ResetSuccessfully", "Password reset successfully"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div" +
"");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 44 "..\..\Views\Account\PasswordRecovery.cshtml"
           Write(forgotPassword.FormGroupFor(x => x.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 49 "..\..\Views\Account\PasswordRecovery.cshtml"
           Write(forgotPassword.FormGroupFor(x => x.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n               <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"animate btn-primary\"");

WriteLiteral(">Set Password</button>\r\n            </div>\r\n        </div>\r\n    </form>\r\n</div>\r\n" +
"");

DefineSection("Scripts", () => {

WriteLiteral("\r\n    <script>\r\n        var recoverPassword = \'");

            
            #line 61 "..\..\Views\Account\PasswordRecovery.cshtml"
                           Write(Html.BuildUrlFromExpression<AccountController>(c => c.RecoverPassword(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n         var returnUrl = \'");

            
            #line 62 "..\..\Views\Account\PasswordRecovery.cshtml"
                      Write(Html.BuildUrlFromExpression<AccountController>(c=>c.SignIn(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        window.app.constant(\'accountConfig\', {\r\n            recoverPassword: " +
"recoverPassword,\r\n            returnUrl: returnUrl\r\n        });\r\n        window." +
"app.constant(\'model\', ");

            
            #line 67 "..\..\Views\Account\PasswordRecovery.cshtml"
                                Write(Html.JsonFor(Model));

            
            #line default
            #line hidden
WriteLiteral(");\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
