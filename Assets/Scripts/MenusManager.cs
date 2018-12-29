using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenusManager : MonoBehaviour {

    public static MenusManager instance;

    public GameObject Inicio;
    public GameObject Monumento;
    public GameObject Informacion;

    public GameObject materialDesignPanel;
    public GameObject Background;

    public VuforiaMonoBehaviour Camera;

    public Monumento monInfo;
    public GameObject currentMon;
    public Text nombreMon;
    public Text descMon;
    public RawImage map, Pic;
    public Text dir;

    private void Awake()
    {
        instance = this;
    }
	
    public void EncenderCamara(bool state)
    {
        Camera.enabled = state;
        Background.SetActive(!state);
        materialDesignPanel.SetActive(!state);
        if (state==true)
        {
            Inicio.SetActive(false);
            Monumento.SetActive(false);
            Informacion.SetActive(false);
        }
    }

    public void ToMenuInicial()
    {
        EncenderCamara(false);
        Monumento.SetActive(false);
        Inicio.SetActive(true);
    }
    public void ToMonumento(Monumento m, GameObject mon)
    {
        EncenderCamara(false);

        Inicio.SetActive(false);
        Monumento.SetActive(true);
        Informacion.SetActive(false);

        monInfo = m;

        nombreMon.text = m.nombre;
        descMon.text = m.Descripcion;
        map.texture = m.Map;
        Pic.texture = m.Pic;
        dir.text = m.Dir;

        if (m.nombre == "Pinturas Rupestres")
            pintura = true;
        else
            pintura = false;

        if (currentMon!=null)
            currentMon.SetActive(false);
        currentMon = mon;
        currentMon.SetActive(true);
    }

    public void ShowInfo()
    {
        Informacion.SetActive(true);
    }



    public bool pause = false;
    public float Speed;
    public bool Backwards = false;
    public bool forceMove = false;

    public bool pintura = false;

    private void Update()
    {

        if (currentMon!=null && currentMon.activeSelf && (!pause || forceMove) && !pintura)
        {
            currentMon.transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * (Backwards? Speed : -Speed));
        }

    }

    public void forceRight()
    {
        forceMove = true;
        Backwards = false;
    }
    public void ForceLeft()
    {
        forceMove = true;
        Backwards = true;
    }
    public void StopForce()
    {
        forceMove = false;
        Backwards = false;
    }
    public void Move()
    {
        pause = false;
    }
    public void StopMove()
    {
        pause = true;
    }
}


