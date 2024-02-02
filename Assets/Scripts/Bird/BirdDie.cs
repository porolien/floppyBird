using System;
using UnityEngine;

public class BirdDie : MonoBehaviour
{
    private BirdMain _bm;

    public event Action onBirdDead;

    public void InitBird(BirdMain birdMain)
    {
        _bm = birdMain;
        _bm.birdDie = this;
    }

    public void Die()
    {
        onBirdDead();
        _bm.birdInput.SwitchToUIMap();
    }
}
