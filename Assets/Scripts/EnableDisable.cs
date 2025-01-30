using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject go;
    public SpriteRenderer sr;
    public EnableDisable script;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            go.SetActive(false);
            sr.enabled = false;
            //script.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            go.SetActive(true);
            sr.enabled = true;
            //script.enabled = true;
        }
    }
}
