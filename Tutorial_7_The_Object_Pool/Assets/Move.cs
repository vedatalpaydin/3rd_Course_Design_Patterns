using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 velocity;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag=="Asteroid")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    void Update()
    {
        transform.Translate(velocity);
    }
}
