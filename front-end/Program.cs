using EMS.Components;
using EMS.Services;
using EMS.Clients;
using Blazored.Toast;
using Microsoft.JSInterop;




var builder = WebApplication.CreateBuilder(args);
var EMSApiUrl = builder.Configuration["EMSApiURL"] ??
    throw new Exception("EMSApiURL n'est pas défini");
// Add services to the container.------------------------
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


builder.Services.AddBlazoredToast();


builder.Services.AddScoped<EmployeeService>();
builder.Services.AddHttpClient<EmployeesClient>(
    client => client.BaseAddress = new Uri(EMSApiUrl)
);

builder.Services.AddHttpClient<DepartmentsClient>(
    client => client.BaseAddress = new Uri(EMSApiUrl)
);


//-----------------------------------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();




app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
