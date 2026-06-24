namespace EleWise.ELMA.Model.Scripts;

public interface IScriptBaseInitializer
{
	void SetConsole(IScriptConsole console);

	void SetIsDebug(bool isDebug);
}
