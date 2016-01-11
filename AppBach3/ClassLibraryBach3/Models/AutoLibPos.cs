using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Newtonsoft.Json;

namespace ClassLibraryBach3.Models
{
	public class AutoLibPos
	{

		[JsonProperty("recordid")]
		public string Id { get; set; }

		[JsonProperty("identifiant_autolib")]
		public string Nom { get; set; }

		[JsonProperty("rue")]
		public string Rue { get; set; }

		[JsonProperty("code_postal")]
		public string CodePostal { get; set; }

		[JsonProperty("ville")]
		public string Ville { get; set; }
		//public int Id { get; set; }
		//public string Nom { get; set; }
		//public string Rue { get; set; }
		//public string CodePostale { get; set; }
		//public string Ville { get; set; }

		// private string ville;
		// Public string Ville
		// {
		//	 get {return ville; }
		//   sdet{ville = value; }
		//}

	}

}
