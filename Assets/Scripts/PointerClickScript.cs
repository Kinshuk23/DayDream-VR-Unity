using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerClickScript : MonoBehaviour
{
    //GraphicRaycaster m_Raycaster;
    //PointerEventData m_PointerEventData;


    //GvrPointerGraphicRaycaster m_Raycaster;
    //GvrPointerEventData m_PointerEventData;
    //EventSystem m_EventSystem;

    void Start()
    {

    }

    [System.Obsolete]
    void Update()
    {
        if (GvrControllerInput.ClickButtonDown)
        {
            Debug.Log("Click hua hai");

        }
        else if (GvrControllerInput.ClickButtonUp)
        {
            Debug.Log("Click khatam hua");
        }

    }
}
