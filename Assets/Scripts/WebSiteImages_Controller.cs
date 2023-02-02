using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using WebSite;

public class WebSiteImages_Controller : MonoBehaviour
{
    [SerializeField] private InputField inputField_UrlWebSite;
    [SerializeField] private Button button_Go;
	[SerializeField] private Text text_countImages;

	[SerializeField] private GridImages_View gridImages_view;

	private WebSiteImages_Model _model;

	public void Setup(WebSiteImages_Model model)
	{
		_model = model;
		gameObject.SetActive(true);
	}

	private void Start()
	{
		button_Go.onClick.AddListener(Button_Go_Clicked);
	}

	private void Button_Go_Clicked()
	{
		_model.parsers.ContainsKey(inputField_UrlWebSite.text);

		ParserWebsite parserWebsite = default(ParserWebsite);

		if ( !_model.parsers.ContainsKey(inputField_UrlWebSite.text) )
		{
			parserWebsite = new ParserWebsite(inputField_UrlWebSite.text);
			_model.parsers.Add(inputField_UrlWebSite.text, parserWebsite);
		}
		else
		{
			parserWebsite = _model.parsers[inputField_UrlWebSite.text];
		}

		int CountImages = parserWebsite.GetCountImages();
		text_countImages.text = "Images: " + CountImages.ToString();
		gridImages_view.SpawnImages(CountImages);
	}
} 
