using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public HealthManager healthmanager;
   

    // Update is called once per frame
    
    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Apple"))
            {
                Destroy(other.gameObject);
                healthmanager.DecreaseHealth();

            }

        }
    
}
