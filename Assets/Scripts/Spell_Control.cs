using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell_Control : MonoBehaviour
{
    public float speed = 5f;
    
    private string ENEMY_TAG = "Enemy";

    void Start()
    {
        // transform.Rotate(Vector3.forward, -90f);
    }
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
            Destroy(collider.gameObject);
        }
    }

}
