using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject ApplePrefab;
    public Transform SpawnPoint;
    public float SpawnTime;
    private float Timer;
    // Start is called before the first frame update
    public AppleScore applescore;

    // Update is called once per frame
    void Update()
    {
        
        Timer += Time.deltaTime;
        //print(Timer);
       
        if (Timer >= SpawnTime)
        {
            

            
                if (Input.GetKey(KeyCode.E))
                { //deltatime =1/fps
                    SpawnApple();
                    Timer = 0;
                }

            

           
            
            
            
        }

        
    }

    void SpawnApple()
    {

        Instantiate(ApplePrefab, SpawnPoint.transform.position, Quaternion.identity);

    }
}
