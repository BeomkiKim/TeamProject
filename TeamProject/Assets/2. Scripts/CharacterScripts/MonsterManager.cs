using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public static MonsterManager instance;
    public List<GameObject> dead_Monsters = new List<GameObject>();

    private void Awake()
    {
        if (!instance)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Update()
    {
        if(dead_Monsters.Count >=1)
        {
            Dead();
        }
    }

    void Dead()
    {
        //애니메이션 작동
        //끝난 후(if를 써서 끝난 애들만 삭제시킬 것이나 지금은 에셋이 없어 이를 대체함)

        for(int i = 0; i< dead_Monsters.Count;i++)
        {
            Destroy(dead_Monsters[i]);
        }

        
    }

}
