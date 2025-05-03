/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 2/5/2025
 * Time: 21:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyectoAlgoritmos
{
	/// <summary>
	/// Description of Obrero.
	/// </summary>
	public class Obrero
	{
		//atributos
		string nombre;
		string apellido;
		double dni;
		double legajo;
		double sueldo;
		string cargo;
		
		//constructor
		public Obrero(string nom, string ape, double dni, double legajo, double sueldo, string cargo)
		{
			this.nombre = nom;
			this apellido = ape;
			this.dni = dni;
			this.legajo = legajo;
			this.sueldo = sueldo;
			this.cargo = cargo;
		}
		
		//metodos
		
		public string getNombre(){return this.nombre;}
		
		public void setNombre(string nom){this.nombre = nom;}
		
		public string getapellido(){return this.apellido;}
		
		public void setApellido(string ape){this.apellido = ape;}
		
		public double getDni(){return this.dni;}
		
		public void setDni(double dni){this.dni = dni;}
		
		public double getLegajo(){return this.legajo;}
		
		public void setLegajo(double leg){this.legajo = leg;}
		
		public double getSueldo(){return this.sueldo;}
		
		public void setSueldo(double s){this.sueldo = s;}
		
		public string getCargo(){return this.cargo;}
		
		public void setCargo(string carg){this.cargo = carg;}
	}
}
