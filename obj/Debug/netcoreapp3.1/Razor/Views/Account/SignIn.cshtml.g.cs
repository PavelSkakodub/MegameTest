#pragma checksum "C:\Users\win10\source\repos\Megame_Admin\Views\Account\SignIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b541d7d6740c7cc95d85e4c97834407e81d35deb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SignIn), @"mvc.1.0.view", @"/Views/Account/SignIn.cshtml")]
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
#line 1 "C:\Users\win10\source\repos\Megame_Admin\Views\_ViewImports.cshtml"
using Megame_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\win10\source\repos\Megame_Admin\Views\_ViewImports.cshtml"
using Megame_Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b541d7d6740c7cc95d85e4c97834407e81d35deb", @"/Views/Account/SignIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244837140bf09da560ec468495b1a8a1d266a5e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_SignIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Megame_Admin.Models.LoginModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/ForgotPassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forgot-pass-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn social-github"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/SignUp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b541d7d6740c7cc95d85e4c97834407e81d35deb7121", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1, shrink-to-fit=no"">
    <title>Login Boxed | CORK - Multipurpose Bootstrap Dashboard Template </title>
    
    <link rel=""icon"" type=""image/x-icon""");
                BeginWriteAttribute("href", " href=", 410, "", 456, 1);
#nullable restore
#line 11 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\SignIn.cshtml"
WriteAttributeValue("", 416, Url.Content("~/assets/img/favicon.ico"), 416, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <link href=\"../../../../https@fonts.googleapis.com/css@family=Nunito_3A400,600,700\" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=", 576, "", 631, 1);
#nullable restore
#line 13 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\SignIn.cshtml"
WriteAttributeValue("", 582, Url.Content("~/bootstrap/css/bootstrap.min.css"), 582, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                BeginWriteAttribute("href", " href=", 678, "", 724, 1);
#nullable restore
#line 14 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\SignIn.cshtml"
WriteAttributeValue("", 684, Url.Content("~/assets/css/plugins.css"), 684, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                BeginWriteAttribute("href", " href=", 771, "", 831, 1);
#nullable restore
#line 15 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\SignIn.cshtml"
WriteAttributeValue("", 777, Url.Content("~/assets/css/authentication/form-2.css"), 777, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=", 911, "", 976, 1);
#nullable restore
#line 16 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\SignIn.cshtml"
WriteAttributeValue("", 917, Url.Content("~/assets/css/forms/theme-checkbox-radio.css"), 917, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=", 1021, "", 1074, 1);
#nullable restore
#line 17 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\SignIn.cshtml"
WriteAttributeValue("", 1027, Url.Content("~/assets/css/forms/switches.css"), 1027, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b541d7d6740c7cc95d85e4c97834407e81d35deb11163", async() => {
                WriteLiteral("\r\n    \r\n\r\n    <div class=\"form-container outer\">\r\n        <div class=\"form-form\">\r\n            <div class=\"form-form-wrap\">\r\n                <div class=\"form-container\">\r\n                    <div class=\"form-content\">\r\n\r\n                        <h1");
                BeginWriteAttribute("class", " class=\"", 1353, "\"", 1361, 0);
                EndWriteAttribute();
                WriteLiteral(">Sign In</h1>\r\n                        <p");
                BeginWriteAttribute("class", " class=\"", 1403, "\"", 1411, 0);
                EndWriteAttribute();
                WriteLiteral(">Log in to your account to continue.</p>\r\n                        \r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b541d7d6740c7cc95d85e4c97834407e81d35deb12141", async() => {
                    WriteLiteral("\r\n                           ");
#nullable restore
#line 32 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\SignIn.cshtml"
                      Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            <div class=""form"">
                                <div id=""username-field"" class=""field-wrapper input"">
                                    <label for=""username"">EMAIL</label>
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-user""><path d=""M20 21v-2a4 4 0 0 0-4-4H8a4 4 0 0 0-4 4v2""></path><circle cx=""12"" cy=""7"" r=""4""></circle></svg>
                                    <input id=""username"" name=""model.Email"" type=""email"" class=""form-control"" placeholder=""Your email"" required>
                                </div>

                                <div id=""password-field"" class=""field-wrapper input mb-2"">
                                    <div class=""d-flex justify-content-between"">
                                        <label for=""password"">PASSWORD</label>
                     ");
                    WriteLiteral("                   ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b541d7d6740c7cc95d85e4c97834407e81d35deb13817", async() => {
                        WriteLiteral("Forgot Password?");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                    </div>
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-lock""><rect x=""3"" y=""11"" width=""18"" height=""11"" rx=""2"" ry=""2""></rect><path d=""M7 11V7a5 5 0 0 1 10 0v4""></path></svg>
                                    <input id=""password"" name=""model.Password"" type=""password"" class=""form-control"" placeholder=""Password"" required>
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" id=""toggle-password"" class=""feather feather-eye""><path d=""M1 12s4-8 11-8 11 8 11 8-4 8-11 8-11-8-11-8z""></path><circle cx=""12"" cy=""12"" r=""3""></circle></svg>
                                </div>

                                   <div class=""field");
                    WriteLiteral(@"-wrapper terms_condition"">
                                    <div class=""n-chk"">
                                        <label class=""new-control new-checkbox checkbox-primary"">
                                          <input type=""checkbox"" name=""model.RememberMe"" class=""new-control-input"">
                                          <span class=""new-control-indicator""></span><span>Keep me logged in</span>
                                        </label>
                                    </div>
                                   </div>

     
                                <div class=""d-sm-flex justify-content-between"">
                                    <div class=""field-wrapper"">
                                        <button type=""submit"" class=""btn btn-primary""");
                    BeginWriteAttribute("value", " value=\"", 4583, "\"", 4591, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">Log In</button>
                                    </div>
                                </div>

                                <div class=""division"">
                                      <span>OR</span>
                                   <div class=""social"">                                    
                                   ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b541d7d6740c7cc95d85e4c97834407e81d35deb17580", async() => {
                        WriteLiteral(@"
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-github""><path d=""M9 19c-5 1.5-5-2.5-7-3m14 6v-3.87a3.37 3.37 0 0 0-.94-2.61c3.14-.35 6.44-1.54 6.44-7A5.44 5.44 0 0 0 20 4.77 5.07 5.07 0 0 0 19.91 1S18.73.65 16 2.48a13.38 13.38 0 0 0-7 0C6.27.65 5.09 1 5.09 1A5.07 5.07 0 0 0 5 4.77a5.44 5.44 0 0 0-1.5 3.78c0 5.42 3.3 6.61 6.44 7A3.37 3.37 0 0 0 9 18.13V22""></path></svg>
                                        <span class=""brand-name"">Login as a guest</span>
                                    ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                </div>\r\n                                </div>\r\n\r\n                          \r\n\r\n                                <p class=\"signup-link\">Not registered ? ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b541d7d6740c7cc95d85e4c97834407e81d35deb19779", async() => {
                        WriteLiteral("Create an account");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("</p>\r\n\r\n                            </div>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    </div>                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=", 6131, "", 6188, 1);
#nullable restore
#line 89 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\SignIn.cshtml"
WriteAttributeValue("", 6136, Url.Content("~/assets/js/libs/jquery-3.1.1.min.js"), 6136, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=", 6211, "", 6260, 1);
#nullable restore
#line 90 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\SignIn.cshtml"
WriteAttributeValue("", 6216, Url.Content("~/bootstrap/js/popper.min.js"), 6216, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=", 6283, "", 6335, 1);
#nullable restore
#line 91 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\SignIn.cshtml"
WriteAttributeValue("", 6288, Url.Content("~/bootstrap/js/bootstrap.min.js"), 6288, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=", 6358, "", 6415, 1);
#nullable restore
#line 92 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\SignIn.cshtml"
WriteAttributeValue("", 6363, Url.Content("~/assets/js/authentication/form-2.js"), 6363, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AppUserManager UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Megame_Admin.Models.LoginModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
