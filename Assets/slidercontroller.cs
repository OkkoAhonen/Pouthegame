using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class slidercontroller : MonoBehaviour
{

    public TextMeshProUGUI ValueText;
    public void OnSliderChange (float value)
    {
        ValueText.text = value.ToString();
    }

}
