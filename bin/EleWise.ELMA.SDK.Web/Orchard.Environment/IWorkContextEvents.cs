namespace Orchard.Environment;

public interface IWorkContextEvents : IUnitOfWorkDependency, IDependency
{
	void Started();

	void Finished();
}
