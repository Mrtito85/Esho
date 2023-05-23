using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
	public GameObject mouseGO;
	
    // Start is called before the first frame update
    void Start()
    {
        resetPositionRandomly_Candy();
    }

    // Update is called once per frame
    void Update()
    {
        clicked();
    }
	
	/*void onMouseDown()
	{
		Debug.Log(" ---- ON moUSE dOWN -- SEPERATE");
	}*/
	
	void clicked()
    {
		if (Input.GetMouseButtonDown(0)) {
			//Debug.Log("=== down function =====");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) {
				if(hit.collider.gameObject.name == "candy")
					// Debug.Log(hit.collider.gameObject.name);
					
					Debug.Log("Candy Clicked");
               // hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }
		}
    }
	
	/*void OnTriggeredEnter2D(Collision2D col) 
    {
		Debug.Log("Collided");
		
	}*/
	void OnTriggerEnter2D(Collider2D col)
    {
		if(col.gameObject.name == "Mouse")
        {
			//Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
			//spriteMove = -0.1f;
			//Debug.Log("Collided");
			resetPositionRandomly_Candy();
		}
    }
	/*
	void OnCollisionEnter(Collision collision) 
	{
		Debug.Log("Collided");
		/*if (collision.collider.tag == "Cubicle")
		 {
			 Debug.Log(collision.gameObject.name + " hit!");
			 myCube = collision.gameObject; // store colliding gameobject info for use elsewhere
		 }
 }*/
	
	void resetPositionRandomly_Candy()
	{
		float randomX = Random.Range(-10f, 10.0f);
		float randomY = Random.Range(-4f, 4.0f);
		Vector2 newPositon = new Vector2(randomX, randomY);
		transform.position = newPositon;
	}
}
