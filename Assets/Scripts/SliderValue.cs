using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SliderValue : MonoBehaviour
{
    public float val;
    public GameObject flow;

    public void setSliderValue(float sliderValue)
    {
        val = sliderValue;
        // set the bolt variable to that of the slider
        Variables.Object(flow).Set("SliderValue", val);
    }
}
