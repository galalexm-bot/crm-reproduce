using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Mappings;

public abstract class AbstractEntityMap<T, IdT> : ClassMapping<T> where T : class, IEntity<IdT>
{
	private static object A6U1Kfhbx1lr60v2wVwZ;

	public AbstractEntityMap(string tableName)
	{
		//Discarded unreachable code: IL_0043, IL_0048
		SingletonReader.PushGlobal();
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals0.tableName = tableName;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				((ClassCustomizer<T>)(object)this).Table(CS_0024_003C_003E8__locals0.tableName);
				num = 2;
				break;
			case 1:
				return;
			case 2:
			{
				ParameterExpression parameterExpression = Expression.Parameter(typeof(T), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C53F227));
				((ClassCustomizer<T>)(object)this).Id<IdT>(Expression.Lambda<Func<T, IdT>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<IdT>).TypeHandle)), new ParameterExpression[1] { parameterExpression }), (Action<IIdMapper>)delegate(IIdMapper i)
				{
					int num2 = 1;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							i.SetGenerator(CS_0024_003C_003E8__locals0.tableName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AC6223));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				});
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num = 1;
				}
				break;
			}
			}
		}
	}

	internal static bool b8Q27Fhb0qygwm7oTIrI()
	{
		return A6U1Kfhbx1lr60v2wVwZ == null;
	}

	internal static object YKA6WGhbmRLiumRjyMDU()
	{
		return A6U1Kfhbx1lr60v2wVwZ;
	}
}
