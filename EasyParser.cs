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
        private String f;

        public EasyParser(String fConstruct)
        {        
            this.f = fConstruct.Replace(",", ".");    
        }

        public String getFunctionString()
        {
            return this.f;
        }

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

        //public String getFunctionDerivativeString()
        //{

        //}

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
