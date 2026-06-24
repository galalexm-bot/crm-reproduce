namespace EleWise.ELMA.Core.React.Models;

public interface IHideEmptyModel
{
	bool IsEmpty { get; }

	void Init();

	void Destroy();
}
