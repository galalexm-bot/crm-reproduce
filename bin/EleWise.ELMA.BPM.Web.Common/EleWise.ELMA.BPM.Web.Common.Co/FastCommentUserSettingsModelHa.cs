using EleWise.ELMA.BPM.Common.Components;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
public class FastCommentUserSettingsModelHandler : IUserSettingsModelHandler
{
	public void Process(IUser user, IUserSettingsModel model)
	{
		if (model is IFastCommentUserSettingsModel fastCommentUserSettingsModel)
		{
			PersonalizationAdministration.SaveState(user.UserName, "FastCommentSettingsModel", fastCommentUserSettingsModel.Comment);
		}
	}
}
