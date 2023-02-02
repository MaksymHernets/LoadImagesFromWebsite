using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private WebSiteImages_Controller webSiteImages_Controller;

	private void Start()
	{
		WebSiteImages_Model webSiteImages_Model = new WebSiteImages_Model();

		webSiteImages_Controller.Setup(webSiteImages_Model);
	}
}
