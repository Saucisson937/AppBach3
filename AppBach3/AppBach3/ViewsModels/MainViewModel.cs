using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using AppBach3.Web;
using GalaSoft.MvvmLight.Command;
using ClassLibraryBach3.Models;

namespace AppBach3.ViewsModels
{
	class MainViewModel
	{

		#region commands

		private RelayCommand refreshDataCommand;

			public RelayCommand RefreshDataCommand
			{
				get
				{
					return refreshDataCommand ?? (refreshDataCommand = new RelayCommand(RefreshData));
				}
			}

#endregion

		private List<AutoLibPos> allStations;

		public List<AutoLibPos> AllStations
		{
			get { return allStations ?? (allStations = new List<AutoLibPos>()); }
		}  
		public async void RefreshData()
		{
			var dm = new DataManager();
			dm.GetAutoLibPos();
		}	
	}
}
