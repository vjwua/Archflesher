using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera fpsVirtualCamera;
    [SerializeField] float zoomedOutPOV = 55f;
    [SerializeField] float zoomedInPOV = 25f;

    bool zoomedInToggle = false;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsVirtualCamera.m_Lens.FieldOfView = zoomedInPOV;
            }
            else
            {
                zoomedInToggle = false;
                fpsVirtualCamera.m_Lens.FieldOfView = zoomedOutPOV;
            }
        }
    }
}
