namespace Orchard.Tasks;

public interface ISweepGenerator : ISingletonDependency, IDependency
{
	void Activate();

	void Terminate();
}
