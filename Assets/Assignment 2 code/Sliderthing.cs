using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliderthing : MonoBehaviour
{

    public Slider upDown;//calling a public veriable for the slider and naming it upDown

    float f;//calling a veriable for the value of the slider

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float f = upDown.value;//in this line of code we are setting the value of the slider equal to the veriable we called

        Vector2 size = transform.localScale;// this line allows the slider to change the size of the weapons

        size.x = f;//changing the x value

        size.y = f;// changing the y value

        transform.localScale = size;// this line makes it so that the slider only changes the size and not the position of the object
    }
}
