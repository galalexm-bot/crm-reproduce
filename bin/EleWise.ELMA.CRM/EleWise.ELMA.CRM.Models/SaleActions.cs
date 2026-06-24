using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

public class SaleActions : DefaultEntityActions
{
	[Uid("c8ffea2f-6c0f-403c-b67c-6c91f7b2918f")]
	[DisplayName("SR.M('Добавление комментария')")]
	[Image(typeof(SaleActions), "comment_outline", 16, ImageFormatType.IconPack, false)]
	public const string AddComment = "c8ffea2f-6c0f-403c-b67c-6c91f7b2918f";

	private static Guid _addCommentGuid = new Guid("c8ffea2f-6c0f-403c-b67c-6c91f7b2918f");

	[Uid("3d41953b-d41b-440e-a5ba-da9aafa1c97b")]
	[DisplayName("SR.M('Изменение статуса')")]
	public const string ChangeStatus = "3d41953b-d41b-440e-a5ba-da9aafa1c97b";

	private static Guid _changeStatusGuid = new Guid("3d41953b-d41b-440e-a5ba-da9aafa1c97b");

	[Uid("a8ab9be9-5631-4fea-8970-44438cea3f2a")]
	[DisplayName("SR.M('Изменение стадии')")]
	public const string ChangeStage = "a8ab9be9-5631-4fea-8970-44438cea3f2a";

	private static Guid _changeStageGuid = new Guid("a8ab9be9-5631-4fea-8970-44438cea3f2a");

	[Uid("8cf94947-234b-4b3c-990c-866a0804b98f")]
	[DisplayName("SR.M('Задать вопрос')")]
	public const string AddQuestion = "8cf94947-234b-4b3c-990c-866a0804b98f";

	private static Guid _addQuestionGuid = new Guid("8cf94947-234b-4b3c-990c-866a0804b98f");

	public static Guid AddCommentGuid => _addCommentGuid;

	public static Guid ChangeStatusGuid => _changeStatusGuid;

	public static Guid ChangeStageGuid => _changeStageGuid;

	public static Guid AddQuestionGuid => _addQuestionGuid;

	protected SaleActions()
	{
	}
}
