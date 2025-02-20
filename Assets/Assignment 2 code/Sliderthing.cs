using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliderthing : MonoBehaviour
{

    public Slider upDown;

    float f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float f = upDown.value;

        Vector2 size = transform.localScale;

        size.x = f;
        size.y = f;
        transform.localScale = size;
    }
}
