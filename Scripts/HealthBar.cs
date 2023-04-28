using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    // Set the maximum value of the health bar slider to the given health value.
    // Also set the current value of the slider to the same value.
    public void setMaxHealth (int health) {
        slider.maxValue = health;
        slider.value = health;
    }
    // Set the value of the health bar slider to the given health value.
    public void SetHealth(int health) {
        slider.value = health;
    }
}
