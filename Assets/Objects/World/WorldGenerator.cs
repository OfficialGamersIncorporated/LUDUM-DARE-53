using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour {

    public float Speed = 10;
    public float RunSpeedMultiplier = 2;
    //public float PlayerMaxSpeed = 20;
    public float Spacing = 10;
    public GameObject Ground;
    //public SpeedUpCollider SpeedUpCollider;
    public static WorldGenerator Singleton;

    void Start() {
        Singleton = this;
    }

    private void FixedUpdate() {
        float currentSpeed = Speed;
        //if(SpeedUpCollider.PlayerTouching) {
        //    currentSpeed = PlayerMaxSpeed;
        //}
        if(Input.GetButton("Fire3")) {
            currentSpeed = Speed * RunSpeedMultiplier; //PlayerMaxSpeed;
        }

        transform.position += currentSpeed * Time.fixedDeltaTime * Vector3.left;
        float xOffset = transform.position.x % (Spacing * 2);
        Ground.transform.position = new Vector3(xOffset, transform.position.y, transform.position.z);
    }
}
