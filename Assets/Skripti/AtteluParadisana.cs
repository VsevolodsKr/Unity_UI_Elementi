using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
    public GameObject bean;
    public GameObject lacitis;
    public GameObject tante;
    public GameObject masina;
    public GameObject paKreisi;
    public GameObject paLabi;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slideraIzmers;
	public GameObject rotacijasSlideris;
    public void BinaAttels(bool vertiba) {
        bean.SetActive(vertiba);
        paKreisi.GetComponent<Toggle>().interactable = vertiba;
        paLabi.GetComponent<Toggle>().interactable = vertiba;
    }
    public void LacitisAttels(bool vertiba)
    {
        lacitis.SetActive(vertiba);
    }
    public void TanteAttels(bool vertiba)
    {
        tante.SetActive(vertiba);
    }
    public void MasinaAttels(bool vertiba)
    {
        masina.SetActive(vertiba);
    }
    public void PakreisiBean(){
        bean.transform.localScale = new Vector2(1,1);
    }
    public void PaLabiBean(){
        bean.transform.localScale = new Vector2(-1,1);
    }
    public void izkritosais(int index){
        if(index == 0){
        mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        }
        if(index == 1){
        mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }
        if(index == 2){
        mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        }
    }
    public void mainitLielumu(){
        float pasreizejaisIzmers = slideraIzmers.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1f*pasreizejaisIzmers, 1f*pasreizejaisIzmers);
    }
	public void rotet(){
		float pasreizejaVertiba = rotacijasSlideris.GetComponent<Slider> ().value;
		mainigaisAttels.transform.localRotation = Quaternion.Euler(0, 0, 360 * pasreizejaVertiba); 
	}
}