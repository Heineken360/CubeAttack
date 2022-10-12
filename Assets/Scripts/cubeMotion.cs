using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeMotion : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    
    void Update()
    {
        rb.velocity = new Vector3(0f, 0f, 1f) * SpawnPoint.speed;
        if (gameObject.transform.position.z >= SpawnPoint.distance)
        {
            Destroy(gameObject);
        }
        
    }

    
    
}
