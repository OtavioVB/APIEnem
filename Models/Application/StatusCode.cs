using APIEnem.Models.Interfaces;
using APIEnem.Models.Candidato;

namespace APIEnem.Models.Application
{
    public class ResultRequest
    {
        public class OK200 : IStatusRequest, IGoodRequest
        {
            public Guid Identificador { get; set; }
            public Guid IdentificadorDbConnection { get; set; }
            public int StatusCode { get; set; }
            public DateTime Time { get; set; }
            public Message Message { get; set; }
            public ParticipanteData DataResult { get; set; }

            public OK200(Guid IdentificadorDoRequest, Message info, Guid identificadorDbConnection, ParticipanteData Resultado)
            {
                this.Identificador = IdentificadorDoRequest;
                this.StatusCode = 200;
                this.Time = DateTime.Now;
                this.Message = info;
                this.IdentificadorDbConnection = identificadorDbConnection;
                this.DataResult = Resultado;
            }
        }

        public class BADREQUEST400 : IStatusRequest
        {
            public Guid Identificador { get; set; }
            public Guid IdentificadorDbConnection { get; set; }
            public int StatusCode { get; set; }
            public DateTime Time { get; set; }
            public Message Message { get; set; }

            public BADREQUEST400(Guid IdentificadorDoRequest, Message info, Guid identificadorDbConnection)
            {
                this.Identificador = IdentificadorDoRequest;
                this.StatusCode = 400;
                this.Time = DateTime.Now;
                this.Message = info;
                this.IdentificadorDbConnection = identificadorDbConnection;
            }
        }

        public class NOTFOUND404 : IStatusRequest
        {
            public Guid Identificador { get; set; }
            public Guid IdentificadorDbConnection { get; set; }
            public int StatusCode { get; set; }
            public DateTime Time { get; set; }
            public Message Message { get; set; }


            public NOTFOUND404(Guid IdentificadorDoRequest, Message info, Guid identificadorDbConnection)
            {
                this.Identificador = IdentificadorDoRequest;
                this.StatusCode = 404;
                this.Time = DateTime.Now;
                this.Message = info;
                this.IdentificadorDbConnection = identificadorDbConnection;
            }
        }
    }
}
