using UnityEngine;
using Random = UnityEngine.Random;

public class MakeBoxes : MonoBehaviour
{
    public GameObject prefab;
    public int n = 300;
    void Start()
    {
        for (int x = 0; x < n; x++)
        {
            var position = new Vector3(Random.Range(2, 15), Random.Range(0, 15), Random.Range(0, 10));
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
