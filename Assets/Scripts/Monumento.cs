using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mon", menuName = "Monumentos", order = 1)]
public class Monumento : ScriptableObject {

    public string nombre;
    public string Descripcion;
    public Texture Map;
    public Texture Pic;
    public string Dir;

    public string Coords;
}
