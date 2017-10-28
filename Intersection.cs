using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// placed on an intersection
// contains information on nearby intersections, cars on the intersections, and traffic controllers placed on the intersection

public class Intersection : MonoBehaviour {

    public ITrafficController[] trafficControllers = new ITrafficController[4]; //[0] faces up, [1] faces down, [2] faces left, [3] faces right
    public List<GameObject> cars = new List<GameObject>();
    public GameObject topIntersection;
    public GameObject bottomIntersection;
    public GameObject leftIntersection;
    public GameObject rightIntersection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HandleTraffic()
    {
    }
}
