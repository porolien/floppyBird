using UnityEngine;

public class Ground : Obstacle
{
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            spawn.StopTheGame();
        }

        if (collision.tag == "Destruct")
        {
            spawn.ContinueGround(transform.position.y);
            Destroy(gameObject);
        }
    }
}
