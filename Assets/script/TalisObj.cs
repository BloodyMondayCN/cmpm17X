using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalisObj : MonoBehaviour
{
    public enum Elements { METAL, WOOD, WATER, FIRE, EARTH }

    private Elements curEle;
    private float xVel, yVel;

    public void SetEle (Elements e) {
        this.curEle = e;
        Debug.Log("made: " + e);
    }

    public void SetVel(float x, float y) {
        this.xVel = x;
        this.yVel = y;
    }

    // Update is called once per frame
    void Update() {
        Debug.Log(xVel + " " + curEle);
        transform.Translate(xVel * Time.deltaTime, yVel * Time.deltaTime, 0);
    }


    private void OnTriggerEnter2D(Collider2D obj) {
        if(true){ // Check if object is a wall
            Elements objEle = Elements.FIRE; // get actual data from wall later
            switch(this.curEle){
                case Elements.EARTH:    AddEarth(obj.gameObject, objEle);   break;
                case Elements.WOOD:     AddWood(obj.gameObject, objEle);    break;
                case Elements.FIRE:     AddFire(obj.gameObject, objEle);    break;
                case Elements.WATER:    AddWater(obj.gameObject, objEle);   break;
                case Elements.METAL:    AddMetal(obj.gameObject, objEle);   break;
                default:                break;
            }
           // Destroy(gameObject);
        }
    }

    private void IncrementObj(GameObject obj) {
        // Do later
    }

     private void DecrementObj(GameObject obj) {
        // Do later
    }

    private void AddEarth(GameObject obj, Elements objEle) {
        switch(objEle){
            case Elements.WATER:    DecrementObj(obj); break;
            case Elements.METAL:    IncrementObj(obj); break;
            default:                break;
        }
    }

    private void AddWood(GameObject obj, Elements objEle) {
        switch(objEle){
            case Elements.EARTH:    DecrementObj(obj); break;
            case Elements.FIRE:     IncrementObj(obj); break;
            default:                break;
        }
    }

    private void AddWater(GameObject obj, Elements objEle) {
        switch(objEle){
            case Elements.FIRE:     DecrementObj(obj); break;
            case Elements.WOOD:     IncrementObj(obj); break;
            default:                break;
        }
    }

    private void AddFire(GameObject obj, Elements objEle) {
        switch(objEle){
            case Elements.METAL:    DecrementObj(obj); break;
            case Elements.EARTH:    IncrementObj(obj); break;
            default:                break;
        }
    }

    private void AddMetal(GameObject obj, Elements objEle) {
        switch(objEle){
            case Elements.WOOD:     DecrementObj(obj); break;
            case Elements.WATER:    IncrementObj(obj); break;
            default:                break;
        }
    }
    
}