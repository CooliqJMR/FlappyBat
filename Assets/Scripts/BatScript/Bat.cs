using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BatMover))]
public class Bat : MonoBehaviour
{
    private BatMover _mover;
    private int _score;

    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChanged;

    private void Start()
    {
        _mover = GetComponent<BatMover>();
    }

    public void ScoreAdd()
    {
        _score++;
        ScoreChanged?.Invoke(_score);
    }
    public void ResetPlayer()
    {
        _score = 0;
        ScoreChanged?.Invoke(_score);
        _mover.ResetBat();
    }

    public void Die()
    {
        GameOver?.Invoke();
        
    }
}
