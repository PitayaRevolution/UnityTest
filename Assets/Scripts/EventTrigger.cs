using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;

public class EventTrigger : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer Down.."+eventData.ToString());
    }

    void OnMouseDown()
    {
        Debug.Log("112358");
    }
}
