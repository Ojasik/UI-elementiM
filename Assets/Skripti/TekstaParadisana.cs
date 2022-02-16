using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {
	//Uzglabas tekstu, kurs panemts no input lauka
	public string teksts;

	//Lauks no kura es tekstu panemsu 
	public GameObject IevadesLauks;

	//Teksta objekts kur attelot mainiga teksts saturu
	public GameObject tekstaAttelosanasLauks;

	public void darbibasArTekstu(){
		teksts = IevadesLauks.GetComponent<Text> ().text;
		tekstaAttelosanasLauks.GetComponent<Text>().text = "Sveiks "+teksts.ToUpper()+"!";
	}



}
