using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGhostController : MonoBehaviour
{
    float speead = 0.5f;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(this.speead, 0, 0);
    }
}
