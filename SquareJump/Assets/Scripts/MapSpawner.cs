using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    public GameObject floor;
    public int offset;
    public Transform storage;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mat dat"))
        {
            GameObject floorPiece = Instantiate(floor) as GameObject;
            floorPiece.transform.position = new Vector3(transform.position.x + offset, -4f, 0);
            floorPiece.transform.SetParent(storage);
        }
    }
    public void clearStorage()
    {
        int i;
        for(i = 0; i < storage.childCount; i++)
        {
            Destroy(storage.GetChild(i).gameObject);
        }
    }
}
