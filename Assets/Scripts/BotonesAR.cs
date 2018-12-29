using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesAR : MonoBehaviour {

    public string dirWik;
    public string dirMaps;

    public void GoToWik()
    {
        Application.OpenURL(dirWik);
    }
    public void GoToMaps()
    {
        Application.OpenURL(dirMaps);
    }

}
