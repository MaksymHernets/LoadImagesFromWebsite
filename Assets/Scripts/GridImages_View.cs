using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridImages_View : MonoBehaviour
{
    [SerializeField] private Image PrefabImage;
	[SerializeField] private GameObject Content;

	private List<Image> images;

	private void Start()
	{
		images = new List<Image>();
	}

	public void SpawnImages(int count)
	{
		for (int i = 0; i < count; ++i)
		{
			Image image = GameObject.Instantiate(PrefabImage, Content.transform);
			image.gameObject.SetActive(true);
			images.Add(image);
		}
	}

	public void SetupSprites()
	{

	}	

	public void Clear()
	{
		foreach (Image image in images)
		{
			GameObject.Destroy(image.gameObject);
		}
	}
}
