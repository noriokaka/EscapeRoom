﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Door : MonoBehaviour, IPointerClickHandler
{
    bool isOpen;//開いてる状態か
    public bool isOpenIn;//内開きかなのか
    float rotY;//開き具合
    public void OnPointerClick(PointerEventData eventData)
    {
        //内開きなのか
        if (isOpenIn)
        {
            rotY = -120;
        }
        else
        {
            rotY = 120;
        }
        //開いてるか
        if (!isOpen)
        {
            transform.Rotate(0, rotY, 0);
            isOpen = true;
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            isOpen = false;
        }
    }
}