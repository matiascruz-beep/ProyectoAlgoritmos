using System;

namespace proyectoAlgoritmos
{
	/// <summary>
	/// Description of JefedeObra.
	/// </summary>
	public class JefedeObra : Obrero
	{
		double bonificacion_Especial;
		public JefedeObra(double bon_esp) : base(nom,  ape,  dni,  legajo,  sueldo,  cargo)
		{
			this.bonificacion_Especial = bon_esp;
		}
	}
}
