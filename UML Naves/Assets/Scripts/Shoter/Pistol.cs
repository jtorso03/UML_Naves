using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Cannon {

    private float currentTime;
    private float Cadency = 0.25f;


	// Use this for initialization
	void Start () {

        n = 0;
	}
	
	// Update is called once per frame
	void Update () {

        ChangeBullet();
        currentTime += Time.deltaTime;
        if (currentTime>Cadency && Input.GetMouseButton(1) == true)
        {
            Shot();
            currentTime = 0;
        }
       

    }

    public override void Shot()
    { 
        
        Instantiate(BulletRefernce[n], this.transform.position, this.transform.rotation);
        

        base.Shot();
    }
    public override void ChangeBullet()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            n = 0;
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            n = 1 ;
        }

        base.ChangeBullet();
    }
}
