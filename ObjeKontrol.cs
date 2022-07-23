using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeKontrol : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 vektor = new Vector3(0.15f, 0.3f, 0.45f);
        transform.Rotate(vektor);
    }
}
