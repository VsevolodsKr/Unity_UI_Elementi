using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtuluGenerator : MonoBehaviour {
		public GameObject[] virtuluSagataves;
		public float laikaIntervals = 1.0f;
		float minPoz, maxPoz;
		Transform krasasTransform;
		void Start(){
			krasasTransform = GetComponent<Transform>();
		}
		public void sagatovotVirtulus(bool stavoklis){
			if(stavoklis)
			StartCoroutine(Generet());
			else
			StopAllCoroutines();
		} 
		IEnumerator Generet(){
			while (true){
				minPoz = krasasTransform.position.x - 20;
				maxPoz = krasasTransform.position.x + 20;
				var cipars = Random.Range(minPoz,maxPoz);
				var pozicija = new Vector2(cipars, transform.position.y);
				GameObject virtulis = Instantiate(virtuluSagataves[Random.Range(0,virtuluSagataves.Length)],pozicija, Quaternion.identity, krasasTransform);
			yield return new WaitForSeconds(laikaIntervals);
			}
		}
	}