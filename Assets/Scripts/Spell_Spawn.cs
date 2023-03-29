using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell_Spawn : MonoBehaviour
{
    [SerializeField] private GameObject spell;
    [SerializeField] private float spawnTime;

    void Start()
    {
        StartCoroutine(SpellShoot());
    }
    IEnumerator SpellShoot()
    {
        yield return new WaitForSeconds(spawnTime);

        Instantiate(spell, transform.position, Quaternion.Euler(0f, 0f, -90f));
        StartCoroutine(SpellShoot());
    }

}
