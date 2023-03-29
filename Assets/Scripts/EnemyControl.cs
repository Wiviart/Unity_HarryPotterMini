using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }
    void EnemyMove()
    {
        transform.position -= new Vector3(Time.deltaTime * speed, 0f, 0f);
    }
}
