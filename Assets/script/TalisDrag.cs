using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TalisDrag : MonoBehaviour, IDragHandler, IEndDragHandler, IDropHandler
{
    public TalisObj.Elements element;
    public Transform talisman, dispManager;

    private Vector3 origin;
    private bool setTalis;

    // Reset position of talisman
    private void OnDisable() {
        transform.position = origin;
    }

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

            // Delete resource here

            // Give player a talisman object here
            GameObject pFab = dispManager.GetComponent<TalisDisplay>().prefab;
            GameObject talis = Instantiate(pFab, Vector3.zero, Quaternion.identity);
            talis.transform.position = dispManager.GetComponent<TalisDisplay>().player.transform.position;
            talis.GetComponent<TalisObj>().SetEle(element);
            talis.GetComponent<TalisObj>().SetVel(0, 1);
            talis.SetActive(true);

            talisman.gameObject.SetActive(false);
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