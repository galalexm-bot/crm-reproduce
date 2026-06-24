namespace EleWise.ELMA.Runtime;

public interface IStartControl
{
	void Continue();

	void Suspend(StartStatus suspendReason);

	void Suspend(StartStatus suspendReason, string suspendMessage);
}
