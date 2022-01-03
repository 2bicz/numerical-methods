using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace numerical_methods_Newton
{
    class EasyParser
    {
        // String przechowujący naszą funkcję
        private String f;

        // Konstruktor, w którym zapisujemy naszą funkcję
        // i wymieniamy w niej przecinki na kropki,
        // by nie kolidowało to z mxparserem
        public EasyParser(String fConstruct)
        {        
            this.f = fConstruct.Replace(",", ".");    
        }

        // Zwracamy string z funkcją
        public String getFunctionString()
        {
            return this.f;
        }

        // Obliczamy ile wynosi wartość naszej funkcji po podaniu x
        public double getFunctionValue(double x)
        {
            try
            {
                String str = this.f.Replace("x", x.ToString().Replace(",", "."));
                Expression e1 = new Expression(str);
                return e1.calculate();
            }
            catch(NullReferenceException err)
            {
                Console.WriteLine("Error message: "+ err.Message);
                Console.WriteLine("Error source: "+ err.Source);
            }
            return 1;
        }

        // Obliczamy pochodną naszej funkcji
        public double getFunctionDerivativeValue(double x)
        {
            try
            {
                Argument xArg = new Argument("x = " + x.ToString().Replace(",", "."));
                Expression eDer = new Expression("der(" + this.f + ",x)", xArg);
                return eDer.calculate();
            }
            catch(NullReferenceException err)
            {
                Console.WriteLine("Error message: " + err.Message);
                Console.WriteLine("Error source: " + err.Source);
            }
            return 1;
        }
    }
}
