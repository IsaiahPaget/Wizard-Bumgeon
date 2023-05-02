using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    Slider slider;
    void Awake() {
        slider = GetComponent<Slider>();
    }
    public void setMaxHealth (float health) {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHealth(float health) {
        slider.value = health;
    }
}
