using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CollisionAnimation : MonoBehaviour
{
    public bool collided = false;

    void OnTriggerEnter(Collider collision)
    {
        if (!collided)
        {
            collided = true;

            GameObject InteractionCube = gameObject;
            Animator InteractionCubeAnimator = InteractionCube.GetComponent<Animator>();
            InteractionCubeAnimator.enabled = true;

            GetComponent<AudioSource>().Play();
        }
    }
}
