using System;


namespace TesteUnitario.Functions
{
    public class VerificaRenda
    {
        public string VerificarRenda(double renda)
        {
            if (renda < 0)
            {
                return("Inválido");
            }
            else if (renda >= 0 && renda <= 1000)
            {
                return("Classe E");
            }
            else if (renda > 1000 && renda <= 2500)
            {
                return("Classe D");
            }
            else if (renda > 2500 && renda <= 3100) 
            {
                return("Classe C");
            }
            else if (renda > 3100 && renda <= 4800)
            {
                return("Classe B");
            }
            else
            {
                return ("Classe A");
            }
        }
    }
}
