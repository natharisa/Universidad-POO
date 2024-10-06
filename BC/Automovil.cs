using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC
{
    public class Automovil
    {
       //Declaración de variables
        public string Marca { get; set; }
        public string Modelo { get;private set; }
        public int Combustible { get; private set; } = 50;
        public enum Estado { Encendido,Apagado}

        

        public Estado EstadoAuto { get; private set; }
        
        //Metodos
        public void Encender() //Entra en estado encendido
        {
            EstadoAuto = Estado.Encendido;
            
        }

        public void Apagar() //Entra en estado apagado
        {
            EstadoAuto = Estado.Apagado;

        }

       public void Avanzar ()
        {

            if (Combustible < 1)
            {
                Apagar(); //El auto se apaga

            }

            //Cuando este apagado no hace nada


            if (EstadoAuto ==Estado.Apagado)
            {
                return;
            }

            else
            {
                Combustible -= 1;

            }


        }

        public void CargarCombustible()
        {      
            //El auto tiene que estar apagado
             if (EstadoAuto==Estado.Encendido)
            {
                Apagar();

            }

            Combustible = 50;
            
        }
        
        public void CargarCombustible( int pTanque)
        {


            if (pTanque>50 && pTanque<1)
            {
                
                return;

            }
            else
            {
                
                Combustible+= pTanque;

                if (Combustible > 50)
                {

                    Combustible = 50;

                }
                

            }

               

            

        }






    }
}
