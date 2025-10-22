using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController Instance;
    [SerializeField] private Slider energySlider;
    [SerializeField] private TMP_Text energyText;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private TMP_Text healthText;
    public GameObject pausePanel;
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void UpdateEnergySlider(float current, float max)
    {
        // Gán giá trị tối đa (max) cho thanh Slider
        energySlider.maxValue = max;
        // Gán giá trị hiện tại (current) cho thanh Slider
        energySlider.value = Mathf.RoundToInt(current);
        // Cập nhật dòng chữ hiển thị dạng "current / max"
        energyText.text = energySlider.value + " / " + energySlider.maxValue;
    }
    public void UpdateHealthSlider(int current, int max)
    {
        healthSlider.maxValue = max;
        healthSlider.value = current;
        healthText.text = healthSlider.value + " / " + healthSlider.maxValue;
    }
}
