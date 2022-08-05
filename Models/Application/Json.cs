﻿using Newtonsoft.Json;

namespace APIEnem.Models.Application
{
    public class Json
    {
        private string JsonRetorno { get; set; }

        public Json(object Data)
        {
            JsonRetorno = JsonConvert.SerializeObject(Data);
        }

        public override string ToString()
        {
            return JsonRetorno;
        }
    }
}
