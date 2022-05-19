using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 posInicial;
    Vector3 posRespuesta = new Vector3(-0.234999999f,0.400999993f,0.34799999f);

    public bool respuestaC = false;
    public int valor;

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

    public void moverDadoResultado()
    {
        transform.position = posInicial;
    }

    public void moverDado()
    {
        transform.position = posRespuesta;
    }

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
