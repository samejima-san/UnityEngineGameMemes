using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject KanyeHeadPrefab;
    public Vector3 center;
    public Vector3 size;

    public float cooldownTime;
    private float nextFireTime = 0;

    public Player player;
    float x = 8.0f;

	// Use this for initialization
	void Start ()
    {	
	}

    void Update ()
    {
        cooldownTime = Random.Range(1.5f, x);
        if (Time.time > nextFireTime)
        {
            SpawnObject();
            nextFireTime = Time.time + cooldownTime;
        }
   

        if (player.GetComponent<Player>().points >= 0 && player.GetComponent<Player>().points < 25)
        {
            x = 8.0f;
        }
        else if (player.GetComponent<Player>().points >= 25 && player.GetComponent<Player>().points < 50)
        {
            x = 6.0f;
        }
        else if (player.GetComponent<Player>().points >= 50 && player.GetComponent<Player>().points < 125)
        {
            x = 4.5f;
        }
        else if (player.GetComponent<Player>().points >= 125 && player.GetComponent<Player>().points < 200)
        {
            x = 3.0f;
        }
        else if (player.GetComponent<Player>().points >= 200 && player.GetComponent<Player>().points < 300)
        {
            x = 2.8f;
        }
        else if (player.GetComponent<Player>().points >= 300 && player.GetComponent<Player>().points < 400)
        {
            x = 2.4f;
        }
        else if (player.GetComponent<Player>().points >= 400 && player.GetComponent<Player>().points < 500)
        {
            x = 2.0f;
        }
    }
	
	// Update is called once per frame
	void SpawnObject()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(KanyeHeadPrefab, pos, Quaternion.identity);
	}

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
