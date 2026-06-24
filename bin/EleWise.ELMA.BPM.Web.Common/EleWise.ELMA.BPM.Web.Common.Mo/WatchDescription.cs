using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class WatchDescription
{
	public IWatch Watch { get; set; }

	public string Description { get; set; }

	public string Category
	{
		get
		{
			if (!Global)
			{
				return SR.T("Изменения по объекту");
			}
			return SR.T("Изменения по типу объекта");
		}
	}

	public bool Global { get; set; }

	public IEntity Entity { get; set; }
}
