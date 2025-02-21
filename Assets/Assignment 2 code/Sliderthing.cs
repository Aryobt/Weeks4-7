using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliderthing : MonoBehaviour
{

    public Slider upDown;//calling a public veriable for the slider and naming it upDown

    float f;//calling a veriable for the value of the slider

    public float t;//calling a veriable for the value of the slider

    // Start is called before the first frame update
    void Start()
    {
        upDown = GetComponent<Slider>();//getting an component for the slider
    }

    // Update is called once per frame
    void Update()
    {

        float f = upDown.value;//in this line of code we are setting the value of the slider equal to the veriable we called

        Vector2 size = transform.localScale;// this line allows the slider to change the size of the weapons

        size.x = f;//changing the x value

        size.y = f;// changing the y value

        transform.localScale = size;// this line makes it so that the slider only changes the size and not the position of the object

        t += Time.deltaTime;//making the update look more smooth with time.deltatime

        upDown.value = t % upDown.maxValue;//taking the max value and cicles through it
    }
}
