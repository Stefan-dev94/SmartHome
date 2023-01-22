using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    [SerializeField] ElectroBlock _wattDisplay;
    [SerializeField] private Text _statusText;

    private int _wattConsume = 50;
    private bool _isOpen;

    public void OpenClose()
    {
        _isOpen = !_isOpen;

        if (_isOpen)
        {
            transform.DORotate(new Vector3(0f, 90f, 0f), 5, RotateMode.Fast);
            _wattDisplay.ConsumeWatt(_wattConsume);
            _statusText.text = "Open";
        }
        else if (!_isOpen)
        {
            transform.DORotate(new Vector3(0f, 0f, 0f), 5, RotateMode.Fast);
            _wattDisplay.ConsumeWatt(_wattConsume);
            _statusText.text = "Closed";
        }
    }
}
