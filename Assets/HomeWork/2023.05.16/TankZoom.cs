using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankZoom : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cameraPoint;
    private bool isZoom = false;
    private void OnZoom(InputValue value)
    {
        if (value.isPressed)
        {
            if (!isZoom)
            {
                cameraPoint.Priority = 20;
                isZoom = true;
            }
            else
            {
                cameraPoint.Priority = 9;
                isZoom = false;
            }
        }
    }
}
