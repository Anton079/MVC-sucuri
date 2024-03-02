using MVC_sucuri;

internal class Program
{
    public static void Main(string[] args)
    {
        SucuriService service = new SucuriService();

        service.LoadData();

        service.AfisareSucuri();

        List<Sucuri> Sucuris = service.FilterSucuriDupaCantiate(2);
        foreach (Sucuri x in Sucuris)
        {
            Console.WriteLine(x.InfoSucuri());
        }

        List<Sucuri> sucuris = service.FilterSucuriDupaCantiate(11);
        foreach (Sucuri x in sucuris)
        {
            Console.WriteLine(x.InfoSucuri());
        }
    }
}