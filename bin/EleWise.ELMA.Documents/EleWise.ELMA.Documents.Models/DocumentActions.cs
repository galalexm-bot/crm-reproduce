using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

public class DocumentActions : DmsObjectActions
{
	[Uid("cc7bcb58-4cc5-4931-94f2-de572153e051")]
	[DisplayName("SR.M('Добавление комментария')")]
	[Image(typeof(DocumentActions), "comment_outline", 16, ImageFormatType.IconPack, false)]
	public const string AddComment = "cc7bcb58-4cc5-4931-94f2-de572153e051";

	private static Guid _addCommentGuid = new Guid("cc7bcb58-4cc5-4931-94f2-de572153e051");

	[Uid("e49ec0ba-0dfd-4715-8b2f-2bb7ecfa00f3")]
	[DisplayName("SR.M('Смена статуса')")]
	[Image(typeof(DocumentActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string ChangeStatus = "e49ec0ba-0dfd-4715-8b2f-2bb7ecfa00f3";

	private static Guid _changeStatusGuid = new Guid("e49ec0ba-0dfd-4715-8b2f-2bb7ecfa00f3");

	[Uid("c2f2ee06-7083-48ef-b5f9-f22906a60865")]
	[DisplayName("SR.M('Задать вопрос')")]
	[Image(typeof(DocumentActions), "help", 16, ImageFormatType.IconPack, false)]
	public const string AddQuestion = "c2f2ee06-7083-48ef-b5f9-f22906a60865";

	private static Guid _addQuestionGuid = new Guid("c2f2ee06-7083-48ef-b5f9-f22906a60865");

	[Uid("9749db56-60fd-4eac-be3b-a2a726816bac")]
	[DisplayName("SR.M('Отправлен')")]
	[Image(typeof(DocumentActions), "complete", 16, ImageFormatType.IconPack, false)]
	public const string Sended = "9749db56-60fd-4eac-be3b-a2a726816bac";

	private static Guid _sendedGuid = new Guid("9749db56-60fd-4eac-be3b-a2a726816bac");

	[Uid("88bfde2c-ef7b-4784-a08e-b021bf658970")]
	[DisplayName("SR.M('Зашифрован')")]
	[Image(typeof(DocumentActions), "document_lock", 16, ImageFormatType.IconPack, false)]
	public const string Encrypt = "88bfde2c-ef7b-4784-a08e-b021bf658970";

	private static Guid _encryptGuid = new Guid("88bfde2c-ef7b-4784-a08e-b021bf658970");

	[Uid("5bfc1311-8554-4981-bde7-d3f57ae1edb0")]
	[DisplayName("SR.M('Расшифрован')")]
	[Image(typeof(DocumentActions), "document_lock", 16, ImageFormatType.IconPack, false)]
	public const string Decrypt = "5bfc1311-8554-4981-bde7-d3f57ae1edb0";

	private static Guid _decryptGuid = new Guid("5bfc1311-8554-4981-bde7-d3f57ae1edb0");

	[Uid("d745477e-4d0c-406b-afea-f46966137358")]
	[DisplayName("SR.M('Введен пароль')")]
	[Description("SR.M('Введен правильный пароль для зашифрованного документа')")]
	[Image(typeof(DocumentActions), "complete", 16, ImageFormatType.IconPack, false)]
	public const string EnterPassword = "d745477e-4d0c-406b-afea-f46966137358";

	private static Guid _enterPasswordGuid = new Guid("d745477e-4d0c-406b-afea-f46966137358");

	[Uid("83875845-16cb-4ea1-84b1-178dcc3bb420")]
	[DisplayName("SR.M('Введен не правильный пароль')")]
	[Image(typeof(DocumentActions), "close_outline", 16, ImageFormatType.IconPack, false)]
	public const string WrongPassword = "83875845-16cb-4ea1-84b1-178dcc3bb420";

	private static Guid _wrongPasswordGuid = new Guid("83875845-16cb-4ea1-84b1-178dcc3bb420");

	[Uid("9f7462eb-9b1c-43a4-a919-26fb9c86b5a6")]
	[DisplayName("SR.M('Изменен тип')")]
	[Image(typeof(DocumentActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string ConvertedFromOtherType = "9f7462eb-9b1c-43a4-a919-26fb9c86b5a6";

	private static Guid _convertedFromOtherTypeGuid = new Guid("9f7462eb-9b1c-43a4-a919-26fb9c86b5a6");

	public static Guid AddCommentGuid => _addCommentGuid;

	public static Guid ChangeStatusGuid => _changeStatusGuid;

	public static Guid AddQuestionGuid => _addQuestionGuid;

	public static Guid SendedGuid => _sendedGuid;

	public static Guid EncryptGuid => _encryptGuid;

	public static Guid DecryptGuid => _decryptGuid;

	public static Guid EnterPasswordGuid => _enterPasswordGuid;

	public static Guid WrongPasswordGuid => _wrongPasswordGuid;

	public static Guid ConvertedFromOtherTypeGuid => _convertedFromOtherTypeGuid;

	protected DocumentActions()
	{
	}
}
