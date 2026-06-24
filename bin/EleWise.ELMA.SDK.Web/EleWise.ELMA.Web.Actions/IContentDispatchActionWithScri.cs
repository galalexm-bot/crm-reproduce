using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.Web.Actions;

public interface IContentDispatchActionWithScriptMethod : IContentDispatchAction, IContentItem, IAuditEventHolder
{
	string ScriptMethodName { get; }
}
