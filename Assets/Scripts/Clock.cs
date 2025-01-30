using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public float hourSpeeds = 1f;
    public AudioSource audioSound;
    public float time;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += 1 * Time.deltaTime;

        Vector3 hourSpeed = transform.eulerAngles;

        hourSpeed.z -= hourSpeeds * Time.deltaTime;

        transform.eulerAngles = hourSpeed;

        if(time > 3.65)
        {
            audioSound.Play();
            time = 0;
        }
       
    }
}
