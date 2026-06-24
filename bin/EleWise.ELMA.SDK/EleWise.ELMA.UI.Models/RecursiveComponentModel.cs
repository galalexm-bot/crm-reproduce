using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models;

[DataContract]
public sealed class RecursiveComponentModel : ICloneable
{
	private static RecursiveComponentModel t1MLmYBW041M197tqhbm;

	[DataMember]
	public List<ClientComponentModel> ComponentCache { get; set; }

	[DataMember]
	public ClientComponentModel Header
	{
		[CompilerGenerated]
		get
		{
			return _003CHeader_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CHeader_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public List<ClientExtensionPointModel> ExtensionPoints { get; set; }

	[DataMember]
	public List<CustomTypeModel> CustomTypes { get; set; }

	[DataMember]
	public List<EntityDependency> EntityDependencies { get; }

	[IgnoreDataMember]
	public List<EnumDependency> EnumDependencies { get; }

	[DataMember]
	public HashSet<Guid> EntityMetadataUids { get; set; }

	[DataMember]
	public HashSet<Guid> EnumMetadataUids { get; set; }

	[DataMember]
	public List<string> Errors { get; }

	public RecursiveComponentModel()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 8;
		while (true)
		{
			switch (num)
			{
			default:
				EnumMetadataUids = new HashSet<Guid>();
				num = 7;
				break;
			case 6:
				ExtensionPoints = new List<ClientExtensionPointModel>();
				num = 4;
				break;
			case 5:
				return;
			case 4:
				CustomTypes = new List<CustomTypeModel>();
				num = 3;
				break;
			case 7:
				Errors = new List<string>();
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num = 5;
				}
				break;
			case 2:
				EnumDependencies = new List<EnumDependency>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num = 1;
				}
				break;
			case 8:
				ComponentCache = new List<ClientComponentModel>();
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num = 2;
				}
				break;
			case 3:
				EntityDependencies = new List<EntityDependency>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				EntityMetadataUids = new HashSet<Guid>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public object Clone()
	{
		//Discarded unreachable code: IL_00b1, IL_00c0
		int num = 3;
		int num2 = num;
		RecursiveComponentModel recursiveComponentModel = default(RecursiveComponentModel);
		while (true)
		{
			switch (num2)
			{
			case 8:
				recursiveComponentModel.EntityMetadataUids.AddRange(EntityMetadataUids);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				recursiveComponentModel.Errors.AddRange(Errors);
				num2 = 12;
				break;
			case 12:
				return recursiveComponentModel;
			case 3:
				recursiveComponentModel = new RecursiveComponentModel();
				num2 = 2;
				break;
			case 4:
				recursiveComponentModel.EnumMetadataUids.AddRange(EnumMetadataUids);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 10;
				}
				break;
			default:
				recursiveComponentModel.Header = (ClientComponentModel)Header.Clone();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (Header == null)
				{
					num2 = 5;
					break;
				}
				goto default;
			case 1:
			case 5:
				recursiveComponentModel.ComponentCache.AddRange(ComponentCache.Select((ClientComponentModel c) => (ClientComponentModel)_003C_003Ec.QwN96dQWdu6iTHYXVm26(c)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 9;
				}
				break;
			case 9:
				recursiveComponentModel.ExtensionPoints.AddRange(ExtensionPoints.Select((ClientExtensionPointModel e) => (ClientExtensionPointModel)_003C_003Ec.VyGo6kQWl9XAhdorJ2ji(e)));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 11;
				}
				break;
			case 11:
				recursiveComponentModel.CustomTypes.AddRange(CustomTypes.Select((CustomTypeModel c) => (CustomTypeModel)_003C_003Ec.dW9OxMQWr9Rh7V1UwytH(c)));
				num2 = 7;
				break;
			case 7:
				recursiveComponentModel.EntityDependencies.AddRange(EntityDependencies.Select(delegate(EntityDependency ed)
				{
					EntityDependency entityDependency = new EntityDependency();
					_003C_003Ec.A9hbRCQW5q8WNlkwKAqs(entityDependency, _003C_003Ec.j5G4xvQWgmfEdZdIvxrB(ed));
					_003C_003Ec.LoaVt9QWY6ZkOZdQSkr2(entityDependency, _003C_003Ec.kv1jM0QWjsHwDGGb8ftG(ed));
					_003C_003Ec.kYuYtjQWUWSScqBRxt0r(entityDependency, _003C_003Ec.De0sB9QWLgx97EJSmufu(ed));
					_003C_003Ec.SPVmiOQWc6vZwn34qZk7(entityDependency, _003C_003Ec.DQTnX9QWsWwa009EpUQP(ed));
					entityDependency.Properties.AddRange(ed.Properties.Select(delegate(PropertySignature p)
					{
						PropertySignature propertySignature = new PropertySignature();
						_003C_003Ec.oMuhmKQoFjbGr7IVTulZ(propertySignature, _003C_003Ec.DMPjmbQWzU3sTX2WiYDe(p));
						_003C_003Ec.h6Z3dWQoB0HeZUasJeZM(propertySignature, p.Name);
						TypeSignature obj = new TypeSignature
						{
							Nullable = _003C_003Ec.InYn1kQooD3nxpbNHjO1(_003C_003Ec.pEHJ9bQoWNx0DBLOgxnp(p))
						};
						_003C_003Ec.yPKRccQobP4lWM5wCGp2(obj, ((TypeSignature)_003C_003Ec.pEHJ9bQoWNx0DBLOgxnp(p)).RelationType);
						_003C_003Ec.uv4ciNQoGTBY1FliefgV(obj, _003C_003Ec.peMUnVQohoRV7SGMkZYK(p.Type));
						_003C_003Ec.jLZS2CQofmrTm7a9PHyg(obj, _003C_003Ec.NGv7cBQoE7wNilbrMuOL(p.Type));
						propertySignature.Type = obj;
						return propertySignature;
					}));
					return entityDependency;
				}));
				num2 = 6;
				break;
			case 6:
				recursiveComponentModel.EnumDependencies.AddRange(EnumDependencies.Select(delegate(EnumDependency ed)
				{
					EnumDependency obj2 = new EnumDependency
					{
						Name = (string)_003C_003Ec.j5G4xvQWgmfEdZdIvxrB(ed),
						DisplayName = (string)_003C_003Ec.kv1jM0QWjsHwDGGb8ftG(ed)
					};
					_003C_003Ec.kYuYtjQWUWSScqBRxt0r(obj2, _003C_003Ec.De0sB9QWLgx97EJSmufu(ed));
					_003C_003Ec.SPVmiOQWc6vZwn34qZk7(obj2, _003C_003Ec.DQTnX9QWsWwa009EpUQP(ed));
					return obj2;
				}));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool uWOfWLBWmOnTl9JDhPqN()
	{
		return t1MLmYBW041M197tqhbm == null;
	}

	internal static RecursiveComponentModel nX8hryBWyNGEU1wT7od7()
	{
		return t1MLmYBW041M197tqhbm;
	}
}
