using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana : MonoBehaviour {
    public GameObject bean;
    public GameObject lacitis;
    public GameObject tante;
    public GameObject masina;
    public void BinaAttels(bool vertiba) {
        bean.SetActive(vertiba);
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
}
