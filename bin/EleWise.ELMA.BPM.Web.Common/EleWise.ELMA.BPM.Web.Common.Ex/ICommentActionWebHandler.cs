using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ICommentActionWebHandler
{
	void BeforeCreateProcess(IValueProvider valueProvider, object target);
}
