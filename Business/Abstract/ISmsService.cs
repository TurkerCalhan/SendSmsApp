using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    //interface imza tutucudur. Design pattern derki işlem için önce interface oluştur arkasına bunu bir class'a implement et. 
    //dependency ınjection// somut bağımlılığı soyut bağımlılık haline dönüştürür. 
    public interface ISmsService
    {
        string SmsGonder(string Telefon, string Mesaj, int servisSaglayici);
    }
}
