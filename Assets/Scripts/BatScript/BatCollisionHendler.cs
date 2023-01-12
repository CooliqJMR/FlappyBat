using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Bat))]
public class BatCollisionHendler : MonoBehaviour
{
    private Bat _bat;

    private void Start()
    {
        _bat = GetComponent<Bat>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ScoreZone scoreZone))
            _bat.ScoreAdd();
        else
        _bat.Die();
    }
}
