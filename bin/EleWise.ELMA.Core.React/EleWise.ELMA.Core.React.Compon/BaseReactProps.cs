using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.Components;

public class BaseReactProps<TModel> : BasePropsWithChildren
{
	private TModel _003CModel_003Ek__BackingField;

	public TModel Model
	{
		get
		{
			return _003CModel_003Ek__BackingField;
		}
		set
		{
			_003CModel_003Ek__BackingField = value;
		}
	}

	public BaseReactProps()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Guid empty = Guid.Empty;
		((BaseProps)this).set_Key(Union<int, string>.op_Implicit(((object)(Guid)(ref empty)).ToString()));
	}
}
