// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Client.Shared
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
    public partial class AlertMessage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Project\WebApplication\WebApplication.Client\Shared\AlertMessage.razor"
       
    [Parameter]
    public string Message { get; set; }

    private Models.AlertMessageType messageType;

    [Parameter]
    public Models.AlertMessageType MessageType
    {
        get => messageType;

        set
        {
            messageType = value;

            switch (messageType)
            {
                case Models.AlertMessageType.Error:
                    alertClass = "alert-danger";
                    break;
                case Models.AlertMessageType.Warning:
                    alertClass = "alert-warning";
                    break;
                case Models.AlertMessageType.Success:
                    alertClass = "alert-success";
                    break;
                default:
                    break;
            }
        }
    }

    string alertClass = "alert-info";

    void HideMessage()
    {
        Message = string.Empty;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
