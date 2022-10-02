using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ_ТС
{
    internal class Самолет:ВоздушныйТранспорт
    {
        protected int maxCapacity;
        public Самолет(string pName, int pReseaseYear, int pMaxHeight, int pMaxCapacity) : base(pName, pReseaseYear, pMaxHeight)
        {
            maxCapacity = pMaxCapacity;
        }
    }
}
