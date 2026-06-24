using System;
using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

[Serializable]
public class EntityListInfo : EntityInfoBase, ICloneable
{
	private List<EntityInfo> items;

	private static EntityListInfo oRROXohZoFj6tekRgEI7;

	public List<EntityInfo> Items => items;

	public override string ToString()
	{
		return string.Join((string)n0cutHhZGHP53KyJr66k(-576149596 ^ -575937026), Items.Select((EntityInfo i) => i.ToString()));
	}

	public virtual EntityListInfo Clone()
	{
		EntityListInfo entityListInfo = new EntityListInfo();
		entityListInfo.Items.AddRange(Items.Select((EntityInfo a) => (EntityInfo)_003C_003Ec.bofvfNCcfhe88QSbf9vH(a)));
		return entityListInfo;
	}

	object ICloneable.Clone()
	{
		return NLHmxZhZELhqVptwXnaZ(this);
	}

	public EntityListInfo()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		items = new List<EntityInfo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object n0cutHhZGHP53KyJr66k(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool D5soWdhZb7ZhlEPMFl0V()
	{
		return oRROXohZoFj6tekRgEI7 == null;
	}

	internal static EntityListInfo YYFfC5hZhNuiYgK976O4()
	{
		return oRROXohZoFj6tekRgEI7;
	}

	internal static object NLHmxZhZELhqVptwXnaZ(object P_0)
	{
		return ((EntityListInfo)P_0).Clone();
	}
}
