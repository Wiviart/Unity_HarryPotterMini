using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnEnemy(){
        yield return new WaitForSeconds(Random.Range(1,5));
        transform.position = new Vector3(4f, Random.Range(-2.5f,2.5f),0f);
        Instantiate(enemy, transform.position, Quaternion.identity);
        StartCoroutine(SpawnEnemy());
    }
}
