namespace EleWise.ELMA.Deploy.Services;

public interface IDeployResult
{
	bool HasErrors { get; }

	string GetLog();
}
