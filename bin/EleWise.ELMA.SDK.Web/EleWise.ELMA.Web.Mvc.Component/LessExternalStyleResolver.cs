using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(Order = 100)]
internal sealed class LessExternalStyleResolver : IStylePathResolver
{
	private readonly ILessService lessService;

	public LessExternalStyleResolver(ILessService lessService)
	{
		this.lessService = lessService;
	}

	public string Resolve(string url)
	{
		return lessService.GetTemporaryCss(url);
	}

	public bool ShouldResolve(string url)
	{
		return url.EndsWith(".less");
	}
}
