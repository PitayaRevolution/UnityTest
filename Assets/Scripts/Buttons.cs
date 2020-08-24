using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Buttons: MonoBehaviour{

    private GameObject go;
    public void Start()
    {
        //go = GameObject.Find("Left");
        //go.GetComponent<Button>().onClick.AddListener(M);
        //go.GetComponent<Button>().onClick.AddListener(M);
    }

    void M ()
    {
        Debug.Log("112358");
        Input.GetKeyDown("left");
    }
}
