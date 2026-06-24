using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EleWise.ELMA.CAB.SmartParts;

[DesignTimeVisible(false)]
public class SmartPartInfoProvider : Component, ISmartPartInfoProvider
{
	private readonly List<ISmartPartInfo> items = new List<ISmartPartInfo>();

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ICollection<ISmartPartInfo> Items => items;

	public ISmartPartInfo GetSmartPartInfo(Type smartPartInfoType)
	{
		return items.Find((ISmartPartInfo info) => info != null && info.GetType() == smartPartInfoType);
	}
}
