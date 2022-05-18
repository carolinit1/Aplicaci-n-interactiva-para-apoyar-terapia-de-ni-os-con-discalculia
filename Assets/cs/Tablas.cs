using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablas : MonoBehaviour
{
    public int valor;
    public bool tocaSuelo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "val")
        {
            tocaSuelo = true;
            valor += valor;

            print(valor);
        }

    }
    void OnTriggerExit(Collider col)
    {

        tocaSuelo = false;


    }
}
