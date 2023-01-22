using UnityEngine;
using UnityEngine.UI;

public class Cameras : MonoBehaviour
{
    [SerializeField] Camera _secondCam;
    [SerializeField] Text _cameraSelected;
    
    private Camera _firstCam;

    private void Start()
    {
        _firstCam = GetComponent<Camera>();
    }

    public void SwitchCam()
    {
        _firstCam.enabled = !_firstCam.enabled;
     
        if(_firstCam.enabled == false)
        {
            _secondCam.enabled = true;
            _cameraSelected.text = "2";
        }
        else 
        {
            _cameraSelected.text = "1";
        }
    }
}
