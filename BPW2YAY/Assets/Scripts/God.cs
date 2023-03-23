using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionBehaviour : MonoBehaviour
{
    public bool collided = false;
    public Camera mainCam;
    public Camera AnimateCam;
    public GameObject Effects;
    public GameObject LakeCollider;

    private void Start()
    {
        AnimateCam.enabled = false;
        Effects.SetActive(false);
    }
    void OnTriggerEnter(Collider collision)
    {
        if (!collided)
        {
            collided = true;

            Animator LakeAnimator = LakeCollider.GetComponent<Animator>();
            LakeAnimator.enabled = true;


            mainCam.enabled = false;
            AnimateCam.enabled = true;

            Effects.SetActive(true);
        }
    }
}