using Blazor8.Client.Pages;
using Blazor8.Components;
using Blazor8.Models;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();
/*
 
 Transient - A cada injenção é um objeto difente
 Scoped - A injeção gera o mesmo objeto no escopo
 Singleton - Gera apenas um objeto para aplicação e guarda esse valor. O objeto so muda se a aplicação reiniciar

 */
builder.Services.AddSingleton<RandomNumber>();
builder.Services.AddSingleton<IMensagem, MensagemWpp>();
builder.Services.AddKeyedSingleton<IMensagem, MensagemWpp>("whatsapp");
builder.Services.AddKeyedSingleton<IMensagem, MensagemSMS>("sms");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithRedirects("StatusCode/{0}");
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Blazor8.Client._Imports).Assembly);

app.Run();
