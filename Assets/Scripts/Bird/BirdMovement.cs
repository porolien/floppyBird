using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField]
    private float jumpForce;

    private BirdMain _bm;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    public void InitBird(BirdMain birdMain)
    {
        _bm = birdMain;
        _bm.birdMovement = this;
    }
}
