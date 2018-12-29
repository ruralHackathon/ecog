using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandle : MonoBehaviour
{
    public Transform reference;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Handle screen touches.
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = new Ray(Camera.main.ScreenToViewportPoint(Input.mousePosition), reference.forward);


            Debug.DrawRay(Camera.main.ScreenToViewportPoint(Input.mousePosition), reference.forward * 1000, Color.red, 5f);

            int layer_mask = LayerMask.GetMask("ARButton");

            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(ray, out hit, 1000, layer_mask))
            {
                Debug.DrawLine(Camera.main.transform.position, Input.mousePosition, Color.red, 5f);
                Debug.Log("Did Hit");
            }
            else
            {

                Debug.DrawRay(Camera.main.ScreenToViewportPoint(Input.mousePosition), reference.forward * 1000, Color.red, 5f);
                Debug.Log("Did not Hit");
            }
        }
    }
}
