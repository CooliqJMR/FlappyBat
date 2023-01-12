using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatTracker : MonoBehaviour
{
    [SerializeField] private Bat _bat;
    [SerializeField] private float _xOffset;

    private void Update()
    {
        transform.position = new Vector3(_bat.transform.position.x - _xOffset, transform.position.y, transform.position.z);
    }
}
