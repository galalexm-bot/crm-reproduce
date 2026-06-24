using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.Services;

[Service]
internal class QualifiedTypeNameResolverService : IQualifiedTypeNameResolverService
{
	private readonly IEnumerable<IQualifiedTypeResolverExtension> qualifiedTypeResolverExtensions;

	private static QualifiedTypeNameResolverService n5hyvsbLT6DQf6ZSEW4r;

	public QualifiedTypeNameResolverService(IEnumerable<IQualifiedTypeResolverExtension> qualifiedTypeResolverExtensions)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.qualifiedTypeResolverExtensions = qualifiedTypeResolverExtensions;
	}

	public string GetQualifiedTypeName(Type type)
	{
		int num = 1;
		Guid uid = default(Guid);
		IQualifiedTypeResolverExtension qualifiedTypeResolverExtension = default(IQualifiedTypeResolverExtension);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 4:
					uid = qualifiedTypeResolverExtension.Uid;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return (string)OxoDXsbLOhtgdO8G31wV(uid.ToByteArray().Concat(qualifiedTypeResolverExtension.GetQualifiedTypeData(_003C_003Ec__DisplayClass2_.type)).ToArray());
				case 1:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					_003C_003Ec__DisplayClass2_.type = type;
					num2 = 3;
					continue;
				}
				break;
			}
			qualifiedTypeResolverExtension = qualifiedTypeResolverExtensions.First(_003C_003Ec__DisplayClass2_._003CGetQualifiedTypeName_003Eb__0);
			num = 4;
		}
	}

	public Type GetType(string qualifiedTypeName)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		byte[] source = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return qualifiedTypeResolverExtensions.First(_003C_003Ec__DisplayClass3_._003CGetType_003Eb__0).GetType(source.Skip(16));
			case 2:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass3_.uid = new Guid(source.Take(16).ToArray());
				num2 = 3;
				break;
			case 1:
				source = Convert.FromBase64String(qualifiedTypeName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object OxoDXsbLOhtgdO8G31wV(object P_0)
	{
		return Convert.ToBase64String((byte[])P_0);
	}

	internal static bool lINoqibLkh16I7QXqoQZ()
	{
		return n5hyvsbLT6DQf6ZSEW4r == null;
	}

	internal static QualifiedTypeNameResolverService YoFRPgbLnWoAIJSHj7ZS()
	{
		return n5hyvsbLT6DQf6ZSEW4r;
	}
}
