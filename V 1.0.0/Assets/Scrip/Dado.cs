using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//usar interfaz del canvas como botones
using System.Text;


public class Dado : MonoBehaviour

{
	public Text texto; //variable el cual mostrará las respuestas del sistema al usuario
	public Cara[] caras; //arreglo que almacena las caras del dado
	public int numeroActual; //numero de la cara en el que cayo el dado
	public string puntosC; //variable almacena los puntos acumulados por el usuario por responder correctamente 



	// Start is called before the first frame update

	void Start()
	{
		numeroDado();
		

}

	// Update is called once per frame
	void Update()
	{
		

		//print para validar la cara del dado
		print(numeroActual);
		

		

	}
	//metodo que valida la acción a llevar según la cara que cayó
	public int numeroDado()
	{
		for (int i = 0; i < caras.Length; i++) //for que recorre las cara para validar en cuál cayó
		{

			if (caras[i].tocaSuelo)
			{
				//numero actual guarda el numero de la cara que cayo, se resta porque se obtiene el valor de la cara del dado que toca el suelo
				numeroActual = 7 - caras[i].valor;
				puntosC = caras[numeroActual - 1].puntos;
				

				
  

			}
		}
		Invoke("numeroDado", 1f); //metodo que actualiza cada segundo el valor de la cara del dado para validar si cambió
		return numeroActual;
	}
	//método que se encarga de manera aleatoria de lanzar el dado con diferentes fuerzas
	public void LanzarDado()
	{
		float fuerzaIncial = Random.Range(1, 3);
		GetComponent<Rigidbody>().isKinematic = false;
		GetComponent<Rigidbody>().AddForce(new Vector3(0, fuerzaIncial * 100, 0));
		GetComponent<Rigidbody>().rotation = Random.rotation;
		


	}
	//metodo que valida si la cara y el gesto con la mano derecha de la persona es uno
	 public void esUno()

	{

		if (numeroActual == 1)
		{
					

			texto.text = " excelente, cara del dado es uno";
			
		}

	}
	//metodo que valida si la cara y el gesto con la mano derecha de la persona es dos

	public void esDos()

	{


		if (numeroActual == 2)
		{
			texto.text = "excelente, cara del dado es dos";	
			
		

			
		}
	}
	//metodo que valida si la cara y el gesto con la mano derecha de la persona es tres

	public void esTres()

	{

		if (numeroActual == 3)
		{
			texto.text = "excelente, cara del dado es tres";
		

		}
	}
		//metodo que valida si la cara y el gesto con la mano derecha de la persona es cuatro


	public void esCuatro()

	{

		if (numeroActual == 4)
		{
			texto.text = "excelente, cara del dado es cuatro";
			

		}
	}
		//metodo que valida si la cara y el gesto con la mano derecha de la persona es cinco

	public void esCinco()

	{
		

		if (numeroActual == 5)
		{
			texto.text = " excelente, cara del dado es cinco";
			print("entra");
			
			
		}

	}
	//metodo que valida si la cara y el gesto con la mano derecha de la persona es cero

	public void esCero()

	{
		print("entro  en 0");

		

		if (numeroActual == 0 )
		{
			texto.text = " excelente, cara del dado es cero";
		
		}
		
	}



}
