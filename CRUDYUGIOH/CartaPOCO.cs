using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDYUGIOH
{
    public partial class Carta
    {
        public int getAtaque()
        {
            return this.Ataque;
        }
        public void setAtaque(int ataque)
        {
            if (ataque > 0 && ataque <= 5000)
            {
                this.Ataque = ataque;
            }
            else
            {
                throw new Exception("O valor de ataque deverá ser entre 0 e 5000");
            }
        }

        public int getDefesa()
        {
            return this.Defesa;
        }
        public void setDefesa(int ataque)
        {
            if (ataque > 0 && ataque <= 5000)
            {
                this.Defesa = ataque;
            }
            else
            {
                throw new Exception("O valor de Defesa deverá ser entre 0 e 5000");
            }
        }
    }
    /*private interface x;

    public interface x
    {
        set{ 
            if (value>0)
            {
            x=value;
            }*/

}


