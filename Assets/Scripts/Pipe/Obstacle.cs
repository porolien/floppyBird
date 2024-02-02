using UnityEngine;

public class Obstacle : MonoBehaviour
{
    protected SpawnPipe spawn;

    private void Start()
    {
        spawn = (SpawnPipe)FindAnyObjectByType(typeof(SpawnPipe));
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destruct")
        {
            Destroy(gameObject);
        }

        if (collision.tag == "Player")
        {
            spawn.StopTheGame();
        }
    }
}
