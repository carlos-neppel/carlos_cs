namespace Aula14_05Interfaces
{
    interface IMeioTransporte1
    {
        string Modelo { get; set; }
        int Velocidade { get; set; }

        void Acelerar();
        void Desacelerar();
        string ImprimirInfo();
    }
}