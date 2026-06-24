using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

[Component(Order = 10)]
public class CommonViewItemToolboxGroup : BaseViewItemToolboxGroup
{
	public static readonly Guid UID = new Guid("{9909E2D9-567A-428A-981A-B6556155490B}");

	public override Guid GroupUid => UID;

	public override Guid ParentGroupUid => Guid.Empty;

	public override string Name => SR.T("Основные");
}
