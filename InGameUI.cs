using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    [SerializeField] Text pointstext;
    [SerializeField] Text healthtext;
    [SerializeField] Text zonetext;
    public Player player;
    float x = .5f;
    float changeSpeed = .005f;

    // Use this for initialization
    void Start () {
        pointstext.text = ("Points: " + player.GetComponent<Player>().points);
        healthtext.text = ("Health:  " + player.GetComponent<Player>().health);
        zonetext.rectTransform.localScale.Set(x, x, x);
    }
	
	// Update is called once per frame
	void Update () {
        pointstext.text = ("Points: " + player.GetComponent<Player>().points);
        healthtext.text = ("Health:  " + player.GetComponent<Player>().health);
        

        x += changeSpeed;
        if (x <= .45f || x >= 2.5f)
        {
           changeSpeed = changeSpeed * -1;
        }
        zonetext.rectTransform.localScale = new Vector3(x, x, x);
    }
}
