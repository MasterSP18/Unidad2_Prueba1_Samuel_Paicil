using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiWorld : MonoBehaviour {

	private string message;

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Hola Mundo";
	}

	// Update is called once per frame
	void Update () {

	}

	public string HolaMundo(){
		//Me voy a tomar un cafe, que el hola mundo entregue la hora actual y 
		//según la hora, diga buenos días mundo, 
		//buenas tarde o buenas noches
		message="Buenas tardes Mundo";
		return message;
	}
}
