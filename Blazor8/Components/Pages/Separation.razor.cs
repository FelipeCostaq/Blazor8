using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazor8.Components.Pages
{
    public partial class Separation
    {
        /*
            Razor (Engine Template - ASP.NET): HTML5 + CSS3 + C# + JS

            Blazor: .razor (Componentes Blazor)
            ASP.NET .cshtml (MVC & Razor Pages): 
        */

        public string texto = "Olá, Mundo!";

        [Inject]
        public IJSRuntime JSRuntime { get; set; } = default!;

        public async Task CarregarJS()
        {
            var modulo = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./Components/Pages/Separation.razor.js");
        }
    }
}
