using Autofac;
using Autofac.Extensions.DependencyInjection;
using RatingApp.Business.DependencyResolvers.Autofac;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>{
    builder.RegisterModule(new AutofacBusinessModule());
});
var app = builder.Build();
if (!app.Environment.IsDevelopment()){
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");
app.Run();