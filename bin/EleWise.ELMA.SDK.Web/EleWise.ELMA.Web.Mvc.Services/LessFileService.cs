using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Services;

[Service]
internal class LessFileService : ILessFileService
{
	private LessFileModel model;

	public LessFileModel GetCurrent()
	{
		return model;
	}

	public void SetCurrent(LessFileModel model)
	{
		this.model = model;
	}
}
