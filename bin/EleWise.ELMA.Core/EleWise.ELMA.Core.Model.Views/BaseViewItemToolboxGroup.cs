using System;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

public abstract class BaseViewItemToolboxGroup : IViewItemToolboxGroup
{
	public abstract Guid GroupUid { get; }

	public abstract Guid ParentGroupUid { get; }

	public abstract string Name { get; }

	public virtual bool Visible => true;
}
