#pragma checksum "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5b945c44214fd2e97e6f4332667bbe2f6b9fb97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Contacts), @"mvc.1.0.view", @"/Views/Account/Contacts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5b945c44214fd2e97e6f4332667bbe2f6b9fb97", @"/Views/Account/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244837140bf09da560ec468495b1a8a1d266a5e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addContactModalTitle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contacts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
  
    //Подключаем мастер-страницу
    Layout = "~/Views/MasterPage.cshtml";
    var user = await UserManager.GetUserIdentityAsync(User);
    var friends = await UserManager.GetUserFriendsAsync(User);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5b945c44214fd2e97e6f4332667bbe2f6b9fb975556", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1, shrink-to-fit=no"">
    <title>Contact Profile | CORK - Multipurpose Bootstrap Dashboard Template </title>
    <link rel=""stylesheet"" type=""text/css""");
                BeginWriteAttribute("href", " href=", 581, "", 646, 1);
#nullable restore
#line 15 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
WriteAttributeValue("", 587, Url.Content("~/assets/css/forms/theme-checkbox-radio.css"), 587, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link");
                BeginWriteAttribute("href", " href=", 658, "", 717, 1);
#nullable restore
#line 16 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
WriteAttributeValue("", 664, Url.Content("~/plugins/jquery-ui/jquery-ui.min.css"), 664, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\"/>\r\n    <link");
                BeginWriteAttribute("href", " href=", 763, "", 815, 1);
#nullable restore
#line 17 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
WriteAttributeValue("", 769, Url.Content("~/assets/css/apps/contacts.css"), 769, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5b945c44214fd2e97e6f4332667bbe2f6b9fb978167", async() => {
                WriteLiteral(@"

    <div class=""main-container"" id=""container"">

        <div class=""overlay""></div>
        <div class=""search-overlay""></div>

        <!--  BEGIN CONTENT AREA  -->
        <div id=""content"" class=""main-content"">
            <div class=""layout-px-spacing"">                
                <div class=""row layout-spacing layout-top-spacing"" id=""cancel-row"">
                    <div class=""col-lg-12"">
                        <div class=""widget-content searchable-container list"">

                            <div class=""row"">
                                <div class=""col-xl-4 col-lg-5 col-md-5 col-sm-7 filtered-list-search layout-spacing align-self-center"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5b945c44214fd2e97e6f4332667bbe2f6b9fb979167", async() => {
                    WriteLiteral("\r\n                                        <div");
                    BeginWriteAttribute("class", " class=\"", 1672, "\"", 1680, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-search""><circle cx=""11"" cy=""11"" r=""8""></circle><line x1=""21"" y1=""21"" x2=""16.65"" y2=""16.65""></line></svg>
                                            <input type=""text"" class=""form-control product-search"" id=""input-search"" placeholder=""Search Contacts..."">
                                        </div>
                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                                ");
#nullable restore
#line 42 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <div class=""col-xl-8 col-lg-7 col-md-7 col-sm-5 text-sm-right text-center layout-spacing align-self-center"">
                                    <div class=""d-flex justify-content-sm-end justify-content-center"">
                                        <svg id=""btn-add-contact"" xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-user-plus""><path d=""M16 21v-2a4 4 0 0 0-4-4H5a4 4 0 0 0-4 4v2""></path><circle cx=""8.5"" cy=""7"" r=""4""></circle><line x1=""20"" y1=""8"" x2=""20"" y2=""14""></line><line x1=""23"" y1=""11"" x2=""17"" y2=""11""></line></svg>

                                        <div class=""switch align-self-center"">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round");
                WriteLiteral(@""" class=""feather feather-list view-list active-view""><line x1=""8"" y1=""6"" x2=""21"" y2=""6""></line><line x1=""8"" y1=""12"" x2=""21"" y2=""12""></line><line x1=""8"" y1=""18"" x2=""21"" y2=""18""></line><line x1=""3"" y1=""6"" x2=""3"" y2=""6""></line><line x1=""3"" y1=""12"" x2=""3"" y2=""12""></line><line x1=""3"" y1=""18"" x2=""3"" y2=""18""></line></svg>
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-grid view-grid""><rect x=""3"" y=""3"" width=""7"" height=""7""></rect><rect x=""14"" y=""3"" width=""7"" height=""7""></rect><rect x=""14"" y=""14"" width=""7"" height=""7""></rect><rect x=""3"" y=""14"" width=""7"" height=""7""></rect></svg>
                                        </div>
                                    </div>                                    
                                    <!-- Modal -->
                                    <div class=""modal fade"" id=""ad");
                WriteLiteral(@"dContactModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addContactModalTitle"" aria-hidden=""true"">
                                        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-body"">
                                                    <i class=""flaticon-cancel-12 close"" data-dismiss=""modal""></i>
                                                    <div class=""add-contact-box"">
                                                        <div class=""add-contact-content"">
                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5b945c44214fd2e97e6f4332667bbe2f6b9fb9714743", async() => {
                    WriteLiteral(@"
                                                               
                                                                <div class=""row"">
                                                                    <div class=""col-md-6"">
                                                                        <div class=""contact-email"">
                                                                            <i class=""flaticon-mail-26""></i>
                                                                            <input type=""text"" id=""c-email"" name=""email"" class=""form-control"" placeholder=""Email"">
                                                                            <span class=""validation-text""></span>
                                                                        </div>                                                                                                                              
                                                                    </div>  
        ");
                    WriteLiteral(@"                                                            <div class=""col-md-6"">
                                                                        <div class=""contact-email"">
                                                                            <i class=""flaticon-mail-26""></i>
                                                                            <button id=""btn-add"" type=""submit"" class=""form-control btn"">Add</button>
                                                                            <span class=""validation-text""></span>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class=""modal-footer"">
                                                    <button id=""btn-edit"" class=""float-left btn"">Save</button>
                                                    <button class=""btn"" data-dismiss=""modal""> <i class=""flaticon-delete-1""></i> Discard</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class=""searchable-items list"">
                                <div class=""items items-header-section"">
                                    <div class=""item-content"">
                           ");
                WriteLiteral("             <div");
                BeginWriteAttribute("class", " class=\"", 8146, "\"", 8154, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <div class=""n-chk align-self-center text-center"">
                                                <label class=""new-control new-checkbox checkbox-primary"">
                                                  <input type=""checkbox"" class=""new-control-input"" id=""contact-check-all"">
                                                  <span class=""new-control-indicator""></span>
                                                </label>
                                            </div>
                                            <h4>Name</h4>
                                        </div>
                                        <div class=""user-email"">
                                            <h4>Email</h4>
                                        </div>
                                        <div class=""user-location"">
                                            <h4 style=""margin-left: 0;"">Location</h4>
                                        </div>
     ");
                WriteLiteral(@"                                   <div class=""user-phone"">
                                            <h4 style=""margin-left: 3px;"">Phone</h4>
                                        </div>
                                        <div class=""action-btn"">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-trash-2  delete-multiple""><polyline points=""3 6 5 6 21 6""></polyline><path d=""M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2""></path><line x1=""10"" y1=""11"" x2=""10"" y2=""17""></line><line x1=""14"" y1=""11"" x2=""14"" y2=""17""></line></svg>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 118 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                 for(int i=0;i<friends.Count;i++)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <div class=""items"">
                                    <div class=""item-content"">
                                        <div class=""user-profile"">
                                            <div class=""n-chk align-self-center text-center"">
                                                <label class=""new-control new-checkbox checkbox-primary"">
                                                  <input type=""checkbox"" class=""new-control-input contact-chkbox"">
                                                  <span class=""new-control-indicator""></span>
                                                </label>
                                            </div>
                                            <img");
                BeginWriteAttribute("src", " src=", 10945, "", 10976, 1);
#nullable restore
#line 129 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
WriteAttributeValue("", 10950, friends[i].BaseUser.Photo, 10950, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"avatar\">\r\n                                            <div class=\"user-meta-info\">\r\n                                                <p class=\"user-name\" data-name=");
#nullable restore
#line 131 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                                                          Write(friends[i].BaseUser.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral(">");
#nullable restore
#line 131 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                                                                                        Write(friends[i].BaseUser.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                <p class=\"user-work\" data-occupation=");
#nullable restore
#line 132 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                                                                Write(friends[i].BaseUser.Profession);

#line default
#line hidden
#nullable disable
                WriteLiteral(">");
#nullable restore
#line 132 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                                                                                                Write(friends[i].BaseUser.Profession);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                        <div class=""user-email"">
                                            <p class=""info-title"">Email: </p>
                                            <p class=""usr-email-addr"" data-email=");
#nullable restore
#line 137 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                                                            Write(friends[i].Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(">");
#nullable restore
#line 137 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                                                                              Write(friends[i].Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                        </div>
                                        <div class=""user-location"">
                                            <p class=""info-title"">Location: </p>
                                            <p class=""usr-location"" data-location=");
#nullable restore
#line 141 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                                                             Write(friends[i].BaseUser.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 141 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                                                                                          Write(friends[i].BaseUser.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral(">");
#nullable restore
#line 141 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                                                                                                                        Write(friends[i].BaseUser.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 141 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                                                                                                                                                     Write(friends[i].BaseUser.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                        </div>
                                        <div class=""user-phone"">
                                            <p class=""info-title"">Phone: </p>
                                            <p class=""usr-ph-no"" data-phone=");
#nullable restore
#line 145 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                                                       Write(friends[i].PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(">");
#nullable restore
#line 145 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                                                                               Write(friends[i].PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 149 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
                                }                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!--  END CONTENT AREA  -->\r\n    </div>\r\n    \r\n    <script");
                BeginWriteAttribute("src", " src=", 12878, "", 12935, 1);
#nullable restore
#line 159 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
WriteAttributeValue("", 12883, Url.Content("~/assets/js/libs/jquery-3.1.1.min.js"), 12883, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=", 12958, "", 12997, 1);
#nullable restore
#line 160 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
WriteAttributeValue("", 12963, Url.Content("~/assets/js/app.js"), 12963, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>    \r\n    <script>\r\n        $(document).ready(function() {\r\n            App.init();\r\n        });\r\n    </script>\r\n    <script");
                BeginWriteAttribute("src", " src=", 13131, "", 13173, 1);
#nullable restore
#line 166 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
WriteAttributeValue("", 13136, Url.Content("~/assets/js/custom.js"), 13136, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- END GLOBAL MANDATORY SCRIPTS -->\r\n    <script");
                BeginWriteAttribute("src", " src=", 13239, "", 13296, 1);
#nullable restore
#line 168 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
WriteAttributeValue("", 13244, Url.Content("~/plugins/jquery-ui/jquery-ui.min.js"), 13244, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=", 13319, "", 13367, 1);
#nullable restore
#line 169 "C:\Users\win10\source\repos\Megame_Admin\Views\Account\Contacts.cshtml"
WriteAttributeValue("", 13324, Url.Content("~/assets/js/apps/contact.js"), 13324, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591