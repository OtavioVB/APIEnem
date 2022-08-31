using APIEnem.Domain.Models.Contracts.Infrascructure.Connection;
using APIEnem.Domain.Models.Contracts.Infrascructure.Persistence.Participant;
using APIEnem.Domain.Repositories.Persistence.Participant;
using APIEnem.Domain.Repositories.Connection;
using APIEnem.Domain.Models.Contracts.Handlers;
using APIEnem.Domain.Handlers;

var builder = WebApplication.CreateBuilder(args);
// builder.WebHost.UseUrls("http://*:" + Environment.GetEnvironmentVariable("PORT"));

builder.Services.AddScoped<IDataConnection, DataConnection>();
builder.Services.AddTransient<IRepositoryParticipant, RepositoryParticipant>();
builder.Services.AddTransient<IParticipantHandler, ParticipantHandler>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();