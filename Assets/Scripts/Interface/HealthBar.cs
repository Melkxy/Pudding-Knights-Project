using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]private Slider slider;

    public void SetHealth(int maxHealth, int currentHealth)
    {
	slider.maxValue = maxHealth;
	slider.value = currentHealth;
    }
}
