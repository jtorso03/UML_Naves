using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 abstract public class Spaceship : MonoBehaviour {
    protected float health;
    protected float damage;
    public GameObject Respawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void TakeDmg(float damage)
    {


        health = health - damage;
        Debug.Log(health);
        if (health<=0)
        {
            Die();
        }




    }


    private void Die()
    {

        health = 50;
       
        

    }
}
