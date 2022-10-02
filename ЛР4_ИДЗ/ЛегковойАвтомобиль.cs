using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЛР4_ИДЗ;

namespace ЛР4_ИДЗ_ТС
{
    internal class ЛегковойАвтомобиль : Автомобиль, ISpeed
    {
        protected int seatsNumber;
        public ЛегковойАвтомобиль(string pName, int pReseaseYear, bool pHighPass, int pWheelsNumber, int pSeatsNumber) : base(pName, pReseaseYear, pHighPass, pWheelsNumber)
        {
            seatsNumber=pSeatsNumber;
        }

        public string GetSpeed()
        {
            return ("Быстрая, т.к. легковая");
        }
    }
}
