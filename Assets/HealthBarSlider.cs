using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image HealthBarFill;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health; 

        HealthBarFill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;

        HealthBarFill.color = gradient.Evaluate(slider.normalizedValue);

    }
}

