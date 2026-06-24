using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IExtendedValidateProvider
{
	bool CheckType(Type type);

	void RenderExtendedControl(HtmlHelper html, Guid actionUid, object model);

	string SubmitClick(Guid actionUid, object model, string form, string submitFunction);
}
