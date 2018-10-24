using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : Bullet {


    // Use this for initialization
    virtual public void Start () {
        base.Start();
        Damage = 3;
	}
	
	// Update is called once per frame
	void Update () {
        MoveBullet();
	}

    public override void MoveBullet()
    {
        Speed = 10f;
        directionB = new Vector3(0, Speed, 0)*Time.deltaTime;
        this.transform.position += directionB;      
        
    }
}
