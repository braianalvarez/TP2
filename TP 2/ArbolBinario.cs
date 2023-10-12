/*
 * Created by SharpDevelop.
 * User: Braian
 * Date: 27/8/2023
 * Time: 16:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace Clase_I_complijidad
{
	/// <summary>
	/// Description of ArbolBinario.
	/// </summary>
	public class ArbolBinario<T>
	{
		
		
		
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		public bool NoesHoja() {
			return this.hijoIzquierdo!=null && this.hijoDerecho!=null;
		}
		
		public void inorden() {
			
			if(this.hijoIzquierdo != null)
				
				this.hijoIzquierdo.inorden();
			
			Console.Write(this.getDatoRaiz());
			
			
			if(this.hijoDerecho != null)
				
				this.hijoDerecho.inorden();

		}
		
		public void preorden()
		{
			Console.Write(this.getDatoRaiz());
			
			
			if(this.hijoIzquierdo != null)
				
				this.hijoIzquierdo.preorden();
			
					
			
			if(this.hijoDerecho != null)
				
				this.hijoDerecho.preorden();
		}
		
		public void postorden() 
		{
			
			
			
			if(this.hijoIzquierdo != null)
				
				this.hijoIzquierdo.inorden();
			
					
			
			if(this.hijoDerecho != null)
				
				this.hijoDerecho.inorden();
			
			Console.Write(this.getDatoRaiz());
		}
		
		public void recorridoPorNiveles() 
		{
			
			Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>(); //instanciamos la cola
			ArbolBinario<T> arbolAux; // no instanciamos porque ya existe el arbol a usar
			 
			//encolar el arbol
			c.encolar(this);
			
			
				
			//mientras la cola no este vacia 
			while (!c.esVacia())
			{
				//desencolamos
				arbolAux = c.desencolar();
				
				Console.Write(arbolAux.dato);
				
				//si tiene hijo izquierdo
				if (arbolAux.getHijoIzquierdo() != null) 
				{
					// lo encolo
					c.encolar(arbolAux.getHijoIzquierdo());
				}
				
				//si tiene hijo derecho
				if (arbolAux.getHijoDerecho() != null) 
				{
					// lo encolo
					c.encolar(arbolAux.getHijoDerecho());
				}
				
				
			}
		}
	
		public int contarHojas() {
			return 0;
		}
		
		
		
		public void recorridoporNivelesconSeparador() //la diferencia es que va contando los niveles
		{
		
			Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>(); //instanciamos la cola
			ArbolBinario<T> arbolAux; // no instanciamos porque ya existe el arbol a usar
			 
			//agregamos el contador que es lo que difiere de recorrido por niveles
			int nivel= 0;
			
			//encolar el arbol
			c.encolar(this);
			
			//encolo el separador
			
			c.encolar(null);
			Console.WriteLine("Nivel {0}",nivel);
				
			//mientras la cola no este vacia 
			while (!c.esVacia())
			{
				
				//desencolamos
				arbolAux = c.desencolar();
				
				//chequeo si es un arbol o un separador
				
				if(arbolAux != null)
				{
					
					
					if (arbolAux.getHijoIzquierdo() != null) 
					{
						// lo encolo
						c.encolar(arbolAux.getHijoIzquierdo());
						
					}
				
				      //si tiene hijo derecho
					if (arbolAux.getHijoDerecho() != null) 
					{
						// lo encolo
						c.encolar(arbolAux.getHijoDerecho());
						
					}
					
					Console.Write(arbolAux.getDatoRaiz() + " ");
					
				}else
				{//es un nodo
					
					nivel ++;
					if (!c.esVacia()) {
						c.encolar(null);
						Console.WriteLine("");
						Console.WriteLine("Nivel {0}",nivel);
						
					}
				
				}
				
				
				
			}
			
		}
		
		
		public void recorridoentreNiveles(int n, int m) //la diferencia es que va contando los niveles
		{
		
			Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>(); //instanciamos la cola
			ArbolBinario<T> arbolAux; // no instanciamos porque ya existe el arbol a usar	
			int nivel= 0; //agregamos el contador que es lo que difiere de recorrido por niveles

			c.encolar(this); //encolar el arbol
			c.encolar(null); //encolo el separador
			
				
			//mientras la cola no este vacia 
			while (!c.esVacia())
			{
				//desencolamos
				arbolAux = c.desencolar();
				
				//chequeo si es un arbol o un separador
				
				if(arbolAux != null)
				{
					if (nivel >= n && nivel <= m) 
					{
						Console.Write(arbolAux.getDatoRaiz() + " ");	
					}
					if (arbolAux.getHijoIzquierdo() != null) 
					{
						// lo encolo
						c.encolar(arbolAux.getHijoIzquierdo());
					}
				
				      //si tiene hijo derecho
					if (arbolAux.getHijoDerecho() != null) 
					{
						// lo encolo
						c.encolar(arbolAux.getHijoDerecho());
					}
				}else{
					
					nivel ++;
					if (!c.esVacia()) {
						c.encolar(null);
					}
				
				
				
				}
				
				
				
				
			}
			
		}
		
		
		
		
		//TP1
		public List<T> resolver(int longitud)
		{
			
			List<T> camino = new List<T>();
			
			return _resolver(longitud ,this, camino);
				
		}
		
		private List<T> _resolver(int longitud, ArbolBinario<T> arbol,List<T> camino)
		{
			
		
				if (this.hijoIzquierdo != null) {
				this.hijoIzquierdo._resolver(longitud-1 ,this, camino);
				}
			
				if (camino.Count > 0) {
					camino.Add(this.getDatoRaiz());
					return camino;	
					
					}	
				if (this.hijoDerecho != null){
				this.hijoDerecho._resolver(longitud - 1 ,this, camino);
					
				}
			
				if (camino.Count > 0) {
					camino.Add(this.getDatoRaiz());
					return camino;	
					
				}
			
					
					if (this.hijoIzquierdo == null && this.hijoDerecho == null && longitud == 0) {
						camino.Add(this.getDatoRaiz());
						return camino;	
					}
				
			
			
				
				
			
			
			
			
				
			
			return camino;
		}
			
			
		
		
		
	
	}
	
	
}
