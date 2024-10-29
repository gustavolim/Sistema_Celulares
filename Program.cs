using System;

abstract class Smartphone
{
    public string Numero { get; set; }
    protected string Modelo { get; set; }
    protected string IMEI { get; set; }
    protected int Memoria { get; set; }

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nome);
}

class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria) 
        : base(numero, modelo, imei, memoria) { }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} no Nokia.");
    }
}

class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imei, int memoria) 
        : base(numero, modelo, imei, memoria) { }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} no iPhone.");
    }
}

class Program
{
    static void Main()
    {
        Smartphone nokia = new Nokia("123456789", "Nokia X", "111111111", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Smartphone iphone = new Iphone("987654321", "iPhone 13", "222222222", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
