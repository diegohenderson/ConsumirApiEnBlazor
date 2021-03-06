#pragma checksum "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34e7e93365928f35c778b975af0a59ff56fb0922"
// <auto-generated/>
#pragma warning disable 1591
namespace ConsumirApiBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\_Imports.razor"
using ConsumirApiBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\_Imports.razor"
using ConsumirApiBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\Pages\FetchData.razor"
using ConsumirApiBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>lo mas importante es el front end</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 13 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\Pages\FetchData.razor"
 if (personaje == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>si...</em></p>\r\n");
#nullable restore
#line 16 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Nombre</th>\r\n                <th>Apellido</th>\r\n                <th>Localizacion</th>\r\n                \r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 30 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\Pages\FetchData.razor"
                     personaje.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 31 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\Pages\FetchData.razor"
                     personaje.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 32 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\Pages\FetchData.razor"
                     personaje.Localizacion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 46 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\repos\ConsumirApi\ConsumirApi\ConsumirApiBlazor\Pages\FetchData.razor"
       
    private ConsumirApiBlazor.Modelos.Personaje personaje;

    protected override async Task OnInitializedAsync()
    {
        int Id = 3;
        string url = "https://localhost:44383/api/personajes/";

        //personaje = await personajeservice.GetTaskByIdAsync();
        personaje = await GenericServices<ConsumirApiBlazor.Modelos.Personaje>.GetTaskByIdAsync(Id, url);

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PersonajeServices personajeservice { get; set; }
    }
}
#pragma warning restore 1591
