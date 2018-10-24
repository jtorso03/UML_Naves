using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalyerMovement :Movement {

    private float MaxSpeed = 20;
    private float CurrentSpeed=0;
    private float Acceleration= 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    public override void Move()
    {
        if (Input.GetAxis("Horizontal") == 1 || Input.GetAxis("Horizontal") == -1)
        {
            CurrentSpeed += Acceleration;
        }if (CurrentSpeed >= MaxSpeed)
        {
            CurrentSpeed = MaxSpeed;
        }

        direction = new Vector3(CurrentSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
        this.transform.position += direction;

        base.Move();
    }
}
