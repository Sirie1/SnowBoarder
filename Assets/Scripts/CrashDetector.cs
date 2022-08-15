using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float crashdelay = 1.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool crashed = false;
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Ground")
        {   
            Debug.Log("Crash detected");
            FindObjectOfType<PlayerController>().DisableControls();
            if (!crashed)
            {
                crashEffect.Play();
                GetComponent<AudioSource>().PlayOneShot(crashSFX);
                crashed = true;
            }

            Invoke("ReloadScene", crashdelay);


        }
        
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
