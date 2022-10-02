using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ_ТС
{
    public class ТехСредство : IInfo
    {
        protected string name;
        protected int releaseYear;

        public ТехСредство(string pName,int pReseaseYear)
        {
            name = pName;
            releaseYear = pReseaseYear;
        }

        public virtual string GetInfo()
        {
            return "ТехСредство";
        }

        virtual public string GetName()
        {
            return name;
        }
    }
}
