using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ_ТС
{
    internal class ВоздушныйТранспорт : ТехСредство, IInfo
    {
        protected int maxHeight;


        public ВоздушныйТранспорт(string pName, int pReseaseYear, int pMaxHeight) : base(pName, pReseaseYear)
        {
            maxHeight = pMaxHeight;
        }

        override public string GetName()
        {
            return name+" Макс высота: "+maxHeight.ToString();
        }
    }
}
