using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClose : MonoBehaviour {

    private void Awake()
    {
        gameObject.SetActive(false);
    }
}
