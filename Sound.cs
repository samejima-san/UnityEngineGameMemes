using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public bool on = true; 

    public void SoundCheck()
    {
        if(on == true)
        {
            AudioListener.volume = 0.5f;
            on = false;

        }
        else
        {
            AudioListener.volume = 0.0f;
            on = true;
        }
        
    }

	// Use this for initialization
	void Start () {
        AudioListener.volume = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
