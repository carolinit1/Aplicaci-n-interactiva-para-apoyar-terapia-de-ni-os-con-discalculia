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
	public GameObject mainPanel;
	public GameObject optionsPanel;
	public GameObject moduloSelectPanel;

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

	public void OpenePanel(GameObject panel) {

		mainPanel.SetActive(false);
		optionsPanel.SetActive(false);
		moduloSelectPanel.SetActive(false);

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
