using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH.Listeners;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Security.Listeners;

[Component(Order = int.MinValue)]
internal class EntityInstanceDefaultPermissionEventListener : PostFlushEventListener
{
	private readonly Func<IEnumerable<IEntityInstanceDefaultPermission>> permissionDefaults;

	private static EntityInstanceDefaultPermissionEventListener nVKLi5aHrTjNrYQeGt9;

	public EntityInstanceDefaultPermissionEventListener(Func<IEnumerable<IEntityInstanceDefaultPermission>> permissionDefaults)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.permissionDefaults = permissionDefaults;
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_00f4, IL_0103, IL_010e, IL_01a2, IL_01b5, IL_01c4
		int num = 1;
		int num2 = num;
		IEntity entity = default(IEntity);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		List<IEntityInstanceDefaultPermission>.Enumerator enumerator = default(List<IEntityInstanceDefaultPermission>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 2:
				if (entity != null)
				{
					_003C_003Ec__DisplayClass2_.type = gloephawAP1YmCLL1wZ(entity);
					num2 = 3;
				}
				else
				{
					num2 = 6;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 3:
				enumerator = permissionDefaults().Where(_003C_003Ec__DisplayClass2_._003COnPostInsert_003Eb__0).ToList().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
				{
					num2 = 5;
				}
				break;
			default:
				entity = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IEntity;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
							{
								num3 = 0;
							}
							goto IL_0112;
						}
						goto IL_0128;
						IL_0128:
						zaoC9xa2FhU1eMkqOEw(enumerator.Current, entity);
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 != 0)
						{
							num3 = 2;
						}
						goto IL_0112;
						IL_0112:
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							break;
						case 2:
							continue;
						}
						goto IL_0128;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	internal static Type gloephawAP1YmCLL1wZ(object P_0)
	{
		return EntityHelper.GetType(P_0);
	}

	internal static void zaoC9xa2FhU1eMkqOEw(object P_0, object P_1)
	{
		((IEntityInstanceDefaultPermission)P_0).CreatePermissions((IEntity)P_1);
	}

	internal static bool E0Mrv7aa7d2o6HYtw5f()
	{
		return nVKLi5aHrTjNrYQeGt9 == null;
	}

	internal static EntityInstanceDefaultPermissionEventListener vF5RP6aRARgEITS7VLp()
	{
		return nVKLi5aHrTjNrYQeGt9;
	}
}
