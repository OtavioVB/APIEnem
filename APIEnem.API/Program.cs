using APIEnem.Domain.Models.Interfaces;
using APIEnem.Domain.Models.Interfaces.Database;
using APIEnem.Domain.Models.Interfaces.Database.Participante;
using APIEnem.Infra.Data.Participante;
using APIEnem.Infra.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IDataConnection, Conexão>();
builder.Services.AddScoped<IGlobalDataActions, GlobalDataActions>();
builder.Services.AddScoped<IParticipanteDataActions, ParticipanteActions>();
builder.Services.AddScoped<IDataParticipante, BancoParticipante>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.WebHost.UseUrls("http://*:" + Environment.GetEnvironmentVariable("PORT"));
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();