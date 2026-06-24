using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Components;
using EleWise.ELMA.Deploy.Export.Helpers;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Helpers;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export;

[Component(Order = 500)]
internal class ComponentExportExtension : MetadataConfigurationExportExtension
{
	[Component]
	private sealed class ImportantData : IImportantData
	{
		internal static object nsKHrc870HxFPBMP7R4r;

		public static Guid Uid { get; }

		Guid IImportantData.Uid => SdI59A87MQJlquUlNieB();

		public IEnumerable<Version> Versions { get; }

		public string Module => null;

		public ImportantData()
		{
			//Discarded unreachable code: IL_0046, IL_004b
			z73wu787Jb8nHrIOE6ub();
			Versions = new Version[1]
			{
				new Version(4, 1, 0)
			};
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static ImportantData()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					SingletonReader.JJCZtPuTvSt();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					Uid = new Guid((string)OoDfUg879AfLCX1yEhhx(0x3630F361 ^ 0x3636F42D));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static Guid SdI59A87MQJlquUlNieB()
		{
			return Uid;
		}

		internal static void z73wu787Jb8nHrIOE6ub()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool nQMGqs87m2jiYP4JCvGi()
		{
			return nsKHrc870HxFPBMP7R4r == null;
		}

		internal static ImportantData tVSvHR87yjjNhDg8dI5x()
		{
			return (ImportantData)nsKHrc870HxFPBMP7R4r;
		}

		internal static object OoDfUg879AfLCX1yEhhx(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	private ExportRuleBuilder<ComponentMetadataItemHeader> customExportRuleBuilder;

	internal static ComponentExportExtension nVoFxmEg6pguHjGB20D9;

	public override Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			ComponentExportConsts.ExportExtensionUid,
			new ComponentExportSetting()
		} };
	}

	public override void AddExportObjects(ExportExtensionParams parameters)
	{
		int num = 2;
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
				AddExportObjectsCustom(parameters.Parameters, parameters.PacketEntities, parameters.PacketMetadatas, parameters.ServiceData, parameters.Messages, parameters.Importants, parameters.FormExportData);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				AddCustomRules();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static string GetViewNamePrefix(ComponentMetadata componentMetadata)
	{
		return (string)crNDrgEgxsaOQ4ZPhXSt(AYBD4tEg761EYyO0fYiE(componentMetadata));
	}

	internal static string GetViewNamePrefix(string metadataName)
	{
		return (string)dXEPLIEgm10eKJBHjZjp(lmHntfEg0anGyjS0hW3Z(-541731959 ^ -542037971), metadataName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70016163));
	}

