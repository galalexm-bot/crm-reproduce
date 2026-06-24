using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Globalization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Transformations;

[Serializable]
public abstract class BaseTransformation<TItem, TUid> : IXsiType where TItem : class
{
	private static object VnTQbLWLzDEqn3bantr2;

	public TUid Uid { get; set; }

	public abstract void Apply(TItem rootItem);

	public virtual IEnumerable<string> GetLocalizableStrings()
	{
		return LocalizableAttributeHelper.GetStrings(this);
	}

	public virtual void ApplyLocalization()
	{
		LocalizableAttributeHelper.Localize(this);
	}

	protected BaseTransformation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool JXWxlHWUFs5m8RBqVxll()
	{
		return VnTQbLWLzDEqn3bantr2 == null;
	}

	internal static object UsoDdBWUBoQAGUmppWtF()
	{
		return VnTQbLWLzDEqn3bantr2;
	}
}
