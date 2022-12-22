using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrtScModels.Models
{
    public class PrtScStatus
    {
        public PrtScStatus() { }

        public PrtScStatus(string? status, string? token)
        {
            Status = status;
            Token = token;
        }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("token")]
        public string? Token { get; set; }
    }
}