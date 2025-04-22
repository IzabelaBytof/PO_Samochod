public class Samochod{
    private string Marka { get; set; }
    protected int Predkosc { get; set; }
    private int RokProdukcji { get; set; }
    private int _predkoscMax;
    public int PredkoscMax
    {
        get { return _predkoscMax; }
    }
    public Samochod(string marka, int predkosc, int predkoscMax, int rokProdukcji){
        this.Marka = marka;
        this.Predkosc = predkosc;
        this._predkoscMax = predkoscMax;
        this.RokProdukcji = rokProdukcji;
    }
    public Samochod(string marka, int predkoscMax, int rokProdukcji) :this(marka, 0, predkoscMax, rokProdukcji){

    }
    public string ZwrocInformacje(){
        return $"Marka: {this.Marka}, Predkosc: {this.Predkosc}, PredkoscMax: {this.PredkoscMax}, RokProdukcji: {this.RokProdukcji}";
    }
}