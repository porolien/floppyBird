using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _actualScore;

    public void ShowUI()
    {
        _actualScore.gameObject.SetActive(true);
    }

    public void HideUI()
    {
        _actualScore.gameObject.SetActive(false);
    }

    public void ChangeScoreUI(int newScore)
    {
        _actualScore.text = string.Empty + newScore;
    }

    public void ActiveEvent(BirdMain birdMain)
    {
        birdMain.birdScore.onScoreChange += ChangeScoreUI;
        birdMain.birdDie.onBirdDead += HideUI;
    }
}
