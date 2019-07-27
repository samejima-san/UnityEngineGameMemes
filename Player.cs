using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 3;
    public int points = 0;

    public void addPoints()
    {
        points += 1;
    }
    public void loseHealth()
    {
        health -= 1;
    }
    void death()
    {
    }
    // Use this for initialization
    void Start ()
    {
       health = 3;
       points = 0;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (health <= 0)
        {
            death();
        }
    }
}
