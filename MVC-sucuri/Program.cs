using MVC_sucuri;

internal class Program
{
    public static void Main(string[] args)
    {
        SucuriService service = new SucuriService();

        service.LoadData();
        View view = new View();

        Sucuri sucNou = new Sucuri();
        sucNou.brand = "Sprite";
        sucNou.cantitate = 1;
        sucNou.pret = 8;


        service.AfisareSucuri();

        
    }
}