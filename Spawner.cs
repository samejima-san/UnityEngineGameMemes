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

	// Use this for initialization
	void Start ()
    {	
	}

    void Update ()
    {
        cooldownTime = Random.Range(2.0f, 8.0f);
        if (Time.time > nextFireTime)
        {
            SpawnObject();
            nextFireTime = Time.time + cooldownTime;
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
