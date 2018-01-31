using UnityEngine;
using System.Linq;

public class Floor : MonoBehaviour
{
	public GameObject cubePrefab;
	public float width = 2.0f;
	public float height = 0.7f;
	[ContextMenu("Build")]

	void Build()
	{
		var floor1 = Instantiate(cubePrefab, GetComponent<Transform>());
		floor1.transform.localPosition = new Vector3(0, 0, 0);
		floor1.transform.localScale = new Vector3(width*1.8f, height, width*4f);

		var floor2 = Instantiate(cubePrefab, transform);
		floor2.transform.localPosition = new Vector3(0, height, 0);
		floor2.transform.localScale = new Vector3(width*1.6f, height, width*3.8f);

		var floor3 = Instantiate(cubePrefab, transform);
		floor3.transform.localPosition = new Vector3(0, height*2, 0);
		floor3.transform.localScale = new Vector3(width*1.4f, height, width*3.6f);
	}

	[ContextMenu("Destory All Children")]
	void DestroyAllChildren()
	{
		foreach (Transform t in transform.Cast<Transform>().ToArray())
		{
			DestroyImmediate(t.gameObject);
		}
	}
}
