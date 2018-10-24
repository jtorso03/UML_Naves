using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour {

    public GameObject Target;
   public  float Damage;
    protected Vector3 directionB = new Vector3();
    protected float Speed;
    protected float WaitToDestroy=5.0f;
	// Use this for initialization
	virtual public void Start () {
        InvokeRepeating("Destroy", WaitToDestroy, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    virtual public void MoveBullet()
    {

    }
    virtual public void ApplyDmg()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Spaceship>() != null)
        {

            Debug.Log("enter");
            other.GetComponent<Spaceship>().TakeDmg(Damage);
            Destroy(this.gameObject);
        }
        

    }

    virtual public void Destroy()
    {
        Debug.Log("hi");
        Destroy(this.gameObject);
    }
}
