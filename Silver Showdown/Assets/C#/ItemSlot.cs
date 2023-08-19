using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{

    public GrugAndGropo grugAnd;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop"); 
        if(grugAnd.CanMoveCoin == true)
        {
        if( eventData.pointerDrag != null ) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            grugAnd.CanMoveCoin = false;
        }

        }
    }
}
