using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gestos : MonoBehaviour
{
   
    [SerializeField]
    public Cubo[] miCubo; //arreglo que guarda las posiciones de las caras del dado
    int posicionSeleccionada; 
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //s
    //metodo que mueve los dados a la casiila de resultado para validas si es correcta
    public void detectarGestoResultado()
    {
        miCubo[0].moverDadoResultado();
        miCubo[1].moverDadoResultado();
        miCubo[2].moverDadoResultado();
    }
 //metodo  que retornma el dado 0 a la posicion de origen sacandolo de la casilla de respuesta
    public void detectarGesto1_Origen()
    {
        miCubo[0].moverDado();
        miCubo[1].moverDadoResultado();
        miCubo[2].moverDadoResultado();
        posicionSeleccionada = 0;

    }
 //metodo  que retornma el dado 1 a la posicion de origen sacandolo de la casilla de respuesta

    public void detectarGesto2_Origen()
    {
        miCubo[1].moverDado();
        miCubo[0].moverDadoResultado();
        miCubo[2].moverDadoResultado();
        posicionSeleccionada = 1;
    }
 //metodo  que retornma el dado 2 a la posicion de origen sacandolo de la casilla de respuesta

    public void detectarGesto3_Origen()
    {
        miCubo[2].moverDado();
        miCubo[0].moverDadoResultado();
        miCubo[1].moverDadoResultado();
        posicionSeleccionada = 2;
    }
// metod que valida si el dado que esta en la casilla de respuesta es la correspondiente a la respuesta correcta de la suma
    public void seleccionRespuesta()
    {
        miCubo[posicionSeleccionada].validarRespuesta();
        ///Invoke("seleccionRespuesta", 2f);
    }
    
   

    
}