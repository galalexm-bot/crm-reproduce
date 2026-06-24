using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

public class RelationshipActions : DefaultEntityActions
{
	[Uid("3e3e8dd9-b4ea-4ad8-9aa1-19b4fe27ff80")]
	[DisplayName("SR.M('Добавление комментария')")]
	[Image(typeof(RelationshipActions), "comment_outline", 16, ImageFormatType.IconPack, false)]
	public const string AddComment = "3e3e8dd9-b4ea-4ad8-9aa1-19b4fe27ff80";

	private static Guid _addCommentGuid = new Guid("3e3e8dd9-b4ea-4ad8-9aa1-19b4fe27ff80");

	[Uid("687e895b-0cae-42e1-b882-e431b66535ae")]
	[DisplayName("SR.M('Изменение взаимоотношения пользователем')")]
	[Image(typeof(RelationshipActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string Edit = "687e895b-0cae-42e1-b882-e431b66535ae";

	private static Guid _editGuid = new Guid("687e895b-0cae-42e1-b882-e431b66535ae");

	[Uid("786919b5-d160-426a-a578-f74b503cf966")]
	[DisplayName("SR.M('Выполнение')")]
	[Image(typeof(RelationshipActions), "complete", 16, ImageFormatType.IconPack, false)]
	public const string Complete = "786919b5-d160-426a-a578-f74b503cf966";

	private static Guid _completeGuid = new Guid("786919b5-d160-426a-a578-f74b503cf966");

	[Uid("e6dded39-cd54-4e9e-a99c-e84ac3a1dd82")]
	[DisplayName("SR.M('Просрочено')")]
	[Image(typeof(RelationshipActions), "control", 16, ImageFormatType.IconPack, false)]
	public const string Expired = "e6dded39-cd54-4e9e-a99c-e84ac3a1dd82";

	private static Guid _expiredGuid = new Guid("e6dded39-cd54-4e9e-a99c-e84ac3a1dd82");

	[Uid("fa413130-d92d-41e4-9fba-b133c43fe02a")]
	[DisplayName("SR.M('Изменение времени')")]
	[Image(typeof(RelationshipActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string ChangeTime = "fa413130-d92d-41e4-9fba-b133c43fe02a";

	private static Guid _changeTimeGuid = new Guid("fa413130-d92d-41e4-9fba-b133c43fe02a");

	[Uid("2d98aa5c-5f26-476a-9fe5-8b53e227f160")]
	[DisplayName("SR.M('Удаление взаимоотношения')")]
	[Image(typeof(RelationshipActions), "basket", 16, ImageFormatType.IconPack, false)]
	public const string DeleteRelationship = "2d98aa5c-5f26-476a-9fe5-8b53e227f160";

	private static Guid _deleteRelationshipGuid = new Guid("2d98aa5c-5f26-476a-9fe5-8b53e227f160");

	public static Guid AddCommentGuid => _addCommentGuid;

	public static Guid EditGuid => _editGuid;

	public static Guid CompleteGuid => _completeGuid;

	public static Guid ExpiredGuid => _expiredGuid;

	public static Guid ChangeTimeGuid => _changeTimeGuid;

	public static Guid DeleteRelationshipGuid => _deleteRelationshipGuid;

	protected RelationshipActions()
	{
	}
}
