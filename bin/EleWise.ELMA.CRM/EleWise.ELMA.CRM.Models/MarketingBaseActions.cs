using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Models;

public class MarketingBaseActions : DefaultEntityActions
{
	[Uid("f8daf930-6f35-4a76-aa79-78c75ea09c2b")]
	[DisplayName(typeof(__Resources_MarketingBaseActions), "P_AddComment_DisplayName")]
	public const string AddComment = "f8daf930-6f35-4a76-aa79-78c75ea09c2b";

	private static Guid _addCommentGuid = new Guid("f8daf930-6f35-4a76-aa79-78c75ea09c2b");

	[Uid("03210724-db9f-467a-a607-c602906a16eb")]
	[DisplayName(typeof(__Resources_MarketingBaseActions), "P_Archive_DisplayName")]
	public const string Archive = "03210724-db9f-467a-a607-c602906a16eb";

	private static Guid _archiveGuid = new Guid("03210724-db9f-467a-a607-c602906a16eb");

	[Uid("e74d3c28-fcaf-47ef-b58e-f2be948be113")]
	[DisplayName(typeof(__Resources_MarketingBaseActions), "P_Activate_DisplayName")]
	public const string Activate = "e74d3c28-fcaf-47ef-b58e-f2be948be113";

	private static Guid _activateGuid = new Guid("e74d3c28-fcaf-47ef-b58e-f2be948be113");

	[Uid("5d8ddc7d-7e27-4f46-8346-b066d08ebac1")]
	[DisplayName(typeof(__Resources_MarketingBaseActions), "P_AddQuestion_DisplayName")]
	public const string AddQuestion = "5d8ddc7d-7e27-4f46-8346-b066d08ebac1";

	private static Guid _addQuestionGuid = new Guid("5d8ddc7d-7e27-4f46-8346-b066d08ebac1");

	public static Guid AddCommentGuid => _addCommentGuid;

	public static Guid ArchiveGuid => _archiveGuid;

	public static Guid ActivateGuid => _activateGuid;

	public static Guid AddQuestionGuid => _addQuestionGuid;

	protected MarketingBaseActions()
	{
	}
}
