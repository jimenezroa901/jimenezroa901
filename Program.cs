// See https://aka.ms/new-console-template for more information
int np = 0, p2 = 0, p1 = 0, nu = 0;

double total = 0, tv = 0, resultado = 0;



Console.WriteLine("numero de usuarios");
nu = int.Parse(Console.ReadLine());

for (int i = 0; i < nu; i++)
{
    Console.WriteLine("digite el valor del producto porfavor");
    p1 = int.Parse(Console.ReadLine());

    Console.WriteLine("digite el valor del producto porfavor");
    p2 = int.Parse(Console.ReadLine());
    resultado = p1 + p2;

    if (resultado <= 100.000)
    {
        total = resultado * 0.05;
        Console.WriteLine(" el total a pagar es" + total);
        tv++;
    }


    else if (resultado > 100000 || resultado <= 400000)
    {
        total = resultado * 0.07;
        Console.WriteLine("el total a pagar es de " + total);
        tv++;
    }


    if (resultado > 400000 || resultado <= 900000)
    {

        total = resultado * 0.12;
        Console.WriteLine("el total a pagar es de " + total);
        tv++;
    }


    else
    {
        total = resultado * 0.15;
        Console.WriteLine("el total a pagar es de " + total);
        tv++;

    }
}
Console.WriteLine("el total de ventas es de " + tv);