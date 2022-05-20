using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabla : MonoBehaviour
{

    Vector3 posInicial;
    public int valorTabla;
    public bool selecionado;

    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void moverPosicion()
    {
          transform.position = new Vector3(6.93000021f,0f,3.7f);
    }


    public void moverPosicionInicial ()
    {
        transform.position = posInicial;
    }
}
