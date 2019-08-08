namespace Ejercicios_de_objetos
{
    public class Bus
    {
        string marca;
        string modelo;
        string patente;
        string motor;
        Ruedabus[] ruedas;


        void Frenar()
        {
            for (int i = 0; i < ruedas.Length; i++)
            {
                ruedas[i].Frenar();
            }
        }

    }
}