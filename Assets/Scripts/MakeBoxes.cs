using UnityEngine;
using Random = UnityEngine.Random;
using System.Collections;

public class MakeBoxes : MonoBehaviour
{
	public GameObject alpha_block;
    void Start()
    {
         StartCoroutine(InfiniteLoop());
    }
	public IEnumerator InfiniteLoop()
	{
    	WaitForSeconds waitTime = new WaitForSeconds(1);
    	while (true)
    	{
        	var position = new Vector3(Random.Range(-5, 5), Random.Range(15, 50), Random.Range(-5, 5));
        	GameObject gameObject = Instantiate(alpha_block, position, Quaternion.identity);
			yield return waitTime;
    	}
	}
}
