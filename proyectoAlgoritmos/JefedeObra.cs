using System;

namespace proyectoAlgoritmos
{

	public class JefedeObra : Obrero
	{
		//Atributos
		private double bonificacion_Especial;
		
		//Construtor
		public JefedeObra(string nom, string ape, double dni, double legajo, double sueldo, string cargo, double bon_esp) : base(nom,  ape,  dni,  legajo,  sueldo,  cargo)
		{
			this.bonificacion_Especial = bon_esp;
		}
		
		//Metodos
		
		public double getBonificacion(){
			return this.bonificacion_Especial;
		}
		public void setBonificacion(double b){
			this.bonificacion_Especial = b;
		}
	}
}
