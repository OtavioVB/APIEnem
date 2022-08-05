using APIEnem.Models.Interfaces;
using APIEnem.Infra.Data;
using APIEnem.Infra.Data.Participante;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IDataParticipante, BancoParticipante>();
builder.Services.AddSingleton<IDataConnection, Conexão>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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