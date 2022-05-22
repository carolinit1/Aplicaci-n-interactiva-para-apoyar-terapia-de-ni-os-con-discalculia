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
    void OnTriggerEnter(Collider col)
    {
			if(col.gameObject.tag=="suelo")
			{
				tocaSuelo=true;
				
				print(valor);
			}
		
	}
	 void OnTriggerExit(Collider col)
    {
			
		tocaSuelo=false;
			
		
	}
	
	
	
}
