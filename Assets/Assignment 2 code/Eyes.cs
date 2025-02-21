using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    public float eyepos;//Public veriable too call the position of the gun shop owners eyes

    public float speed = 5;//public veriable too call the speed of the shopowner

    //public AnimationCurve t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 eyepos = transform.position;//this line makes it so that the shopowners eye position would be equal to the changed position 

        eyepos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;// the shop onwers X position changes with pressing the key and it moves horizataly and the time.delta time makes the movement smoother

        transform.position = eyepos;//the changed position is equal to the shopowners eye position

    }
}
