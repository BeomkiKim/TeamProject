using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    MeshRenderer meshRender;
    public Material[] backGroundMaterial;
    Renderer backGroundRederer;

    public Transform cameraTransform;

    public float speed;
    float offset;

    public GameObject[] stageBackGround;

    [Header("플레이어거리")]
    public float distance = 0f;

    [Header("2라운드거리")]
    public float secondDistance;

    [Header("3라운드거리")]
    public float thirdDistance;
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>();
        backGroundRederer = GetComponent<Renderer>();
        backGroundRederer.enabled = true;
        backGroundRederer.sharedMaterial = backGroundMaterial[0];
    }

    void Update()
    {
        Vector2 backGround =cameraTransform.position;
        transform.position = backGround;

        distance += Time.deltaTime;

        if (distance >= secondDistance && distance < thirdDistance)
        {

            backGroundRederer.sharedMaterial = backGroundMaterial[1];
            offset += Time.deltaTime * speed;
            meshRender.material.mainTextureOffset = new Vector2(offset, 0);
        }
        else if (distance >= thirdDistance)
        {
            backGroundRederer.sharedMaterial = backGroundMaterial[2];
            offset += Time.deltaTime * speed;
            meshRender.material.mainTextureOffset = new Vector2(offset, 0);
        }
        else
        {
            offset += Time.deltaTime * speed;
            meshRender.material.mainTextureOffset = new Vector2(offset, 0);
        }

    }
}
