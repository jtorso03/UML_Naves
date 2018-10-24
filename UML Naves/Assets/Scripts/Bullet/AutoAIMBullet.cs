using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAIMBullet : Bullet {

  
	// Use this for initialization
	virtual public void Start () {
        Damage = 2;
        base.Start();


	}
	
	// Update is called once per frame
	void Update () {
        MoveBullet();
	}


    public override void MoveBullet()
    {
        Speed = 10f;
        Target = GameObject.FindWithTag("Enemy");

        directionB = ((Target.transform.position - this.transform.position).normalized)*Speed*Time.deltaTime;
        this.transform.position += directionB;

        base.MoveBullet();
    }

    public override void ApplyDmg()
    {
        
        base.ApplyDmg();
    }
}
