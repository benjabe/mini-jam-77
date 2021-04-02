using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    [SerializeField] private float _starsPerUnitSquared = 2.0f;

    private int _starsSpawned = 0;

    private void SpawnStar()
    {
        var starGameObject = Instantiate(new GameObject($"Star_{_starsSpawned}"), transform);
    }
}
