using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// placed on a stop sign object
// stops an approaching car for a certain amount of time
public class StopSign : MonoBehaviour {

    public float timer = 0f;
    public float timeToStop;
    public bool stopCars;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (stopCars)
        {
            timer += Time.deltaTime;
            if (timer >= timeToStop)
            {
                timer = 0;
                stopCars = false;
            }
        }
    }
}
