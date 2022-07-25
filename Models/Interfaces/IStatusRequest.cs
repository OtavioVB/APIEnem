using Microsoft.AspNetCore.Mvc;
using APIEnem.Models.Application;

namespace APIEnem.Models.Interfaces
{
    public interface IStatusRequest
    {
        public Guid Identificador { get; set; }
        public int StatusCode { get; set; }
        public DateTime Time { get; set; }
        public Message Message { get; set; }
    }
}
