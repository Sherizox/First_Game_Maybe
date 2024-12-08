using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelcom : MonoBehaviour
{
    public GameObject levelpenal;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Sphere")
        {
            levelpenal.SetActive(true);
            Time.timeScale = 0f;

           

        }
    }
}