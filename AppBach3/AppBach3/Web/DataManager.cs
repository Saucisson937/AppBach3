using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBach3.Models;
using Newtonsoft.Json.Linq;

namespace AppBach3.Web
{
	//class DataManager

	class DataManager
	{
		public const string URL = "http://opendata.paris.fr/api/records/1.0/search?dataset=stations_et_espaces_autolib_de_la_metropole_parisienne&facet=identifiant_autolib&facet=code_postal&facet=ville&facet=emplacement";
		public async Task<List<AutoLibPos>> GetAutoLibPos()
		{
			try
			{
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, URL);
				HttpClient httpClient = new HttpClient();

				HttpResponseMessage httpResponse = await httpClient.SendAsync(request);

				string content = await httpResponse.Content.ReadAsStringAsync();
				if (!string.IsNullOrWhiteSpace(content))
				{
					var json = JObject.Parse(content);

					var records = Newtonsoft.Json.JsonConvert.
						DeserializeObject<List<AutoLibPos>>(json["records"].ToString());

				}
				Debug.WriteLine(content);

				return null;
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.Message);
				return null;
			}

		}
	}
}
