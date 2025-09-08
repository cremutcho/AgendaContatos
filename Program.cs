using AgendaContatos.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte a controllers com views
builder.Services.AddControllersWithViews();

// Configura o DbContext com SQL Server
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AgendaConnection")));

var app = builder.Build();

// Configurações de exceção e arquivos estáticos
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Define a rota padrão para abrir direto na Agenda de Contatos
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Contatos}/{action=Index}/{id?}");

app.Run();
