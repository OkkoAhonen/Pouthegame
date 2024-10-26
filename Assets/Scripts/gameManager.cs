using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public slidercontroller sliderController;  // Viittaus slidercontroller-objektiin
    public Slider slider;                      // Viittaus suoraan Slider-komponenttiin

    public int progress = 1000;
    public int basicProgress = 1;
    private float timer = 0f;
    public float timertime = 10f;

    // Metodi p‰ivitt‰‰ progress-arvoa ja slideria
    public void UpdateProgress()
    {
        progress -= 50;
        slider.value = progress;
        sliderController.OnSliderChange(progress); // P‰ivitet‰‰n myˆs teksti
    }

    // Start is called before the first frame update
    void Start()
    {
        // Oletetaan, ett‰ slidercontroller on m‰‰ritetty Unity-editorissa
        if (sliderController == null)
        {
            Debug.LogError("SliderController ei ole m‰‰ritetty gameManagerissa!");
        }

        // Varmistetaan, ett‰ slider on asetettu
        if (slider == null)
        {
            Debug.LogError("Slider ei ole m‰‰ritetty gameManagerissa!");
        }

        slider.maxValue = 1000; // Esimerkki maksimiarvosta
        slider.value = progress; // Asetetaan sliderin arvo aluksi progress-arvoon
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // Kun 10 sekuntia on kulunut, v‰hennet‰‰n progress-arvo
        if (timer >= timertime)
        {
            progress -= basicProgress;  // V‰hennet‰‰n progress-arvoa
            slider.value = progress;    // P‰ivitet‰‰n sliderin arvo
            sliderController.OnSliderChange(progress); // P‰ivitet‰‰n myˆs teksti
            timer = 0f;                 // Nollataan ajastin
        }
    }
}
//lis‰‰ t‰nne raha systeemi