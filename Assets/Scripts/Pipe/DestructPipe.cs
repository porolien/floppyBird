using UnityEngine;

public class DestructPipe : MonoBehaviour
{
    private SpawnPipe _spawn;

    private void Start()
    {
        _spawn = GetComponent<SpawnPipe>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
        }
    }
}
