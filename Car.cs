using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// placed on a car object
// contains information on the car and methods to move it

public class Car : MonoBehaviour {

    public GameObject target;
    public float maxSpeed;
    public float accelRate;
    public float deaccelRate;
    public Vector3 direction;
    public Vector3 position;
    public Vector3 velocity;
    public Vector3 acceleration;
    public bool slowing;
    public bool stopped;
    public const float SLOW_DISTANCE = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    public void Move()
    {
        position = transform.position;
        direction = (target.transform.position - position).normalized;
        float distanceFromTarget = (target.transform.position - position).magnitude;

        if(distanceFromTarget == 0)
        {
            slowing = false;
            stopped = true;
        }
        else if(distanceFromTarget <= SLOW_DISTANCE)
        {
            slowing = true;
        }

        acceleration = direction * accelRate;

        if (stopped)
        {
            velocity = Vector3.zero;
        }
        else if (slowing)
        {
            velocity = velocity * deaccelRate;
        }
        else
        {
            velocity += acceleration;
            velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        }

        position += velocity;
        transform.position = position;
    }
}
