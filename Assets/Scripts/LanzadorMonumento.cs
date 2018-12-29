using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzadorMonumento : MonoBehaviour {

    public Monumento m;
    public GameObject g;

    public void OpenMonumento()
    {
        MenusManager.instance.ToMonumento(m, g);
    }

    public void openMaps() { 
}


}
