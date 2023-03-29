using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	//Mainīgais, kurā ieglābājas informācija no Input field
	private string teksts;
	private string[] A = {"Sveiki!","Labdien!","Čau čau!","Prikes tevi redzēt!"};
	//Uzglāba nejaušo skaitli
	int nejauss;
	//Lauks no kurā ievada teksta
	public GameObject ievadesLauks;
	//Teksts, kurā attēlos tekstu
	public GameObject tekstaAttelosana;

	public void uzglabatTekstu(){
		nejauss = Random.Range (0,A.Length);
		teksts = ievadesLauks.GetComponent<Text>().text;
		tekstaAttelosana.GetComponent<Text>().text = A[nejauss]+teksts.ToUpper()+"!";
	}
}
