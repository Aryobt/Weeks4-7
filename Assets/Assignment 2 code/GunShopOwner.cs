using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShopOwner : MonoBehaviour
{
    public float Shoppos;//Public veriable too call the position of the gun shop owner

    public float speed = 5;//public veriable too call the speed of the shopowner

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Shoppos = transform.position;//this line makes it so that the shopowner position would be equal to the changed position 

        Shoppos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;// the shop onwers X position changes with pressing the key and it moves horizataly and the time.delta time makes the movement smoother

        transform.position = Shoppos;//the changed position is equal to the shopowners position
    }
}
