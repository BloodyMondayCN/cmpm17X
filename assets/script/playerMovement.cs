using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
	public Sprite dragon;
	public Sprite human;
    [SerializeField] private float moveSpeed = 2.0f;
    
    private void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update(){
        moveH = Input.GetAxisRaw("Horizontal")* moveSpeed;
        moveV = Input.GetAxisRaw("Vertical") * moveSpeed;
		if(Input.GetKey("space")){
			this.gameObject.GetComponent<SpriteRenderer>().sprite = dragon;
		}else{
			this.gameObject.GetComponent<SpriteRenderer>().sprite = human;
		}
			
    }

    private void FixedUpdate(){
        rb.velocity = new Vector2(moveH, moveV);
    }
}
