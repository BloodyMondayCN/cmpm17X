using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public GameObject MessagePanel;
    public Text PickUpMessage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            properties woodScript = GameObject.Find("LvlWood").GetComponent<properties>();
            properties waterScript = GameObject.Find("LvlWater").GetComponent<properties>();
            properties earthScript = GameObject.Find("LvlEarth").GetComponent<properties>();
            properties metalScript = GameObject.Find("LvlMetal").GetComponent<properties>();
            properties fireScript = GameObject.Find("LvlFire").GetComponent<properties>();

            woodScript.level--;
            waterScript.level--;
            earthScript.level--;
            metalScript.level--;
            fireScript.level--;
        }
    }

    public void OpenMessagePanel(string item) {
        PickUpMessage.text = "Press F to pick up " + item;
        MessagePanel.SetActive(true);
    }

    public void CloseMessagePanel() {
        MessagePanel.SetActive(false);
    }
}
