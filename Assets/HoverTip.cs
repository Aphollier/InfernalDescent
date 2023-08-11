using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public string Tip;

    public void OnPointerEnter(PointerEventData eventData)
    {
        HoverTipManager.OnMouseHover(Tip, Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverTipManager.OnMouseDrop();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        HoverTipManager.OnMouseClick(gameObject.GetComponent<SpriteRenderer>(), "passive");
    }

}

