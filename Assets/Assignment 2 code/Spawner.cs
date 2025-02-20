using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float speed = 5;
    public float gun;
    public Button slide; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab,new Vector2(0,0), Quaternion.identity);
            Vector2 speed = transform.position;
            speed.y--;
            transform.position = speed;
        }
        
    }
}
