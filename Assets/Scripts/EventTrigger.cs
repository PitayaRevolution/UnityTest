using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class EventTrigger : MonoBehaviour
{
    [DllImport("user32.dll", EntryPoint = "keybd_event")]
    public static extern void Keybd_event(byte bvk, byte bScan, int dwFlags, int dwExtraInfo);

    public void OnLeftDown(BaseEventData eventData)
    {
        Debug.Log("Press " + name.ToString());
        Keybd_event(0x25, 0, 0x0001 | 0, 1);

    }

    public void OnLeftUp(BaseEventData eventData)
    {
        Debug.Log("Release " + eventData.ToString());
        Keybd_event(0x25, 0, 0x0001 | 0x0002, 1);
    }

    public void OnRightDown(BaseEventData eventData)
    {
        Debug.Log("Press " + name);
        Keybd_event(0x27, 0, 0x0001 | 0, 1);
    }

    public void OnRightUp(BaseEventData eventData)
    {
        Debug.Log("Release " + eventData.ToString());
        Keybd_event(0x27, 0, 0x0001 | 0x0002, 1);
    }

    public void OnSpaceDown(BaseEventData eventData)
    {
        Debug.Log("Press " + name);
        Keybd_event(0x20, 0, 0x0001 | 0, 1);
    }

    public void OnSpaceUp(BaseEventData eventData)
    {
        Debug.Log("Release " + eventData.ToString());
        Keybd_event(0x20, 0, 0x0001 | 0x0002, 1);
    }
}
