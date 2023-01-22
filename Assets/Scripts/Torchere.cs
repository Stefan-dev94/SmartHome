using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Torchere : MonoBehaviour
{
    [SerializeField] private ElectroBlock _blockDisplay;
    [SerializeField] private Light [] _light;
    [SerializeField] private Text _statusText;

    private int _consumeWatt = 30;

    public void OnOff()
    {
        foreach(Light light in _light)
        {
            light.enabled = !light.enabled;
           
            if(light.enabled == true)
            {
                _blockDisplay.ConsumeWatt(_consumeWatt);
                _statusText.text = "On";
            }
            else
            {
                _statusText.text = "Off";
            }
        }
    }
}
