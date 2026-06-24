using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Components;

public abstract class StringKeyLinkedFinder : LinkedFinderBase
{
	private static StringKeyLinkedFinder cmvLmhfGQlF40nQX4cjT;

	protected abstract object GetDataWithUidStr(string uidStr, LinkedObjectsContext context);

	protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
	{
		return null;
	}

	protected object GetData(string uidStr, LinkedObjectsContext context)
	{
		//Discarded unreachable code: IL_0049, IL_00d3, IL_00e2
		int num = 7;
		object value = default(object);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					value = ytgksEfG8vZgt31qfX4B(this, _003C_003Ec__DisplayClass2_.uidStr, context);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					_003C_003Ec__DisplayClass2_.uidStr = uidStr;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					context.LoadedWithStringKey[_003C_003Ec__DisplayClass2_.uidStr] = value;
					num2 = 2;
					break;
				case 1:
					if (value == null)
					{
						num2 = 9;
						break;
					}
					goto case 5;
				case 4:
					return value;
				default:
					if (!context.LoadedWithStringKey.TryGetValue(_003C_003Ec__DisplayClass2_.uidStr, out value))
					{
						if (context.AllObjects.OfType<StringKeyLinkedObject>().FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetData_003Eb__0) == null)
						{
							goto end_IL_0012;
						}
						goto case 3;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 4;
					}
					break;
				case 7:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 6;
					break;
				case 2:
				case 9:
					return value;
				case 8:
					return null;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	protected void FillStrObj(FindLinkedObjectsResult resultObj, LinkedObjectsContext context, string uidStr)
	{
		int num = 8;
		_003C_003Ec__DisplayClass3_1 _003C_003Ec__DisplayClass3_2 = default(_003C_003Ec__DisplayClass3_1);
		IEnumerable<StringKeyLinkedObject> source2 = default(IEnumerable<StringKeyLinkedObject>);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		IEnumerable<StringKeyLinkedObject> source = default(IEnumerable<StringKeyLinkedObject>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass3_2.obj = source2.First(_003C_003Ec__DisplayClass3_._003CFillStrObj_003Eb__2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					_003C_003Ec__DisplayClass3_.uidStr = uidStr;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 2;
					}
					break;
				case 9:
					resultObj.LinkedObjects.Add(_003C_003Ec__DisplayClass3_2.obj);
					num2 = 3;
					break;
				default:
					if (resultObj.LinkedObjects.OfType<StringKeyLinkedObject>().All(_003C_003Ec__DisplayClass3_2._003CFillStrObj_003Eb__3))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num2 = 9;
						}
						break;
					}
					goto case 3;
				case 8:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 7;
					break;
				case 4:
					context.CheckedObjects.Add(_003C_003Ec__DisplayClass3_2.obj);
					num2 = 5;
					break;
				case 12:
					if (!source2.Any(_003C_003Ec__DisplayClass3_._003CFillStrObj_003Eb__0))
					{
						return;
					}
					goto end_IL_0012;
				case 6:
					source2 = context.AllObjects.OfType<StringKeyLinkedObject>();
					num2 = 10;
					break;
				case 3:
					resultObj.AddedObjects.Add(_003C_003Ec__DisplayClass3_2.obj);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 4;
					}
					break;
				case 11:
					_003C_003Ec__DisplayClass3_2 = new _003C_003Ec__DisplayClass3_1();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					if (source.All(_003C_003Ec__DisplayClass3_._003CFillStrObj_003Eb__1))
					{
						num2 = 11;
						break;
					}
					return;
				case 5:
					return;
				case 10:
					source = context.CheckedObjects.OfType<StringKeyLinkedObject>();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 7;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	protected StringKeyLinkedFinder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IcmCNyfGZljXfgfp3FKq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object ytgksEfG8vZgt31qfX4B(object P_0, object P_1, object P_2)
	{
		return ((StringKeyLinkedFinder)P_0).GetDataWithUidStr((string)P_1, (LinkedObjectsContext)P_2);
	}

	internal static bool tdaIqSfGCnlLc8clY96Y()
	{
		return cmvLmhfGQlF40nQX4cjT == null;
	}

	internal static StringKeyLinkedFinder hu2G5AfGvngErH3ZyHrr()
	{
		return cmvLmhfGQlF40nQX4cjT;
	}

	internal static void IcmCNyfGZljXfgfp3FKq()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
