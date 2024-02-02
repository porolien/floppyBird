using UnityEngine;

public class BirdMain : MonoBehaviour
{

    public BirdInput birdInput;
    public BirdMovement birdMovement;
    public BirdTrigger birdTrigger;
    public BirdScore birdScore;
    public BirdDie birdDie;

    private void Awake()
    {
        SendMessage("InitBird", this);
        SendMessage("ActiveEvent", this);
    }
}
