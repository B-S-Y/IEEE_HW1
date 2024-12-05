using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnerMovement : MonoBehaviour
{
    public GameObject AppleSpawner;
    public Vector3 vector;
    public float speed;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        { //deltatime =1/fps
            AppleSpawner.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            AppleSpawner.transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow))//ayrý iflerde olma sebepleri ayný anda basamayýz yoksa
        {
            AppleSpawner.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow))
        {
            AppleSpawner.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }


        if (Input.GetKey(KeyCode.Space))//ayrý iflerde olma sebepleri ayný anda basamayýz yoksa
        {
            AppleSpawner.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            AppleSpawner.transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
        }

        print(AppleSpawner.transform.position);
    }
}