	private void AddCustomRules()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
				{
					ExportRuleBuilderSelectType<ComponentMetadataItemHeader> exportRuleBuilderSelectType8 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)FGfB3vEgy2g1yWAlelWU(Q4T9HHEglVpr2HVGxF5K(typeof(ComponentMetadataItemHeader).TypeHandle), lmHntfEg0anGyjS0hW3Z(0x4A1640F ^ 0x4A1C9FB));
					Gl90IVEgJgbEKY3bdnJn(exportRuleBuilderSelectType8.ForPropertyName(Expression.Lambda<Func<ComponentMetadataItemHeader, object>>((Expression)vpfjK2EgMDZ1JWk69Pvl(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 10:
					break;
				case 6:
				{
					ExportRuleBuilderSelectType<ComponentMetadataItemHeader> exportRuleBuilderSelectType10 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)FGfB3vEgy2g1yWAlelWU(Q4T9HHEglVpr2HVGxF5K(typeof(MetadataItemGroupUI).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61ECA14C));
					Gl90IVEgJgbEKY3bdnJn(exportRuleBuilderSelectType10.ForPropertyName(Expression.Lambda<Func<MetadataItemGroupUI, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					num2 = 3;
					continue;
				}
				case 2:
					customExportRuleBuilder = new ExportRuleBuilder<ComponentMetadataItemHeader>(new ExportRuleList());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
				{
					ExportRuleBuilderSelectType<ComponentMetadataItemHeader> exportRuleBuilderSelectType2 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)FGfB3vEgy2g1yWAlelWU(Q4T9HHEglVpr2HVGxF5K(typeof(ComponentMetadataItem).TypeHandle), lmHntfEg0anGyjS0hW3Z(--1360331293 ^ 0x5115AFE9));
					exportRuleBuilderSelectType2.ForPropertyName(Expression.Lambda<Func<ComponentMetadataItem, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).ExportDeep();
					num2 = 13;
					continue;
				}
				case 3:
				{
					ExportRuleBuilderSelectType<ComponentMetadataItemHeader> exportRuleBuilderSelectType9 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)FGfB3vEgy2g1yWAlelWU(typeof(MetadataItemGroupUI), lmHntfEg0anGyjS0hW3Z(-1886646897 ^ -1886609285));
					exportRuleBuilderSelectType9.ForPropertyName(Expression.Lambda<Func<MetadataItemGroupUI, object>>((Expression)vpfjK2EgMDZ1JWk69Pvl(parameterExpression, (MethodInfo)rC3ug9Eg931J26fJGakJ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).Ignore();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 7;
					}
					continue;
				}
				case 9:
				{
					ExportRuleBuilderSelectType<ComponentMetadataItemHeader> exportRuleBuilderSelectType7 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)FGfB3vEgy2g1yWAlelWU(typeof(ComponentMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218452902));
					YnUVnbEgdE8lol3ILCh0(exportRuleBuilderSelectType7.ForPropertyName(Expression.Lambda<Func<ComponentMetadataItemHeader, object>>((Expression)vpfjK2EgMDZ1JWk69Pvl(parameterExpression, (MethodInfo)rC3ug9Eg931J26fJGakJ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				case 12:
				{
					ExportRuleBuilderSelectType<ComponentMetadataItemHeader> exportRuleBuilderSelectType6 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)FGfB3vEgy2g1yWAlelWU(Q4T9HHEglVpr2HVGxF5K(typeof(ComponentMetadataItemHeader).TypeHandle), lmHntfEg0anGyjS0hW3Z(-957824448 ^ -957845580));
					YnUVnbEgdE8lol3ILCh0(exportRuleBuilderSelectType6.ForPropertyName(Expression.Lambda<Func<ComponentMetadataItemHeader, object>>((Expression)hPdmgEEgrUqnZ16WaJ1C(vpfjK2EgMDZ1JWk69Pvl(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Q4T9HHEglVpr2HVGxF5K(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 5;
					}
					continue;
				}
				case 11:
					YnUVnbEgdE8lol3ILCh0(customExportRuleBuilder.Rule().ForPropertyName(InterfaceActivator.TypeOf<ScriptModule>(), (string)lmHntfEg0anGyjS0hW3Z(0x12441CA4 ^ 0x1245A48A)));
					num2 = 10;
					continue;
				case 1:
				{
					ExportRuleBuilderSelectType<ComponentMetadataItemHeader> exportRuleBuilderSelectType5 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)FGfB3vEgy2g1yWAlelWU(typeof(ComponentMetadataItemHeader), lmHntfEg0anGyjS0hW3Z(0x57A5235E ^ 0x57A58EAA));
					Gl90IVEgJgbEKY3bdnJn(exportRuleBuilderSelectType5.ForPropertyName(Expression.Lambda<Func<ComponentMetadataItemHeader, object>>((Expression)vpfjK2EgMDZ1JWk69Pvl(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					num2 = 9;
					continue;
				}
				case 13:
				{
					ExportRuleBuilderSelectType<ComponentMetadataItemHeader> exportRuleBuilderSelectType4 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = Expression.Parameter(Q4T9HHEglVpr2HVGxF5K(typeof(ComponentMetadataItem).TypeHandle), (string)lmHntfEg0anGyjS0hW3Z(-889460160 ^ -889501772));
					YnUVnbEgdE8lol3ILCh0(exportRuleBuilderSelectType4.ForPropertyName(Expression.Lambda<Func<ComponentMetadataItem, object>>(Expression.Convert((Expression)vpfjK2EgMDZ1JWk69Pvl(parameterExpression, (MethodInfo)rC3ug9Eg931J26fJGakJ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Q4T9HHEglVpr2HVGxF5K(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
					num2 = 11;
					continue;
				}
				default:
				{
					ExportRuleBuilderSelectType<ComponentMetadataItemHeader> exportRuleBuilderSelectType3 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)FGfB3vEgy2g1yWAlelWU(Q4T9HHEglVpr2HVGxF5K(typeof(ComponentMetadataItem).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C0EB8F));
					Gl90IVEgJgbEKY3bdnJn(exportRuleBuilderSelectType3.ForPropertyName(Expression.Lambda<Func<ComponentMetadataItem, object>>((Expression)vpfjK2EgMDZ1JWk69Pvl(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					num2 = 7;
					continue;
				}
				case 8:
					return;
				case 7:
				{
					ExportRuleBuilderSelectType<ComponentMetadataItemHeader> exportRuleBuilderSelectType = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)FGfB3vEgy2g1yWAlelWU(Q4T9HHEglVpr2HVGxF5K(typeof(ComponentMetadataItem).TypeHandle), lmHntfEg0anGyjS0hW3Z(-1876063057 ^ -1876090533));
					Gl90IVEgJgbEKY3bdnJn(exportRuleBuilderSelectType.ForPropertyName(Expression.Lambda<Func<ComponentMetadataItem, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				}
				break;
			}
			YnUVnbEgdE8lol3ILCh0(customExportRuleBuilder.Rule().ForPropertyName(InterfaceActivator.TypeOf<ScriptModule>(), (string)lmHntfEg0anGyjS0hW3Z(0x571EA399 ^ 0x571E0E65)));
			num = 6;
		}
	}

	private List<IEntity> GetEntities(ComponentMetadataItemHeader header)
	{
		ExportHelperBuilder<ComponentMetadataItemHeader> exportHelperBuilder = ExportHelperBuilder.Create(header);
		exportHelperBuilder.ExportRuleList = customExportRuleBuilder.ExportRules;
		return exportHelperBuilder.EntityExportList();
	}

	private void AddExportObjectsCustom(Dictionary<Guid, object> parameters, List<PacketEntity> packetEntities, List<PacketMetadata> packetMetadatas, Dictionary<string, object> serviceData, List<DeployLogMessage> messages, ISet<Guid> importants, List<FormExportData> formExportData)
	{
		if (!(parameters[ComponentExportConsts.ExportExtensionUid] is ComponentExportSetting componentExportSetting) || componentExportSetting.ComponentsIds.Count == 0)
		{
			return;
		}
		List<Guid> componentsIds = componentExportSetting.ComponentsIds;
		ComponentMetadataItemHeaderManager instance = ComponentMetadataItemHeaderManager.Instance;
		List<ComponentMetadata> list = new List<ComponentMetadata>();
		foreach (Guid item in componentsIds)
		{
			ComponentMetadataItemHeader componentMetadataItemHeader = instance.LoadOrNull(item);
			if (componentMetadataItemHeader == null)
			{
				continue;
			}
			if (IsUIForm(componentMetadataItemHeader))
			{
				PacketEntity packetEntity = new PacketEntity(componentMetadataItemHeader);
				packetEntity.ExportRules = customExportRuleBuilder.ExportRules;
				foreach (IEntity entity in GetEntities(componentMetadataItemHeader))
				{
					packetEntity.SubEntities.Add(entity);
					if (entity is ComponentMetadataItem componentMetadataItem)
					{
						ComponentMetadata componentMetadata = (ComponentMetadata)componentMetadataItem.Metadata;
						formExportData.Add(new FormExportData
						{
							EntityName = componentMetadata.DisplayName,
							FormViewItems = new FormViewItem[1] { componentMetadata.Content.View },
							ViewNamePrefix = GetViewNamePrefix(componentMetadata)
						});
					}
				}
				packetEntities.Add(packetEntity);
				continue;
			}
			ComponentMetadata componentMetadata2 = ClassSerializationHelper.CloneObjectByXml((ComponentMetadata)componentMetadataItemHeader.Published.Metadata);
			componentMetadata2.Uid = componentMetadataItemHeader.Uid;
			list.Add(componentMetadata2);
			PacketMetadata packetMetadata = new PacketMetadata(componentMetadata2);
			if (componentMetadataItemHeader.Group != null)
			{
				serviceData.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A32FDE) + componentMetadataItemHeader.Uid, componentMetadataItemHeader.Group.Uid);
				foreach (IEntity item2 in AddInfoMetadataGroup(componentMetadataItemHeader.Group, serviceData))
				{
					if (!packetMetadata.SubEntitiesBefore.ContainsKey(item2))
					{
						packetMetadata.SubEntitiesBefore.Add(item2, null);
					}
				}
			}
			importants.Add(ImportantData.Uid);
			packetMetadata.SubUserMetadataInfo[componentMetadata2.Uid] = new SubUserMetadataInfo(componentMetadata2);
			AddExportObjectsHelper.AddScriptModule(packetMetadata, serviceData, componentMetadata2, componentMetadataItemHeader.Published.ScriptModule, componentMetadataItemHeader.Draft.ScriptModule, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633518907), base.ScriptModuleManager, base.ExternalAssemblyManager);
			AddExportObjectsHelper.AddScriptModule(packetMetadata, serviceData, componentMetadata2, componentMetadataItemHeader.Published.ClientScriptModule, componentMetadataItemHeader.Draft.ClientScriptModule, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106465774), base.ScriptModuleManager, base.ExternalAssemblyManager);
			packetMetadatas.Add(packetMetadata);
			formExportData.Add(new FormExportData
			{
				EntityName = componentMetadata2.DisplayName,
				FormViewItems = new FormViewItem[1] { componentMetadata2.Content.View },
				ViewNamePrefix = GetViewNamePrefix(componentMetadata2)
			});
		}
		ICollection<ValidationError> collection = TestComponents(list, packetMetadatas.SelectMany((PacketMetadata p) => p.SubUserMetadataInfo.Values.Select((SubUserMetadataInfo i) => (IMetadata)_003C_003Ec.o358Oe875b1AtxnWd2VU(i)).Append(p.MetaData)).OfType<EntityMetadata>());
		if (collection.Count <= 0)
		{
			return;
		}
		messages.AddRange(from e in collection.SelectMany((ValidationError e) => GetErrors(e))
			select new DeployLogMessage(DeployLogMessageType.Error, e.Message));
		throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1A18DA)));
	}

	private bool IsUIForm(ComponentMetadataItemHeader header)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return GKWAOfEg5Ghki9CSkNCS(GOS42mEggXWBFL2JUKJm(header), PortletComponentMetadata.TypeUid);
			case 1:
				if (GKWAOfEg5Ghki9CSkNCS(GOS42mEggXWBFL2JUKJm(header), PageComponentMetadata.TypeUid))
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static IEnumerable<ValidationError> GetErrors(object error)
	{
		return ((ValidationError)error).InnerErrors.EmptyIfNull().SelectMany(GetErrors).Prepend((ValidationError)error);
	}

	private ICollection<ValidationError> TestComponents(ICollection<ComponentMetadata> components, IEnumerable<EntityMetadata> entities)
	{
		using (MetadataServiceContext.Extend(components))
		{
			_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
			CS_0024_003C_003E8__locals0.componentsSet = components.Select((ComponentMetadata c) => c.Uid).ToHashSet();
			return (from e in entities.Where((EntityMetadata m) => m.ViewModelMetadata != null).Select(delegate(EntityMetadata m)
				{
					int num3 = 2;
					int num4 = num3;
					_003C_003Ec__DisplayClass10_1 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_1);
					while (true)
					{
						switch (num4)
						{
						case 3:
							_003C_003Ec__DisplayClass10_.m = m;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num4 = 0;
							}
							break;
						case 2:
							_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_1();
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
							{
								num4 = 1;
							}
							break;
						case 1:
							_003C_003Ec__DisplayClass10_.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
							{
								num4 = 2;
							}
							break;
						default:
							return GenerateError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EA12A7), _003C_003Ec__DisplayClass10_0.QB8c8F87sH8ywyLfJJ2F(_003C_003Ec__DisplayClass10_.m)), _003C_003Ec__DisplayClass10_0.eH1kg887cigNcskKff0n(_003C_003Ec__DisplayClass10_.m), Guid.Empty, (from e in _003C_003Ec__DisplayClass10_.m.Forms.Select(_003C_003Ec__DisplayClass10_._003CTestComponents_003Eb__7)
								where e != null
								select e).ToArray());
						}
					}
				})
				where e != null
				select e).Concat(from m in components
				select (ValidationError)_003C_003Ec__DisplayClass10_0.bFNNhf8xBTH58aiCNoNd(SR.T((string)_003C_003Ec__DisplayClass10_0.QsWCX587z8vv2yJMNtBP(-477139494 ^ -477534772), m.DisplayName), _003C_003Ec__DisplayClass10_0.eH1kg887cigNcskKff0n(m), Guid.Empty, CheckComponentHelper.CheckComponentViewItems(((ComponentContentMetadata)_003C_003Ec__DisplayClass10_0.oICfWV8xFGmt8hDVEn3Q(m)).View, _003C_003Ec__DisplayClass10_0.eH1kg887cigNcskKff0n(m), CS_0024_003C_003E8__locals0.componentsSet.Contains).ToArray()) into e
				where e != null
				select e).ToArray();
		}
		static ValidationError GenerateError(string errorMessage, Guid ownerUid, Guid formUid, ValidationError[] errors)
		{
			//Discarded unreachable code: IL_004e, IL_005d
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (errors.Length == 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
				{
					ValidationError validationError = new ValidationError();
					pFG6tOEgYe8MlW9Ps5I8(validationError, ownerUid);
					lRK71hEgLPkMBEllBX3x(validationError, (formUid != Guid.Empty) ? ValidationElementType.ObjectFormViewItem : Guid.Empty);
					rVBMkEEgUmWy2BxXiL4M(validationError, formUid);
					uFwg5rEgs29ewiu0kLak(validationError, errorMessage);
					eOcsiYEgcIdqNgltHLhl(validationError, errors);
					return validationError;
				}
				default:
					return null;
				}
			}
		}
	}

	public ComponentExportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oVeelcEgj3iLktx0ZgED();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool kYZPePEgHIdr8otvkGox()
	{
		return nVoFxmEg6pguHjGB20D9 == null;
	}

	internal static ComponentExportExtension Cg8yGJEgA196ROe6MSqH()
	{
		return nVoFxmEg6pguHjGB20D9;
	}

	internal static object AYBD4tEg761EYyO0fYiE(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object crNDrgEgxsaOQ4ZPhXSt(object P_0)
	{
		return GetViewNamePrefix((string)P_0);
	}

	internal static object lmHntfEg0anGyjS0hW3Z(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object dXEPLIEgm10eKJBHjZjp(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object FGfB3vEgy2g1yWAlelWU(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object vpfjK2EgMDZ1JWk69Pvl(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static void Gl90IVEgJgbEKY3bdnJn(object P_0)
	{
		((ExportRuleBuilderSelectAction<ComponentMetadataItemHeader>)P_0).ExportDeep();
	}

	internal static object rC3ug9Eg931J26fJGakJ(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static void YnUVnbEgdE8lol3ILCh0(object P_0)
	{
		((ExportRuleBuilderSelectAction<ComponentMetadataItemHeader>)P_0).Ignore();
	}

	internal static Type Q4T9HHEglVpr2HVGxF5K(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object hPdmgEEgrUqnZ16WaJ1C(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static Guid GOS42mEggXWBFL2JUKJm(object P_0)
	{
		return ((ComponentMetadataItemHeader)P_0).MetadataTypeUid;
	}

	internal static bool GKWAOfEg5Ghki9CSkNCS(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static void oVeelcEgj3iLktx0ZgED()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void pFG6tOEgYe8MlW9Ps5I8(object P_0, Guid value)
	{
		((ValidationError)P_0).OwnerUid = value;
	}

	internal static void lRK71hEgLPkMBEllBX3x(object P_0, Guid value)
	{
		((ValidationError)P_0).ElementTypeUid = value;
	}

	internal static void rVBMkEEgUmWy2BxXiL4M(object P_0, Guid value)
	{
		((ValidationError)P_0).ElementUid = value;
	}

	internal static void uFwg5rEgs29ewiu0kLak(object P_0, object P_1)
	{
		((ValidationError)P_0).Message = (string)P_1;
	}

	internal static void eOcsiYEgcIdqNgltHLhl(object P_0, object P_1)
	{
		((ValidationError)P_0).InnerErrors = (ValidationError[])P_1;
	}
}
