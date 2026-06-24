using System;
using System.Reflection;
using System.Reflection.Extensions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.SDK;

public static class TypeOf
{
	public static readonly RipeType EnumerableExtensions;

	public static readonly RipeType Locator;

	public static readonly RipeType InterfaceActivator;

	public static readonly RipeType Entity1;

	public static readonly RipeType EntityDynamic1;

	public static readonly RipeType EntityManager1;

	public static readonly RipeType EntityManager2;

	public static readonly RipeType EntityImplManager3;

	public static readonly RipeType IEntity1;

	public static readonly RipeType IEntityManager1;

	public static readonly RipeType IEntityManager2;

	public static readonly RipeType EnumBaseConverter1;

	internal static TypeOf Dxrdpa27uMDej64mJNW;

	static TypeOf()
	{
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 5:
				EnumerableExtensions = typeof(EnumerableExtensions).ToRipeType();
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 10;
				}
				break;
			default:
				EntityManager2 = (RipeType)BwTcTC2McFdZPr5MujO(utRnEh2ywFjdVTVnHEB(typeof(EntityManager<, >).TypeHandle));
				num2 = 10;
				break;
			case 4:
				IEntityManager2 = (RipeType)BwTcTC2McFdZPr5MujO(utRnEh2ywFjdVTVnHEB(typeof(IEntityManager<, >).TypeHandle));
				num2 = 9;
				break;
			case 6:
				h8IT8b2mlOIwoA9UfJt();
				num2 = 5;
				break;
			case 2:
				IEntityManager1 = (RipeType)BwTcTC2McFdZPr5MujO(utRnEh2ywFjdVTVnHEB(typeof(IEntityManager<>).TypeHandle));
				num2 = 4;
				break;
			case 8:
				EntityManager1 = (RipeType)BwTcTC2McFdZPr5MujO(typeof(EntityManager<>));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 0;
				}
				break;
			case 12:
				EntityDynamic1 = (RipeType)BwTcTC2McFdZPr5MujO(utRnEh2ywFjdVTVnHEB(typeof(EntityDynamic<>).TypeHandle));
				num2 = 8;
				break;
			case 3:
				Entity1 = (RipeType)BwTcTC2McFdZPr5MujO(utRnEh2ywFjdVTVnHEB(typeof(Entity<>).TypeHandle));
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 12;
				}
				break;
			case 1:
				InterfaceActivator = (RipeType)BwTcTC2McFdZPr5MujO(utRnEh2ywFjdVTVnHEB(typeof(InterfaceActivator).TypeHandle));
				num2 = 3;
				break;
			case 11:
				IEntity1 = (RipeType)BwTcTC2McFdZPr5MujO(typeof(IEntity<>));
				num2 = 2;
				break;
			case 13:
				Locator = utRnEh2ywFjdVTVnHEB(typeof(Locator).TypeHandle).ToRipeType();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				EnumBaseConverter1 = (RipeType)BwTcTC2McFdZPr5MujO(utRnEh2ywFjdVTVnHEB(typeof(EnumBaseConverter<>).TypeHandle));
				num2 = 7;
				break;
			case 10:
				EntityImplManager3 = (RipeType)BwTcTC2McFdZPr5MujO(utRnEh2ywFjdVTVnHEB(typeof(EntityImplManager<, , >).TypeHandle));
				num2 = 11;
				break;
			}
		}
	}

	internal static void h8IT8b2mlOIwoA9UfJt()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type utRnEh2ywFjdVTVnHEB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object BwTcTC2McFdZPr5MujO(Type type)
	{
		return type.ToRipeType();
	}

	internal static bool vrxQQS2xAm9hQp8kb5Q()
	{
		return Dxrdpa27uMDej64mJNW == null;
	}

	internal static TypeOf jH8tjd20qXqZRehF5IY()
	{
		return Dxrdpa27uMDej64mJNW;
	}
}
