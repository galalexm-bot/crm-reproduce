namespace EleWise.ELMA.Core.Controllers;

public interface IClientController : IController
{
	IServerController Server { get; }
}
