
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
	public GameObject box;

    void Start()
   {
		box = (GameObject) Resources.Load("/Assets/Environment/Prefabs/Box_100x100x100_Prefab.prefab");
        Instantiate(box, new Vector3(4, 0, 3), Quaternion.identity);
    }
}
