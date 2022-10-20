using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class SendSmsDto
    {
        public string Telefon { get; set; }
        public string Mesaj { get; set; }
        public int ServisSaglayici { get; set; }

    }
}
