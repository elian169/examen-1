using System;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int retiro=0, transacion=0,opcion,banco;
            Console.WriteLine();
            Console.WriteLine("    *********************************************   ");
            Console.WriteLine("    ****          elija su banco **   ");
            Console.WriteLine("    *********************************************   ");
            Console.WriteLine("\n");
            Console.WriteLine("[1]FDP INVERSMENTS\n[2]popular\n[3]BHD ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            if (opcion ==1 )
            {
                Console.WriteLine();
                Console.WriteLine("    *********************************************   ");
                Console.WriteLine("    ****          elija una opcion **   ");
                Console.WriteLine("    *********************************************   ");
                Console.WriteLine("\n");
                Console.WriteLine("[1]retiro");
                Console.WriteLine("[2]transacion");
                opcion = int.Parse(Console.ReadLine());
                

                if (opcion == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("    *********************************************   ");
                    Console.WriteLine("    ****          RETIRO **   ");
                    Console.WriteLine("    *********************************************   ");
                    Console.WriteLine("\n");
                    Console.WriteLine("digite el monto: ");
                    retiro = int.Parse(Console.ReadLine());
                    

                    while (retiro > 20000 || retiro < 100)
                    {
                        Console.WriteLine("no se pude retirar ese monto");
                        Console.WriteLine("intente denuevo ");
                        retiro = int.Parse(Console.ReadLine());
                    }
                    

                    Console.WriteLine("billetes de 1000 entregados");
                  
                    Console.WriteLine(retiro /1000);
                    retiro = retiro % 1000;
                    Console.WriteLine("billetes de 500 entregados");
                   
                    Console.WriteLine(retiro /500);
                    retiro = retiro % 500;
                    Console.WriteLine("billetes de 200 entregados");

                    Console.WriteLine(retiro / 200);
                    retiro = retiro % 200;
                    Console.WriteLine("billetes de 100 entregados");

                    Console.WriteLine(retiro / 100);
                    retiro = retiro % 100;
                    
                }
                else if (opcion == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("    *********************************************   ");
                    Console.WriteLine("    ****digite el numero de cuenta al cual quieres transferir **   ");
                    Console.WriteLine("    *********************************************   ");
                    Console.WriteLine("\n");
                    
                    transacion = int.Parse(Console.ReadLine());
                    Console.WriteLine("la transferencia fue exitosa, a: " + transacion);
                }

            }

            else if (opcion == 2) 
            {
                Program wii = new Program();
               wii.caja();
            }
            else if (opcion == 3)
            {
                Program wii = new Program();
                wii.caja();
            }





        }
        

           
    void caja()
    {
        int retiro = 0, transacion = 0, opcion;

            Console.WriteLine();
            Console.WriteLine("    *********************************************   ");
            Console.WriteLine("    ****          elija una opcion **   ");
            Console.WriteLine("    *********************************************   ");
            Console.WriteLine("\n");
            Console.WriteLine("[1]retiro");
        Console.WriteLine("[2]transacion");

        opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            if (opcion == 1)
        {

                Console.WriteLine();
                Console.WriteLine("    *********************************************   ");
                Console.WriteLine("    ****          RETIRO **   ");
                Console.WriteLine("    *********************************************   ");
                Console.WriteLine("\n");
                Console.WriteLine("digite el monto: ");
            retiro = int.Parse(Console.ReadLine());
                

                while (retiro > 20000 || retiro < 100)
            {
                Console.WriteLine("no se pude retirar ese monto");
                Console.WriteLine("intente denuevo ");
                retiro = int.Parse(Console.ReadLine());
            }

                Console.WriteLine("billetes de 1000 entregados");

                Console.WriteLine(retiro / 1000);
                retiro = retiro % 1000;
                Console.WriteLine("billetes de 500 entregados");

                Console.WriteLine(retiro / 500);
                retiro = retiro % 500;
                Console.WriteLine("billetes de 200 entregados");

                Console.WriteLine(retiro / 200);
                retiro = retiro % 200;
                Console.WriteLine("billetes de 100 entregados");

                Console.WriteLine(retiro / 100);
                retiro = retiro % 100;
            }
        else if (opcion == 2)
        {
                Console.WriteLine();
                Console.WriteLine("    *********************************************   ");
                Console.WriteLine("    ****digite el numero de cuenta al cual quieres transferir **   ");
                Console.WriteLine("    *********************************************   ");
                Console.WriteLine("\n");
                transacion = int.Parse(Console.ReadLine());
                    Console.WriteLine("la transferencia fue exitosa, a: " + transacion);
        }
            Console.ReadKey();
    }
    }
}
