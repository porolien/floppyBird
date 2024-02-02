using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _spawnList = new List<GameObject>();

    [SerializeField]
    private GameObject _ground;

    [SerializeField]
    private Transform _spawnPoint;

    [SerializeField]
    private Transform _spawnParent;

    private Terrain _terrain;

    public void SpawnNewPipe()
    {
        GameObject newPipe = Instantiate(_spawnList[Random.Range(0, _spawnList.Count)], _spawnParent);
        newPipe.transform.position = new Vector2(_spawnPoint.position.x, newPipe.transform.position.y);
    }

    public void ContinueGround(float posY)
    {
        GameObject newGround = Instantiate(_ground, _spawnParent);
        newGround.transform.position = new Vector2(_spawnPoint.position.x, posY);
    }

    void Start()
    {
        _terrain = (Terrain)FindAnyObjectByType(typeof(Terrain));
        InvokeRepeating("SpawnNewPipe", 1, 1);
    }

    public void StopTheGame()
    {
        CancelInvoke();
        _terrain.StopTheGame();
    }
}
