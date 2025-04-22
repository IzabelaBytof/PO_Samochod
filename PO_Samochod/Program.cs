public class Program{
    public static void Main(string[] args){
        Samochod samochod1 = new Samochod("Toyota", 120, 180, 2020);
        Samochod samochod2 = new Samochod("Honda", 200, 2021);
        Console.WriteLine(samochod1.ZwrocInformacje());
        Console.WriteLine(samochod2.ZwrocInformacje());
        SamochodKierowany samochodKierowany1 = new SamochodKierowany("BMW", 150, 240, 2019, "12345678901");
        SamochodKierowany samochodKierowany2 = new SamochodKierowany("Audi", 2021, 220, "98765432101"); 
        Console.WriteLine(samochodKierowany1.ZwrocInformacje());
        Console.WriteLine(samochodKierowany2.ZwrocInformacje());
        samochodKierowany1.Przyspiesz(50);
        Console.WriteLine($"Po przyspieszeniu: {samochodKierowany1.ZwrocInformacje()}");
        samochodKierowany1.Zwolnij(30);
        Console.WriteLine($"Po zwolnieniu: {samochodKierowany1.ZwrocInformacje()}");
        samochodKierowany1.Przyspiesz(300); // Przekroczenie maksymalnej prędkości
        Console.WriteLine($"Po próbie przekroczenia maksymalnej prędkości: {samochodKierowany1.ZwrocInformacje()}");
        samochodKierowany1.Zwolnij(200); // Zmniejszenie prędkości poniżej zera
        Console.WriteLine($"Po próbie zmniejszenia prędkości poniżej zera: {samochodKierowany1.ZwrocInformacje()}");
        samochodKierowany1.Przyspiesz(-20); // Próba zmniejszenia prędkości o wartość ujemną
        Console.WriteLine($"Po próbie zmniejszenia prędkości o wartość ujemną: {samochodKierowany1.ZwrocInformacje()}");

    }
}