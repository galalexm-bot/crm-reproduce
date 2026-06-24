using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Services;

public interface ILessFileService
{
	void SetCurrent(LessFileModel model);

	LessFileModel GetCurrent();
}
