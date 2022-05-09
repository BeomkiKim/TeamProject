using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigCamera : MonoBehaviour
{
    [SerializeField]
    GameObject character;


    private void Update()
    {
        Rigging();
    }

    void Rigging()
    {
        this.gameObject.transform.position = new Vector3(character.transform.position.x+5f, 0, -10);
    }
}
