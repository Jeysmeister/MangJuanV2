using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StandItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] Transform gameCanvas;
    Transform dragItem;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        dragItem = Instantiate(gameObject, Input.mousePosition, Quaternion.identity, gameCanvas).transform;
    }

    public void OnDrag(PointerEventData eventData)
    {
        dragItem.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Destroy(dragItem.gameObject);
    }
}
