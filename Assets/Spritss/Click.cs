using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
	public GameObject mouseGO;
	
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Game Started!");
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            Vector2 posi = Camera.main.ScreenToWorldPoint(pos);
			//Debug.Log("Click Position" + posi);
			//mouseGO.GetComponent<MouseScript>().setMousePosition(posi);
			mouseGO.GetComponent<MouseScript>().moveMouse(posi);
		}
    }
}
