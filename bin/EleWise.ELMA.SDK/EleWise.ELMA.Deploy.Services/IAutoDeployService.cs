namespace EleWise.ELMA.Deploy.Services;

public interface IAutoDeployService
{
	void RunAutoDeploy();

	void RunAutoDeploy(string autoDeployPath);
}
