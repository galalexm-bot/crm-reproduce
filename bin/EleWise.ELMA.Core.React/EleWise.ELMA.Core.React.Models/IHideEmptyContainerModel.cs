using System;

namespace EleWise.ELMA.Core.React.Models;

public interface IHideEmptyContainerModel
{
	void AddIsHidden(Func<bool> isHidden);

	void RemoveIsHidden(Func<bool> isHidden);
}
