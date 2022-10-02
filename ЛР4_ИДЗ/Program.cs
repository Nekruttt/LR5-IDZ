using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЛР4_ИДЗ_ТС;

namespace ЛР4_ИДЗ
{
    class Programm 
    {
        static void Main(string[] args)
        {
            var list = new List<ТехСредство>();
            list.Add(new ТехСредство("Подводная лодка", 1942));
            list.Add(new ВоздушныйТранспорт("Квадрокоптер", 2042, 22));
            list.Add(new НаземныйТранстпорт("Велосипед",2012, false));
            list.Add(new Вертолет("Вертик", 1988,201,true));
            list.Add(new Самолет("Стрела", 2032, 2042, 52));
            list.Add(new Танк("Тигр", 1953, true, 99));
            list.Add(new Автомобиль("Неизвестность", 2593, true, 99));
            list.Add(new ЛегковойАвтомобиль("Волга", 1995,false,4,4));
            list.Add(new ГрузовойАвтомобиль("Камаз2000", 2000,true,8,492));
            foreach (var item in list)
            {
                Console.WriteLine(item.GetName());
            }
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item.GetInfo());
            }
            Console.WriteLine();
            var auto = new List<Автомобиль>();
            auto.Add(new Автомобиль("Неизвестность", 2593, true, 99));
            auto.Add(new ЛегковойАвтомобиль("Волга", 1995, false, 4, 4));
            auto.Add(new ГрузовойАвтомобиль("Камаз2000", 2000, true, 8, 492));
            foreach (var item in auto)
            {
                Console.WriteLine(item.GetWheelsCount());
            }
            Console.WriteLine();
            var legk = new ЛегковойАвтомобиль("Волга", 1995, false, 4, 4);
            Console.WriteLine(legk.GetSpeed());
            var gruz = new ГрузовойАвтомобиль("Камаз2000", 2000, true, 8, 492);
            Console.WriteLine(gruz.GetSpeed());
        }
    }
}
