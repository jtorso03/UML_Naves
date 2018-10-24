using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cannon : MonoBehaviour {

    protected bool HasLaunched;
    public GameObject[] BulletRefernce;
    protected int n;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    virtual public void Shot()
    {


    }
    virtual public void ChangeBullet()
    {



    }
}
