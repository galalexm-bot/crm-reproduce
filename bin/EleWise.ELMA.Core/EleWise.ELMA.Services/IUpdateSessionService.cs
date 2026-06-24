using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[ServiceContract]
internal interface IUpdateSessionService
{
	void SetNeedUpdate(bool flag);
}
