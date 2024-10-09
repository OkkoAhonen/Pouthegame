using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class slidercontroller : MonoBehaviour
{

    public TextMeshProUGUI ValueText;
    [SerializeField] private int progress = 1000;
    [SerializeField] private int basicProgress = 1;
    public Slider slider;
    private float timer = 0f;
    [SerializeField] private float timertime = 10f;
    public void OnSliderChange (float value)
    {
        ValueText.text = value.ToString();
    }

    public void Updateprogress()
    {
        progress = progress - 50;
        slider.value = progress;
    }

    public void Update()
    {
        timer += Time.deltaTime;

        // Kun 10 sekuntia on kulunut, v‰hennet‰‰n progress-arvo
        if (timer >= timertime)
        {
            progress -= basicProgress; // V‰hennet‰‰n progress-arvoa
            slider.value = progress;   // P‰ivitet‰‰n sliderin arvo
            timer = 0f;                // Nollataan ajastin
        }
    }

}
