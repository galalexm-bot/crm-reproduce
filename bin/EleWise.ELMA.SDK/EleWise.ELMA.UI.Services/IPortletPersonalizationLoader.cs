using System;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UI.Services;

public interface IPortletPersonalizationLoader
{
	IPortletPersonalization Load(int portletManagerScope, string portletManagerPath, Guid portletId, Guid instanceId, string path);
}
