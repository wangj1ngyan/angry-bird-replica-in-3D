using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;
    public Camera sideCamera;
    public Button mainCameraButton;
    public Button sideCameraButton;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        sideCamera.enabled = false;
        mainCameraButton.gameObject.SetActive(false);
        sideCameraButton.gameObject.SetActive(true);
    }

    public void SwitchToMainCamera()
    {
        Debug.Log("Switching to Main Camera");
        mainCamera.enabled = true;
        sideCamera.enabled = false;
        mainCameraButton.gameObject.SetActive(false);
        sideCameraButton.gameObject.SetActive(true);
    }

    public void SwitchToSideCamera()
    {
        Debug.Log("Switching to Side Camera");
        mainCamera.enabled = false;
        sideCamera.enabled = true;
        mainCameraButton.gameObject.SetActive(true);
        sideCameraButton.gameObject.SetActive(false);
    }

}
