
using System;
using System.Collections.Generic;

namespace proyectoAlgoritmos
{
	class Program
	{
		public static void Main(string[] args)
		{
			Obra obra1 = new Obra("losa","matias cruz",41208008,1,"construccion",20,"Nino",400000);
				
			Obrero ob1 = new Obrero("juan","cruz",43333333,1,100000,"albañil");
			Obrero ob2 = new Obrero("Marcos","Villarreal",44444555,2,20000,"ayudante");
			
			obra1.añadir_Obrero(ob1);
			obra1.añadir_Obrero(ob2);
			
			List<Obrero> lista = new List<Obrero>();
			
			lista = obra1.retornarLista__Obreros();
			
			for (int i =0; i<lista.Count; i++){
				Console.WriteLine("Nombre del obrero agregado: "+lista[i].getNombre());
			}
				
			Console.ReadKey(true);
		}
	}
}