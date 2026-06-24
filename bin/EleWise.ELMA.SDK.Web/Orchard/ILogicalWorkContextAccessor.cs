namespace Orchard;

public interface ILogicalWorkContextAccessor : IWorkContextAccessor
{
	WorkContext GetLogicalContext();
}
