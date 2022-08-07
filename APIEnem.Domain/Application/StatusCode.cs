using APIEnem.Domain.Models.Interfaces;
using APIEnem.Domain.Models.Candidato;

namespace APIEnem.Domain.Models.Application
{
    public abstract class ResultRequest
    {
        public class Ok200 : IGoodRequest
        {
            public Guid Identificador { get; set; }
            public Guid IdentificadorDbConnection { get; set; }
            public int StatusCode { get; set; }
            public DateTime Time { get; set; }
            public Message Message { get; set; }
            public ParticipanteData DataResult { get; set; }

            public Ok200(Guid identificadorDoRequest, Message info, Guid identificadorDbConnection, ParticipanteData resultado)
            {
                Identificador = identificadorDoRequest;
                StatusCode = 200;
                Time = DateTime.Now;
                Message = info;
                IdentificadorDbConnection = identificadorDbConnection;
                DataResult = resultado;
            }
        }

        public class BadRequest400 : IStatusRequest
        {
            public Guid Identificador { get; set; }
            public Guid IdentificadorDbConnection { get; set; }
            public int StatusCode { get; set; }
            public DateTime Time { get; set; }
            public Message Message { get; set; }

            public BadRequest400(Guid identificadorDoRequest, Message info, Guid identificadorDbConnection)
            {
                Identificador = identificadorDoRequest;
                StatusCode = 400;
                Time = DateTime.Now;
                Message = info;
                IdentificadorDbConnection = identificadorDbConnection;
            }
        }

        public class NotFound404 : IStatusRequest
        {
            public Guid Identificador { get; set; }
            public Guid IdentificadorDbConnection { get; set; }
            public int StatusCode { get; set; }
            public DateTime Time { get; set; }
            public Message Message { get; set; }


            public NotFound404(Guid identificadorDoRequest, Message info, Guid identificadorDbConnection)
            {
                Identificador = identificadorDoRequest;
                StatusCode = 404;
                Time = DateTime.Now;
                Message = info;
                IdentificadorDbConnection = identificadorDbConnection;
            }
        }
    }
}
