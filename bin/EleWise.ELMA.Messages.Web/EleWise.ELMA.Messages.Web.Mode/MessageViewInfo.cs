using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Models;

public class MessageViewInfo<T> where T : IBaseMessage
{
	protected bool? alowComment;

	protected bool? alowEdit;

	protected bool? fullAccess;

	[NotNull]
	protected static ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	[NotNull]
	protected static IAuthenticationService AuthenticationService => Locator.GetServiceNotNull<IAuthenticationService>();

	public bool CompactView { get; set; }

	public T Message { get; set; }

	public MessageExpandedItem State { get; set; }

	public string ExceptionWindow { get; set; }

	public string CommentWindow { get; set; }

	public virtual bool AllowComment => true;

	public virtual bool AllowEdit => false;

	public virtual bool FullAccess => false;
}
