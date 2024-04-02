using UnityEngine;

public class SpawnByTime : MonoBehaviour
{
    [Tooltip("Time, in seconds, between spawns")]
    public float _spawnDelay;
    [Tooltip("Shall we spawn at the begining or shall we wait <<SpawnDelay>> amount of time?")]
    public bool _spawnAtBegining;
    [Tooltip("If set to false, first prefab will be spawned")]
    public bool _useRandomPrefab = false;

    public GameObject[] _prefabs;

    void Start()
    {
        InvokeRepeating("SpawnItem", _spawnAtBegining ? 0f : _spawnDelay, _spawnDelay);
    }

    void SpawnItem()
    {
        int l_spawnPrefabIndex = _useRandomPrefab ? Random.Range(0, _prefabs.Length) : 0;
        Instantiate<GameObject>(_prefabs[l_spawnPrefabIndex]);
    }
}
