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
        
    }

    public void OpenMessagePanel(string item) {
        PickUpMessage.text = "Press F to pick up " + item;
        MessagePanel.SetActive(true);
    }

    public void CloseMessagePanel() {
        MessagePanel.SetActive(false);
    }
}
