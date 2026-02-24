Console.WriteLine("Cuantas ventas va a ingresar");
int n=int.Parse(Console.ReadLine());
double ventas=0;
for(int i=0;i<n;i++){
    Console.WriteLine("Ingrese el monto de la venta");
    ventas+=double.Parse(Console.ReadLine());
}
Console.WriteLine("Total en ventas: "+ ventas);

