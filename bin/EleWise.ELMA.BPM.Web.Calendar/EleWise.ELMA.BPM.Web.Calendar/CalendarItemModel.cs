using System;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

[Serializable]
public class CalendarItemModel<T>
{
	public T Item { get; set; }

	public Guid ProviderUid { get; set; }

	public string Icon { get; set; }

	public CalendarItemModel(T item, Guid providerUid)
	{
		Item = item;
		ProviderUid = providerUid;
	}

	public CalendarItemModel()
	{
	}
}
