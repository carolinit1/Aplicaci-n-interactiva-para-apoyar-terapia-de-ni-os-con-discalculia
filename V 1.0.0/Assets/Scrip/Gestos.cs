using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gestos : MonoBehaviour
{
   
    [SerializeField]
    public Cubo[] miCubo;
    int posicionSeleccionada;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void detectarGestoResultado()
    {
        miCubo[0].moverDadoResultado();
        miCubo[1].moverDadoResultado();
        miCubo[2].moverDadoResultado();
    }

    public void detectarGesto1_Origen()
    {
        miCubo[0].moverDado();
        miCubo[1].moverDadoResultado();
        miCubo[2].moverDadoResultado();
        posicionSeleccionada = 0;

    }

    public void detectarGesto2_Origen()
    {
        miCubo[1].moverDado();
        miCubo[0].moverDadoResultado();
        miCubo[2].moverDadoResultado();
        posicionSeleccionada = 1;
    }

    public void detectarGesto3_Origen()
    {
        miCubo[2].moverDado();
        miCubo[0].moverDadoResultado();
        miCubo[1].moverDadoResultado();
        posicionSeleccionada = 2;
    }

    public void seleccionRespuesta()
    {
        miCubo[posicionSeleccionada].validarRespuesta();
        ///Invoke("seleccionRespuesta", 2f);
    }
    
   

    
}