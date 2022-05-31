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

	public void CreateJugador(int id, string nombre, string apellido, int edad, int n_sesiones_asignadas, int cedula_terapeuta, int cedula_acudiente, string diagnostico, Action<Response> response) {
    	
		StartCoroutine(CO_CreateJugador (id, nombre, apellido, edad, n_sesiones_asignadas, cedula_terapeuta, cedula_acudiente, diagnostico, response));
	}

	private IEnumerator CO_CreateJugador(int id, string nombre, string apellido, int edad, int n_sesiones_asignadas, int cedula_terapeuta, int cedula_acudiente, string diagnostico, Action<Response> response) {
		
		WWWForm form = new WWWForm();
		form.AddField("id", id);
		form.AddField("nombre", nombre);
		form.AddField("apellido", apellido);
		form.AddField("edad", edad);
		form.AddField("n_sesiones_asignadas", n_sesiones_asignadas);
		form.AddField("cedula_terapeuta", cedula_terapeuta);
		form.AddField("cedula_acudiente", cedula_acudiente);
		form.AddField("diagnostico", diagnostico);

		Debug.Log("id: "+id);
		Debug.Log("Nombre: "+nombre);
		Debug.Log("Apellido: "+apellido);
		Debug.Log("edad: "+edad);
		Debug.Log("n_sesiones_asignadas: "+n_sesiones_asignadas);
		Debug.Log("cedula_terapeuta: "+cedula_terapeuta);
		Debug.Log("cedula_acudiente: "+cedula_acudiente);
		Debug.Log("diagnostico: "+diagnostico);

		WWW w = new WWW("http://localhost/Dismath/CreateJugador.php", form);


		yield return w;		
		Debug.Log("w: "+w.text);
		response(JsonUtility.FromJson<Response>(w.text));
	}


	public void CreateAcudiente(int cedula, string nombre, string apellido, string parentesco, int celular, string correo, string direccion, Action<Response> response) {
    	
		StartCoroutine(CO_CreateAcudiente (cedula, nombre, apellido, parentesco, celular, correo, direccion, response));
	}

	private IEnumerator CO_CreateAcudiente(int cedula, string nombre, string apellido, string parentesco, int celular, string correo, string direccion, Action<Response> response) {
		
		WWWForm form = new WWWForm();
		form.AddField("cedula", cedula);
		form.AddField("nombre", nombre);
		form.AddField("apellido", apellido);
		form.AddField("parentesco", parentesco);
		form.AddField("celular", celular);
		form.AddField("correo", correo);
		form.AddField("direccion", direccion);

		WWW w = new WWW("http://localhost/Dismath/CreateAcudiente.php", form);


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
