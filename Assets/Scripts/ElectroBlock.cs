using UnityEngine;
using UnityEngine.UI;

public class ElectroBlock : MonoBehaviour
{
    [SerializeField] private GameObject _displayTimeText;
    
    [SerializeField] private Text _totalWattTxt;

    private int _hour, _minutes, _seconds;
    private int _watt;

    private void Update()
    {
        CurrentHour();
    }

    public void ConsumeWatt(int totalWatt)
    {
        _watt += totalWatt;
        _totalWattTxt.text = "Total: " + _watt + "W";
    }

    private void CurrentHour()
    {
        _hour = System.DateTime.Now.Hour;
        _minutes = System.DateTime.Now.Minute;
        _seconds = System.DateTime.Now.Second;
        _displayTimeText.GetComponent<Text>().text = _hour + ":" + _minutes + ":" + _seconds;
    }
}
