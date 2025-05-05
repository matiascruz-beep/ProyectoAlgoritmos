using System;
using System.Collections.Generic;

namespace proyectoAlgoritmos
{
	/// <summary>
	/// Description of Empresa.
	/// </summary>
	public class Empresa
	{
		//Atributos
		private List<GrupoObreros> grupos_obreros;
		
		//la empresa debe tener una lista con todos sus obreros.
		private List<Obrero> obreros;
		
		private List<Obra> obras;
		
		//Constructor
		public Empresa()
		{
			grupos_obreros = new List<GrupoObreros>();
			obreros = new List<Obrero>();
			obras = new List<Obra>();	
		}
		
		//Metodos de lista de obreros                                 
		public void añadir_Obrero(Obrero g)
		{obreros.Add(g);}
		
		public void eliminar_Obrero(Obrero g)
		{ obreros.Remove(g);
		}
		
		public int cantidad_Obreros()
		{ return obreros.Count;
		}
		
		public Obrero recuperar_Obrero(int posicion){
			return obreros[posicion];
		}
		
		public bool existeObrero(double legajo){
			int contador_coincidencia = 0;
			for(int i = 0 ; i<obreros.Count ; i++){
				if(obreros[i].getLegajo() == legajo){contador_coincidencia++;}
			}
			if(contador_coincidencia != 0){
				return true;
			}else{return false;}
		}
		
		public List<Obrero> retornarLista_Obreros(){
			List<Obrero> lista = new List<Obrero>();
			for(int i=0 ; i < obreros.Count ; i++){
				lista.Add(obreros[i]);
			}
			return lista;
		}
		
		//Metodos de lista de obras
		public void añadir_Obra(Obra ob)
		{obras.Add(ob);}
		
		public void eliminar_Obra(Obra ob)
		{ obras.Remove(ob);
		}
		
		public int cantidad_Obras()
		{ return obras.Count;
		}
		
		public Obra recuperar_Obra(int posicion){
			return obras[posicion];
		}
		
		public bool existeObra(double cod_int){
			int contador_coincidencia = 0;
			for(int i = 0 ; i < obras.Count ; i++){
				if(obras[i].getCodInt() == cod_int){contador_coincidencia++;}
			}
			if(contador_coincidencia != 0){
				return true;
			}else{return false;}
		}
		
		public List<Obra> retornarLista_Obras(){
			List<Obra> lista = new List<Obra>();
			for(int i=0 ; i < obreros.Count ; i++){
				lista.Add(obras[i]);
			}
			return lista;
		}
		
		
		
	}
}
