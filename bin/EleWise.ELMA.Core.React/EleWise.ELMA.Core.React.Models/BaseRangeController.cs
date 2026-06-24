using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.React.Components;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.Models;

public abstract class BaseRangeController<T, TContext> : BaseInputController<T, TContext>, IOnInit where TContext : IBaseRangeContext
{
	protected abstract Guid TypeUid { get; }

	public void OnInit()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		string name = GetName();
		ViewAttributes viewAttributes = base.Context.Attributes.Invoke();
		IPropertyMetadata obj = base.Context.PropertyMetadata.Invoke();
		IPropertyMetadata val = obj.Clone<IPropertyMetadata>();
		val.set_TypeUid(TypeUid);
		((INamedMetadata)val).set_Name(name + "_From");
		val.set_Settings(viewAttributes.TypeSettings);
		TContext context = base.Context;
		context.PropertyFrom = val;
		IPropertyMetadata val2 = obj.Clone<IPropertyMetadata>();
		val2.set_TypeUid(TypeUid);
		((INamedMetadata)val2).set_Name(name + "_To");
		val2.set_Settings(viewAttributes.TypeSettings);
		context = base.Context;
		context.PropertyTo = val2;
	}
}
