using UnityEngine;

public class Clouds : MonoBehaviour
{
	[System.Serializable] class Cloud
	{
		public MeshRenderer meshRenderer = null;
		public float speed = 0f;
		[HideInInspector] public Vector2 offset;
		[HideInInspector] public Material mat;
	}

	[SerializeField] Cloud[] allClouds;

	int count;

	void Start ()
	{
		count = allClouds.Length;
		for (int i = 0; i < count; i++) {
			allClouds [i].offset = Vector2.zero;
			allClouds [i].mat = allClouds [i].meshRenderer.material;
		}
	}

	void Update ()
	{
		for (int i = 0; i < count; i++) {
			allClouds [i].offset.x += allClouds [i].speed * Time.deltaTime;
			allClouds [i].mat.mainTextureOffset = allClouds [i].offset;
		}
	}
}
