using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public float interval = 1.5f;
    public GameObject BoxPrefab;

    private void Start()
    {
        InvokeRepeating(nameof(Spawnbox), 1f, interval);
    }
    void Spawnbox()
    {
       Instantiate(BoxPrefab , transform.position, Quaternion.identity);
    }
}
