using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSpawn : MonoBehaviour
{
    public Transform pos1, pos2;
    public GameObject triangle;
    void Start()
    {
        int x = Random.Range(1, 3);
        if (x == 1)
        {
            GameObject obstacle = Instantiate(triangle) as GameObject;
            obstacle.transform.position = pos1.position;
            obstacle.transform.SetParent(transform);
        }
        x = Random.Range(1, 3);
        if (x == 1)
        {
            GameObject obstacle = Instantiate(triangle) as GameObject;
            obstacle.transform.position = pos2.position;
            obstacle.transform.SetParent(transform);
        }
    }

 
}
