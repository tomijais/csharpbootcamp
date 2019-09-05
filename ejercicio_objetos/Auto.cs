namespace ejercicio_objetos
{
    public class Auto : Vehiculo 
    {
        double velocidad;
        int cantRuedas = 4;

        public Auto(string marca, string modelo, string patente, string motor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.patente = patente;
            this.motor = motor;
        }

        public void Frenar()
        {
            velocidad = 0;
        }
        public void Acelerar(double _aceleracion)
        {
            velocidad = _aceleracion;
        }
    }
}