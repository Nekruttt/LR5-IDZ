using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ_ТС
{
    internal class Танк : НаземныйТранстпорт
    {
        protected float caseHight;
        public Танк (string pName, int pReseaseYear, bool pHighPass, float pCaseHight) : base(pName, pReseaseYear, pHighPass)
        {
            caseHight = pCaseHight;
        }
    }
}
