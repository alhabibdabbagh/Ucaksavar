namespace Ucaksavar
{
    internal interface ICisim
    {
        int HareketMesafesi { get; set; }
        bool HareketEttir(Yon yon);
    }
}
