using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Validacion : MonoBehaviour
{
    public Tablas tabla;


    // Start is called before the first frame update
    void Start()
    {
        valorTablas();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void valorTablas()
    {



        if (tabla.tocaSuelo == true)
        {

            if (tabla.valor == 5)
            {

                print("corecto");

            }


        }

        Invoke("valorTablas", 2f);
    }

    public void mensaje()
    {

        print("hola mundo");

    }
}
