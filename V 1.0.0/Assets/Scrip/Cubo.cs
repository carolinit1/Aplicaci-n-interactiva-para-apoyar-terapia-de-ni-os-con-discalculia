using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 posInicial; //variable de vector en el cual empieza el dado al inicial el juego
    Vector3 posRespuesta = new Vector3(-0.234999999f,0.400999993f,0.34799999f);  //posicion a la cual se movera el dado

    public bool respuestaC = false;
   

    public GameObject sonidoCorrecto;
    public GameObject sonidoIncorrecto;
    
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.3f, 0);
    }
    //guardo el resultado en vectores de donde quedo el dado ubicado luego de moverlo
    public void moverDadoResultado()
    {
        transform.position = posInicial;
    }
    //metodo para mover el dado a traves de transformar su posicion en vectores
    public void moverDado()
    {
        transform.position = posRespuesta;
    }
    //metodos para validar si la respuesta dada por el usuario es correcta, con el fin de saber qué sonido reproducir
    public void validarRespuesta()
    {
        if (validarComponenteTransform() && respuestaC == true)
        {
            Instantiate(sonidoCorrecto);
        }
        else
        {
            Instantiate(sonidoIncorrecto);
        }
    }
//metodo que valida si el dado se movio
    private bool validarComponenteTransform()
    {
        if ( Mathf.Approximately(transform.position.x, posRespuesta.x )&& Mathf.Approximately(transform.position.y, posRespuesta.y) && Mathf.Approximately(transform.position.z, posRespuesta.z) )
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    
}
