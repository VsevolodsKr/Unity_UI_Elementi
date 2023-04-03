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
}