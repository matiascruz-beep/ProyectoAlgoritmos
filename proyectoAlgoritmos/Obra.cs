using System;
using System.Collections.Generic;
namespace proyectoAlgoritmos
{
	/// <summary>
	/// Description of Obra.
	/// </summary>
	public class Obra
	{
		//atributos
		private string nombre;
		private string propietario;
		private double dni;
		private double codigo_interno;
		private string tipo_Obra;
		private int estado_avance;
		private JefedeObra jefe_Obra;
		private double costo;
		private List<Obrero> grupo_Obreros;
		
		public Obra(string nom, string prop, double dni, double cod_int, string tipo_obra,int est_avance, JefedeObra jefe, double costo)
		{
			this.nombre = nom;
			this.propietario = prop;
			this.dni = dni;
			this.codigo_interno = cod_int;
			this.tipo_Obra = tipo_obra;
			this.estado_avance = est_avance;
			this.jefe_Obra = jefe;
			this.costo = costo;
			grupo_Obreros = new List<Obrero>();
		}
		
		//metodos
		public string getNombre(){return this.nombre;}
		
		public void setNombre(string nom){this.nombre = nom;}
		
		public string getPropietario(){return this.propietario;}
		
		public void setPropietario(string prop){this.propietario = prop;}
		
		public double getDni(){return this.dni;}
		
		public void setDni(double dni){this.dni = dni;}
		
		public double getCodInt(){return this.codigo_interno;}
		
		public void setCodInt(double cod){this.codigo_interno = cod;}
		
		public string getTipo_Obra(){return this.tipo_Obra;}
		
		public void setTipo_Obra(string tipo_ob){this.tipo_Obra = tipo_ob;}
		
		public int getEst_Avance(){return this.estado_avance;}
		
		public void setEst_Avance(int estado_av){this.estado_avance = estado_av;}
		
		public JefedeObra getJefe_Obra(){return this.jefe_Obra;}
		
		public void setJefe_Obra(JefedeObra jefe){this.jefe_Obra = jefe;}
		
		
		//Metodos del array
		public void añadir_Obrero(Obrero a)
		{ grupo_Obreros.Add(a);
		}
		
		public void eliminar_Obrero(Obrero a)
		{ grupo_Obreros.Remove(a);
		}
		
		public int cantidad_Obreros()
		{ return grupo_Obreros.Count;
		}
		
		public Obrero RecuperarObrero(int posicion){
			return grupo_Obreros[posicion];
		}
		
		public bool existe__Obrero(double legajo){
			int contador_coincidencia = 0;
			for(int i = 0 ; i < grupo_Obreros.Count ; i++){
				if(grupo_Obreros[i].getLegajo() == legajo){contador_coincidencia++;}
			}
			if(contador_coincidencia != 0){
				return true;
			}else{return false;}
		}
		
		public List<Obrero> retornarLista__Obreros(){
			List<Obrero> lista = new List<Obrero>();
			for(int i=0 ; i < grupo_Obreros.Count ; i++){
				lista.Add(grupo_Obreros[i]);
			}
			return lista;
		}
		
		
		
		
	}
}
