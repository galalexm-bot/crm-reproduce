using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using EleWise.ELMA.UI;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Components;

[Component(Order = 900)]
internal class FormUIQualifiedTypeResolver : IQualifiedTypeResolverExtension
{
	private readonly Guid uid;

	private readonly FormDescriptorProvider formDescriptorProvider;

	internal static FormUIQualifiedTypeResolver Mq9D1OhBlupWvDnV0KSR;

	public Guid Uid => uid;

	public FormUIQualifiedTypeResolver(FormDescriptorProvider formDescriptorProvider)
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		uid = new Guid((string)CsZC3xhB5kC83GJVPtkL(-87337865 ^ -87526295));
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.formDescriptorProvider = formDescriptorProvider;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public bool CheckType(Type type)
	{
		//Discarded unreachable code: IL_0039, IL_0096
		int num = 1;
		int num2 = num;
		MetadataTypeAttribute customAttribute = default(MetadataTypeAttribute);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return TypeOf<FormMetadata>.Raw.IsAssignableFrom(NKkOo5hBLAExDGn563HM(customAttribute));
			case 3:
				return false;
			case 2:
				if (customAttribute == null)
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 5:
				return false;
			default:
				customAttribute = wOh8XThBjRJTbJGqe6dj(type).GetCustomAttribute<MetadataTypeAttribute>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (!qqXPfWhBYo3w1Fy0IaO6(wOh8XThBjRJTbJGqe6dj(type), null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public IEnumerable<byte> GetQualifiedTypeData(Type type)
	{
		FormMetadata obj = (FormMetadata)MetadataLoader.LoadMetadata(type.DeclaringType);
		Guid typeUid = obj.GetTypeUid();
		Guid guid = obj.Uid;
		string fullName = type.FullName;
		return typeUid.ToByteArray().Concat(guid.ToByteArray()).Concat(Encoding.UTF8.GetBytes(fullName));
	}

	public Type GetType(IEnumerable<byte> data)
	{
		Guid metadataType = new Guid(data.Take(16).ToArray());
		Guid descriptorUid = new Guid(data.Skip(16).Take(16).ToArray());
		string @string = Encoding.UTF8.GetString(data.Skip(32).ToArray());
		return formDescriptorProvider.GetDescriptor(metadataType, descriptorUid).Assembly.GetType(@string);
	}

	internal static object CsZC3xhB5kC83GJVPtkL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool B94hnThBr1cnwAiqRd2K()
	{
		return Mq9D1OhBlupWvDnV0KSR == null;
	}

	internal static FormUIQualifiedTypeResolver dBY8O8hBgrFrV6tAhddv()
	{
		return Mq9D1OhBlupWvDnV0KSR;
	}

	internal static Type wOh8XThBjRJTbJGqe6dj(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static bool qqXPfWhBYo3w1Fy0IaO6(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type NKkOo5hBLAExDGn563HM(object P_0)
	{
		return ((MetadataTypeAttribute)P_0).MetadataType;
	}
}
