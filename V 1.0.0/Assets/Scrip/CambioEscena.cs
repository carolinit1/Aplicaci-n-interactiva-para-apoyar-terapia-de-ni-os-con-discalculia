using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class CambioEscena : MonoBehaviour {

	[Header("Mensaje Registro Terapeuta")]
	[SerializeField] private Text mensajeTerapeuta = null;

	[Header("Mensaje Registro Acudiente")]
	[SerializeField] private Text mensajeAcudiente = null;

	[Header("Mensaje Registro Jugador")]
	[SerializeField] private Text mensajeJugador = null;

	[Header("Mensaje Login")]
	[SerializeField] private Text mensajeLogin = null;

	[Header("Login")]
	[SerializeField] private InputField loginUserEmailInput = null;
	[SerializeField] private InputField loginPasswordInput = null;
	
	[Header("Registro Terapeuta")]
	[SerializeField] private InputField cedulaInput = null;
	[SerializeField] private InputField nombreInput = null;
	[SerializeField] private InputField apellidoInput = null;
	[SerializeField] private InputField especialidadInput = null;
	[SerializeField] private InputField emailInput = null;
	[SerializeField] private InputField passInput = null;
	[SerializeField] private InputField confPassInput = null;

	[Header("Registro Acudiente")]
	[SerializeField] private InputField cedulaAcudienteInput = null;
	[SerializeField] private InputField nombreAcudienteInput = null;
	[SerializeField] private InputField apellidoAcudienteInput = null;
	[SerializeField] private InputField parentescoAcudienteInput = null;
	[SerializeField] private InputField celularAcudienteInput = null;
	[SerializeField] private InputField correoAcudienteInput = null;
	[SerializeField] private InputField direccionAcudienteInput = null;

	[Header("Registro Jugador")]
	[SerializeField] private InputField idJugadorInput = null;
	[SerializeField] private InputField nombreJugadorInput = null;
	[SerializeField] private InputField apellidoJugadorInput = null;
	[SerializeField] private InputField edadJugadorInput = null;
	[SerializeField] private InputField n_sesiones_asignadasJugadorInput = null;
	[SerializeField] private InputField cedula_terapeutaInput = null;
	[SerializeField] private InputField cedula_acudienteInput = null;
	[SerializeField] private InputField diagnosticoJugadorInput = null;

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

			mensajeLogin.text = "Por favor llenar todos los campos";
			return;
		}

		mensajeLogin.text = "Procesando...";

		networkManager.CheckUser(loginUserEmailInput.text, loginPasswordInput.text, delegate(Response response) 
		{
			mensajeLogin.text = response.message;

			string prueba = ""+mensajeLogin.text;
				
			if(prueba == "Bienvenido"){
				
				OpenPanel(mainPanel);			
			}
		});	
	}

	public void SubmitRegistro() {
		
		if(cedulaInput.text == "" || nombreInput.text == "" || apellidoInput.text == "" || especialidadInput.text == "" || emailInput.text == "" || passInput.text == "" || confPassInput.text == "") {

			mensajeTerapeuta.text = "Por favor llenar todos los campos";
			return;
		}

		if(passInput.text == confPassInput.text) {

			mensajeTerapeuta.text = "Procesando...";

			networkManager.CreateUser(cedulaInput.text, nombreInput.text, apellidoInput.text, especialidadInput.text, emailInput.text, passInput.text, delegate(Response response) 
			{
				mensajeTerapeuta.text = response.message;
			});
		}
		else {

			mensajeTerapeuta.text = "Las contraseñas son diferentes, por favor verificar";
		}
	}

	public void SubmitRegistroJugador() {
		
		if(idJugadorInput.text == "" || nombreJugadorInput.text == "" || apellidoJugadorInput.text == "" || edadJugadorInput.text == "" || n_sesiones_asignadasJugadorInput.text == "" || cedula_terapeutaInput.text == "" || cedula_acudienteInput.text == "" || diagnosticoJugadorInput.text == "") {

			mensajeJugador.text = "Por favor llenar todos los campos";
			return;
		}

		mensajeJugador.text = "Procesando...";

		networkManager.CreateJugador(Int32.Parse(idJugadorInput.text), nombreJugadorInput.text, apellidoJugadorInput.text, Int32.Parse(edadJugadorInput.text), Int32.Parse(n_sesiones_asignadasJugadorInput.text), Int32.Parse(cedula_terapeutaInput.text), Int32.Parse(cedula_acudienteInput.text), diagnosticoJugadorInput.text, delegate(Response response) 
		{
			mensajeJugador.text = response.message;
		});
	}

	public void SubmitRegistroAcudiente() {
		
		if(cedulaAcudienteInput.text == "" || nombreAcudienteInput.text == "" || apellidoAcudienteInput.text == "" || parentescoAcudienteInput.text == "" || celularAcudienteInput.text == "" || correoAcudienteInput.text == "" || direccionAcudienteInput.text == "") {

			mensajeAcudiente.text = "Por favor llenar todos los campos";
			return;
		}

		mensajeAcudiente.text = "Procesando...";

		networkManager.CreateAcudiente(Int32.Parse(cedulaAcudienteInput.text), nombreAcudienteInput.text, apellidoAcudienteInput.text, parentescoAcudienteInput.text, Int32.Parse(celularAcudienteInput.text), correoAcudienteInput.text, direccionAcudienteInput.text, delegate(Response response) 
		{
			mensajeAcudiente.text = response.message;
		});
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
