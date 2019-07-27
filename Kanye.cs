using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanye : MonoBehaviour
{
    float speed = .025f;
    public Transform TargetObject;
    private Ray ray; // The ray
    private RaycastHit hit; // What we hit

    public Player player;

    private void moveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, TargetObject.position, speed);     
    }


    private void OnCollisionEnter(Collision collision)
    {
        player.GetComponent<Player>().loseHealth();
        Destroy(this.gameObject);
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
        if(player.GetComponent<Player>().points >= 0 && player.GetComponent<Player>().points < 25)
        {
            speed = .025f;
        }
        else if(player.GetComponent<Player>().points >= 25 && player.GetComponent<Player>().points < 50)
        {
            speed = .035f;
        }
        else if(player.GetComponent<Player>().points >= 50 && player.GetComponent<Player>().points < 125)
        {
            speed = .045f;
        }
        else if (player.GetComponent<Player>().points >= 125 && player.GetComponent<Player>().points < 200)
        {
            speed = .065f;
        }
        else
        {
            speed += .001f;
        }

        moveToPlayer();
        isClicked();
    }
}
