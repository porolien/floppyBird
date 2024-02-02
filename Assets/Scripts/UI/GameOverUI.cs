using UnityEngine;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _UIToShow;

    [SerializeField]
    private TextMeshProUGUI _actualScore;

    [SerializeField]
    private TextMeshProUGUI _bestScore;

    private BirdMain _bm;

    public void ShowUI()
    {
        _UIToShow.SetActive(true);
        _actualScore.text = string.Empty + _bm.birdScore._Score;
    }

    public void ActiveEvent(BirdMain birdMain)
    {
        _bm= birdMain;
        birdMain.birdDie.onBirdDead += ShowUI;
    }
}
