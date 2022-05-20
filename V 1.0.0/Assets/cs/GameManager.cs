using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//usar interfaz del canvas como botones




public class GameManager : MonoBehaviour
{
	public Text texto;

    // Start is called before the first frame update

    public Tabla[] listaTablas = new Tabla[2];

    public bool valido;
    
    public Text texto2;
		

     Vector3 posRespuesta = new Vector3(9.92000008f,0f,3.69000006f);
    




    void Start()
    {
	
  
    }

    // Update is called once per frame
    void Update()
    {

    }

	IEnumerator esperar()
    {
 	 yield return new WaitForSeconds (3);

	}
	


    public void pressboton1()
    {
        texto.text = "incorrecto esta tabla no es del mismo tamaño que la de muestra, toca el boton de nuevo para devolvier la ficha al su lugar ";
  	


        print("Boton 1 presionado");
        if (listaTablas[0].selecionado == true)
        {
           




            listaTablas[0].moverPosicionInicial();
 		listaTablas[0].moverPosicionInicial();
            listaTablas[0].selecionado = false;
            valido = false;


        }
        else
        {
            listaTablas[0].moverPosicion();
            listaTablas[0].selecionado = true;

        }

    }

    public void pressboton2()
    {
        texto.text = "incorrecto esta tabla no es del mismo tamaño que la de muestra, toca el boton de nuevo para devolvier la ficha al su lugar ";

        transform.position = posRespuesta;
        print("Boton 2 presionado");
        if (listaTablas[1].selecionado == true)
        {
            transform.position = posRespuesta;

         
          

            esperar();

            listaTablas[1].moverPosicionInicial();

            listaTablas[1].selecionado = false;
            valido = false;
        }
        else
        {
            listaTablas[1].moverPosicion();
            listaTablas[1].selecionado = true;

        }
    }
    public void pressboton3()
    {

        texto.text = "excelente, las tablas  son del mismo tamaño, presiona el boton siguiente";

        transform.position = posRespuesta;
        print("Boton 3 presionado");
        if (listaTablas[2].selecionado == true)
        {

            transform.position = posRespuesta;
            listaTablas[2].moverPosicionInicial();
            listaTablas[2].selecionado = false;
            valido = true;
        }
        else
        {
            listaTablas[2].moverPosicion();
            listaTablas[2].selecionado = true;


        }
    }

}

