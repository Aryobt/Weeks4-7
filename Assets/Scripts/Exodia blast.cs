using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exodiablast : MonoBehaviour
{
    Slider blast ;
    float t;
    // Start is called before the first frame update
    void Start()
    {
        blast = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        blast.value = t % blast.maxValue;
    }
}
