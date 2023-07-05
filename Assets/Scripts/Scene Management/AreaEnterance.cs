using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnterance : MonoBehaviour
{
    [SerializeField] private string transitionName;

    private void Start()
    {
        if (transitionName == SceneManagement.Instance.SceneTransitionName)
        {
            PlayerController.Instance.transform.position = this.transform.position;
            CameraController.Instance.SetPlayerCameraFollow();
            
            UIFade.Instance.FateToClear();
        }
    }
}
