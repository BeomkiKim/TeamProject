using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceText_Scirpt : MonoBehaviour
{
    [SerializeField]
    private GameObject character;

    [SerializeField]
    private Text distance_Text;

    public int distance;

    GameObject user;
    GameObject ghost;

    public bool isCurrentDistance;

    private void Start()
    {
        this.user = GameObject.FindGameObjectWithTag("Player");
        this.ghost = GameObject.FindGameObjectWithTag("Ghost");
    }

    private void Update()
    {
        GetCloseTwo();
    }

    public void FixedUpdate()
    {
        DistanceText_Renwal();
    }

    public void DistanceText_Renwal()
    {
        float distance_Shame = character.transform.position.x+4f;
        int distance_Shame_Int = (int)distance_Shame;
        distance_Text.text = distance_Shame_Int.ToString() + "m";
        distance = (int)distance_Shame;
    }

    void GetCloseTwo()
    {
        if (isCurrentDistance == true)
            return;

        float length = this.user.transform.position.x - this.ghost.transform.position.x;
        float lenght_Int = (int)length;
        if(lenght_Int<4)
        {
            distance_Text.gameObject.SetActive(false);
        }
        else
        {
            distance_Text.gameObject.SetActive(true);
        }
    }
}
