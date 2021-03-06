﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum Elements {Metal, Wood, Water, Fire, Earth};
public class PickUp : MonoBehaviour
{
    public HUD Hud;
    public BackpackDisplay backpack;
    private GameObject itemToPickUp = null;
	private Teleportation tl;
    // Update is called once per frame
    void Update()
    {
        if(itemToPickUp != null && Input.GetKeyDown(KeyCode.F)) {
            if      ("Iron" == itemToPickUp.name) backpack.metalPieces++;
            else if ("Grass" == itemToPickUp.name) backpack.woodPieces++;
            else if ("Ice" == itemToPickUp.name) backpack.waterPieces++;
            else if ("Magma" == itemToPickUp.name) backpack.firePieces++;
            else if ("Stone" == itemToPickUp.name) backpack.earthPieces++;
            else if ("Gold" == itemToPickUp.name) backpack.metalPieces++;
            else if ("Sticks" == itemToPickUp.name) backpack.woodPieces++;
            else if ("Pool" == itemToPickUp.name) backpack.waterPieces++;
            else if ("Small Flame" == itemToPickUp.name) backpack.firePieces++;
            else if ("Dust" == itemToPickUp.name) backpack.earthPieces++;
            
            Destroy(itemToPickUp);
        }
    }

    private void OnTriggerEnter2D(Collider2D obj) {
		if(obj.gameObject.name.Contains("teleport")){
			
			tl = obj.gameObject.GetComponent<Teleportation>();
			//this.transform.position = new Vector2(obj.gameObject.GetComponent<Teleportation>().newX,obj.gameObject.GetComponent<Teleportation>().newY);
			if (tl == null){
				return;
			}
			this.transform.position = new Vector2(tl.newX,tl.newY);
			return;
		}
        itemToPickUp = obj.gameObject;
        Hud.OpenMessagePanel(obj.gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D obj) {
        itemToPickUp = null;
        Hud.CloseMessagePanel();
    }
}
