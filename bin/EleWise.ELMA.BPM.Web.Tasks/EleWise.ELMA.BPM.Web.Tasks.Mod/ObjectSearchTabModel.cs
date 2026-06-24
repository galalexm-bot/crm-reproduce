using System;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class ObjectSearchTabModel
{
	public string ScriptSelect { get; set; }

	public IWorkLogObjectSearchFilter DataFilter { get; private set; }

	public ObjectSearchTabModel()
	{
		DateTime now = DateTime.Now;
		DataFilter = InterfaceActivator.Create<IWorkLogObjectSearchFilter>();
		DataFilter.CreationDate = new RelativeDateTime(new DateTime(now.Year, now.Month, 1).AddMonths(-1), null);
	}
}
