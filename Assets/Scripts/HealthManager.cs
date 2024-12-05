using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int health;
    public static HealthManager instance;
    public TMP_Text healthtext;
    public GameObject Gameovertxt;


    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        healthtext.SetText("Health :" + health);
    }

    public void DecreaseHealth()
    {
        health -= 1;
        if (health < 0)
        {
            health = 0;
            print("Game over");
            Gameovertxt.SetActive(true);
        }
        print("Health :" + health);
        healthtext.SetText("Health :" + health);
    }

}
