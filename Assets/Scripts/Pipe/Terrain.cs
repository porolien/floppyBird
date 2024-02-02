using UnityEngine;

public class Terrain : MonoBehaviour
{
    [SerializeField]
    float _speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }

    public void StopTheGame()
    {
        _speed = 0;
    }
}
