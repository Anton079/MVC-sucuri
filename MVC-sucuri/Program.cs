using MVC_sucuri;

internal class Program
{
    public static void Main(string[] args)
    {
        SucuriService service = new SucuriService();

        service.LoadData();

        service.AfisareSucuri();
    }
}