using UnityEngine;

public class BirdTrigger : MonoBehaviour
{
    private BirdMain _bm;

    public void InitBird(BirdMain birdMain)
    {
        _bm = birdMain;
        _bm.birdTrigger = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "PipePoint":
                _bm.birdScore.GainScore();
                break;
            case "Obstacle":
                _bm.birdDie.Die();
                break;
        }
    }
}
