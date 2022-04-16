using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundCtrl : MonoBehaviour
{
    MeshRenderer meshRender;

    public float speed;
    float offset;
    // Start is called before the first frame update
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>();        
    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * speed;
        meshRender.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
