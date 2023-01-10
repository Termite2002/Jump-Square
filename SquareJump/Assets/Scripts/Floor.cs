using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        player = GameObject.Find("Player").transform;    
    }
    void Update()
    {
        if (transform.position.x < (player.position.x-12))
        {
            Destroy(gameObject);
        }    
    }
}
