public class SamochodKierowany : Samochod{
    private string PeselKierowcy { get; set; }
    public SamochodKierowany(string marka, int predkosc, int predkoscMax, int rokProdukcji, string peselKierowcy) 
        : base(marka, predkosc, predkoscMax, rokProdukcji){
        this.PeselKierowcy = peselKierowcy;
    }
    public SamochodKierowany(string marka, int rokProdukcji, int predkoscMax, string peselKierowcy) 
        : base( marka, rokProdukcji, 0, predkoscMax) {
        this.PeselKierowcy = peselKierowcy;
    }
    public new string ZwrocInformacje(){
        return base.ZwrocInformacje() + $", PeselKierowcy: {this.PeselKierowcy}";
    }
    public void Przyspiesz(int oIle){
        if(oIle >= 0 && Predkosc + oIle <= PredkoscMax){
            Predkosc += oIle;
        }else if(oIle < 0){
            Console.WriteLine("Nie można zmniejszyć prędkości o wartość ujemną.");
        }else{
            Console.WriteLine("Nie można przekroczyć maksymalnej prędkości.");
            Predkosc = PredkoscMax;
        }
    }
    public void Zwolnij(int oIle){
        if(Predkosc - Math.Abs(oIle) >= 0){
            Predkosc -= Math.Abs(oIle);
        }else{
            Console.WriteLine("Nie można zmniejszyć prędkości poniżej zera.");
            Predkosc = 0;
        }
    }
}