using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BasketSpawner : MonoBehaviour
{
    public GameObject BasketPrefab;
    public Transform[] SpawnPoint;




    // Update is called once per frame
    private void Start()
    {
        //SpawnBasket();
    }
    //private void OnCollisionEnter(Collision collision )
    //{


    //    if (collision.collider.CompareTag("Apple"))
    //    {


    //        Destroy(collision.gameObject);
    //        Destroy(gameObject);

    //        SpawnBasket();


    //    }
    //}
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.CompareTag("Apple"))
    //    {
    //        Destroy(collision.gameObject);
            
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basket"))
        {
            SpawnBasket();
            Destroy(other.gameObject);
            

        }

    }

    






    public void SpawnBasket()
       {
            
          int index = Random.Range(0, SpawnPoint.Length);
          print(index);

         Instantiate(BasketPrefab, SpawnPoint[index].position, Quaternion.identity);




       }
    }

