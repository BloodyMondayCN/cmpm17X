using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackpackDisplay : MonoBehaviour {

    public int metalPieces, woodPieces, waterPieces, firePieces, earthPieces = 0;
    private bool ifMetal, ifWood, ifWater, ifFire, ifEarth;
    public Text backpackText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ifMetal = Input.GetKeyDown(KeyCode.Alpha1);
        ifWood = Input.GetKeyDown(KeyCode.Alpha2);
        ifWater = Input.GetKeyDown(KeyCode.Alpha3);
        ifFire = Input.GetKeyDown(KeyCode.Alpha4);
        ifEarth = Input.GetKeyDown(KeyCode.Alpha5);
    }

    void FixedUpdate() {
        if (ifMetal) metalPieces++;
        if (ifWood) woodPieces++;
        if (ifWater) waterPieces++;
        if (ifFire) firePieces++;
        if (ifEarth) earthPieces++;
        backpackText.text = "Metal: " + metalPieces + "\n" +
                            "Wood: " + woodPieces + "\n" +
                            "Water: " + waterPieces + "\n" +
                            "Fire: " + firePieces + "\n" +
                            "Earth: " + earthPieces;
    }

    public int getWood() {
        return woodPieces;
    }
}
