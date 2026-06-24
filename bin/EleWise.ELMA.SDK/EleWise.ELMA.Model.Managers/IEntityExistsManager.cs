using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Model.Managers;

public interface IEntityExistsManager
{
	bool Exists();

	bool Exists(IEntityFilter filter);
}
