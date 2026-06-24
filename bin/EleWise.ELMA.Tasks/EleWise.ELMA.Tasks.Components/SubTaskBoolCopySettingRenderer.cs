using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.Tasks.Components;

[Component(Order = 100)]
internal class SubTaskBoolCopySettingRenderer : SubTaskCopySettingsRendererBase
{
	protected override Guid[] ApplyToSubtaskTypes => new Guid[0];

	protected override string[] UselessSettings => new string[0];
}
