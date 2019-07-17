using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanye : MonoBehaviour
{
    private int health = 1;
    float speed = .025f;
    public Transform TargetObject;
    private Ray ray; // The ray
    private RaycastHit hit; // What we hit

    public Player player;

    private void moveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, TargetObject.position, speed);     
    }

    private void Death()
    {
        if(this.health<=0)
        {
            Destroy(this.gameObject);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        this.health--;
    }

    public void isClicked()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Ray will be sent out from where your mouse is located    
        if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0)) // On left click we send down a ray
        {
            BoxCollider bc = hit.collider as BoxCollider;
            if(bc != null)
            {
                Destroy(bc.gameObject);
            }
            player.GetComponent<Player>().addPoints();
        }
    }

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.moveToPlayer();
        this.isClicked();
        this.Death();
    }
}
