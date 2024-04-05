using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ParticleSystem flamio2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ParticleTrigger"))
        {
            //other.transform.Find("FlameStream").GetComponent<ParticleSystem>().Play();
            flamio2.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ParticleTrigger"))
        {
            //other.transform.Find("FlameStream").GetComponent<ParticleSystem>().Play();
            flamio2.Stop();
        }
    } 
}
