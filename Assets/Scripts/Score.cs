using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Bat _bat;
    [SerializeField] private TMP_Text _score;

    private void OnEnable()
    {
        _bat.ScoreChanged += OnScoreChanged;
    }

    private void OnDisable()
    {
        _bat.ScoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(int score)
    {
        _score.text = score.ToString();
    }
}
