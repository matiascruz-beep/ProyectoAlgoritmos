
using System;
using System.Collections.Generic;

namespace proyectoAlgoritmos
{
	class Program
	{
		public static void Main(string[] args)
		{
			//creo un jefe de obra
			JefedeObra jefe1 = new JefedeObra("Ignacio","cruz",34343434,5,10000000,"albañil",1300);
			
			//Creo una obra
			Obra obra1 = new Obra("losa","matias cruz",41208008,1,"construccion",20,jefe1,400000);
			
			//Creo Obreros
			Obrero ob1 = new Obrero("juan","cruz",43333333,1,100000,"albañil");
			Obrero ob2 = new Obrero("Marcos","Villarreal",44444555,2,20000,"ayudante");
			
			//Añado obreros a la obra1
			obra1.añadir_Obrero(ob1);
			obra1.añadir_Obrero(ob2);
			
			//creo una lista de obreros
			List<Obrero> lista = new List<Obrero>();
		
			//le asigno a la lista, la lista de obreros de obra1	
			lista = obra1.retornarLista__Obreros();
			
			//recorro la lista para imprimir los datos de los obreros
			for (int i =0; i<lista.Count; i++){
				Console.WriteLine("Nombre del obrero agregado: "+lista[i].getNombre());
			}
			
			//Agrego el jefe de obra a una obra
			obra1.setJefe_Obra(jefe1);
			
			Console.WriteLine(obra1.getJefe_Obra().getNombre());
			
			
				
			Console.ReadKey(true);
		}
	}
}