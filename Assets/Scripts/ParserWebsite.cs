using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WebSite
{
	public class ParserWebsite
	{
		public string Url { get; private set; }
		public Dictionary<string, Image> Images { get; private set; }

		public ParserWebsite(string url)
		{
			Url = url;
			Images = new Dictionary<string, Image>();
		}

		public int GetCountImages()
		{
			return 3;
		}

		public List<string> GetUrlImages()
		{
			return new List<string>();
		}
	}
}

