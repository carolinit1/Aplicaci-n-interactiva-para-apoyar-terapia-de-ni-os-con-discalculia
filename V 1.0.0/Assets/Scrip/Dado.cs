using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//usar interfaz del canvas como botones
using System.Text;


public class Dado : MonoBehaviour

{
	public Text texto;
	public Cara[] caras;
	public int numeroActual;
	public string puntosC;
	public int mensajeGesto;
	public bool val;

	public int contador = 0;


	// Start is called before the first frame update
	void Start()
	{
		numeroDado();
		 contador = 0;

}

	// Update is called once per frame
	void Update()
	{
		


		print(numeroActual);
		

		

	}
	public int numeroDado()
	{
		for (int i = 0; i < caras.Length; i++)
		{

			if (caras[i].tocaSuelo)
			{
				
				numeroActual = 7 - caras[i].valor;
				puntosC = caras[numeroActual - 1].puntos;
				print("toca suelo");

				
  

			}
		}
		Invoke("numeroDado", 1f);
		return numeroActual;
	}
	public void LanzarDado()
	{
		float fuerzaIncial = Random.Range(1, 3);
		GetComponent<Rigidbody>().isKinematic = false;
		GetComponent<Rigidbody>().AddForce(new Vector3(0, fuerzaIncial * 100, 0));
		GetComponent<Rigidbody>().rotation = Random.rotation;
		print("entra y lanzaS");
		


	}

	 public void esUno()

	{

		if (numeroActual == 1)
		{
					

			texto.text = " excelente, cara del dado es uno";
			print("entra");
		}

	}

	public void esDos()

	{


		if (numeroActual == 2)
		{
			texto.text = "excelente, cara del dado es dos";	
			print("entra");
		

			
		}
	}

	public void esTres()

	{

		if (numeroActual == 3)
		{
			texto.text = "excelente, cara del dado es tres";
		

		}
	}

	public void esCuatro()

	{

		if (numeroActual == 4)
		{
			texto.text = "excelente, cara del dado es cuatro";
			

		}
	}
	public void esCinco()

	{
		

		if (numeroActual == 5)
		{
			texto.text = " excelente, cara del dado es cinco";
			print("entra");
			
			
		}

	}

	public void esCero()

	{
		print("entro  en 0");

		

		if (numeroActual == 0 )
		{
			texto.text = " excelente, cara del dado es cero";
		
		}
		print(val+ "validacion");
	}



}
