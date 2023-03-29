using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    private string POINT_TAG = "Point";
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag(POINT_TAG)) FindObjectOfType<GameControl>().ScoreSubtract();
        Destroy(collider.gameObject);
    }
}
