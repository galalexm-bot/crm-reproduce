using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Diagrams;

[Serializable]
public class ElementExtendedSettings : List<ElementExtendedSetting>
{
	public object this[string key]
	{
		get
		{
			ElementExtendedSetting elementExtendedSetting = this.FirstOrDefault((ElementExtendedSetting v) => v.Key.Equals(key, StringComparison.OrdinalIgnoreCase));
			if (elementExtendedSetting == null)
			{
				elementExtendedSetting = new ElementExtendedSetting
				{
					Key = key
				};
				Add(elementExtendedSetting);
			}
			return elementExtendedSetting.Value;
		}
		set
		{
			ElementExtendedSetting elementExtendedSetting = this.FirstOrDefault((ElementExtendedSetting v) => v.Key.Equals(key, StringComparison.OrdinalIgnoreCase));
			if (elementExtendedSetting == null)
			{
				elementExtendedSetting = new ElementExtendedSetting
				{
					Key = key
				};
				Add(elementExtendedSetting);
			}
			elementExtendedSetting.Value = value;
		}
	}
}
