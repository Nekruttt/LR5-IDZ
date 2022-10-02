using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ_ТС
{
    internal class Вертолет : ВоздушныйТранспорт, IInfo
    {
        protected bool isMilitary;
        public  Вертолет (string pName, int pReseaseYear, int pMaxHeight, bool pIsMilitary) : base(pName, pReseaseYear, pMaxHeight)
        {
            isMilitary = pIsMilitary;
        }
    }
}
