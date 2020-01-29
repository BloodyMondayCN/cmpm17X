using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TalisDrag : MonoBehaviour, IDragHandler, IEndDragHandler, IDropHandler
{
    public enum Elements { METAL, WOOD, WATER, FIRE, EARTH }
    public Elements element;
    public Transform talisman;

    private Vector3 origin;
    private bool setTalis;

    public void OnDrag(PointerEventData eventData){
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData){
        if(!setTalis){
            transform.position = origin;
        }
    }

    public void OnDrop(PointerEventData eventData){
        RectTransform invPanel = talisman as RectTransform;
        
        if(RectTransformUtility.RectangleContainsScreenPoint(invPanel, Input.mousePosition)){
            setTalis = true;
            Debug.Log("Made talisman of type: " + element);
        }
    }

    // Start is called before the first frame update
    void Start() {
        origin = transform.position;
    }

    // Update is called once per frame
    void Update() {
        
    }
}
