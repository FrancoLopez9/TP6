using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank banco = new Bank();
            
            Console.WriteLine("***********  BANCO  ************");
            Console.WriteLine("Seleccione una opcion: ");
            Console.WriteLine("1: ABRIR CUENTA");
            Console.WriteLine("2: REGISTRAR MOVIMIENTO");
            Console.WriteLine("3: INFORMACION SUMARIA DE CUENTAS DE UN CLIENTE");
            Console.WriteLine("4: OBTENER ULTIMOS MOVIMIENTOS DE CUENTA DE UN CLIENTE");
            Console.WriteLine("5: OBTENER CUENTAS EN ROJO");

            int value = System.Convert.ToInt32(Console.ReadLine());

            switch(value)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("***********  BANCO  ************");
                    Console.WriteLine("Especifique su id de cliente");
                    int idCliente1 = System.Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Especifique nombre de la cuenta");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Especifique limite del descubierto");
                    double descubierto = System.Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ABRIENDO CUENTA..........");
                    banco.OppenAccount(idCliente1, nombre, descubierto);
                    Console.WriteLine("CUENTA ABIERTA CON EXITO");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("***********  BANCO  ************");
                    Console.WriteLine("Especifique su id de cuenta");
                    int idCuenta1 = System.Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Especifique descripcion del movimiento");
                    string descripcion = Console.ReadLine();
                    Console.WriteLine("Especifique cantidad del movimiento");
                    double cantidad = System.Convert.ToDouble(Console.ReadLine());
                    banco.MakeMovement(idCuenta1, descripcion, cantidad);
                    Console.WriteLine("MOVIMIENTO REALIZADO CON EXITO");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("***********  BANCO  ************");
                    Console.WriteLine("Especifique su id de cliente");
                    int idCliente = System.Convert.ToInt32(Console.ReadLine());
                    foreach (var cuentas in banco.GetClientAccounts(idCliente))
                    {
                        Console.WriteLine("****************************");
                        Console.WriteLine("Id: {0}, Nombre: {1}, Limite de descubierto: {2}, Balance: {3}",
                        cuentas.Id,
                        cuentas.Name,
                        cuentas.OverDraftLimit,
                        cuentas.Balance);
                        Console.WriteLine("****************************");
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("***********  BANCO  ************");
                    Console.WriteLine("Especifique su id de cuenta");
                    int idCuenta2 = System.Convert.ToInt32(Console.ReadLine());
                    foreach (var movimientos in banco.GetAccountMovements(idCuenta2))
                    {
                        Console.WriteLine("****************************");
                        Console.WriteLine("Id: {0}, Fecha: {1}, Descripcion: {2}, Cantidad: {3}",
                        movimientos.Id,
                        movimientos.Date,
                        movimientos.Description,
                        movimientos.Amount);
                        Console.WriteLine("****************************");
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("***********  BANCO  ************");
                    Console.WriteLine("OBTENIENDO CUENTAS EN ROJO.......");
                    foreach (var cuentas in banco.GetOverDrawnAccounts())
                    {
                        Console.WriteLine("****************************");
                        Console.WriteLine("Id: {0}, Nombre: {1}, Limite de descubierto: {2}, Balance: {3}",
                        cuentas.Id,
                        cuentas.Name,
                        cuentas.OverDraftLimit,
                        cuentas.Balance);
                        Console.WriteLine("****************************");
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                    break;
                     
            }
        }
    }
}
