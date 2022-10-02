using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЛР4_ИДЗ;

namespace ЛР4_ИДЗ_ТС
{
    internal class Автомобиль : НаземныйТранстпорт, IAuto
    {
        protected int wheelsNumber;

        public Автомобиль(string pName, int pReseaseYear, bool pHighPass, int pWheelsNumber) : base(pName, pReseaseYear, pHighPass)
        {
            wheelsNumber = pWheelsNumber;
        }

        public virtual string GetWheelsCount()
        {
            return wheelsNumber.ToString();
        }
    }
}
