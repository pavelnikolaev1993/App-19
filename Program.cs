using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
List<Comp> listComp = new List<Comp>()
{
new Comp (){Id=1, Name = "Lenovo", Cpu = "Socket AM3+", Frequency = 3900, Ddr =  4, HHD = 1000, GPU = 1024, Price = 23500, Available = 38},
new Comp (){Id=2, Name = "Acer", Cpu = "LGA 1700", Frequency = 2100, Ddr =  8, HHD = 800, GPU = 2048, Price = 46000, Available = 14},
new Comp (){Id=3, Name = "Asus", Cpu = "Socket 423", Frequency = 1500, Ddr =  4, HHD = 500, GPU = 512, Price = 50000, Available = 41},
new Comp (){Id=4, Name = "Intel", Cpu = "Socket 423", Frequency = 1500, Ddr =  6, HHD = 500, GPU = 4096, Price = 18000, Available = 26},
new Comp (){Id=5, Name = "HP", Cpu = "LGA 1700", Frequency = 2100, Ddr =  12, HHD = 800, GPU = 512, Price = 35200, Available = 17},
new Comp (){Id=6, Name = "Toshiba", Cpu = "Socket AM3+", Frequency = 3900, Ddr =  8, HHD = 700, GPU = 2048, Price = 28000, Available = 13},
};
//Console.WriteLine("Введите название процессора (Socket AM3+, LGA 1700, Socket 423)");
//string cpu = Console.ReadLine();
//List<Comp> listComp1 = listComp.Where(x => x.Cpu == cpu).ToList();
//Print(listComp1);

//Console.WriteLine("Введите объём оперативной памяти");
//int ddr = Convert.ToInt32(Console.ReadLine());
//List<Comp> listComp2 = listComp.Where(x => x.Ddr >= ddr).ToList();
//Print(listComp1);

//Console.WriteLine("Cписок, отсортированный по увеличению стоимости");
//List<Comp> listComp3 = listComp.OrderBy(x => x.Price).ToList();
//Print(listComp1); 

//Console.WriteLine("Cписок , сгруппированнный по типу процессора");
//IEnumerable<IGrouping<string, Comp>> listComp4 = listComp.GroupBy(x => x.Cpu);
//foreach (IGrouping<string, Comp> gr in listComp4)
//{
//    Console.WriteLine(gr.Key);
//    foreach (Comp e in gr)
//    {
//        Console.WriteLine($"{e.Id} {e.Name} {e.Cpu} {e.Frequency} {e.Ddr} {e.HHD} {e.GPU} {e.Price} {e.Available}");
//    }
//}


//Console.WriteLine("Cамый дорогой и самый дешевый компьютер");
//Comp listComp5 = listComp.OrderByDescending(x => x.Price).FirstOrDefault();
//Console.WriteLine($"{listComp5.Id} {listComp5.Name} {listComp5.Cpu} {listComp5.Frequency} {listComp5.Ddr} {listComp5.HHD} {listComp5.GPU} {listComp5.Price} {listComp5.Available}");

//Console.WriteLine(listComp.Any(x=>x.Available>30));

static void Print(List<Comp> listComp)
{
    foreach (Comp e in listComp)
    {
        Console.WriteLine($"{e.Id} {e.Name} {e.Cpu} {e.Frequency} {e.Ddr} {e.HHD} {e.GPU} {e.Price} {e.Available}");
    }
    Console.WriteLine();

}
class Comp
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Cpu { get; set; }
    public int Frequency { get; set; }
    public int Ddr { get; set; }
    public int HHD { get; set; }
    public int GPU { get; set; }
    public int Price { get; set; }
    public int Available { get; set; }
}
