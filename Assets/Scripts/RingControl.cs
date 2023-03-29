using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingControl : MonoBehaviour
{
    private string PLAYER_TAG="Player";
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RingMove();
    }
    void RingMove()
    {
        transform.position -= new Vector3(Time.deltaTime * speed, 0f, 0f);
        
    }
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag(PLAYER_TAG)) Destroy(gameObject);
    }
}
