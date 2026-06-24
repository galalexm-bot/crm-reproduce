using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Models;

public class InpaymentActions : DefaultEntityActions
{
	[Uid("6d9c6794-b46c-4bbe-8d72-e81ed7635c1e")]
	[DisplayName("SR.M('Добавление комментария')")]
	public const string AddComment = "6d9c6794-b46c-4bbe-8d72-e81ed7635c1e";

	private static Guid _addCommentGuid = new Guid("6d9c6794-b46c-4bbe-8d72-e81ed7635c1e");

	[Uid("0943fe4e-2aec-4cae-9fef-381383afa900")]
	[DisplayName("SR.M('Задать вопрос')")]
	public const string AddQuestion = "0943fe4e-2aec-4cae-9fef-381383afa900";

	private static Guid _addQuestionGuid = new Guid("0943fe4e-2aec-4cae-9fef-381383afa900");

	public static Guid AddCommentGuid => _addCommentGuid;

	public static Guid AddQuestionGuid => _addQuestionGuid;

	protected InpaymentActions()
	{
	}
}
