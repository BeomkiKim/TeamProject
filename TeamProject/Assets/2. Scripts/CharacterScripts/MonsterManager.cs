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
        //�ִϸ��̼� �۵�
        //���� ��(if�� �Ἥ ���� �ֵ鸸 ������ų ���̳� ������ ������ ���� �̸� ��ü��)

        for(int i = 0; i< dead_Monsters.Count;i++)
        {
            Destroy(dead_Monsters[i]);
        }

        
    }

}
