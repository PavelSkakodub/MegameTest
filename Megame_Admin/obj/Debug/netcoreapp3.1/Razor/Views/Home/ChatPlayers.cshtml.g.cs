#pragma checksum "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "666da024ca42b09a68009b06f07e54497b3e2c56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChatPlayers), @"mvc.1.0.view", @"/Views/Home/ChatPlayers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"666da024ca42b09a68009b06f07e54497b3e2c56", @"/Views/Home/ChatPlayers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244837140bf09da560ec468495b1a8a1d266a5e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ChatPlayers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("chat-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "dialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
  
    //???????????????????? ????????????-????????????????
    Layout = "~/Views/MasterPage.cshtml";
    var user = await UserManager.GetUserIdentityAsync(User);
    var players = await UserManager.GetPlayersAsync();    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "666da024ca42b09a68009b06f07e54497b3e2c564573", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1, shrink-to-fit=no"">
    <title>Chat Application | CORK - Multipurpose Bootstrap Dashboard Template </title>
    <link");
                BeginWriteAttribute("href", " href=", 545, "", 601, 1);
#nullable restore
#line 15 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
WriteAttributeValue("", 551, Url.Content("~/assets/css/apps/mailing-chat.css"), 551, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />   \r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "666da024ca42b09a68009b06f07e54497b3e2c566285", async() => {
                WriteLiteral(@"

    <div class=""main-container"" id=""container"">
        <div class=""overlay""></div>
        <div class=""search-overlay""></div>                
        <div id=""content"" class=""main-content"">
            <div class=""layout-px-spacing"">
                <div class=""chat-section layout-top-spacing"">
                    <div class=""row"">                        
                        <div class=""col-xl-12 col-lg-12 col-md-12"">                            
                            <div class=""chat-system"">
                                <div class=""hamburger""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-menu mail-menu d-lg-none""><line x1=""3"" y1=""12"" x2=""21"" y2=""12""></line><line x1=""3"" y1=""6"" x2=""21"" y2=""6""></line><line x1=""3"" y1=""18"" x2=""21"" y2=""18""></line></svg></div>
                                <div class=""user-list-box"">
            ");
                WriteLiteral(@"                        <div class=""search"">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-search""><circle cx=""11"" cy=""11"" r=""8""></circle><line x1=""21"" y1=""21"" x2=""16.65"" y2=""16.65""></line></svg>
                                        <input type=""text"" class=""form-control"" placeholder=""Search"" />
                                    </div>

                                    <div class=""people"">
");
#nullable restore
#line 36 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                         for (int i = 0; i < players.Count; i++) //???????????????????? ???????? ??????????????
                                        {
                                            if (players[i].PlayerMessages.Count != 0) //?????????????????? ?????????? ???????? ?? ??????????????????????
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <div class=\"person\" data-chat=\"");
#nullable restore
#line 40 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                          Write(players[i].Token);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                                    <div class=\"user-info\">\r\n                                                        <div class=\"f-head\">\r\n                                                            <img");
                BeginWriteAttribute("src", " src=", 2927, "", 2975, 1);
#nullable restore
#line 43 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
WriteAttributeValue("", 2932, Url.Content("~/assets/img/profile-30.png"), 2932, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""avatar"">
                                                        </div>
                                                        <div class=""f-body"">
                                                            <div class=""meta-info"">
                                                                <span class=""user-name"" data-name=""");
#nullable restore
#line 47 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                                              Write(players[i].Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">");
#nullable restore
#line 47 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                                                                    Write(players[i].Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                                <span class=\"user-meta-time\">");
#nullable restore
#line 48 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                                        Write(players[i].PlayerMessages[players[i].PlayerMessages.Count - 1].Time.ToString("G"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                            </div>\r\n");
#nullable restore
#line 50 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                             if (@players[i].PlayerMessages[players[i].PlayerMessages.Count - 1].IsRead == true)
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <span class=\"preview\">");
#nullable restore
#line 52 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                                 Write(players[i].PlayerMessages[players[i].PlayerMessages.Count - 1].Body);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 53 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                            }
                                                            else //???????? ???? ?????????????????? - ???????????????? ????????????
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <span class=\"preview\"><b>");
#nullable restore
#line 56 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                                    Write(players[i].PlayerMessages[players[i].PlayerMessages.Count - 1].Body);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></span>\r\n");
#nullable restore
#line 57 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        </div>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 61 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </div>

                                </div>
                                <div class=""chat-box"">

                                    <div class=""chat-not-selected"">
                                        <p> <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-message-square""><path d=""M21 15a2 2 0 0 1-2 2H7l-4 4V5a2 2 0 0 1 2-2h14a2 2 0 0 1 2 2z""></path></svg> Click User To Chat</p>
                                    </div>

                                    <div class=""chat-box-inner"">
                                        <div class=""chat-meta-user"">
                                            <div class=""current-chat-user-name""><span><img");
                BeginWriteAttribute("src", " src=", 5584, "", 5627, 1);
#nullable restore
#line 74 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
WriteAttributeValue("", 5589, Url.Content("~/assets/img/90x90.jpg"), 5589, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""dynamic-image""><span class=""name""></span></span></div>

                                            <div class=""chat-action-btn align-self-center"">
                                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-phone  phone-call-screen""><path d=""M22 16.92v3a2 2 0 0 1-2.18 2 19.79 19.79 0 0 1-8.63-3.07 19.5 19.5 0 0 1-6-6 19.79 19.79 0 0 1-3.07-8.67A2 2 0 0 1 4.11 2h3a2 2 0 0 1 2 1.72 12.84 12.84 0 0 0 .7 2.81 2 2 0 0 1-.45 2.11L8.09 9.91a16 16 0 0 0 6 6l1.27-1.27a2 2 0 0 1 2.11-.45 12.84 12.84 0 0 0 2.81.7A2 2 0 0 1 22 16.92z""></path></svg>
                                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-video video-call-screen""><");
                WriteLiteral(@"polygon points=""23 7 16 12 23 17 23 7""></polygon><rect x=""1"" y=""5"" width=""15"" height=""14"" rx=""2"" ry=""2""></rect></svg>
                                                <div class=""dropdown d-inline-block"">
                                                    <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink-2"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-more-vertical""><circle cx=""12"" cy=""12"" r=""1""></circle><circle cx=""12"" cy=""5"" r=""1""></circle><circle cx=""12"" cy=""19"" r=""1""></circle></svg>
                                                    </a>

                                                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuLink-2"">
                           ");
                WriteLiteral(@"                             <a class=""dropdown-item"" href=""javascript:void(0);""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-settings""><circle cx=""12"" cy=""12"" r=""3""></circle><path d=""M19.4 15a1.65 1.65 0 0 0 .33 1.82l.06.06a2 2 0 0 1 0 2.83 2 2 0 0 1-2.83 0l-.06-.06a1.65 1.65 0 0 0-1.82-.33 1.65 1.65 0 0 0-1 1.51V21a2 2 0 0 1-2 2 2 2 0 0 1-2-2v-.09A1.65 1.65 0 0 0 9 19.4a1.65 1.65 0 0 0-1.82.33l-.06.06a2 2 0 0 1-2.83 0 2 2 0 0 1 0-2.83l.06-.06a1.65 1.65 0 0 0 .33-1.82 1.65 1.65 0 0 0-1.51-1H3a2 2 0 0 1-2-2 2 2 0 0 1 2-2h.09A1.65 1.65 0 0 0 4.6 9a1.65 1.65 0 0 0-.33-1.82l-.06-.06a2 2 0 0 1 0-2.83 2 2 0 0 1 2.83 0l.06.06a1.65 1.65 0 0 0 1.82.33H9a1.65 1.65 0 0 0 1-1.51V3a2 2 0 0 1 2-2 2 2 0 0 1 2 2v.09a1.65 1.65 0 0 0 1 1.51 1.65 1.65 0 0 0 1.82-.33l.06-.06a2 2 0 0 1 2.83 0 2 2 0 0 1 0 2.83l-.06.06a1.65 1.65 0 0 0-.33 1.82V9a1.65 1.65 0 0 0 1.51 1H21a2 2");
                WriteLiteral(@" 0 0 1 2 2 2 2 0 0 1-2 2h-.09a1.65 1.65 0 0 0-1.51 1z""></path></svg> Settings</a>
                                                        <a class=""dropdown-item"" href=""javascript:void(0);""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-mail""><path d=""M4 4h16c1.1 0 2 .9 2 2v12c0 1.1-.9 2-2 2H4c-1.1 0-2-.9-2-2V6c0-1.1.9-2 2-2z""></path><polyline points=""22,6 12,13 2,6""></polyline></svg> Mail</a>
                                                        <a class=""dropdown-item"" href=""javascript:void(0);""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-copy""><rect x=""9"" y=""9"" width=""13"" height=""13"" rx=""2"" ry=""2""></rect><path d=""M5 15H4a2 2 0 0 1-2-2V4a2 2 0 0 1 2-2h9a2 2 0 0 1 2 2v1""></path></svg> Copy</a>");
                WriteLiteral(@"
                                                        <a class=""dropdown-item"" href=""javascript:void(0);""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-trash-2""><polyline points=""3 6 5 6 21 6""></polyline><path d=""M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2""></path><line x1=""10"" y1=""11"" x2=""10"" y2=""17""></line><line x1=""14"" y1=""11"" x2=""14"" y2=""17""></line></svg> Delete</a>
                                                        <a class=""dropdown-item"" href=""javascript:void(0);""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-share-2""><circle cx=""18"" cy=""5"" r=""3""></circle><circle cx=""6"" cy=""12"" r=""3""></circle><circle cx=""18"" cy=""19"" r=""3""></circle><line x1=""8.59"" y");
                WriteLiteral(@"1=""13.51"" x2=""15.42"" y2=""17.49""></line><line x1=""15.41"" y1=""6.51"" x2=""8.59"" y2=""10.49""></line></svg> Share</a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                                                                  
                                        <div class=""chat-conversation-box"">
                                            <div id=""chat-conversation-box-scroll"" class=""chat-conversation-box-scroll"">
");
#nullable restore
#line 97 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                  for (int i = 0; i < players.Count; i++)
                                                 {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <div class=\"chat\"");
                BeginWriteAttribute("id", " id=\"", 11570, "\"", 11595, 1);
#nullable restore
#line 99 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
WriteAttributeValue("", 11575, players[i].Username, 11575, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-chat=\"");
#nullable restore
#line 99 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                                                      Write(players[i].Token);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                                        <input type=\"hidden\" name=\"username\"");
                BeginWriteAttribute("value", " value=\"", 11721, "\"", 11749, 1);
#nullable restore
#line 100 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
WriteAttributeValue("", 11729, players[i].Username, 11729, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 101 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                         if (players[i].PlayerMessages.Count != 0)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                             for (int j = 0; j < players[i].PlayerMessages.Count; j++)  //?????????? ???????? ??????????????????
                                                            {
                                                                if (players[i].PlayerMessages[j].MessageType == MessageType.Operator) //???? ???????? ??????????????????
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <div class=\"bubble me\">");
#nullable restore
#line 107 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                      Write(players[i].PlayerMessages[j].Body);

#line default
#line hidden
#nullable disable
                WriteLiteral("   |");
#nullable restore
#line 107 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                                                            Write(players[i].PlayerMessages[j].Time.ToString("T"));

#line default
#line hidden
#nullable disable
                WriteLiteral("|</div>\r\n");
#nullable restore
#line 108 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                } else
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <div class=\"bubble you\">");
#nullable restore
#line 110 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                       Write(players[i].PlayerMessages[j].Body);

#line default
#line hidden
#nullable disable
                WriteLiteral("   |");
#nullable restore
#line 110 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                                                             Write(players[i].PlayerMessages[j].Time.ToString("T"));

#line default
#line hidden
#nullable disable
                WriteLiteral("|</div>\r\n");
#nullable restore
#line 111 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                                }
                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                             
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    </div>   \r\n");
#nullable restore
#line 115 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                                  }                                              

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </div>\r\n                                        </div>                               \r\n");
#nullable restore
#line 119 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                         if(User.Identity.IsAuthenticated&&User.IsInRole("Operator")) 
                                        { 

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"chat-footer\">\r\n                                            <div class=\"chat-input\">\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "666da024ca42b09a68009b06f07e54497b3e2c5627327", async() => {
                    WriteLiteral(@"
                                                    <div class=""input-group mb-4"">
                                                        <input type=""text"" class=""form-control"" id=""messageInput"" placeholder=""Enter message..."" aria-label=""Recipient's username"">
                                                        <div class=""input-group-append"">
                                                           <button class=""btn btn-success"" id=""sendToUser"">Send</button>
                                                        </div>
                                                    </div>
                                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 133 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
                                        }                                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    

    <script");
                BeginWriteAttribute("src", " src=", 14910, "", 14967, 1);
#nullable restore
#line 145 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
WriteAttributeValue("", 14915, Url.Content("~/assets/js/libs/jquery-3.1.1.min.js"), 14915, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=", 14990, "", 15039, 1);
#nullable restore
#line 146 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
WriteAttributeValue("", 14995, Url.Content("~/bootstrap/js/popper.min.js"), 14995, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=", 15062, "", 15114, 1);
#nullable restore
#line 147 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
WriteAttributeValue("", 15067, Url.Content("~/bootstrap/js/bootstrap.min.js"), 15067, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=", 15137, "", 15210, 1);
#nullable restore
#line 148 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
WriteAttributeValue("", 15142, Url.Content("~/plugins/perfect-scrollbar/perfect-scrollbar.min.js"), 15142, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=", 15237, "", 15290, 1);
#nullable restore
#line 151 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
WriteAttributeValue("", 15242, Url.Content("~/assets/js/apps/mailbox-chat.js"), 15242, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=", 15313, "", 15358, 1);
#nullable restore
#line 152 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
WriteAttributeValue("", 15318, Url.Content("~/signalr/ChatPlayers.js"), 15318, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=", 15381, "", 15422, 1);
#nullable restore
#line 153 "C:\Users\win10\source\repos\Megame_Admin\Views\Home\ChatPlayers.cshtml"
WriteAttributeValue("", 15386, Url.Content("~/signalr/signalr.js"), 15386, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    \r\n");
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
            WriteLiteral("\r\n</html>");
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
