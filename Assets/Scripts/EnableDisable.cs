using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject go;
    public SpriteRenderer sr;
    public EnableDisable script;
    public AudioSource audioSource;
    public AudioClip ac;



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
        if(Input.GetKey(KeyCode.Space))
        {
            //audioSource.Play();
            audioSource.PlayOneShot(ac);
        }
        if(audioSource.isPlaying == false)
        {
            audioSource.PlayOneShot(ac);
        }
    }
}
