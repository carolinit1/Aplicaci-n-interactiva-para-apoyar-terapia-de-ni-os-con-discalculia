using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//clase que se utiliza para tocar el botón con el fin de pasar a la siguiente escena
public class ClickBoton : MonoBehaviour
{
	public void clickBoton(string scenaName) {

		SceneManager.LoadScene(scenaName);
	}
}
