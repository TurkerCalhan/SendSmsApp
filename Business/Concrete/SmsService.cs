using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SmsService : ISmsService
    {
        public string SmsGonder(string Telefon, string Mesaj, int servisSaglayici)
        {
            string returnValue = string.Empty;

            if (!string.IsNullOrEmpty(Telefon))
            {
                Telefon = Telefon.Replace("+", string.Empty).Replace(" ", string.Empty);
                if (Telefon.Length == 10)
                {
                    Telefon = "90" + Telefon;
                }
                else if (Telefon.Length == 11)
                {
                    Telefon = "9" + Telefon;
                }

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                if (servisSaglayici == 0)
                {
                    returnValue = ServisSaglayicilar.SmsGonderGuvenTelekom(Telefon, Mesaj);
                }
                else if (servisSaglayici == 1)
                {
                    returnValue = ServisSaglayicilar.SmsGonderTFonTelekom(Telefon, Mesaj);
                }
                else if (servisSaglayici == 2)
                {
                    returnValue = ServisSaglayicilar.SmsGonderNetGsm(Telefon, Mesaj);
                }
                else if (servisSaglayici == 3)
                {
                    returnValue = ServisSaglayicilar.SmsGonderSmartMessage(Telefon, Mesaj);
                }
                else if (servisSaglayici == 4)
                {
                    returnValue = ServisSaglayicilar.SmsGonderRelatedDigital(Telefon, Mesaj);
                }
                else if (servisSaglayici == 5)
                {
                    returnValue = ServisSaglayicilar.SmsGonderTelsam(Telefon, Mesaj);
                }
                else if (servisSaglayici == 6)
                {
                    returnValue = ServisSaglayicilar.SmsGonderVerimor(Telefon, Mesaj);
                }
            }
            return returnValue;
        }
    }
}



