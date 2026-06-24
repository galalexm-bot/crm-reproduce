using System;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

public class TablePartExtensionsContainer<TItem> where TItem : IEntity
{
	private IEntity _parent;

	internal static object prUfrmhZqSwaXCAnuMMx;

	public IEntity Parent => _parent;

	public TablePartExtensionsContainer(IEntity parent)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				_parent = parent;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 0;
				}
				break;
			case 1:
				Contract.ArgumentNotNull(parent, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A69723));
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public TypeSettings GetSettingsFor<TValue>(Expression<Func<TItem, TValue>> expression)
	{
		IPropertyMetadata propertyMetadata = IEntityExtensions.GetPropertyMetadata(typeof(TItem), expression.Body);
		return Parent.GetPropertySettings(propertyMetadata.PropertyUid, propertyMetadata.Settings);
	}

	public TablePartExtensionsContainer<TChildItem> ForTablePart<TChildItem>(Expression<Func<TItem, ISet<TChildItem>>> expression) where TChildItem : IEntity
	{
		return new TablePartExtensionsContainer<TChildItem>(Parent);
	}

	internal static bool CnnaKIhZKBbVqE9eHN6b()
	{
		return prUfrmhZqSwaXCAnuMMx == null;
	}

	internal static object U6MO5hhZXr2ycvPRGw52()
	{
		return prUfrmhZqSwaXCAnuMMx;
	}
}
