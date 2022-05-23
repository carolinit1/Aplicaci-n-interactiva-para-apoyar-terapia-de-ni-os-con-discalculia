using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text UItexto;  //variable encargada de mostrar el tiempo que pasa
    private int contador = 0; //variable para guardar el valor final del tiempo transcurrido durante el juego 

    private void Awake()
    {
        InvokeRepeating("Cronometro", 0f, 1f); //metodo que actualiza el tiempo cada segundo
    }

    // Update is called once per frame
    void Cronometro()
    {
        contador++; //acumula los segundos
        UItexto.text = contador.ToString() + " Seg"; //muestra el tiempo
    }
}
