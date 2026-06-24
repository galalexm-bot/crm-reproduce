using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

[Component(Order = 20)]
public class AdditionalViewItemToolboxGroup : BaseViewItemToolboxGroup
{
	public static readonly Guid UID = new Guid("{962F5F4A-9D67-4911-90B9-803026CB1123}");

	public override Guid GroupUid => UID;

	public override Guid ParentGroupUid => Guid.Empty;

	public override string Name => SR.T("Дополнительные");
}
