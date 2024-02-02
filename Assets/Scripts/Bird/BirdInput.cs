using UnityEngine;
using UnityEngine.InputSystem;

public class BirdInput : MonoBehaviour
{
    private PlayerInput _playerInput;
    private BirdMain _bm;

    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    public void OnJump()
    {
        _bm.birdMovement.Jump();
    }

    public void InitBird(BirdMain birdMain)
    {
        _bm = birdMain;
        _bm.birdInput = this;
    }

    public void SwitchToUIMap()
    {
        _playerInput.SwitchCurrentActionMap("UI");
    }

    public void SwitchToBirdMap()
    {
        _playerInput.SwitchCurrentActionMap("Bird");
    }
}
