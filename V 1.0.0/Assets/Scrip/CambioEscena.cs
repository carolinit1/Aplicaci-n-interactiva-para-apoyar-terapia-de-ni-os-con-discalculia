using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambioEscena : MonoBehaviour {

	[SerializeField] private Text mensaje = null;
	
	[SerializeField] private InputField cedulaInput = null;
	[SerializeField] private InputField nombreInput = null;
	[SerializeField] private InputField apellidoInput = null;
	[SerializeField] private InputField especialidadInput = null;
	[SerializeField] private InputField emailInput = null;
	[SerializeField] private InputField passInput = null;
	[SerializeField] private InputField confPassInput = null;

	private NetworkManager networkManager = null;

	private void Awake() {

		networkManager = GameObject.FindObjectOfType<NetworkManager>();		
	}

	public void SubmitRegistro() {
		
		if(cedulaInput.text == "" || nombreInput.text == "" || apellidoInput.text == "" || especialidadInput.text == "" || emailInput.text == "" || passInput.text == "" || confPassInput.text == "") {

			mensaje.text = "Por favor llenar todos los campos";
			return;
		}

		if(passInput.text == confPassInput.text) {

			mensaje.text = "Procesando...";

			networkManager.CreateUser(cedulaInput.text, nombreInput.text, apellidoInput.text, especialidadInput.text, emailInput.text, passInput.text, delegate(Response response) 
			{
				mensaje.text = response.message;
			});
		}
		else {

			mensaje.text = "Las contraseñas son diferentes, por favor verificar";
		}
	}

	
    public void LoadScene(string sceneName) {

        SceneManager.LoadScene(sceneName);
    }
}
