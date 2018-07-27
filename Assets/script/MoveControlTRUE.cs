using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveControlTRUE : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
  //  [SerializeField] private Text _Text;
public void OnDrag(PointerEventData eventData)
{
        /* gameObject.GetComponent<RectTransform>().anchoredPosition=
             new Vector2( 
                 eventData.pointerCurrentRaycast.screenPosition.x, 
             eventData.pointerCurrentRaycast.screenPosition.y);*/
        gameObject.transform.position = eventData.pointerCurrentRaycast.worldPosition;
       // Debug.Log(eventData.pointerCurrentRaycast.screenPosition.x + " "+ eventData.pressPosition.y);
}

public void OnBeginDrag(PointerEventData eventData)
{
        // _Text.text = "You dragging!";
        //Debug.Log("You dragging!");
}

public void OnEndDrag(PointerEventData eventData)
{
        //_Text.text = "Drag me!";
        gameObject.transform.localPosition = new Vector3();
       // Debug.Log("You dragging!");
    }

	
   
}
