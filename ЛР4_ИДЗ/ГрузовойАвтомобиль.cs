using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЛР4_ИДЗ;

namespace ЛР4_ИДЗ_ТС
{
    internal class ГрузовойАвтомобиль : Автомобиль, ISpeed
    {
        protected float loadCapacity;
        public ГрузовойАвтомобиль(string pName, int pReseaseYear, bool pHighPass, int pWheelsNumber, float pLoadCapacity) : base(pName, pReseaseYear, pHighPass, pWheelsNumber)
        {
            loadCapacity = pLoadCapacity;
        }
        public override string GetWheelsCount()
        {
            
            return wheelsNumber.ToString()+" +1 запасное колесо";
        }
        public string GetSpeed()
        {
            return ("Медленная, т.к. грузовая");
        }
    }
}
