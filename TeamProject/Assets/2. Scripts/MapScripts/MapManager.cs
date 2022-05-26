using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [Header("1���������ð�")]
    public float stage1Max;
    [Header("2���������ð�")]
    public float stage2Max;



    float gameTime;
    public int level;

    private void Update()
    {
        gameTime += Time.deltaTime;

        gameTime += Time.deltaTime;
        if (gameTime >= 0 && gameTime < stage1Max) { level = 1; }
        if (gameTime >= stage1Max && gameTime < stage2Max) { level = 2; }
        if (gameTime >= stage2Max) { level = 3; }
    }
}
