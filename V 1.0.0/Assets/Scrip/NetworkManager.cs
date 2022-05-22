using System;
using System.Collections;
using UnityEngine;

public class NetworkManager : MonoBehaviour {

	public void CheckUser(string email, string pass, Action<Response> response) {

		StartCoroutine(CO_CheckUser (email, pass, response));
	}

	private IEnumerator CO_CheckUser(string email, string pass, Action<Response> response) {
		
		WWWForm form = new WWWForm();
		form.AddField("email", email);
		form.AddField("pass", pass);

		Debug.Log("email: "+email);
		Debug.Log("Password: "+pass);


		WWW w = new WWW("http://localhost/Dismath/checkUser.php", form);

		yield return w;	

		Debug.Log("w: "+w.text);	

		response(JsonUtility.FromJson<Response>(w.text));
	}

	public void CreateUser(string cedula, string nombre, string apellido, string especialidad, string email, string pass, Action<Response> response) {
    	
		StartCoroutine(CO_CreateUser (cedula, nombre, apellido, especialidad, email, pass, response));
	}

	private IEnumerator CO_CreateUser(string cedula, string nombre, string apellido, string especialidad, string email, string pass, Action<Response> response) {
		
		WWWForm form = new WWWForm();
		form.AddField("cedula", cedula);
		form.AddField("nombre", nombre);
		form.AddField("apellido", apellido);
		form.AddField("especialidad", especialidad);
		form.AddField("email", email);
		form.AddField("pass", pass);

		Debug.Log("Cedula: "+cedula);
		Debug.Log("Nombre: "+nombre);
		Debug.Log("Apellido: "+apellido);
		Debug.Log("Especialidad: "+especialidad);
		Debug.Log("email: "+email);
		Debug.Log("Password: "+pass);


		WWW w = new WWW("http://localhost/Dismath/createUser.php", form);

		yield return w;	

		Debug.Log("w: "+w.text);	

		response(JsonUtility.FromJson<Response>(w.text));
	}


}

[Serializable]
public class Response {
	public bool done = false;
	public string message = "";
}
