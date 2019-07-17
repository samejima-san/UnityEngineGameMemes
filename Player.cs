using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 3;
    public int points = 0;

    void OnCollisionEnter(Collision collision)
    {
        takeDamage();
    }
    void takeDamage()
    {
        loseHealth();
        if (health <= 0)
        {
            death();
        }
    }


    public void addPoints()
    {
        points += 1;
    }
    void loseHealth()
    {
        health -= 1;
    }
    void death()
    {
    }
    void showZone()
    {
    }
    // Use this for initialization
    void Start ()
    {
        this.health = 3;
        this.points = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
    }
}
