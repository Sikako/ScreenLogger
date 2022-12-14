using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrtScModels.Models
{
    public class PrtSc
    {
        public PrtSc()
        {

        }
        public PrtSc(string Status, string Token)
        {
            this.Status = Status;
            this.Token = Token;
        }
        public  string? Status { get; set; }
        public string? Token { get; set; }
    }
}


