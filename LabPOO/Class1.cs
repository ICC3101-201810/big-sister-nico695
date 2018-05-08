using System;

namespace LabPOO
{

    public class BigSisters
    {
        public delegate void BigSisterEventHandler(List<Product> carro, int answer);

        public event BigSisterEventHandler BigSister;

        protected void OnBigSister(List<Product> carro, int answer)
        {
            Console.WriteLine("Este elemento no puede ser agregado");
            int carro1 = carro.Count();
            carro.RemoveAt(carro1 - 1);
        }
        public void Suscribir()
        {
            BigSister += new BigSisterEventHandler(OnBigSister);
        }




        public static void Checkear(List<Product> carro, int answer)
        {
            if (answer == "1")
            {
                BigSister();
            }
            else if (answer == "3")
            {
                BigSisters();
            }
            else if (answer == "3")
            {
                BigSisters();
            }
            else if (answer == "5")
            {
                BigSisters();
            }
            else if (answer == "7")
            {
                BigSisters();
            }
            else if (answer == "9")
            {
                BigSisters();
            }
            else if (answer == "10")
            {
                BigSisters();
            }
            else if (answer == "11")
            {
                BigSisters();
            }
            else if (answer == "15")
            {
                BigSisters();
            }
            else if (answer == "20")
            {
                BigSisters();
            }
            else if (answer == "1")
            {
                int carro1 = carro.Count();
                if (carro1 < 2)
                { }
                else
                {
                    BigSisters();
                }

            }
            else if (answer == "2")
            {
                int carro1 = carro.Count();
                if (carro1 < 3)
                { }
                else
                {
                    BigSisters();
                }

            }
            else if (answer == "4")
            {
                int carro1 = carro.Count();
                if (carro1 < 3)
                { }
                else
                {
                    BigSisters();
                }

            }
            else if (answer == "6")
            {
                int carro1 = carro.Count();
                if (carro1 < 3)
                { }
                else
                {
                    BigSisters();
                }

            }
            else if (answer == "8")
            {
                int carro1 = carro.Count();
                if (carro1 < 13)
                { }
                else
                {
                    BigSisters();
                }

            }
            else if (answer == "10")
            {
                int carro1 = carro.Count();
                if (carro1 < 2)
                { }
                else
                {
                    carro.RemoveAt(carro1 - 1);
                }

            }

        }


    }
}


