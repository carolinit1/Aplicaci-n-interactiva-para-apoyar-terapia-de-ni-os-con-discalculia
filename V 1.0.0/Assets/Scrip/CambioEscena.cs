using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambioEscena : MonoBehaviour {

	[Header("Mensaje Registro")]
	[SerializeField] private Text mensaje = null;

	[Header("Mensaje Login")]
	[SerializeField] private Text mensaje1 = null;

	[Header("Login")]
	[SerializeField] private InputField loginUserEmailInput = null;
	[SerializeField] private InputField loginPasswordInput = null;
	
	[Header("Registro")]
	[SerializeField] private InputField cedulaInput = null;
	[SerializeField] private InputField nombreInput = null;
	[SerializeField] private InputField apellidoInput = null;
	[SerializeField] private InputField especialidadInput = null;
	[SerializeField] private InputField emailInput = null;
	[SerializeField] private InputField passInput = null;
	[SerializeField] private InputField confPassInput = null;

	[Header("Panels")]
	public GameObject registroTerapeutaPanel;
	public GameObject registroAcudientePanel;
	public GameObject registroUsuarioPanel;
	public GameObject loginPanel;
	public GameObject homePanel;
	public GameObject mainPanel;
	public GameObject optionsPanel;
	public GameObject modulosPanel;

	private NetworkManager networkManager = null;

	private void Awake() {

		networkManager = GameObject.FindObjectOfType<NetworkManager>();		
	}

	public void SubmitLogin() {

		if(loginUserEmailInput.text == "" || loginPasswordInput.text == "") {

			mensaje1.text = "Por favor llenar todos los campos";
			return;
		}

		mensaje.text = "Procesando...";

		networkManager.CheckUser(loginUserEmailInput.text, loginPasswordInput.text, delegate(Response response) 
		{
			mensaje1.text = response.message;

			string prueba = ""+mensaje1.text;
				
			if(prueba == "Bienvenido"){
				
				OpenPanel(mainPanel);			
			}
		});	
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

	public void OpenPanel(GameObject panel) {

		registroTerapeutaPanel.SetActive(false);
		registroAcudientePanel.SetActive(false);
		registroUsuarioPanel.SetActive(false);
		loginPanel.SetActive(false);
		homePanel.SetActive(false);
		mainPanel.SetActive(false);
		optionsPanel.SetActive(false);
		modulosPanel.SetActive(false);

		panel.SetActive(true);
	}
}
