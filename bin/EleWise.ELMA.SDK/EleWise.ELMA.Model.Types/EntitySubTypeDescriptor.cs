using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types;

public abstract class EntitySubTypeDescriptor<TEntity> : EntityDescriptor where TEntity : IEntity
{
	private static object uB24BKoyr2aCjgDmCQMg;

	public override Guid SubTypeUid => EntityUid;

	public override bool Visible => false;

	protected virtual Guid EntityUid => InterfaceActivator.UID<TEntity>(loadImplementation: false);

	public override object SerializeSimple(IEntity value)
	{
		return SerializeSimple((TEntity)value);
	}

	public virtual object SerializeSimple(TEntity value)
	{
		return SerializeSimple(value, typeof(TEntity));
	}

	public new virtual TEntity DeserializeSimple(object value)
	{
		return (TEntity)DeserializeSimple(value, typeof(TEntity));
	}

	protected EntitySubTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool dQuVv4oygh2hnPy9kk3H()
	{
		return uB24BKoyr2aCjgDmCQMg == null;
	}

	internal static object g5kptmoy5So7MZ89xpnA()
	{
		return uB24BKoyr2aCjgDmCQMg;
	}
}
