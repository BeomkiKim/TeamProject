using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject levelPart_1;
    GameObject map;


    void SpawnLevelPart(Vector3 spawnPosition)
    {
        map = Instantiate(levelPart_1, spawnPosition, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            SpawnLevelPart(new Vector3(gameObject.transform.position.x + 25.0f, 0));
            StartCoroutine(DestoryGround());
        }
    }

    IEnumerator DestoryGround()
    {
        yield return new WaitForSeconds(11.5f);
        Destroy(map);
    }

}
