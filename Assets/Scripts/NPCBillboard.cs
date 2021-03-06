﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBillboard : MonoBehaviour {

    //This code was taken from http://wiki.unity3d.com/index.php?title=CameraFacingBillboard under the "Mods" Section.
    //The only change that has been made is that the varriable "autoInit" was set to "True".


    public Camera m_Camera;
    public bool amActive = false;
    public bool autoInit = true;
    GameObject myContainer;

    void Awake()
    {
        if (autoInit == true)
        {
            m_Camera = Camera.main;
            amActive = true;
        }

        myContainer = new GameObject();
        myContainer.name = "GRP_" + transform.gameObject.name;
        myContainer.transform.position = transform.position;
        transform.parent = myContainer.transform;
    }


    void Update()
    {
        if (amActive == true)
        {
            myContainer.transform.LookAt(myContainer.transform.position + m_Camera.transform.rotation * Vector3.back, m_Camera.transform.rotation * Vector3.up);
        }
    }
}
