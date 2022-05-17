using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestDistanceScript : MonoBehaviour
{
    int distance;
    int bestdistance;

    [SerializeField]
    Text bestDistance_Text;

    [SerializeField]
    DistanceText_Scirpt distanceText;

    private void Start()
    {
        bestdistance = PlayerPrefs.GetInt("BestDistance");
        bestDistance_Text.text = bestdistance.ToString() + "m";
    }

    private void Update()
    {
        GameOverBestDistance();
    }

    private void FixedUpdate()
    {
        BestDistanceRenwal();
    }

    void BestDistanceRenwal()
    {
        if(bestdistance<=distanceText.distance)
        {
            bestdistance = distanceText.distance;
            bestDistance_Text.text = bestdistance.ToString() + "m";
        }
    }

    void GameOverBestDistance()
    {
        if (GameOverScript.instance.is_gameOver == false)
            return;

        if(bestdistance >= PlayerPrefs.GetInt("BestDistance"))
        {
            PlayerPrefs.SetInt("BestDistance", bestdistance);
        }
    }


}
