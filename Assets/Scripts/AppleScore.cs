using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class AppleScore : MonoBehaviour
{
    
    public TMP_Text text;
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Apple"))
        {
            score++;
            Destroy(other.gameObject);
            text.SetText("Score :" + score.ToString());

        }



    }
}



    



