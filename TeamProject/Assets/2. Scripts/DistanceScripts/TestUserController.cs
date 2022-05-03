using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUserController : MonoBehaviour
{
    float speead = 1.0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(this.speead, 0, 0);
    }
}
