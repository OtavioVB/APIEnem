using APIEnem.Domain.Models.Application;

namespace APIEnem.Domain.Models.Interfaces
{
    public interface IStatusRequest
    {
        public Guid Identificador { get; set; }
        public Guid IdentificadorDbConnection { get; set; }
        public int StatusCode { get; set; }
        public DateTime Time { get; set; }
        public Message Message { get; set; }
    }
}
