using System.Reflection;

namespace Nemerle.Compiler;

public interface IEvent : IMember
{
	EventInfo GetEventInfo();

	IMethod GetAdder();

	IMethod GetRemover();
}
