using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TemperatureUI : MonoBehaviour
{
    public Temperature temp;
    public TextMeshProUGUI tmpro;

    void Update()
    {
        tmpro.text = $"{temp.currentTemp:F1}";
    }
}
