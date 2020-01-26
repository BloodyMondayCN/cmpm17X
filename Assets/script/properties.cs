using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class properties : MonoBehaviour
{
    public int level = 1;
    public GameObject element;
    public GameObject element2;

    // Update is called once per frame
    void Update()
    {
        if (level == 0){
            int numberToSpawn = Random.Range(1, 4);
            for (int i = 0; i < numberToSpawn; i++){
                GameObject randomEle = randomElement();
                GameObject ele = Instantiate(randomEle) as GameObject;
                ele.transform.position = newPos();
                ele.name = randomEle.name;
            }
            Destroy(this.gameObject);
        }
    }

    private Vector2 newPos(){
        float xpos = Random.Range(-0.5f, 0.5f);
        float ypos = Random.Range(-0.5f, 0.5f);
        Vector2 position = new Vector2(this.transform.position.x + xpos, this.transform.position.y + ypos);
        return position;
    }

    private GameObject randomElement(){
        float pick = Random.Range(-10.0f, -10.0f);
        if (pick > 0) return element;
        else return element2;
    }
}
