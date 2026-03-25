var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc(); // to add all mvc services we required 

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//This is a method which response to an every object
//app.Run();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles() ; // to use static files which are in present in wwwroot folder

//app.UseMvcWithDefaultRoute(); // to configure mvc route & this looks for default Home Controller & Index Method

app.UseDefaultFiles() ; // When we wanna use default documents

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
