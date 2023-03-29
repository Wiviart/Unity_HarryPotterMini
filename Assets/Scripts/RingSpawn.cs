using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpawn : MonoBehaviour
{
    [SerializeField] private GameObject Ring;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRing());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnRing()
    {
        yield return new WaitForSeconds(Random.Range(1, 5));
        
        transform.position = new Vector3(4f, Random.Range(-2f,2f),0f);
        Instantiate(Ring, transform.position, Quaternion.identity);

        StartCoroutine(SpawnRing());

    }
}
