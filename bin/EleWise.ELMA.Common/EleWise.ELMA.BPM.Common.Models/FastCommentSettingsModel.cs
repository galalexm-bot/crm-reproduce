using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.BPM.Common.Models;

[Serializable]
public class FastCommentSettingsModel
{
	public const string Uid = "FastCommentSettingsModel";

	[DisplayName("SR.M('Клавиши для отправки комментария')")]
	public bool PostCommentEnterKey { get; set; }
}
