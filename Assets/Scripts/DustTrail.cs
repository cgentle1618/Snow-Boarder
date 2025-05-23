using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] float loadDelay = 0f;
    [SerializeField] ParticleSystem trailEffect;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("on ground");
            trailEffect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("on air");
            trailEffect.Stop();
        }
    }
}
