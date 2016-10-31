using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]

public class PlayVideo : MonoBehaviour {

    public MovieTexture movie;
    private AudioSource audio;

	// Use this for initialization
	void Start () {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
	}

    public void videoControls(string buttonName)
    {
        Debug.Log("buttonName = " + buttonName);
        if (buttonName.Equals("pause") && movie.isPlaying)
        {
            Debug.Log("pause/resume clicked - pause video");
            movie.Pause();
        }
        else if ((buttonName.Equals("pause") || buttonName.Equals("play")) && !movie.isPlaying)
        {
            Debug.Log("pause/resume clicked - resume video");
            audio.Play();
            movie.Play();
        }
        else if (buttonName.Equals("playagain"))
        {
            Debug.Log("play again");
            movie.Stop();
            audio.Play();
            movie.Play();
        }
        else if (buttonName.Equals("welcome"))
        {
            Debug.Log("welcome screen");
            Application.LoadLevel(0);
        }
        else if (buttonName.Equals("startnow"))
        {
            Debug.Log("start now..");
            Application.LoadLevel(1);
        }
    }

    // Update is called once per frame
    /*void Update () {
	    if(Input.GetKeyDown(KeyCode.Space) && movie.isPlaying)
        {
            Debug.Log("if");
            movie.Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && !movie.isPlaying)
        {
            Debug.Log("else "+movie);
            audio.Play();
            movie.Play();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("enter " + movie);
            movie.Stop();
            audio.Play();
            movie.Play();
        }
    }*/
}
