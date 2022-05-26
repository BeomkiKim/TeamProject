using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] pattern;
    GameObject map;
    public int patternNum;

    MapManager mapManager;
    public bool isSpawn;

    private void Awake()
    {
        mapManager = GameObject.Find("MapManager").GetComponent<MapManager>();
        isSpawn = false;
    }

    void SpawnLevelPart(Vector3 spawnPosition)
    {
        map = Instantiate(pattern[patternNum], spawnPosition, Quaternion.identity);
        StartCoroutine(DestoryGround());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && mapManager.level == 1 && !isSpawn)
        {
            patternNum = Random.Range(0, 4);
            SpawnLevelPart(new Vector3(gameObject.transform.position.x + 43.0f, 0));
            isSpawn = true;
        }
        if(collision.tag == "Player" && mapManager.level == 2 && !isSpawn )
        {
            patternNum = Random.Range(4, 8);
            SpawnLevelPart(new Vector3(gameObject.transform.position.x + 43.0f, 0));
            isSpawn = true;
        }
        if (collision.tag == "Player" && mapManager.level == 3 && !isSpawn)
        {
            patternNum = Random.Range(8, 10);
            SpawnLevelPart(new Vector3(gameObject.transform.position.x + 43.0f, 0));
            isSpawn = true;
        }
    }

    IEnumerator DestoryGround()
    {
        yield return new WaitForSeconds(30f);
        Destroy(map);
    }

}
