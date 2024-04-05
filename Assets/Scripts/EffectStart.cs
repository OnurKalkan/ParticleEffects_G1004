using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectStart : MonoBehaviour
{
    public GameObject effect;

    public void EffectPlay()
    {
        effect.GetComponent<ParticleSystem>().Play();
    }

}
