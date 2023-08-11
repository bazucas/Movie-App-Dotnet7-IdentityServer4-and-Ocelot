using IdentityServer;
using IdentityServerHost.Quickstart.UI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddIdentityServer()
    .AddInMemoryClients(Config.Clients)
    .AddInMemoryApiScopes(Config.ApiScopes)
    .AddInMemoryIdentityResources(Config.IdentityResources)
    .AddTestUsers(TestUsers.Users)
    .AddDeveloperSigningCredential();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();

app.UseAuthorization();

app.MapDefaultControllerRoute(); // for mvc + api routing  

//app.MapControllers(); // only for api routing

app.Run();

