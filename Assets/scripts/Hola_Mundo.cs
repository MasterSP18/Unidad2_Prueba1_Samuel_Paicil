using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;

public class Hola_Mundo : MonoBehaviour {

	private string message;

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Hola Mundo";
	}

	// Update is called once per frame
	void Update () {
		text.text = HolaMundo ();

	}

	public string HolaMundo(){
		//Me voy a tomar un cafe, que el hola mundo entregue la hora actual y 
		//según la hora, diga buenos días mundo, 
		//buenas tarde o buenas noches
		if (System.DateTime.Now.Hour > 12 && System.DateTime.Now.Hour < 20)
			message="Buenas tardes Mundo";
		if (System.DateTime.Now.Hour > 20 || System.DateTime.Now.Hour < 6)
			message= "Buenas Noches Mundo";
		if (System.DateTime.Now.Hour > 6 && System.DateTime.Now.Hour < 12)
			message= "Buenos Dias Mundo";
		return message;
	}
}
