using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursorsUzAtteliem : MonoBehaviour {
	public AudioSource kuruAtskanot;
	public AudioClip koAtskanot;
	public int aboluskaits;

	public void uzAttela(){
		kuruAtskanot.PlayOneShot(koAtskanot);
	}
	public void noAttela(){
		kuruAtskanot.Stop();
	}
}
