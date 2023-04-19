using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ainasparvietosana : MonoBehaviour {
	public void uzBinaAinu(){
		SceneManager.LoadScene(1, LocalSceneMode.Single);
	}
	public void uzSakumu(){
		SceneManager.LoadScene("Sakums", LocalSceneMode.Single);

	}
	public void stop(){
		Application.Quit();
	}
}
