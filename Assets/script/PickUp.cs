using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum Elements {Metal, Wood, Water, Fire, Earth};
public class PickUp : MonoBehaviour
{
    public HUD Hud;
    public BackpackDisplay backpack;
    private GameObject itemToPickUp = null;

    // Update is called once per frame
    void Update()
    {
        if(itemToPickUp != null && Input.GetKeyDown(KeyCode.F)) {
            if      ("Metal" == itemToPickUp.name) backpack.metalPieces++;
            else if ("Wood" == itemToPickUp.name) backpack.woodPieces++;
            else if ("Water" == itemToPickUp.name) backpack.waterPieces++;
            else if ("Fire" == itemToPickUp.name) backpack.firePieces++;
            else if ("Earth" == itemToPickUp.name) backpack.earthPieces++;
            
            Destroy(itemToPickUp);
        }
    }

    private void OnTriggerEnter2D(Collider2D obj) {
        itemToPickUp = obj.gameObject;
        Hud.OpenMessagePanel(obj.gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D obj) {
        itemToPickUp = null;
        Hud.CloseMessagePanel();
    }
}
