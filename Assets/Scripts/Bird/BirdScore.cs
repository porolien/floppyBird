using System;
using UnityEngine;

public class BirdScore : MonoBehaviour
{
    private int _score;

    public int _Score
    {
        get { return _score; }
    }

    private BirdMain _bm;

    public event Action<int> onScoreChange;

    public void InitBird(BirdMain birdMain)
    {
        _bm = birdMain;
        _bm.birdScore = this;
    }

    public void GainScore()
    {
        _score++;
        if (_score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", _score);
        }

        onScoreChange(_score);
    }
}
