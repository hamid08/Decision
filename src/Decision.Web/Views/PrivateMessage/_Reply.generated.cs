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
    
    #line 2 "..\..\Views\PrivateMessage\_Reply.cshtml"
    using Decision.Common.Helpers;
    
    #line default
    #line hidden
    using Decision.Common.HtmlHelpers;
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PrivateMessage/_Reply.cshtml")]
    public partial class _Views_PrivateMessage__Reply_cshtml : System.Web.Mvc.WebViewPage<Decision.ViewModel.PrivateMessage.AddMessageViewModel>
    {
        public _Views_PrivateMessage__Reply_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"panel panel-defautl\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" aria-controls=\"reply\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(" class=\"btn btn-default btn-sm btn-block\"");

WriteLiteral(" data-target=\"#reply\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"fa fa-plus\"");

WriteLiteral("></i>ارسال پاسخ\r\n        </button>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"panel-body collapse\"");

WriteLiteral(" id=\"reply\"");

WriteLiteral(">\r\n");

            
            #line 11 "..\..\Views\PrivateMessage\_Reply.cshtml"
        
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\PrivateMessage\_Reply.cshtml"
         using (Html.BeginForm(MVC.PrivateMessage.Reply(), FormMethod.Post, new {role = "form", @class = "form-horizontal", autocomplete = "off", id = "replyForm", enctype = "multipart/form-data"}))
        {
            
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\PrivateMessage\_Reply.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\PrivateMessage\_Reply.cshtml"
                                    
            
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\PrivateMessage\_Reply.cshtml"
       Write(Html.HiddenFor(a => a.ConversationId));

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\PrivateMessage\_Reply.cshtml"
                                                  
            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\PrivateMessage\_Reply.cshtml"
       Write(Html.HiddenFor(a => a.ParentId));

            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\PrivateMessage\_Reply.cshtml"
                                            

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"Content\"");

WriteLiteral(" class=\"control-label col-md-1\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"fa fa-align-justify\"");

WriteLiteral("></i>\r\n                            متن پیغام\r\n                        </label>\r\n " +
"                       <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("                            ");

            
            #line 25 "..\..\Views\PrivateMessage\_Reply.cshtml"
                       Write(Html.TextAreaFor(a => a.Body, new {@class = "ckeditor form-control", rows = 10}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 26 "..\..\Views\PrivateMessage\_Reply.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Body, "", new {@class = "text-danger"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
"\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-6 col-md-offset-1\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" onclick=\"AjaxForm.CustomSubmitWithEditor(this, \'replyForm\')\"");

WriteLiteral("\r\n                                    data-loading-text=\"در حال ارسال اطلاعات\"");

WriteLiteral(" class=\"btn btn-success\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"fa fa-paper-plane-o\"");

WriteLiteral("></i>\r\n                                ارسال پاسخ\r\n                            </" +
"button>\r\n                        </div>\r\n                        </div>\r\n       " +
"         </div>\r\n            </div>\r\n");

            
            #line 41 "..\..\Views\PrivateMessage\_Reply.cshtml"


        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
