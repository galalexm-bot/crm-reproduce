using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Tasks.Models;

public class QuestionActions : TaskBaseActions
{
	[Uid("9800bbe4-3b24-49b6-b854-973d13045a67")]
	[DisplayName("SR.M('Закрытие автором')")]
	public const string Close = "9800bbe4-3b24-49b6-b854-973d13045a67";

	private static Guid _closeGuid = new Guid("9800bbe4-3b24-49b6-b854-973d13045a67");

	public static Guid CloseGuid => _closeGuid;

	protected QuestionActions()
	{
	}
}
