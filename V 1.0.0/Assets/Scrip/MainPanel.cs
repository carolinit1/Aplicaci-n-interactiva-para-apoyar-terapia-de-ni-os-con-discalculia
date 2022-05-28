using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainPanel : MonoBehaviour
{
	[Header("Options")]
	public Slider volumenFX;
	public Slider volumenMaster;
	public Toggle mute;
	public AudioMixer mixer;
	public AudioSource fxSource;
	public AudioClip clickSound;
	public float lastVolumen;

	[Header("Panels")]
	public GameObject registroTerapeutaPanel;
	public GameObject registroAcudientePanel;
	public GameObject registroUsuarioPanel;
	public GameObject loginPanel;
	public GameObject homePanel;
	public GameObject mainPanel;
	public GameObject optionsPanel;
	public GameObject modulosPanel;

	private void Awake() {

		volumenFX.onValueChanged.AddListener(ChangeVolumeFX);
		volumenMaster.onValueChanged.AddListener(ChangeVolumeMaster);
	}

	public void PlayModulo(string moduloName) {

		SceneManager.LoadScene(moduloName);
	}

	public void SetMute() {

		
		if(mute.isOn) {

			mixer.GetFloat("volMaster", out lastVolumen);
			mixer.SetFloat("volMaster", -80);
		}
		else {

			mixer.SetFloat("volMaster", lastVolumen);
		}
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
		PlaySoundButton();
	}

	public void ChangeVolumeMaster(float v) {

		mixer.SetFloat("volMaster", v);
	}

	public void ChangeVolumeFX(float v) {

		mixer.SetFloat("volFX", v);
	}

	public void PlaySoundButton() {

		fxSource.PlayOneShot(clickSound);
	}
    
}
