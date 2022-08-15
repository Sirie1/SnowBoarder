using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustTrail;
    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustTrail.Play();
            Debug.Log("Touching GND");
        }
        
    }
    void OnCollisionExit2D (Collision2D other) 
    {
        if (other.gameObject.tag == "Ground")
        {
            dustTrail.Stop();
            Debug.Log("not touching GND");
        }
        
    }
}
