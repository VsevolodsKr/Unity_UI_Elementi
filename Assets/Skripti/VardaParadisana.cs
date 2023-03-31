using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	//Mainīgais, kurā ieglābājas informācija no Input field
	private string teksts;
	private string krasa;
	private string[] A = {"Sveiki ","Labdien ","Čau čau ","Prieks tevi redzēt "};
	private Color[] krasas = {Color.blue,Color.green,Color.red,Color.yellow};
	//Uzglāba nejaušo skaitli
	int nejauss1, nejauss2;
	//Lauks no kurā ievada teksta
	public GameObject ievadesLauks;
	//Teksts, kurā attēlos tekstu
	public GameObject tekstaAttelosana;
	public GameObject krasasMaina;

	public void uzglabatTekstu(){
		nejauss1 = Random.Range (0,A.Length);
		nejauss2 = Random.Range(0,krasas.Length);
		teksts = ievadesLauks.GetComponent<Text>().text;
		tekstaAttelosana.GetComponent<Text>().text = A[nejauss1]+teksts.ToUpper()+"!";
	}
}
