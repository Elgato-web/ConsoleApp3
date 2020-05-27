utilizando el  sistema ;
utilizando el  sistema.Colecciones.Genérico ;
utilizando el  sistema.Linq ;
utilizando el  sistema.Threading.tareas ;
utilizando el  sistema.Ventanas.Formularios ;

espacio de nombres AppCons_test2
{
	Programa de clase estática
	{
		/// Punto de entrada principal para la aplicación.
		[STAThread]
		vacío estático Main()
		{
			int a; a = 10;
			int b; b = 20;
			Consola.WriteLine(" El producto de {0} X {1} es: {2} ", a, b, (a * b));
			Consola.WriteLine(" Pulse una tecla para continuar ... ");
			Consola.ReadKey();

			// Condicionales

			si(a > b)
			{
				Consola.WriteLine(" {0} es mayor ", a);
			}
			más
			{
				Consola.WriteLine(" {0} es mayor ", b);
			}
			Consola.WriteLine(" Pulse una tecla para continuar ... ");
			Consola.ReadKey();

			// Bucle While
			int j = 1;
			mientras que(j  <= 10 )
			{
				j++;
				Consola.WriteLine(" {0} Bienvenidos a Git ", j);
			}
			Consola.WriteLine(" Pulse una tecla para continuar ... ");
			Consola.ReadKey();

			// Agregar el bucle para (commit-sincronizar)
			para(int  i = 1 ; i <= 10; i++ )
            {
				Consola.WriteLine(" {0} Bienvenidos a Git ", i);
			}
			Consola.WriteLine(" Pulse una tecla para continuar ... ");
			Consola.ReadKey();

			// Agregar bucle foreach (commit-sincronizar)
			var numeros = nueva  Lista<int> { 0 , 1 , 1 , 2 , 3 , 5 , 8 , 13 };
			int contador = 0;
			foreach (elemento int  en numeros )  
			{
				contador++;
				Consola.WriteLine( $ " Elemento # { contador }: { elemento } ");
			}
			Consola.WriteLine( $ " Número de elementos: { contador } ");
			Consola.WriteLine(" Pulse una tecla para continuar ... ");
		/Consola.ReadKey()/ Desde repositorio /re
		}
	}
}
