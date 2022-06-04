using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [Header("1스테이지시간")]
    public float stage1Max;
    [Header("2스테이지시간")]
    public float stage2Max;

    public GameObject[] bgm;

    public float gameTime;
    public int level;

    private void Update()
    {

        gameTime += Time.deltaTime;
        if (gameTime >= 0 && gameTime < stage1Max) { level = 1;}
        if (gameTime >= stage1Max && gameTime < stage2Max)
        {   level = 2;
            StartCoroutine(BgmDelay());
        }
        if (gameTime >= stage2Max) { level = 3; }
    }
    IEnumerator BgmDelay()
    {
        yield return new WaitForSecondsRealtime(7.0f);
        bgm[0].SetActive(false);
        bgm[1].SetActive(true);
    }
}
