using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLight : MonoBehaviour, ITrafficController {

    public bool on; // true = green, false = red

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Toggle();
	}

    public void Toggle()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SpriteRenderer sprite = gameObject.GetComponent<SpriteRenderer>();
            float minX = sprite.bounds.min.x;
            float minY = sprite.bounds.min.y;
            float maxX = sprite.bounds.max.x;
            float maxY = sprite.bounds.max.y;

            if(mouseWorldPos.x >= minX && mouseWorldPos.x <= maxX && mouseWorldPos.y <= minY && mouseWorldPos.y >= maxY)
            {
                on = !on;
            }
        }
    }
}
