using UnityEngine;
using UnityEngine.UI;

public class LightOnOff : MonoBehaviour
{
    [SerializeField] private ElectroBlock _wattDysplay;
    [SerializeField] private Text _statusText;
    
    private Light _light;

    private int _wattConsume = 100;
   
    private void Start()
    {
        _light = GetComponent<Light>();
    }

    public void LightSetActive()
    {
        _light.enabled = !_light.enabled;
         if(_light.enabled == true)
        {
            _statusText.text = "On";
            _wattDysplay.ConsumeWatt(_wattConsume);
        }
        else
        {
            _statusText.text = "Off";
        }
    }
}
