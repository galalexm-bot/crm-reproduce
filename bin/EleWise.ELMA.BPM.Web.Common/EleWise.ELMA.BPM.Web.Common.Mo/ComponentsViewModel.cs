using System.Collections.Generic;
using EleWise.ELMA.Packaging;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ComponentsViewModel
{
	public class ComponentsFilter
	{
		public enum ComponentsViewMode
		{
			Installed,
			Available,
			Importable
		}

		public string SearchString { get; set; }

		public ComponentsViewMode ViewMode { get; set; }
	}

	public IEnumerable<IStoreComponentInfo> Components { get; private set; }

	public ComponentsFilter Filter { get; set; }

	public BPMLicenseViewModel BPMLicense { get; private set; }

	public ComponentsViewModel(IEnumerable<IStoreComponentInfo> components, ComponentsFilter filter)
	{
		Components = components;
		Filter = filter;
		BPMLicense = BPMLicenseViewModel.Current;
	}
}
