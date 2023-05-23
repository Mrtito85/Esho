using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
	float speed = 0.04f;
	Vector2 destinationPosition;// = transform.position;
	//MouseScript mouseScript;
	
    // Start is called before the first frame update
    void Start()
    {
		destinationPosition = transform.position;
        //mouseScript = GameObject.FindWithTag("mouseScript");
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = Vector3.MoveTowards(transform.position, destinationPosition, speed);
    }
	
	public void setMousePosition(Vector2 destinationPosition)
	{
		//Debug.Log("Clicked");
		transform.position = destinationPosition;
	}
	
	public void moveMouse(Vector2 pDestinationPosition)
	{
		//Debug.Log("Move");
		//transform.position = pDestinationPosition;
		destinationPosition = pDestinationPosition;
	}
}
