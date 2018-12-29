using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GMapsScrip : MonoBehaviour
{

    public string url;

    public RawImage map;

    public float lon;
    public float lat;

    public int zoom;
    public int mapHeight;
    public int mapWidth;
    public int scale;

    LocationInfo li;

    public enum mapType { roadMap, satelite, hybrid, terrain };
    public mapType mapSelected;

    private IEnumerator mapCoroutine;

    IEnumerator GoogleMaps(float lat, float lon)
    {


        url = "https://maps.googleapis.com/maps/api/staticmap?center=" + lat +
              "," + lon + "&zoom=" + zoom + "&size=" + mapHeight + "x" +
               mapWidth + "&Scale=" + scale + "&maptype=" + mapSelected +
               "&key=AIzaSyAVv1dTpIeYEI9EapbP4Xbqzt3sKOAIC3g";


        WWW www = new WWW(url);
        yield return www;
        map.texture = www.texture;


    }



    void Start()
    {
        map = this.gameObject.GetComponent<RawImage>();
        StartCoroutine(GoogleMaps(lat, lon));
        lon = 39.217425f;
        lat = -7.002289f;
        Debug.Log("new maps");
    }


    public void Open()
    {
        Application.OpenURL("http://maps.google.com/maps?q=" + MenusManager.instance.monInfo.Coords);
    }

}
