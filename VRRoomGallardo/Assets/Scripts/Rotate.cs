using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    [SerializeField]
    private GameObject reticleCircular;
    private readonly float speed = 50.0f;
    private Vector3 vector3;

    void Update()
    {
        if (Application.isPlaying)
        {
            vector3 = new Vector3(0, 1, 0);
            transform.Rotate(speed * Time.deltaTime * vector3);
        }
    }
}
