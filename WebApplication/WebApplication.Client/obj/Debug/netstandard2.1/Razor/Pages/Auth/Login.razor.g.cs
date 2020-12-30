#pragma checksum "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c5ce038b248e9dc7052cc26020d7af1c9f81d53"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Client.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Project\WebApplication\WebApplication.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\WebApplication\WebApplication.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\WebApplication\WebApplication.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\WebApplication\WebApplication.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\WebApplication\WebApplication.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Project\WebApplication\WebApplication.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Project\WebApplication\WebApplication.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Project\WebApplication\WebApplication.Client\_Imports.razor"
using WebApplication.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Project\WebApplication\WebApplication.Client\_Imports.razor"
using WebApplication.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Project\WebApplication\WebApplication.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Project\WebApplication\WebApplication.Client\_Imports.razor"
using WebApplication.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Project\WebApplication\WebApplication.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
using WebApplication.Shared.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-12");
            __builder.AddMarkupContent(4, "<h2>Войдите учетную запись</h2>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                         model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                                               LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<WebApplication.Client.Shared.AlertMessage>(11);
                    __builder3.AddAttribute(12, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                                        message

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "MessageType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WebApplication.Client.Models.AlertMessageType>(
#nullable restore
#line 14 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                                                               messageType

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(14, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(17);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n\r\n                ");
                    __builder3.AddMarkupContent(19, "<label>Email</label>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(20);
                    __builder3.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                                            model.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Email = __value, model.Email))));
                    __builder3.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Email));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n\r\n                ");
                    __builder3.AddMarkupContent(25, "<label>Пароль</label>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(26);
                    __builder3.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                                             model.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Password = __value, model.Password))));
                    __builder3.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n\r\n                <hr>\r\n\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(31);
                    __builder3.AddAttribute(32, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 26 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                                          Radzen.ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Text", "Войти");
                    __builder3.AddAttribute(34, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 27 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                                           Radzen.ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "class", "btn-block mr-2");
                    __builder3.AddAttribute(36, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                                        isBusy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\r\n\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(38);
                    __builder3.AddAttribute(39, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 30 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                                          Radzen.ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "Text", "Зарегестрироваться");
                    __builder3.AddAttribute(41, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 31 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                                           Radzen.ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "class", "btn-block mr-2");
                    __builder3.AddAttribute(43, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                                        isBusy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
                                                       GoToRegister

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Project\WebApplication\WebApplication.Client\Pages\Auth\Login.razor"
       
    LoginViewModel model = new LoginViewModel();

    bool isBusy = false;
    string message = string.Empty;
    Models.AlertMessageType messageType = Models.AlertMessageType.Success;
    public async Task LoginUser()
    {
        isBusy = true;

        var result = await authService.LoginUserAsync(model);
        if (result.IsSuccess)
        {
            message = "Вы вошли!";
            messageType = Models.AlertMessageType.Success;

            var userInfo = new WebApplication.Client.Models.LocalUserInfo()
            {
                AccessToken = result.Message,
                Email = result.UserInfo["Email"],
                Roles = result.UserInfo["Roles"],
                Id = result.UserInfo[System.Security.Claims.ClaimTypes.NameIdentifier]
            };

            await storageService.SetItemAsync("User", userInfo);

        }
        else
        {
            message = result.Message;
            messageType = Models.AlertMessageType.Error;
        }
        isBusy = false;
    }

    void GoToRegister()
    {
        navigationManager.NavigateTo("/auth/register");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService storageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService authService { get; set; }
    }
}
#pragma warning restore 1591
