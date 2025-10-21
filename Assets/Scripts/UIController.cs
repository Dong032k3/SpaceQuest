using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController Instance;
    [SerializeField] private Slider energySlider;
    [SerializeField] private TMP_Text energyText;
    void Awake()
    {
        if(Instance != null)
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
        // Gán giá trị hiện tại (current) cho thanh Slider
        energySlider.value = Mathf.RoundToInt(current);

        // Gán giá trị tối đa (max) cho thanh Slider
        energySlider.maxValue = max;

        // Cập nhật dòng chữ hiển thị dạng "current / max"
        energyText.text = energySlider.value + " / " + energySlider.maxValue;
    }
}
