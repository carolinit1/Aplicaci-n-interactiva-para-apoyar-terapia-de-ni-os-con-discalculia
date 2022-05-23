using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cara : MonoBehaviour
{
	public int valor;// variable para para recopilar numero de la cara

	public bool tocaSuelo;// variable que me confima cuando el dado toca el suelo
	public string puntos;
	
    // Start is called before the first frame update
    void Start()
    {
		
	 puntos =GetComponent<TextMesh>().text;

	
    }

    // Update is called once per frame
    void Update()
    {

		
    }
	//méodo que se encarga de validar que el dado ya toco el suelo para saber en qué cara cayó 
    void OnTriggerEnter(Collider col)
    {
			if(col.gameObject.tag=="suelo")
			{
				tocaSuelo=true;
				
				print(valor);
			}
		
	}
		//méodo que se encarga de validar que el dado no toca el suelo aún 
	 void OnTriggerExit(Collider col)
    {
			
		tocaSuelo=false;
			
		
	}
	
	
	
}
