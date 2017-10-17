using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{


    public float Speed = 0.06f;
    private float RotationAmount;//how much to rotate each update
    private float Direction;//direction in radians 0 is right, Pi is left.
    private float CurrentRotation = 0;//current rotation in degrees

    // Use this for initialization
    void Start()
    {
        //calculates the random numbers for update amounts
        Direction = Random.Range(-Mathf.PI, Mathf.PI);
        RotationAmount = Random.Range(0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        float newY = transform.position.y + Speed * Mathf.Sin(Direction);
        float newX = transform.position.x + Speed * Mathf.Cos(Direction);

        //update the object's position and rotation.
        transform.position = new Vector3(newX, newY, transform.position.z);
        transform.rotation = Quaternion.AngleAxis(CurrentRotation, Vector3.forward);
        CurrentRotation += RotationAmount;
    }

    //Called when a collision occurs.
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name.Equals("RightBorder"))//right wall
        {
            Direction = Mathf.PI - Direction;
        }
        else if (other.name.Equals("BotBorder"))//bot wall
        {
            Direction = -Direction;
        }
        else if (other.name.Equals("LeftBorder"))//left wall
        {
            Direction = Mathf.PI - Direction;
        }
        else if (other.name.Equals("TopBorder"))//top wall
        {
            Direction = -Direction;
        }
        else//collision is with the other object
        {
            Debug.Log(other.name);
        }
    }

}
