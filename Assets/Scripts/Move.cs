using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Kaibapos;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Kaibapos = transform.position;
        Kaibapos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        transform.position = Kaibapos;
        }
}
