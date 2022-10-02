using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ_ТС
{
    internal class НаземныйТранстпорт : ТехСредство
    {
        protected bool isHightPass;
        public НаземныйТранстпорт(string pName, int pReseaseYear, bool pIsHighPass) : base(pName, pReseaseYear)
        {
            isHightPass = pIsHighPass;
        }

        override public string GetName()
        {
            return name + " Труднопроходимый: : " + isHightPass.ToString();
        }
    }
}
