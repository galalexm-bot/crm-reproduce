using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Calendar.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class ProductionScheduleModel
{
	public IResourceCalendar Entity { get; set; }

	public IEnumerable<IProductionScheduleExtension> Extensions { get; private set; }

	public IEnumerable<IProductionScheduleMode> AvailableModes { get; private set; }

	public IProductionScheduleMode CurrentMode { get; set; }

	public bool IsReadOnly { get; set; }

	public ProductionScheduleModel(IResourceCalendar entity, string modeCode = null)
	{
		Entity = entity;
		Extensions = ComponentManager.Current.GetExtensionPoints<IProductionScheduleExtension>();
		AvailableModes = ComponentManager.Current.GetExtensionPoints<IProductionScheduleMode>();
		CurrentMode = (string.IsNullOrWhiteSpace(modeCode) ? AvailableModes.First() : AvailableModes.FirstOrDefault((IProductionScheduleMode m) => m.Code == modeCode));
		IsReadOnly = true;
	}
}
