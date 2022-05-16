using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] pattern;
    GameObject map;
    public int patternNum;


    void SpawnLevelPart(Vector3 spawnPosition)
    {
        map = Instantiate(pattern[patternNum], spawnPosition, Quaternion.identity);
        StartCoroutine(DestoryGround());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            patternNum = Random.Range(0, pattern.Length);
            SpawnLevelPart(new Vector3(gameObject.transform.position.x + 39.5f, 0));
        }
    }

    IEnumerator DestoryGround()
    {
        yield return new WaitForSeconds(30f);
        Destroy(map);
    }

}
