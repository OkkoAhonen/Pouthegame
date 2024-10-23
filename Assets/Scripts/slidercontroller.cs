using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class slidercontroller : MonoBehaviour
{

    public TextMeshProUGUI ValueText;

    public Slider slider;

    public void OnSliderChange (float value)
    {
        ValueText.text = value.ToString();
    }



    public void Update()
    {

    }

}
