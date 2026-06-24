using System;

namespace EleWise.ELMA.Model.Services;

public interface IModulePublishService
{
	void Publish(Guid headerUid, string comment);
}
