using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float finishdelay = 1.5f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            Debug.Log("Finish line reached");
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", finishdelay);

        }
        
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
