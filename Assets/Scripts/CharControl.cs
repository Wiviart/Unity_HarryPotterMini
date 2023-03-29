using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{
    private string ENEMY_TAG = "Enemy";
    private string POINT_TAG = "Point";
    [SerializeField] private float jumpForce;
    private Rigidbody2D character;
    void Start()
    {
        character = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        CharFly();
    }
    void CharFly()
    {
        // Make character jump by mouse click
        if (Input.GetMouseButtonDown(0))
        {
            character.velocity = jumpForce * Vector2.up;
        }

        // // Make character rotate up or down when jumping or falling
        // if (character.velocity.y > 0) character.SetRotation(30);
        // else if (character.velocity.y == 0) character.SetRotation(0);
        // else character.SetRotation(-45);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag(ENEMY_TAG)) FindObjectOfType<Menu>()._EndGame();
        if (collider.CompareTag(POINT_TAG)) FindObjectOfType<GameControl>().ScoreCount();
    }
}
