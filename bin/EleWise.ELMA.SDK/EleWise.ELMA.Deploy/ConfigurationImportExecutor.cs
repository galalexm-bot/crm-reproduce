using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Xml;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.BPMApps.Managers;
using EleWise.ELMA.BPMApps.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.Enums;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Deploy.Import.UserActions;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Deploy.Serialization;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using ICSharpCode.SharpZipLib.Zip;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy;

internal sealed class ConfigurationImportExecutor : IConfigurationTesterInternal, IConfigurationTester, IConfigurationImporterInternal, IConfigurationImporter
{
	private class ReadPacketResult
	{
		private readonly object executor;

		private readonly object contentType;

		private readonly ICollection<(Dictionary<string, Dictionary<string, object>>, EntityMetadata, Type)> entitiesValues;

		private readonly ICollection<(IReadMetadataResult ReadMetadataResult, bool IsSystemMd)> readMetadataResults;

		private readonly IDictionary<string, string> packetData;

		internal static object vpNLbH8kNNLaKk3aej4i;

		public IEnumerable<IMetadata> Metadatas => from r in readMetadataResults
			where !r.IsSystemMd
			select r.ReadMetadataResult.Metadata;

		public ReadPacketResult(ConfigurationImportExecutor executor, XmlReader reader, string contentType, string serverFolderName)
		{
			//Discarded unreachable code: IL_004e, IL_0190, IL_01ba, IL_024d, IL_02f7, IL_030a, IL_031d, IL_032c, IL_034f, IL_035e, IL_03c9, IL_03d8, IL_03eb, IL_0470
			koay8P8kaNpH0fCKvclM();
			entitiesValues = new List<(Dictionary<string, Dictionary<string, object>>, EntityMetadata, Type)>();
			readMetadataResults = new List<(IReadMetadataResult, bool)>();
			packetData = new Dictionary<string, string>();
			base._002Ector();
			int num = 18;
			string text = default(string);
			(Dictionary<string, Dictionary<string, object>>, EntityMetadata, Type) item = default((Dictionary<string, Dictionary<string, object>>, EntityMetadata, Type));
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 13:
						if (executor.step != ImportStep.ImportMetadata)
						{
							num2 = 21;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num2 = 12;
							}
							continue;
						}
						return;
					case 2:
					case 8:
					case 29:
					case 32:
					case 36:
						fYKtSr8kAwmGvuSqSdP4(reader);
						num2 = 16;
						continue;
					case 5:
						if (!(text == (string)PRH1KZ8kwRVnUxUgYDZ5(-542721635 ^ -542980725)))
						{
							num2 = 37;
							continue;
						}
						goto case 30;
					case 20:
						if (!fBhsQb8k4qIxjcqlogVN(text, PRH1KZ8kwRVnUxUgYDZ5(0x3B36AB09 ^ 0x3B3341C9)))
						{
							num2 = 29;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num2 = 9;
							}
							continue;
						}
						goto case 22;
					case 11:
						executor.ReadDictionary(reader, packetData);
						num = 23;
						break;
					case 24:
						if (item.Item1 != null)
						{
							num2 = 17;
							continue;
						}
						goto case 9;
					case 26:
						text = (string)LaQt8C8ktxSUdw89ibM3(reader);
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 28;
						}
						continue;
					case 18:
						this.executor = executor;
						num2 = 25;
						continue;
					case 25:
						this.contentType = contentType;
						num2 = 7;
						continue;
					case 22:
						if (Ndpqrk8k6SkM17rgk43X(reader))
						{
							num = 32;
							break;
						}
						goto case 11;
					case 9:
					case 14:
					case 15:
					case 16:
					case 27:
					case 35:
						reader.MoveToContent();
						num2 = 6;
						continue;
					case 31:
						return;
					case 33:
						if (!BtCUdd8kDDmeGtyL8Gev(reader))
						{
							num2 = 14;
							continue;
						}
						goto case 26;
					case 34:
						caj3358kHcYY8aMQT5rh(reader);
						num2 = 12;
						continue;
					case 17:
						entitiesValues.Add(item);
						num2 = 35;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 12;
						}
						continue;
					case 37:
						if (!(text == (string)PRH1KZ8kwRVnUxUgYDZ5(-309639236 ^ -309380026)))
						{
							num2 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
							{
								num2 = 20;
							}
							continue;
						}
						goto case 3;
					default:
						caj3358kHcYY8aMQT5rh(reader);
						num2 = 10;
						continue;
					case 1:
					case 19:
						item = ReadEntity(reader);
						num2 = 24;
						continue;
					case 3:
						if (!Ndpqrk8k6SkM17rgk43X(reader))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 2;
					case 4:
						if (fBhsQb8k4qIxjcqlogVN(text, PRH1KZ8kwRVnUxUgYDZ5(-606654180 ^ -606900464)))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 5;
					case 28:
						if (text == null)
						{
							num = 8;
							break;
						}
						goto case 4;
					case 30:
						if (Ndpqrk8k6SkM17rgk43X(reader))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 34;
					case 21:
						Process();
						num2 = 31;
						continue;
					case 6:
					case 7:
						if (bdYSFW8k7VwgXRwG3PMP(reader) == XmlNodeType.EndElement)
						{
							num2 = 13;
							continue;
						}
						goto case 33;
					case 23:
						caj3358kHcYY8aMQT5rh(reader);
						num2 = 15;
						continue;
					case 12:
						readMetadataResults.AddRange<(IReadMetadataResult, bool)>(from r in executor.ReadMetadataBlock(reader, isSystemMd: true, serverFolderName)
							select (r, true));
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num2 = 27;
						}
						continue;
					case 10:
						readMetadataResults.AddRange<(IReadMetadataResult, bool)>(from r in executor.ReadMetadataBlock(reader, isSystemMd: false, serverFolderName)
							select (r, false));
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					break;
				}
			}
		}

		public void Process()
		{
			//Discarded unreachable code: IL_007d
			int num = 6;
			_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
			IUser user = default(IUser);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 5:
						_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
						num2 = 8;
						continue;
					case 7:
						lyG6Nt8kmZgQVf2qrHDS(entitiesValues);
						num = 10;
						break;
					case 3:
						obj = null;
						goto IL_01bb;
					case 4:
						_003C_003Ec__DisplayClass8_.needInterrupt = false;
						num2 = 9;
						continue;
					default:
						_003C_003Ec__DisplayClass8_.isBadRule = false;
						num2 = 4;
						continue;
					case 8:
						_003C_003Ec__DisplayClass8_.isException = "";
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 0;
						}
						continue;
					case 9:
						if (((ConfigurationImportExecutor)executor).signUserId == 0L)
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
							{
								num2 = 3;
							}
							continue;
						}
						obj = QJG3Ut8kxgHNwW4YdUhL(((ConfigurationImportExecutor)executor).securityDeployHelperExtensions.First(), ((ConfigurationImportExecutor)executor).signUserId);
						goto IL_01bb;
					case 10:
						HG1h2k8kyHOrtY9RcQ0V(readMetadataResults);
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 11;
						}
						continue;
					case 6:
						_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num2 = 5;
						}
						continue;
					case 1:
						return;
					case 11:
						E7D1aN8kM4f5eqqqhAMw(packetData);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 1;
						}
						continue;
					case 2:
						{
							KGbyRg8k0peOJ190OOkv(((ConfigurationImportExecutor)executor).securityService, user, new Action(_003C_003Ec__DisplayClass8_._003CProcess_003Eb__0));
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
							{
								num2 = 7;
							}
							continue;
						}
						IL_01bb:
						user = (IUser)obj;
						num = 2;
						break;
					}
					break;
				}
			}
		}

		private (Dictionary<string, Dictionary<string, object>> propValues, EntityMetadata metadata, Type type) ReadEntity(XmlReader reader)
		{
			reader.MoveToAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63ABE68A));
			Guid guid = Guid.Parse(reader.Value);
			Guid result = Guid.Empty;
			if (reader.MoveToAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561271288)))
			{
				Guid.TryParse(reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107650190)), out result);
			}
			Type typeByUidOrNull = MetadataServiceContext.MetadataRuntimeService.GetTypeByUidOrNull(guid);
			if (typeByUidOrNull == null)
			{
				reader.Skip();
				reader.MoveToContent();
				((ConfigurationImportExecutor)executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099397777), guid), endProcess: false));
				return (null, null, null);
			}
			Dictionary<string, Dictionary<string, object>> dictionary = new Dictionary<string, Dictionary<string, object>>();
			dictionary.Add(RegularProperty, new Dictionary<string, object>());
			dictionary.Add(XmlProperty, new Dictionary<string, object>());
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(typeByUidOrNull);
			if (entityMetadata == null)
			{
				reader.Skip();
				reader.MoveToContent();
				((ConfigurationImportExecutor)executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867439105), typeByUidOrNull.Name), endProcess: false));
				return (null, null, null);
			}
			reader.Read();
			reader.MoveToContent();
			dictionary = new EntityXmlSerializer().XmlEntityRead(reader, dictionary, ((ConfigurationImportExecutor)executor).mergeUidReplace, ((ConfigurationImportExecutor)executor).mergeReplace, guid);
			reader.Read();
			if (result != Guid.Empty)
			{
				dictionary[RegularProperty][z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105207696)] = result.ToString();
			}
			return (dictionary, entityMetadata, typeByUidOrNull);
		}

		private bool SaveEntity((Dictionary<string, Dictionary<string, object>> propValues, EntityMetadata metadata, Type type) _, IDictionary<IEntity, Exception> packet)
		{
			_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			Dictionary<string, Dictionary<string, object>> item = _.propValues;
			CS_0024_003C_003E8__locals0.metadata = _.metadata;
			CS_0024_003C_003E8__locals0.type = _.type;
			CS_0024_003C_003E8__locals0.propValuesR = item[RegularProperty];
			Dictionary<string, object> dictionary = item[XmlProperty];
			((ConfigurationImportExecutor)executor).AddMessage(new DeployLogMessage(BPMAppItemImportStatus.InProgress, CS_0024_003C_003E8__locals0.propValuesR.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108662366), out var value) ? Guid.Parse((string)value) : Guid.Empty, ((ConfigurationImportExecutor)executor).treeUid));
			CS_0024_003C_003E8__locals0.supportedImportEntitySaveActionsExtensions = ((ConfigurationImportExecutor)executor).entityImportSaveActionExtensions.Where((IEntityImportSaveActions ex) => _003C_003Ec__DisplayClass10_0.LNt6FGZ2VIvWiCCVCWnM(ex, _003C_003Ec__DisplayClass10_0.vnkbrFZ2IlPBD5J2rqs4(CS_0024_003C_003E8__locals0.metadata))).ToList();
			bool flag = true;
			List<DeployLogMessage> deployMessages = new List<DeployLogMessage>();
			ImportEntityCanBeSavedData importEntityCanBeSavedData = new ImportEntityCanBeSavedData(((ConfigurationImportExecutor)executor).serviceData, deployMessages);
			if (CS_0024_003C_003E8__locals0.supportedImportEntitySaveActionsExtensions.Count > 0)
			{
				foreach (IEntityImportSaveActions supportedImportEntitySaveActionsExtension in CS_0024_003C_003E8__locals0.supportedImportEntitySaveActionsExtensions)
				{
					bool flag2 = supportedImportEntitySaveActionsExtension.CanBeSaved(CS_0024_003C_003E8__locals0.propValuesR, importEntityCanBeSavedData);
					foreach (DeployLogMessage deployMessage in importEntityCanBeSavedData.DeployMessages)
					{
						((ConfigurationImportExecutor)executor).AddMessage(deployMessage);
						ImportLog.Error(deployMessage.MessageText);
					}
					flag = flag && flag2;
				}
			}
			if (!((ConfigurationImportExecutor)executor).skipEntityImportResolvers.Where((ISkipEntityImportResolver r) => _003C_003Ec__DisplayClass10_0.atJguQZ2SKLT1NI1e8ie(r, _003C_003Ec__DisplayClass10_0.vnkbrFZ2IlPBD5J2rqs4(CS_0024_003C_003E8__locals0.metadata))).ToList().Any((ISkipEntityImportResolver r) => r.IsSkip(CS_0024_003C_003E8__locals0.propValuesR, ((ConfigurationImportExecutor)CS_0024_003C_003E8__locals0._003C_003E4__this.executor).serviceData)))
			{
				_003C_003Ec__DisplayClass10_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass10_1();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propValuesR.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740345274), out var value2) && value2 != null)
				{
					string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410910947) + value2.ToString().ToLower();
					if (((ConfigurationImportExecutor)executor).serviceData.TryGetValue(key, out var value3))
					{
						((ConfigurationImportExecutor)executor).AddMessage(new DeployLogMessage(BPMAppItemImportStatus.InProgress, value3, ((ConfigurationImportExecutor)executor).treeUid));
					}
				}
				IEntityManager entityManager = ModelHelper.GetEntityManager(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.type);
				CS_0024_003C_003E8__locals1.entity = null;
				Guid guid = (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propValuesR.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3D80EC), out value) ? Guid.Parse((string)value) : Guid.Empty);
				if (guid != default(Guid))
				{
					CS_0024_003C_003E8__locals1.entity = (IEntity)entityManager.LoadOrNull(((ConfigurationImportExecutor)executor).mergeUidReplace.GetUidReplace(guid));
				}
				else
				{
					((ConfigurationImportExecutor)executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97715036), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadata.Name), endProcess: false));
				}
				if (CS_0024_003C_003E8__locals1.entity == null)
				{
					CS_0024_003C_003E8__locals1.entity = (IEntity)InterfaceActivator.Create(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.type);
				}
				if (!((ConfigurationImportExecutor)executor).entitiesMetadata.TryGetValue(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.type, out var value4))
				{
					value4 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadata.Properties.ConvertAll((Converter<PropertyMetadata, IPropertyMetadata>)((PropertyMetadata a) => a));
					value4.AddRange(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadata.TableParts.ConvertAll((Converter<TablePartMetadata, IPropertyMetadata>)((TablePartMetadata a) => a)));
					((ConfigurationImportExecutor)executor).entitiesMetadata.Add(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.type, value4);
				}
				LinksDictionary collection = new EntityXmlSerializer().Deserialize(CS_0024_003C_003E8__locals1.entity, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propValuesR);
				((ConfigurationImportExecutor)executor).linksDictionary.AddRange(collection);
				foreach (KeyValuePair<string, object> item2 in dictionary)
				{
					_003C_003Ec__DisplayClass10_2 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass10_2();
					CS_0024_003C_003E8__locals2.val = item2;
					if (value4.FindIndex((IPropertyMetadata p) => _003C_003Ec__DisplayClass10_2.h62pbeZ2aTiLtYhs9HXn(_003C_003Ec__DisplayClass10_2.AdFQ0CZ2pAfVGa9li69t(p), CS_0024_003C_003E8__locals2.val.Key)) != -1)
					{
						PropertyInfo propertyCached = CS_0024_003C_003E8__locals1.entity.GetType().GetPropertyCached(CS_0024_003C_003E8__locals2.val.Key);
						if (!(propertyCached == null) && propertyCached.CanWrite)
						{
							propertyCached.SetValue(CS_0024_003C_003E8__locals1.entity, CS_0024_003C_003E8__locals2.val.Value, null);
						}
					}
				}
				if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.supportedImportEntitySaveActionsExtensions.Count > 0)
				{
					ImportEntityPreSaveData data = new ImportEntityPreSaveData(((ConfigurationImportExecutor)executor).serviceData, ((ConfigurationImportExecutor)executor).systemMessages, ((ConfigurationImportExecutor)executor).mergeReplace, ((ConfigurationImportExecutor)executor).linksDictionary);
					foreach (IEntityImportSaveActions supportedImportEntitySaveActionsExtension2 in CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.supportedImportEntitySaveActionsExtensions)
					{
						List<TestImportMessages> list = supportedImportEntitySaveActionsExtension2.ExecPreSaveActions(CS_0024_003C_003E8__locals1.entity, data);
						bool flag3 = false;
						if (list != null)
						{
							flag3 = list.Any((TestImportMessages m) => _003C_003Ec.SiKGTtZOy6OHHHJAQh4n(m) == TestImportMessagesType.Error);
							foreach (TestImportMessages item3 in list)
							{
								switch (item3.Type)
								{
								case TestImportMessagesType.Error:
									ImportLog.Error(item3.Text);
									((ConfigurationImportExecutor)executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Error, item3.Text, endProcess: false));
									break;
								case TestImportMessagesType.Warning:
									ImportLog.Warn(item3.Text);
									((ConfigurationImportExecutor)executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, item3.Text, endProcess: false));
									break;
								default:
									ImportLog.Info(item3.Text);
									((ConfigurationImportExecutor)executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Info, item3.Text, endProcess: false));
									break;
								}
							}
						}
						flag = flag && !flag3;
					}
				}
				CS_0024_003C_003E8__locals1.uid = (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propValuesR.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17ADA34A), out value) ? value : ((object)Guid.Empty));
				ImportLog.Info(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234016022), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.type.Name, CS_0024_003C_003E8__locals1.uid));
				((ConfigurationImportExecutor)executor).withFormDependenciesService.Run(delegate
				{
					//Discarded unreachable code: IL_0156, IL_0166, IL_0170, IL_021d, IL_0230, IL_023f, IL_02d1, IL_02e0, IL_02eb, IL_03b3, IL_03c6, IL_03d5, IL_0401, IL_0410
					int num = 6;
					int num2 = num;
					List<IEntityImportSaveActions>.Enumerator enumerator8 = default(List<IEntityImportSaveActions>.Enumerator);
					while (true)
					{
						switch (num2)
						{
						case 5:
						case 8:
						{
							object obj2 = _003C_003Ec__DisplayClass10_1.xL38OgZ2XWN6ZXSHSDIu(((ConfigurationImportExecutor)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.executor).sessionProvider, "");
							_003C_003Ec__DisplayClass10_1.DRtldlZ2TxLPS95j4AO3(obj2, CS_0024_003C_003E8__locals1.entity);
							_003C_003Ec__DisplayClass10_1.wfCd48Z2kdH8U54h4S5A(obj2);
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						default:
							if (!CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.supportedImportEntitySaveActionsExtensions.Any())
							{
								num2 = 7;
								continue;
							}
							goto case 11;
						case 6:
							if (!CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.supportedImportEntitySaveActionsExtensions.Any())
							{
								num2 = 5;
								continue;
							}
							break;
						case 3:
							return;
						case 7:
							return;
						case 2:
							_003C_003Ec__DisplayClass10_1.JaSDVtZ228HZDpL7Axvp(ImportLog, _003C_003Ec__DisplayClass10_1.NG7fUrZ2ORPNcGyKn5Mp(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675632275), _003C_003Ec__DisplayClass10_1.dyMrxoZ2nx0lScHnSGxu(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.type), CS_0024_003C_003E8__locals1.uid));
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
							{
								num2 = 9;
							}
							continue;
						case 11:
							enumerator8 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.supportedImportEntitySaveActionsExtensions.GetEnumerator();
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num2 = 1;
							}
							continue;
						case 10:
							try
							{
								while (true)
								{
									int num5;
									if (!enumerator8.MoveNext())
									{
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
										{
											num5 = 0;
										}
										goto IL_0174;
									}
									goto IL_018a;
									IL_018a:
									enumerator8.Current.ExecSaveActions(CS_0024_003C_003E8__locals1.entity, ((ConfigurationImportExecutor)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.executor).serviceData);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
									{
										num5 = 1;
									}
									goto IL_0174;
									IL_0174:
									switch (num5)
									{
									case 2:
										goto IL_018a;
									case 1:
										continue;
									case 0:
										break;
									}
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator8).Dispose();
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								case 0:
									break;
								}
							}
							goto case 2;
						case 9:
							((ConfigurationImportExecutor)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Info, SR.T((string)_003C_003Ec__DisplayClass10_1.VKrodPZ2eWoRSVIEixxi(-812025778 ^ -811644066), _003C_003Ec__DisplayClass10_1.sd92TbZ2PdBXgOd6FAjR(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadata), CS_0024_003C_003E8__locals1.uid, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadata.Name), endProcess: false));
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
							{
								num2 = 0;
							}
							continue;
						case 1:
							try
							{
								while (true)
								{
									int num3;
									if (!enumerator8.MoveNext())
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
										{
											num3 = 0;
										}
										goto IL_02ef;
									}
									goto IL_0305;
									IL_0305:
									enumerator8.Current.ExecPostSaveActions(CS_0024_003C_003E8__locals1.entity, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.type, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propValuesR, ((ConfigurationImportExecutor)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.executor).serviceData, ((ConfigurationImportExecutor)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.executor).linksDictionary);
									num3 = 2;
									goto IL_02ef;
									IL_02ef:
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
									goto IL_0305;
								}
							}
							finally
							{
								((IDisposable)enumerator8).Dispose();
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
						case 4:
							break;
						}
						enumerator8 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.supportedImportEntitySaveActionsExtensions.GetEnumerator();
						num2 = 10;
					}
				});
				if (flag)
				{
					try
					{
						_003C_003Ec__DisplayClass10_3 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass10_3();
						Guid.TryParse(CS_0024_003C_003E8__locals1.uid.ToString(), out CS_0024_003C_003E8__locals3.eUid);
						List<ILinksDictionaryItem> list2 = new List<ILinksDictionaryItem>();
						foreach (LinksDictionaryItem item4 in from i in ((ConfigurationImportExecutor)executor).linksDictionary.OfType<LinksDictionaryItem>()
							where _003C_003Ec__DisplayClass10_3.pEe2CcZ26QZlT14o1EUF(i, CS_0024_003C_003E8__locals3.eUid)
							select i)
						{
							try
							{
								if (item4.SetLinkValue(CS_0024_003C_003E8__locals1.entity, CS_0024_003C_003E8__locals3.eUid))
								{
									list2.Add(item4);
								}
							}
							catch (Exception ex2)
							{
								ImportLog.Info(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575845992), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.type.Name, CS_0024_003C_003E8__locals1.uid, item4.EntityUid, item4.EntityPropertyName, item4.LinkPropertyUid, ex2.Message));
							}
						}
						foreach (IEntityImportSaveActions entityImportSaveActionExtension in ((ConfigurationImportExecutor)executor).entityImportSaveActionExtensions)
						{
							try
							{
								IEnumerable<ILinksDictionaryItem> enumerable = entityImportSaveActionExtension.RecoveryLinks(CS_0024_003C_003E8__locals1.entity, CS_0024_003C_003E8__locals3.eUid, ((ConfigurationImportExecutor)executor).linksDictionary);
								if (enumerable != null)
								{
									list2.AddRange(enumerable);
								}
							}
							catch (Exception ex3)
							{
								ImportLog.Info(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4ED954F4), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.type.Name, CS_0024_003C_003E8__locals1.uid, entityImportSaveActionExtension.GetType().Name, ex3.Message));
							}
						}
						foreach (ILinksDictionaryItem item5 in list2)
						{
							((ConfigurationImportExecutor)executor).linksDictionary.Remove(item5);
						}
					}
					catch
					{
					}
				}
				packet[CS_0024_003C_003E8__locals1.entity] = (flag ? null : new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA0AF64), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadata.DisplayName)));
			}
			else
			{
				ImportLog.Info(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671753599), CS_0024_003C_003E8__locals0.type.Name, string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A779BB5), CS_0024_003C_003E8__locals0.propValuesR.Select((KeyValuePair<string, object> p) => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x124232BE), p.Key, p.Value)))));
				((ConfigurationImportExecutor)executor).AddMessage(new DeployLogMessage(DeployLogMessageType.Info, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107687910), CS_0024_003C_003E8__locals0.metadata.DisplayName, CS_0024_003C_003E8__locals0.metadata.Name), endProcess: false));
			}
			return true;
		}

		internal static void koay8P8kaNpH0fCKvclM()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool BtCUdd8kDDmeGtyL8Gev(object P_0)
		{
			return ((XmlReader)P_0).IsStartElement();
		}

		internal static object LaQt8C8ktxSUdw89ibM3(object P_0)
		{
			return ((XmlReader)P_0).Name;
		}

		internal static object PRH1KZ8kwRVnUxUgYDZ5(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool fBhsQb8k4qIxjcqlogVN(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static bool Ndpqrk8k6SkM17rgk43X(object P_0)
		{
			return ((XmlReader)P_0).IsEmptyElement;
		}

		internal static bool caj3358kHcYY8aMQT5rh(object P_0)
		{
			return ((XmlReader)P_0).Read();
		}

		internal static void fYKtSr8kAwmGvuSqSdP4(object P_0)
		{
			((XmlReader)P_0).Skip();
		}

		internal static XmlNodeType bdYSFW8k7VwgXRwG3PMP(object P_0)
		{
			return ((XmlReader)P_0).NodeType;
		}

		internal static bool dP2IK38k3ZrNYFoPy3Rt()
		{
			return vpNLbH8kNNLaKk3aej4i == null;
		}

		internal static ReadPacketResult pFswJM8kp07UnjN6Hqu8()
		{
			return (ReadPacketResult)vpNLbH8kNNLaKk3aej4i;
		}

		internal static object QJG3Ut8kxgHNwW4YdUhL(object P_0, long userId)
		{
			return ((ISecurityDeployHelperExtension)P_0).LoadUserOrNull(userId);
		}

		internal static void KGbyRg8k0peOJ190OOkv(object P_0, object P_1, object P_2)
		{
			((ISecurityService)P_0).RunByUser((IUser)P_1, (Action)P_2);
		}

		internal static void lyG6Nt8kmZgQVf2qrHDS(object P_0)
		{
			((ICollection<(Dictionary<string, Dictionary<string, object>>, EntityMetadata, Type)>)P_0).Clear();
		}

		internal static void HG1h2k8kyHOrtY9RcQ0V(object P_0)
		{
			((ICollection<(IReadMetadataResult, bool)>)P_0).Clear();
		}

		internal static void E7D1aN8kM4f5eqqqhAMw(object P_0)
		{
			((ICollection<KeyValuePair<string, string>>)P_0).Clear();
		}
	}

	private sealed class ImportantDataClass
	{
		private static object currentVersion;

		private static object maxVersion;

		private static object xorJkJ8kJmU3hRHks3nv;

		public Guid Uid { get; }

		public Version Version { get; }

		public string Module { get; }

		static ImportantDataClass()
		{
			int num = 4;
			int num2 = num;
			Version version = default(Version);
			while (true)
			{
				switch (num2)
				{
				case 2:
					maxVersion = new Version(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				default:
					currentVersion = new Version(I5cASK8kry1b07Chw4YT(version), dEGr7s8kg3yubHMmhHtG(version));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					XCIodT8klSe7nNvdd68E();
					num2 = 3;
					break;
				case 3:
					version = VersionInfo.GetVersion<SR>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public static ImportantDataClass Read(object reader, ISet<Guid> importantData)
		{
			if (!((XmlReader)reader).MoveToAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A43911)) || !Guid.TryParse(((XmlReader)reader).Value, out var result) || importantData.Contains(result))
			{
				((XmlReader)reader).Skip();
				return null;
			}
			string text = ((((XmlReader)reader).MoveToAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1FD3C0)) && !string.IsNullOrWhiteSpace(((XmlReader)reader).Value)) ? ((XmlReader)reader).Value : null);
			Version version = (Version)maxVersion;
			((XmlReader)reader).MoveToContent();
			if (!((XmlReader)reader).IsEmptyElement)
			{
				((XmlReader)reader).Read();
				((XmlReader)reader).MoveToContent();
				while (((XmlReader)reader).NodeType != XmlNodeType.EndElement)
				{
					if (((XmlReader)reader).IsStartElement() && ((XmlReader)reader).Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281809460) && !((XmlReader)reader).IsEmptyElement && Version.TryParse(((XmlReader)reader).ReadElementString(), out var result2) && (text != null || result2 >= (Version)currentVersion) && result2 < version)
					{
						version = result2;
					}
					((XmlReader)reader).Skip();
					((XmlReader)reader).MoveToContent();
				}
				((XmlReader)reader).Read();
			}
			if (!(version == (Version)maxVersion))
			{
				return new ImportantDataClass(result, version, text);
			}
			return null;
		}

		private ImportantDataClass(Guid uid, Version version, string module)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					Uid = uid;
					num = 3;
					break;
				default:
					Module = module;
					num = 2;
					break;
				case 2:
					return;
				case 3:
					Version = version;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		internal static void XCIodT8klSe7nNvdd68E()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static int I5cASK8kry1b07Chw4YT(object P_0)
		{
			return ((Version)P_0).Major;
		}

		internal static int dEGr7s8kg3yubHMmhHtG(object P_0)
		{
			return ((Version)P_0).Minor;
		}

		internal static bool tvDjtK8k9Nrg8NAKn1f1()
		{
			return xorJkJ8kJmU3hRHks3nv == null;
		}

		internal static ImportantDataClass AZLZOL8kdnMxF7bd0RPJ()
		{
			return (ImportantDataClass)xorJkJ8kJmU3hRHks3nv;
		}
	}

	internal static string RegularProperty;

	internal static string XmlProperty;

	private ImportStep step;

	private int testStep;

	private Dictionary<string, string> serviceData;

	private readonly IImportSettings importSettings;

	private readonly string treeUid;

	private ISet<Guid> metadataNotIsUnique;

	private readonly LinksDictionary linksDictionary;

	private readonly List<PackageOperationInfo> packagesOperations;

	private List<string> packetError;

	private List<IEntity> savedPacketEntities;

	private readonly MergeReplace mergeReplace;

	private readonly MergeUidReplace mergeUidReplace;

	private static readonly ILogger ImportLog;

	private long signUserId;

	private readonly Dictionary<Type, List<IPropertyMetadata>> entitiesMetadata;

	private readonly List<long> headers;

	private readonly ISecurityService securityService;

	private readonly IAuthenticationService authenticationService;

	private readonly IModelManager modelManager;

	private readonly IModuleManager moduleManager;

	private readonly IWorkWithFormDependeciesService withFormDependenciesService;

	private readonly IZipService zipService;

	private readonly ITagService tagService;

	private readonly IUnitOfWorkManager unitOfWorkManager;

	private readonly IRuntimeApplication runtimeApplication;

	private readonly MetadataItemManager metadataItemManager;

	private readonly BPMAppManager bpmAppManager;

	private readonly PackageService packageService;

	private readonly PacketVersionService packetVersionService;

	private readonly ISessionProvider sessionProvider;

	private readonly IContextBoundVariableService contextCacheService;

	private readonly RunWithSoftDeletableService runWithSoftDeletableService;

	private readonly IEnumerable<IPacketActions> packetActions;

	private readonly IEnumerable<IMetadataImport> metadataImport;

	private readonly IEnumerable<ISkipEntityImportResolver> skipEntityImportResolvers;

	private readonly IExportImportFileManager exportImportFileManager;

	private readonly IEnumerable<IConfigImportExtension> importExtensions;

	private readonly IEnumerable<IIgnoreIsUniqueMetadata> ignoreIsUniqueMetadata;

	private readonly IEnumerable<ISecurityDeployHelperExtension> securityDeployHelperExtensions;

	private readonly IEnumerable<IPrivilegeModuleAccessGroup> privilegeModuleAccessGroups;

	private readonly IEnumerable<IPostEntityXmlSerializer> postEntityXmlSerializers;

	private readonly IEnumerable<IConfigImportActionExtension> configImportActionExtensions;

	private readonly IEnumerable<IEntityImportSaveActions> entityImportSaveActionExtensions;

	private readonly IEnumerable<IImportantData> importantData;

	private List<DeployLogMessage> messages;

	private readonly List<TestImportMessages> testMessages;

	private List<DeploySystemMessage> systemMessages;

	private readonly List<DeploySystemMessage> testSystemMessages;

	private BPMAppManifest manifestExecuteMetadata;

	private ElmaStoreComponentManifest manifest;

	private static ConfigurationImportExecutor hMiB5FE1uQm4WfVepvcS;

	private BPMAppManifest ManifestExecuteMetadata
	{
		get
		{
			//Discarded unreachable code: IL_00c5, IL_00f7, IL_010e, IL_011d, IL_012d, IL_013c, IL_014b
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return manifestExecuteMetadata;
				case 4:
					if (manifestExecuteMetadata != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 6;
				case 5:
					if (!string.IsNullOrEmpty(manifest.BPMAppManifest))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 1:
					try
					{
						manifestExecuteMetadata = ClassSerializationHelper.DeserializeObjectByXml<BPMAppManifest>((string)U5UHMaE1S4JqtTam5itl(manifest));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto default;
				case 6:
					if (manifest == null)
					{
						num2 = 2;
						break;
					}
					goto case 5;
				}
			}
		}
	}

	public string AppId
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					ElmaStoreComponentManifest elmaStoreComponentManifest = manifest;
					if (elmaStoreComponentManifest == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 0;
						}
						break;
					}
					return (string)GvRGdQE1iuAiuxD2PxRf(elmaStoreComponentManifest);
				}
				default:
					return null;
				}
			}
		}
	}

	public event Action<TestImportMessages> BeforeAddTestMessage;

	public event EventHandler<EventArgs> OnImportFinished;

	private void TestMessagesAdd(TestImportMessages message)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				return;
			default:
				TestMessageInternalAdd(message);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (message == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	private void TestMessageInternalAdd(TestImportMessages message)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 2:
				{
					Action<TestImportMessages> beforeAddTestMessage = this.BeforeAddTestMessage;
					if (beforeAddTestMessage == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num2 = 1;
						}
						continue;
					}
					beforeAddTestMessage(message);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				}
				break;
			}
			testMessages.Add(message);
			num = 3;
		}
	}

	public List<DeploySystemMessage> GetTestSystemMessages()
	{
		return testSystemMessages;
	}

	public ConfigurationImportExecutor(IImportSettings settings, ISecurityService securityService, IAuthenticationService authenticationService, IModelManager modelManager, IModuleManager moduleManager, IWorkWithFormDependeciesService withFormDependenciesService, IZipService zipService, ITagService tagService, IUnitOfWorkManager unitOfWorkManager, IRuntimeApplication runtimeApplication, MetadataItemManager metadataItemManager, BPMAppManager bpmAppManager, PackageService packageService, PacketVersionService packetVersionService, RunWithSoftDeletableService runWithSoftDeletableService, ISessionProvider sessionProvider, IContextBoundVariableService contextCacheService, IExportImportFileManager exportImportFileManager, IEnumerable<IConfigImportExtension> importExtensions, IEnumerable<IConfigImportActionExtension> configImportActionExtensions, IEnumerable<IEntityImportSaveActions> entityImportSaveActionExtensions, IEnumerable<IImportantData> importantData, IEnumerable<IPacketActions> packetActions, IEnumerable<IMetadataImport> metadataImport, IEnumerable<ISkipEntityImportResolver> skipEntityImportResolvers, IEnumerable<IIgnoreIsUniqueMetadata> ignoreIsUniqueMetadata, IEnumerable<ISecurityDeployHelperExtension> securityDeployHelperExtensions, IEnumerable<IPrivilegeModuleAccessGroup> privilegeModuleAccessGroups, IEnumerable<IPostEntityXmlSerializer> postEntityXmlSerializers)
	{
		SingletonReader.JJCZtPuTvSt();
		linksDictionary = new LinksDictionary();
		packagesOperations = new List<PackageOperationInfo>();
		packetError = new List<string>();
		savedPacketEntities = new List<IEntity>();
		mergeReplace = new MergeReplace();
		mergeUidReplace = new MergeUidReplace();
		entitiesMetadata = new Dictionary<Type, List<IPropertyMetadata>>();
		headers = new List<long>();
		messages = new List<DeployLogMessage>();
		testMessages = new List<TestImportMessages>();
		systemMessages = new List<DeploySystemMessage>();
		testSystemMessages = new List<DeploySystemMessage>();
		base._002Ector();
		importSettings = settings;
		this.securityService = securityService;
		this.authenticationService = authenticationService;
		this.modelManager = modelManager;
		this.moduleManager = moduleManager;
		this.withFormDependenciesService = withFormDependenciesService;
		this.zipService = zipService;
		this.tagService = tagService;
		this.unitOfWorkManager = unitOfWorkManager;
		this.runtimeApplication = runtimeApplication;
		this.metadataItemManager = metadataItemManager;
		this.bpmAppManager = bpmAppManager;
		this.packageService = packageService;
		this.packetVersionService = packetVersionService;
		this.runWithSoftDeletableService = runWithSoftDeletableService;
		this.sessionProvider = sessionProvider;
		this.contextCacheService = contextCacheService;
		this.exportImportFileManager = exportImportFileManager;
		this.importExtensions = importExtensions;
		this.configImportActionExtensions = configImportActionExtensions;
		this.entityImportSaveActionExtensions = entityImportSaveActionExtensions;
		this.importantData = importantData;
		this.packetActions = packetActions;
		this.metadataImport = metadataImport;
		this.skipEntityImportResolvers = skipEntityImportResolvers;
		this.ignoreIsUniqueMetadata = ignoreIsUniqueMetadata;
		this.securityDeployHelperExtensions = securityDeployHelperExtensions;
		this.privilegeModuleAccessGroups = privilegeModuleAccessGroups;
		this.postEntityXmlSerializers = postEntityXmlSerializers;
		treeUid = ((!(settings is IConfigImportSettings configImportSettings)) ? null : (configImportSettings.FakeManifest?.TreeUid ?? configImportSettings.FileName));
	}

	public void RunTest(IRunTestParameters parameters)
	{
		//Discarded unreachable code: IL_0103, IL_0144, IL_0167, IL_0176, IL_0211, IL_0249, IL_0258, IL_0283, IL_0301, IL_03a5, IL_03b4
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass66_0 _003C_003Ec__DisplayClass66_ = default(_003C_003Ec__DisplayClass66_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				_003C_003Ec__DisplayClass66_.parameters = parameters;
				num2 = 2;
				break;
			case 2:
				Contract.ArgumentNotNull(_003C_003Ec__DisplayClass66_.parameters, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477122732));
				num2 = 4;
				break;
			case 3:
			{
				TestImportMessages testImportMessages3 = new TestImportMessages();
				wt62WtE1k42GRNSw2qm3(testImportMessages3, TestImportMessagesType.Finish);
				TestMessageInternalAdd(testImportMessages3);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 0:
				return;
			case 6:
				_003C_003Ec__DisplayClass66_ = new _003C_003Ec__DisplayClass66_0();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass66_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				try
				{
					CallContextSessionOwner callContextSessionOwner = (CallContextSessionOwner)mnstkKE1RmbkZ8XHtSpt();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							int num4;
							if (authenticationService.GetCurrentUser<IUser>() != null)
							{
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
								{
									num4 = 1;
								}
								goto IL_0148;
							}
							goto IL_01b9;
							IL_01b9:
							xqZoL9E1ql5fDD155gNy(securityService, new Action(_003C_003Ec__DisplayClass66_._003CRunTest_003Eb__0));
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num4 = 3;
							}
							goto IL_0148;
							IL_0148:
							while (true)
							{
								switch (num4)
								{
								case 1:
									goto end_IL_0148;
								case 2:
									RunTest(_003C_003Ec__DisplayClass66_.parameters.ActivationKey, _003C_003Ec__DisplayClass66_.parameters.CancellationToken);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
									{
										num4 = 1;
									}
									continue;
								case 3:
									goto end_IL_0148;
								}
								goto IL_01b9;
								continue;
								end_IL_0148:
								break;
							}
						}
						finally
						{
							if (callContextSessionOwner != null)
							{
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										GH8iJvE1KjBtdq7Mib6q(callContextSessionOwner);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
										{
											num5 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
						break;
					case 1:
						break;
					}
				}
				catch (OperationCanceledException)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
						{
							TestImportMessages testImportMessages = new TestImportMessages();
							jUdVKCE1TQNJBY9uYmb9(testImportMessages, U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD398F0A)));
							wt62WtE1k42GRNSw2qm3(testImportMessages, TestImportMessagesType.Error);
							TestMessageInternalAdd(testImportMessages);
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
							{
								num6 = 1;
							}
							continue;
						}
						case 1:
							break;
						}
						break;
					}
				}
				catch (Exception ex2)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num7 = 1;
					}
					while (true)
					{
						switch (num7)
						{
						default:
						{
							TestImportMessages testImportMessages2 = new TestImportMessages();
							jUdVKCE1TQNJBY9uYmb9(testImportMessages2, SR.T((string)NUn1HRE1nboQISCQgj1B(0x7459E02 ^ 0x741FED8), Ye6XkoE12l2wWmACTc0I(ex2)));
							testImportMessages2.Type = TestImportMessagesType.Error;
							TestMessageInternalAdd(testImportMessages2);
							num7 = 2;
							continue;
						}
						case 1:
							mpPoVWE1OsoeCdWeb6OT(Logger.Log, NUn1HRE1nboQISCQgj1B(-541731959 ^ -542002371), ex2);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num7 = 0;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				goto case 3;
			}
		}
	}

	public void RunImport(IRunImportParameters parameters)
	{
		//Discarded unreachable code: IL_00aa, IL_030a, IL_0343, IL_03c6, IL_03f3, IL_04f3, IL_0502, IL_062c, IL_093b, IL_0a34, IL_0a43, IL_0aa5, IL_0ad6, IL_0bde, IL_0bed, IL_0c9e, IL_0d04, IL_0e32, IL_0ec3, IL_0efb, IL_0f5c, IL_1051, IL_12c8, IL_12d7, IL_12e7, IL_1356, IL_1386, IL_1406, IL_14b7, IL_14ef, IL_150e, IL_153a, IL_1583, IL_1592, IL_166b, IL_167a, IL_1943, IL_1a3f, IL_1a4e, IL_1bae, IL_1bee, IL_1bf9, IL_1c08, IL_1c2c, IL_1c3b, IL_1dba, IL_1dc9, IL_1e97, IL_1ea6, IL_1eb6, IL_1ec5, IL_1f65, IL_1f74, IL_1f7f, IL_1fc7, IL_2022, IL_208e, IL_20a5, IL_20b4, IL_20c3, IL_20f4, IL_2113, IL_2122, IL_213f, IL_2195, IL_21a4, IL_21b4, IL_22e8, IL_23bc, IL_23cb, IL_23f5, IL_2404, IL_2413, IL_253b, IL_254e, IL_25ef, IL_261c, IL_262b, IL_2701, IL_29a6, IL_29de, IL_2a0c, IL_2b4d, IL_2b60, IL_2bae, IL_2bb8, IL_2c3b, IL_2c4a, IL_2cf8, IL_2d80, IL_2d8f, IL_2dc0, IL_2ddf, IL_2dee, IL_2e1b, IL_2e2a, IL_2ef8, IL_2f07
		int num = 2;
		int num2 = num;
		IEnumerator<TestImportMessages> enumerator = default(IEnumerator<TestImportMessages>);
		CallContextSessionOwner callContextSessionOwner = default(CallContextSessionOwner);
		_003C_003Ec__DisplayClass67_0 CS_0024_003C_003E8__locals1;
		Action action = default(Action);
		CancellationToken cancellationToken = default(CancellationToken);
		StoreComponentUnpackStatus storeComponentUnpackStatus = default(StoreComponentUnpackStatus);
		string text2 = default(string);
		string text3 = default(string);
		IConfigImportSettings configImportSettings = default(IConfigImportSettings);
		_003C_003Ec__DisplayClass67_1 _003C_003Ec__DisplayClass67_ = default(_003C_003Ec__DisplayClass67_1);
		string unpackedPackagesFolder = default(string);
		XmlReader xmlReader = default(XmlReader);
		_003C_003Ec__DisplayClass67_3 CS_0024_003C_003E8__locals0;
		string text5 = default(string);
		string attribute = default(string);
		bool needRestart = default(bool);
		string text4 = default(string);
		string text6 = default(string);
		List<ReadPacketResult> list2 = default(List<ReadPacketResult>);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		List<PackageInstallOperationInfo> list = default(List<PackageInstallOperationInfo>);
		string text = default(string);
		XmlTextReader xmlTextReader = default(XmlTextReader);
		bool value = default(bool);
		TestImportMessages current = default(TestImportMessages);
		TestImportMessagesType testImportMessagesType = default(TestImportMessagesType);
		while (true)
		{
			switch (num2)
			{
			default:
				enumerator = importSettings.TestResult.GetEnumerator();
				num2 = 8;
				break;
			case 10:
				systemMessages = parameters.SystemMessages;
				num2 = 5;
				break;
			case 4:
				try
				{
					CI84eLE1w15ESyMY8UaR(runWithSoftDeletableService, true);
					int num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							callContextSessionOwner = (CallContextSessionOwner)mnstkKE1RmbkZ8XHtSpt();
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
							{
								num5 = 0;
							}
							continue;
						case 2:
							return;
						}
						try
						{
							CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass67_0();
							int num6 = 74;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
							{
								num6 = 84;
							}
							while (true)
							{
								object obj;
								int num8;
								switch (num6)
								{
								case 3:
								case 67:
								case 101:
									action = delegate
									{
										//Discarded unreachable code: IL_0123, IL_0156, IL_01c3, IL_0354, IL_0363
										int num28 = 3;
										IBPMApp iBPMApp = default(IBPMApp);
										byte[] additionalFilesContent = default(byte[]);
										byte[] helpFileContent = default(byte[]);
										BPMAppManifest bPMAppManifest = default(BPMAppManifest);
										IBPMApp iBPMApp2 = default(IBPMApp);
										_003C_003Ec__DisplayClass67_2 _003C_003Ec__DisplayClass67_2 = default(_003C_003Ec__DisplayClass67_2);
										while (true)
										{
											int num29 = num28;
											while (true)
											{
												switch (num29)
												{
												case 15:
													if (!_003C_003Ec__DisplayClass67_0.kygQql8nWdGwTCEGAh2y(_003C_003Ec__DisplayClass67_0.fRKROO8nBQKYEIvhXDKp(CS_0024_003C_003E8__locals1._003C_003E4__this.manifest)))
													{
														num29 = 5;
														continue;
													}
													goto case 20;
												case 17:
													_003C_003Ec__DisplayClass67_0.m1OLe88nZWPoO6Ecuo8m(iBPMApp, additionalFilesContent, helpFileContent);
													num29 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
													{
														num29 = 6;
													}
													continue;
												case 4:
													CS_0024_003C_003E8__locals1._003C_003E4__this.moduleManager.SaveStoreComponent(CS_0024_003C_003E8__locals1._003C_003E4__this.manifest, CS_0024_003C_003E8__locals1.signatures, CS_0024_003C_003E8__locals1.zipFileName, StoreComponentStatus.Active);
													num29 = 14;
													continue;
												case 5:
													try
													{
														bPMAppManifest = ClassSerializationHelper.DeserializeObjectByXml<BPMAppManifest>((string)_003C_003Ec__DisplayClass67_0.fRKROO8nBQKYEIvhXDKp(CS_0024_003C_003E8__locals1._003C_003E4__this.manifest));
														int num30 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
														{
															num30 = 0;
														}
														switch (num30)
														{
														case 0:
															break;
														}
													}
													catch (Exception ex5)
													{
														int num31 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
														{
															num31 = 0;
														}
														while (true)
														{
															switch (num31)
															{
															default:
																_003C_003Ec__DisplayClass67_0.jrlrLZ8nb3DmhMThZGV5(ImportLog, _003C_003Ec__DisplayClass67_0.IQlNDR8noPf7FvvNIMxd(0x53CB464B ^ 0x53CF345D), ex5);
																num31 = 1;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
																{
																	num31 = 1;
																}
																break;
															case 1:
																throw new InvalidOperationException((string)_003C_003Ec__DisplayClass67_0.J6vO988nhknDyY5U5RRs(_003C_003Ec__DisplayClass67_0.IQlNDR8noPf7FvvNIMxd(0x463A0F3C ^ 0x463E7D5C)));
															}
														}
													}
													goto case 20;
												case 13:
													if (CS_0024_003C_003E8__locals1._003C_003E4__this.manifest != null)
													{
														num29 = 4;
														continue;
													}
													return;
												default:
													if (!iBPMApp2.Installed)
													{
														num29 = 12;
														continue;
													}
													goto case 7;
												case 21:
													if (iBPMApp2 == null)
													{
														num29 = 7;
														continue;
													}
													goto default;
												case 11:
													_003C_003Ec__DisplayClass67_0.GOe0ug8n8kGOmWJGpdlY(iBPMApp, CS_0024_003C_003E8__locals1.manifestImage);
													num29 = 17;
													continue;
												case 9:
													return;
												case 20:
													if (bPMAppManifest == null)
													{
														return;
													}
													num29 = 3;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
													{
														num29 = 8;
													}
													continue;
												case 19:
													_003C_003Ec__DisplayClass67_0.NN0VZ88nvvrkUq6FW7aA(iBPMApp, bPMAppManifest);
													num29 = 11;
													continue;
												case 2:
													_003C_003Ec__DisplayClass67_2.postCompleteParams = new PostCompleteImportParameters(CS_0024_003C_003E8__locals1._003C_003E4__this.messages, CS_0024_003C_003E8__locals1._003C_003E4__this.systemMessages, CS_0024_003C_003E8__locals1.serverFolderName, CS_0024_003C_003E8__locals1._003C_003E4__this.serviceData, CS_0024_003C_003E8__locals1._003C_003E4__this.manifest, _003C_003Ec__DisplayClass67_0.I77IhD8nFaFq7a40GkPp(CS_0024_003C_003E8__locals1._003C_003E4__this.importSettings), CS_0024_003C_003E8__locals1._003C_003E4__this.treeUid);
													num29 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
													{
														num29 = 1;
													}
													continue;
												case 14:
													bPMAppManifest = null;
													num29 = 15;
													continue;
												case 1:
													CS_0024_003C_003E8__locals1._003C_003E4__this.importExtensions.Each(_003C_003Ec__DisplayClass67_2._003CRunImport_003Eb__9);
													num29 = 13;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
													{
														num29 = 3;
													}
													continue;
												case 10:
													_003C_003Ec__DisplayClass67_0.b7mmjx8nC1QJcp4HLSee(iBPMApp, CS_0024_003C_003E8__locals1._003C_003E4__this.manifest);
													num29 = 19;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
													{
														num29 = 17;
													}
													continue;
												case 6:
													iBPMApp.Installed = true;
													num29 = 18;
													continue;
												case 16:
													iBPMApp2 = (IBPMApp)_003C_003Ec__DisplayClass67_0.RAMlmg8nfBQIHtGC5SK3(CS_0024_003C_003E8__locals1._003C_003E4__this.bpmAppManager, _003C_003Ec__DisplayClass67_0.LhZadN8nEoyrmwTy3iaH(CS_0024_003C_003E8__locals1._003C_003E4__this.manifest));
													num29 = 21;
													continue;
												case 3:
													break;
												case 12:
													throw new InvalidOperationException((string)_003C_003Ec__DisplayClass67_0.J6vO988nhknDyY5U5RRs(_003C_003Ec__DisplayClass67_0.IQlNDR8noPf7FvvNIMxd(0x3C5338FF ^ 0x3C574A51)));
												case 7:
													iBPMApp = (IBPMApp)_003C_003Ec__DisplayClass67_0.tHoa5F8nQ3YvEJkFwUJM(CS_0024_003C_003E8__locals1._003C_003E4__this.bpmAppManager, _003C_003Ec__DisplayClass67_0.LhZadN8nEoyrmwTy3iaH(CS_0024_003C_003E8__locals1._003C_003E4__this.manifest));
													num29 = 10;
													continue;
												case 18:
													CS_0024_003C_003E8__locals1._003C_003E4__this.bpmAppManager.Save(iBPMApp);
													num29 = 9;
													continue;
												case 8:
													CS_0024_003C_003E8__locals1._003C_003E4__this.AddAdditionalFilesInBpmApp(CS_0024_003C_003E8__locals1._003C_003E4__this.serviceData, CS_0024_003C_003E8__locals1.serverFolderName, (string)_003C_003Ec__DisplayClass67_0.RATqDy8nGeFFJbZAGpmg(CS_0024_003C_003E8__locals1._003C_003E4__this.manifest), out additionalFilesContent, out helpFileContent);
													num29 = 6;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
													{
														num29 = 16;
													}
													continue;
												}
												break;
											}
											_003C_003Ec__DisplayClass67_2 = new _003C_003Ec__DisplayClass67_2();
											num28 = 2;
										}
									};
									num6 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
									{
										num6 = 5;
									}
									break;
								case 47:
								case 85:
									if (manifest != null)
									{
										num6 = 15;
										break;
									}
									goto case 35;
								case 10:
									cancellationToken = parameters.CancellationToken;
									num6 = 44;
									break;
								case 60:
									Y2royjE1plb4gjxp3MMP(ImportLog, NUn1HRE1nboQISCQgj1B(-1459557599 ^ -1459321419));
									num6 = 63;
									break;
								case 25:
									storeComponentUnpackStatus = UnpackIfSigned("", ComponentManager.Current.ModuleManager.GetMainLicensedUnitExpiration, text2, CS_0024_003C_003E8__locals1.serverFolderName, out CS_0024_003C_003E8__locals1.signatures);
									num6 = 50;
									break;
								case 48:
									manifest.Packages.ForEach(delegate(PackageManifest p)
									{
										int num44 = 1;
										int num45 = num44;
										while (true)
										{
											switch (num45)
											{
											default:
												return;
											case 0:
												return;
											case 1:
												AddMessage(new DeployLogMessage(BPMAppItemImportStatus.InProgress, (string)sScEJBEpBDW6U2w2MX2Z(p), treeUid));
												num45 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
												{
													num45 = 0;
												}
												break;
											}
										}
									});
									num6 = 20;
									break;
								case 22:
								case 73:
									action();
									num6 = 8;
									break;
								case 38:
								case 71:
									text3 = (string)dYeXvrE19eZSUKAbx1sd(exportImportFileManager, configImportSettings.FileName);
									num6 = 91;
									break;
								case 82:
									signUserId = NCSjPOE14LFcERlhbSPn(parameters);
									num6 = 83;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
									{
										num6 = 41;
									}
									break;
								case 29:
									if (_003C_003Ec__DisplayClass67_.packagingComponent == null)
									{
										num6 = 93;
										break;
									}
									if (u1lVu1E1rkXXYmfryECy(CS_0024_003C_003E8__locals1.serverFolderName))
									{
										num6 = 30;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
										{
											num6 = 51;
										}
										break;
									}
									obj = Qv8oHUE1ge6GYP1mkdeN(CS_0024_003C_003E8__locals1.serverFolderName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A2B7EE));
									goto IL_282c;
								case 49:
									moduleManager.SaveStoreComponent(manifest, CS_0024_003C_003E8__locals1.signatures, CS_0024_003C_003E8__locals1.zipFileName, StoreComponentStatus.Allowed, unpackedPackagesFolder);
									num6 = 65;
									break;
								case 43:
									CS_0024_003C_003E8__locals1.signatures = null;
									num6 = 33;
									break;
								case 46:
									if (step == ImportStep.Prepare)
									{
										num6 = 88;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
										{
											num6 = 21;
										}
										break;
									}
									goto case 69;
								case 34:
									if (step != 0)
									{
										num6 = 22;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
										{
											num6 = 27;
										}
										break;
									}
									goto case 95;
								case 57:
									throw new InvalidOperationException(SR.T((string)NUn1HRE1nboQISCQgj1B(--1360331293 ^ 0x51116183)));
								case 8:
									importExtensions.ForEach(delegate(IConfigImportExtension ext)
									{
										int num26 = 1;
										int num27 = num26;
										while (true)
										{
											switch (num27)
											{
											default:
												return;
											case 1:
												nKImFUEpo4E81h5qigGH(ext, new ImportSuccessfullParameters(messages, systemMessages, importSettings));
												num27 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
												{
													num27 = 0;
												}
												break;
											case 0:
												return;
											}
										}
									});
									num6 = 57;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
									{
										num6 = 60;
									}
									break;
								case 81:
									xmlReader = GetXmlReader(importSettings);
									num6 = 96;
									break;
								case 62:
									AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-889460160 ^ -889222766)), endProcess: false));
									num6 = 79;
									break;
								case 36:
									throw new InvalidOperationException((string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(0xE1229CF ^ 0xE164D33)));
								case 44:
									cancellationToken.ThrowIfCancellationRequested();
									num6 = 53;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
									{
										num6 = 6;
									}
									break;
								case 9:
									AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-87337865 ^ -87083373)), endProcess: false));
									num6 = 7;
									break;
								case 51:
									obj = null;
									goto IL_282c;
								case 42:
									AddMessage(new DeployLogMessage(DeployLogMessageType.Info, SR.T((string)NUn1HRE1nboQISCQgj1B(0x7247028A ^ 0x724361EA), IqRtZhE17pn25i9D9fqG(manifest), i9i9roE1xW3lOWfH6muS(manifest)), endProcess: false));
									num6 = 12;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
									{
										num6 = 77;
									}
									break;
								case 95:
									ImportLog.Info(NUn1HRE1nboQISCQgj1B(-1867198571 ^ -1867469519));
									num6 = 9;
									break;
								case 20:
								case 21:
								case 90:
								case 99:
									Djk57qE1lBxyJ81fVK0Z(packageService);
									num6 = 68;
									break;
								case 96:
									try
									{
										CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass67_3();
										int num9 = 44;
										while (true)
										{
											int num10;
											switch (num9)
											{
											case 76:
											case 85:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-542721635 ^ -542976133)), endProcess: false));
												num9 = 31;
												break;
											case 96:
												ImportLog.Warn(Ylt4G6E13n0iSBWhEp4K(NUn1HRE1nboQISCQgj1B(-475857671 ^ -475622521), pKSQRRENZbYQwtPx8LrK(packetError)));
												num9 = 38;
												break;
											case 24:
												if (!MoveToConfigurationData(xmlReader))
												{
													num9 = 7;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
													{
														num9 = 1;
													}
													break;
												}
												goto case 99;
											case 110:
												return;
											case 12:
											case 45:
												if (u8mPV3ENBOqyjN9FPD2H(xmlReader) == XmlNodeType.EndElement)
												{
													num9 = 27;
													break;
												}
												goto case 79;
											case 28:
												dyhjy5EN8VoqkehOYLQ1(action);
												num9 = 94;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
												{
													num9 = 29;
												}
												break;
											case 63:
											case 70:
												CS_0024_003C_003E8__locals0.preReadPacketsParams = new PreReadPacketsParameters(messages, systemMessages, CS_0024_003C_003E8__locals1.serverFolderName, serviceData, manifest, h9ykD5E1Px7Gft1hHX4m(importSettings));
												num10 = 64;
												goto IL_06da;
											case 79:
												text5 = (string)bvLSv2ENhtbgyyFsrZvn(xmlReader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334848397));
												num9 = 98;
												break;
											case 26:
												Y2royjE1plb4gjxp3MMP(ImportLog, NUn1HRE1nboQISCQgj1B(0x5F3078B6 ^ 0x5F341694));
												num9 = 89;
												break;
											case 43:
											case 93:
												qPNZx7ENFAG8vQyPD8WG(xmlReader);
												num9 = 101;
												break;
											case 65:
												if (step == ImportStep.Prepare)
												{
													num9 = 18;
													break;
												}
												goto case 34;
											case 34:
												if (!xfWXwXENbk9MHTq6ErLw(attribute, NUn1HRE1nboQISCQgj1B(0x7459E02 ^ 0x741C0E4)))
												{
													num9 = 72;
													break;
												}
												goto case 20;
											case 54:
												if (!xZ06MUENQJVAH6dS5LZK(zmwHRHE1UslqZB4OAIKq(xmlReader), NUn1HRE1nboQISCQgj1B(-87337865 ^ -87082967)))
												{
													num9 = 43;
													break;
												}
												goto case 78;
											case 21:
											case 53:
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												num9 = 35;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
												{
													num9 = 66;
												}
												break;
											case 59:
												return;
											case 58:
												if (!RmoLaAE1sJvsY73orXow(xmlReader.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD39B112)))
												{
													num9 = 108;
													break;
												}
												goto case 30;
											case 80:
												CS_0024_003C_003E8__locals0.postReadPacketsParams = new PostReadPacketsParameters(messages, systemMessages, CS_0024_003C_003E8__locals1.serverFolderName, serviceData, manifest, importSettings.ImportStep, headers, treeUid);
												num9 = 41;
												break;
											case 89:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, (string)U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FE6E9A)), endProcess: true, endStage: true, needRestart));
												num9 = 5;
												break;
											case 33:
												if (step != 0)
												{
													num9 = 9;
													break;
												}
												goto case 63;
											case 17:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Info, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1A8F68)), endProcess: true, endStage: true));
												num9 = 59;
												break;
											case 102:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Empty, (string)XMrkgmENfovAAtbNS0Bw("", Array.Empty<object>()), endProcess: false));
												num9 = 63;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
												{
													num9 = 8;
												}
												break;
											case 99:
												xmlReader.Read();
												num9 = 32;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
												{
													num9 = 105;
												}
												break;
											case 50:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Info, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD139AE), text4), endProcess: false));
												num9 = 68;
												break;
											case 6:
											case 101:
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												num9 = 12;
												break;
											case 81:
												try
												{
													ImportLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12407016) + string.Join((string)NUn1HRE1nboQISCQgj1B(0x20261A4F ^ 0x2026164D), headers));
													int num11 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
													{
														num11 = 0;
													}
													while (true)
													{
														switch (num11)
														{
														case 3:
															needRestart = modelManager.Publish("", (long[])AQbKojENvtPqGhFGxYCO(headers)).NeedRestart;
															num11 = 5;
															continue;
														default:
															AddMessage(new DeployLogMessage(DeployLogMessageType.Empty, string.Empty, endProcess: false));
															num11 = 2;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
															{
																num11 = 1;
															}
															continue;
														case 5:
															configImportActionExtensions.ForEach(delegate(IConfigImportActionExtension ext)
															{
																int num34 = 1;
																int num35 = num34;
																while (true)
																{
																	switch (num35)
																	{
																	default:
																		return;
																	case 1:
																		_003C_003Ec__DisplayClass67_0.lnQdZv8nujbBarKQn6rQ(ext, new PostPublishParameters(CS_0024_003C_003E8__locals1._003C_003E4__this.messages, CS_0024_003C_003E8__locals1._003C_003E4__this.systemMessages, CS_0024_003C_003E8__locals1.serverFolderName, CS_0024_003C_003E8__locals1._003C_003E4__this.serviceData, CS_0024_003C_003E8__locals1._003C_003E4__this.importSettings));
																		num35 = 0;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
																		{
																			num35 = 0;
																		}
																		break;
																	case 0:
																		return;
																	}
																}
															});
															num11 = 4;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
															{
																num11 = 3;
															}
															continue;
														case 1:
															configImportActionExtensions.ForEach(delegate(IConfigImportActionExtension ext)
															{
																int num36 = 1;
																int num37 = num36;
																while (true)
																{
																	switch (num37)
																	{
																	default:
																		return;
																	case 0:
																		return;
																	case 1:
																		popfIhEpWM61FuX4KaTF(ext, new PrePublishParameters(messages, systemMessages, serviceData, importSettings));
																		num37 = 0;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
																		{
																			num37 = 0;
																		}
																		break;
																	}
																}
															});
															num11 = 3;
															continue;
														case 2:
															AddMessage(new DeployLogMessage(DeployLogMessageType.Warn, SR.T((string)NUn1HRE1nboQISCQgj1B(-787452571 ^ -787218039)), endProcess: false));
															num11 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
															{
																num11 = 0;
															}
															continue;
														case 4:
															break;
														}
														break;
													}
												}
												catch (Exception ex)
												{
													int num12 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
													{
														num12 = 1;
													}
													while (true)
													{
														switch (num12)
														{
														case 2:
															mpPoVWE1OsoeCdWeb6OT(ImportLog, NUn1HRE1nboQISCQgj1B(0x53CACA3 ^ 0x538C137), ex);
															num12 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
															{
																num12 = 0;
															}
															break;
														default:
															AddMessage(new DeployLogMessage(DeployLogMessageType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420504932)), endProcess: true));
															num12 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
															{
																num12 = 1;
															}
															break;
														case 1:
															return;
														}
													}
												}
												goto case 26;
											case 107:
												xmlReader.MoveToContent();
												num10 = 23;
												goto IL_06da;
											case 67:
												text6 = (string)zmwHRHE1UslqZB4OAIKq(xmlReader);
												num9 = 73;
												break;
											case 74:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Empty, (string)XMrkgmENfovAAtbNS0Bw("", Array.Empty<object>()), endProcess: false));
												num9 = 70;
												break;
											case 84:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string)U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A655994)), endProcess: false));
												num9 = 74;
												break;
											case 83:
												return;
											case 55:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Error, (string)U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886885081)), endProcess: true));
												num9 = 27;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
												{
													num9 = 104;
												}
												break;
											case 90:
												qlGUxwENGSOyZXd6OKWI(xmlReader);
												num9 = 24;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
												{
													num9 = 14;
												}
												break;
											case 9:
												if (step == ImportStep.ImportMetadata)
												{
													num9 = 35;
													break;
												}
												goto case 77;
											case 56:
												if (step == ImportStep.ImportMetadata)
												{
													num9 = 60;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
													{
														num9 = 37;
													}
													break;
												}
												goto case 28;
											case 8:
												ImportLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979487579));
												num9 = 10;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
												{
													num9 = 0;
												}
												break;
											case 16:
											case 37:
												qlGUxwENGSOyZXd6OKWI(xmlReader);
												num9 = 107;
												break;
											case 13:
												messages.Add(new DeployLogMessage(DeployLogMessageType.Error, (string)U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1633AF67)), endProcess: true));
												num9 = 83;
												break;
											case 68:
												ImportLog.Info(Ylt4G6E13n0iSBWhEp4K(NUn1HRE1nboQISCQgj1B(0x76DD48E ^ 0x769BEDA), text4));
												num9 = 52;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
												{
													num9 = 39;
												}
												break;
											case 20:
												if (xfWXwXENbk9MHTq6ErLw(attribute, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35741917)))
												{
													num9 = 36;
													break;
												}
												goto case 1;
											case 75:
												list2 = new List<ReadPacketResult>();
												num9 = 103;
												break;
											case 108:
												if (step == ImportStep.ImportData)
												{
													num9 = 63;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
													{
														num9 = 86;
													}
													break;
												}
												goto case 43;
											case 73:
												if (!(text6 == (string)NUn1HRE1nboQISCQgj1B(-1870892489 ^ -1871172277)))
												{
													num10 = 61;
													goto IL_06da;
												}
												goto case 109;
											case 42:
											case 52:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Empty, "", endProcess: false));
												num9 = 106;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
												{
													num9 = 99;
												}
												break;
											case 36:
												if (step != 0)
												{
													num9 = 48;
													break;
												}
												goto case 88;
											case 92:
												importExtensions.ForEach(delegate(IConfigImportExtension ext)
												{
													int num32 = 1;
													int num33 = num32;
													while (true)
													{
														switch (num33)
														{
														default:
															return;
														case 1:
															nKImFUEpo4E81h5qigGH(ext, new ImportSuccessfullParameters(messages, systemMessages, importSettings));
															num33 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
															{
																num33 = 0;
															}
															break;
														case 0:
															return;
														}
													}
												});
												num9 = 8;
												break;
											case 32:
												cancellationToken.ThrowIfCancellationRequested();
												num9 = 30;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
												{
													num9 = 56;
												}
												break;
											case 95:
												list2.Add(ReadPacket(xmlReader, text5, CS_0024_003C_003E8__locals1.serverFolderName));
												num9 = 40;
												break;
											case 69:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Info, SR.T((string)NUn1HRE1nboQISCQgj1B(0x307E9FD1 ^ 0x307AF0F5), pKSQRRENZbYQwtPx8LrK(packetError)), endProcess: true));
												num9 = 67;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
												{
													num9 = 96;
												}
												break;
											case 4:
												ImportLog.Info(string.Format((string)NUn1HRE1nboQISCQgj1B(-1108654032 ^ -1108402018), NUn1HRE1nboQISCQgj1B(0x63ABA4E8 ^ 0x63AFFA18)));
												num9 = 20;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
												{
													num9 = 34;
												}
												break;
											case 94:
												if (pKSQRRENZbYQwtPx8LrK(packetError) != 0)
												{
													num9 = 85;
													break;
												}
												goto case 92;
											case 23:
												ReadServiceData(xmlReader);
												num9 = 33;
												break;
											case 103:
												if (WaSmnAE1cpYU3LOfjiR7(xmlReader))
												{
													num9 = 87;
													break;
												}
												goto case 47;
											case 106:
												xmlReader.MoveToElement();
												num9 = 90;
												break;
											case 40:
												qlGUxwENGSOyZXd6OKWI(xmlReader);
												num9 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
												{
													num9 = 6;
												}
												break;
											case 2:
											case 61:
												qPNZx7ENFAG8vQyPD8WG(xmlReader);
												num9 = 21;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
												{
													num9 = 13;
												}
												break;
											case 77:
												dTs50nENEjlYgpFBoeKx(xmlReader, NUn1HRE1nboQISCQgj1B(0x3A5D5EF ^ 0x3A57967));
												num9 = 84;
												break;
											case 47:
												qlGUxwENGSOyZXd6OKWI(xmlReader);
												num9 = 69;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
												{
													num9 = 71;
												}
												break;
											case 109:
												if (ReadImportants(xmlReader))
												{
													num9 = 25;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
													{
														num9 = 53;
													}
													break;
												}
												goto case 13;
											case 98:
												if (step != ImportStep.ImportData)
												{
													num9 = 58;
													break;
												}
												goto case 108;
											case 91:
												if (RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(xmlReader), NUn1HRE1nboQISCQgj1B(0x2A7797B7 ^ 0x2A73FC9F)))
												{
													num9 = 51;
													break;
												}
												goto case 23;
											case 71:
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												num9 = 17;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
												{
													num9 = 45;
												}
												break;
											case 3:
												try
												{
													list2.ForEach(delegate(ReadPacketResult r)
													{
														_003C_003Ec.xggMeu8n7D0AUJd2hH2t(r);
													});
													int num13 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
													{
														num13 = 0;
													}
													switch (num13)
													{
													case 0:
														break;
													}
												}
												finally
												{
													int num14;
													if (metadataServiceContext == null)
													{
														num14 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
														{
															num14 = 0;
														}
														goto IL_14f3;
													}
													goto IL_1518;
													IL_1518:
													GH8iJvE1KjBtdq7Mib6q(metadataServiceContext);
													num14 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
													{
														num14 = 0;
													}
													goto IL_14f3;
													IL_14f3:
													switch (num14)
													{
													default:
														goto end_IL_14ce;
													case 1:
														goto end_IL_14ce;
													case 2:
														break;
													case 0:
														goto end_IL_14ce;
													}
													goto IL_1518;
													end_IL_14ce:;
												}
												goto case 80;
											case 46:
												if (!xmlReader.MoveToAttribute((string)NUn1HRE1nboQISCQgj1B(0x5A4C7B29 ^ 0x5A4812D9)))
												{
													num9 = 42;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
													{
														num9 = 21;
													}
													break;
												}
												goto case 82;
											case 5:
												return;
											case 39:
												ImportLog.Warn(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7B5B6C), attribute, NUn1HRE1nboQISCQgj1B(0x53FA00CE ^ 0x53FE5E3E)));
												num9 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
												{
													num9 = 1;
												}
												break;
											case 105:
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												num9 = 91;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
												{
													num9 = 72;
												}
												break;
											case 100:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-541731959 ^ -542001049)), endProcess: false));
												num9 = 102;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
												{
													num9 = 19;
												}
												break;
											case 57:
											case 66:
												if (u8mPV3ENBOqyjN9FPD2H(xmlReader) == XmlNodeType.EndElement)
												{
													num9 = 37;
													break;
												}
												goto case 67;
											case 1:
											case 48:
											case 72:
												if (step == ImportStep.Prepare)
												{
													num9 = 46;
													break;
												}
												goto case 42;
											case 49:
												attribute = xmlReader.GetAttribute((string)NUn1HRE1nboQISCQgj1B(-1751176224 ^ -1751432302));
												num9 = 42;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
												{
													num9 = 65;
												}
												break;
											default:
												cancellationToken = parameters.CancellationToken;
												num10 = 32;
												goto IL_06da;
											case 78:
												if (X15jF8ENCq9JFFU7mBYM(packetVersionService, zmwHRHE1UslqZB4OAIKq(xmlReader), text5))
												{
													num9 = 30;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
													{
														num9 = 13;
													}
													break;
												}
												goto case 43;
											case 86:
												if (RmoLaAE1sJvsY73orXow(xmlReader.Name, NUn1HRE1nboQISCQgj1B(0x12441CA4 ^ 0x124042C8)))
												{
													num9 = 97;
													break;
												}
												goto case 54;
											case 19:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(0x463A0F3C ^ 0x463E634C)), endProcess: false));
												num9 = 14;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
												{
													num9 = 4;
												}
												break;
											case 44:
												if (!CheckImportFileVersion(xmlReader))
												{
													num9 = 55;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
													{
														num9 = 22;
													}
													break;
												}
												goto case 62;
											case 7:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Error, (string)U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751432894)), endProcess: true));
												num10 = 99;
												goto IL_06da;
											case 14:
												needRestart = true;
												num9 = 81;
												break;
											case 10:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Info, SR.T((string)NUn1HRE1nboQISCQgj1B(0x3B36AB09 ^ 0x3B32C5EF)), endProcess: true));
												num10 = 110;
												goto IL_06da;
											case 60:
												if (headers.Any())
												{
													num9 = 19;
													break;
												}
												goto case 17;
											case 18:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Info, SR.T((string)NUn1HRE1nboQISCQgj1B(-16752921 ^ -16501151), NUn1HRE1nboQISCQgj1B(-957824448 ^ -957571920), ExportImportVersion.VersionDescription), endProcess: false));
												num9 = 4;
												break;
											case 82:
												text4 = (string)bvLSv2ENhtbgyyFsrZvn(xmlReader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BFDCCE));
												num9 = 50;
												break;
											case 64:
												importExtensions.Each(delegate(IConfigImportExtension e)
												{
													int num38 = 1;
													int num39 = num38;
													while (true)
													{
														switch (num39)
														{
														default:
															return;
														case 0:
															return;
														case 1:
															_003C_003Ec__DisplayClass67_3.e0l4Wo8nekjwFjnE1d4F(e, CS_0024_003C_003E8__locals0.preReadPacketsParams);
															num39 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
															{
																num39 = 0;
															}
															break;
														}
													}
												});
												num9 = 75;
												break;
											case 11:
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												num9 = 49;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
												{
													num9 = 57;
												}
												break;
											case 104:
												xQ7nFOENWZ1yyIBkqRi4(ImportLog, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957569560), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A18B15)));
												num9 = 29;
												break;
											case 29:
												return;
											case 51:
												if (WaSmnAE1cpYU3LOfjiR7(xmlReader))
												{
													num9 = 16;
													break;
												}
												goto case 25;
											case 88:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Info, SR.T((string)NUn1HRE1nboQISCQgj1B(0x12441CA4 ^ 0x12407442), attribute, NUn1HRE1nboQISCQgj1B(-1751176224 ^ -1751419632)), endProcess: false));
												num9 = 39;
												break;
											case 27:
											case 87:
												if (step == ImportStep.ImportMetadata)
												{
													num9 = 22;
													break;
												}
												goto case 80;
											case 30:
											case 97:
												qlGUxwENGSOyZXd6OKWI(xmlReader);
												num9 = 95;
												break;
											case 62:
												if (hKO1JNENoXjLkkOJaRkc(xmlReader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521505742)))
												{
													num9 = 49;
													break;
												}
												goto case 1;
											case 41:
												importExtensions.Each(delegate(IConfigImportExtension e)
												{
													int num40 = 1;
													int num41 = num40;
													while (true)
													{
														switch (num41)
														{
														default:
															return;
														case 0:
															return;
														case 1:
															e.OnPostReadPackets(CS_0024_003C_003E8__locals0.postReadPacketsParams);
															num41 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
															{
																num41 = 0;
															}
															break;
														}
													}
												});
												num9 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
												{
													num9 = 0;
												}
												break;
											case 35:
												dTs50nENEjlYgpFBoeKx(xmlReader, NUn1HRE1nboQISCQgj1B(-867826612 ^ -868061290));
												num9 = 59;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
												{
													num9 = 100;
												}
												break;
											case 31:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Summary, SR.T((string)NUn1HRE1nboQISCQgj1B(-882126494 ^ -881869242), pKSQRRENZbYQwtPx8LrK(packetError)), endProcess: false));
												num9 = 65;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
												{
													num9 = 69;
												}
												break;
											case 25:
												qlGUxwENGSOyZXd6OKWI(xmlReader);
												num9 = 11;
												break;
											case 22:
												if (list2.Any((ReadPacketResult r) => r.Metadatas.Any()))
												{
													num9 = 15;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
													{
														num9 = 6;
													}
													break;
												}
												goto case 80;
											case 15:
												metadataServiceContext = MetadataServiceContext.Extend(list2.SelectMany((ReadPacketResult r) => r.Metadatas));
												num9 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
												{
													num9 = 3;
												}
												break;
											case 38:
												return;
												IL_06da:
												num9 = num10;
												break;
											}
										}
									}
									finally
									{
										int num15;
										if (xmlReader == null)
										{
											num15 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
											{
												num15 = 1;
											}
											goto IL_1bb2;
										}
										goto IL_1bc8;
										IL_1bc8:
										((IDisposable)xmlReader).Dispose();
										num15 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
										{
											num15 = 0;
										}
										goto IL_1bb2;
										IL_1bb2:
										switch (num15)
										{
										default:
											goto end_IL_1b8d;
										case 2:
											break;
										case 1:
											goto end_IL_1b8d;
										case 0:
											goto end_IL_1b8d;
										}
										goto IL_1bc8;
										end_IL_1b8d:;
									}
								case 14:
									return;
								case 75:
									if (manifest != null)
									{
										num6 = 16;
										break;
									}
									goto case 77;
								case 52:
									if (list.Count > 0)
									{
										num6 = 87;
										break;
									}
									goto case 35;
								case 2:
									if (manifest == null)
									{
										num6 = 58;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
										{
											num6 = 90;
										}
										break;
									}
									goto case 97;
								case 74:
									text2 = (string)Y12gHtE1HlUGeXH6LxZY(exportImportFileManager, O2oXytE162AAMiZL2QmT(configImportSettings));
									num6 = 94;
									break;
								case 16:
									if (step == ImportStep.Prepare)
									{
										num6 = 42;
										break;
									}
									goto case 77;
								case 87:
									Y2royjE1plb4gjxp3MMP(ImportLog, UODdpwE15Qf06297AiTd(NUn1HRE1nboQISCQgj1B(0x3CE17B75 ^ 0x3CE51E87), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852834298), packagesOperations)));
									num6 = 31;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num6 = 12;
									}
									break;
								case 50:
									manifest = ElmaStoreComponentsBuilder.Read(CS_0024_003C_003E8__locals1.zipFileName, out CS_0024_003C_003E8__locals1.manifestImage);
									num6 = 75;
									break;
								case 58:
									((ILogger)MlNMGBE1y8ECm86WgVkD()).Error(string.Concat(NUn1HRE1nboQISCQgj1B(-576149596 ^ -575880430), storeComponentUnpackStatus));
									num6 = 36;
									break;
								case 94:
									AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(0x53CB464B ^ 0x53CF2557)), endProcess: false));
									num6 = 14;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
									{
										num6 = 25;
									}
									break;
								case 15:
									_003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_1();
									num6 = 2;
									break;
								case 70:
									text = null;
									num6 = 37;
									break;
								case 97:
									if (manifest != null)
									{
										num6 = 4;
										break;
									}
									goto case 20;
								case 92:
									if (!jgeG7iE1AJJVuAtTxp9u(CS_0024_003C_003E8__locals1.zipFileName))
									{
										num6 = 38;
										break;
									}
									goto case 74;
								case 37:
									CS_0024_003C_003E8__locals1.serverFolderName = exportImportFileManager.CreateFolderName((string)O2oXytE162AAMiZL2QmT(configImportSettings));
									num6 = 56;
									break;
								case 103:
									try
									{
										int num16;
										if (xmlTextReader == null)
										{
											num16 = 4;
											goto IL_1e4a;
										}
										goto IL_1ed0;
										IL_1ef6:
										if (!RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(xmlTextReader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4ED8DA3E)))
										{
											int num17 = 3;
											num16 = num17;
											goto IL_1e4a;
										}
										goto IL_1e7c;
										IL_1ed0:
										if (!aHWlqJE1LYQIoxkGNkvB(xmlTextReader))
										{
											num16 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
											{
												num16 = 0;
											}
											goto IL_1e4a;
										}
										goto IL_1ef6;
										IL_1e4a:
										while (true)
										{
											switch (num16)
											{
											case 9:
												goto IL_1e7c;
											case 3:
												break;
											case 0:
												break;
											case 5:
												goto IL_1ed0;
											case 1:
												goto IL_1ef6;
											case 8:
												xmlTextReader.Read();
												num16 = 7;
												continue;
											case 7:
												WFMAx6E1zDIJWZIkcCR2(xmlTextReader);
												num16 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
												{
													num16 = 2;
												}
												continue;
											case 2:
												try
												{
													while (true)
													{
														IL_2005:
														int num18;
														if (u8mPV3ENBOqyjN9FPD2H(xmlTextReader) == XmlNodeType.EndElement)
														{
															num18 = 2;
															goto IL_1f83;
														}
														goto IL_2058;
														IL_1fb1:
														qPNZx7ENFAG8vQyPD8WG(xmlTextReader);
														num18 = 7;
														goto IL_1f83;
														IL_2058:
														if (xmlTextReader.IsStartElement())
														{
															num18 = 3;
															goto IL_1f83;
														}
														goto IL_1fb1;
														IL_1f83:
														while (true)
														{
															switch (num18)
															{
															case 6:
															case 8:
																break;
															case 5:
																ReadFilesSection(xmlTextReader);
																num18 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
																{
																	num18 = 0;
																}
																continue;
															default:
																xmlTextReader.MoveToContent();
																num18 = 4;
																continue;
															case 4:
																goto IL_2005;
															case 3:
																if (!RmoLaAE1sJvsY73orXow(xmlTextReader.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811788184)))
																{
																	num18 = 8;
																	continue;
																}
																goto case 5;
															case 1:
																goto IL_2058;
															case 2:
																goto end_IL_2005;
															}
															break;
														}
														goto IL_1fb1;
														continue;
														end_IL_2005:
														break;
													}
												}
												catch (Exception)
												{
													int num19 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
													{
														num19 = 0;
													}
													switch (num19)
													{
													case 0:
														break;
													}
												}
												break;
											case 4:
												break;
											case 6:
												break;
											}
											break;
										}
										goto end_IL_1e35;
										IL_1e7c:
										if (!WaSmnAE1cpYU3LOfjiR7(xmlTextReader))
										{
											num16 = 8;
											goto IL_1e4a;
										}
										end_IL_1e35:;
									}
									finally
									{
										int num20;
										if (xmlTextReader == null)
										{
											num20 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
											{
												num20 = 1;
											}
											goto IL_20f8;
										}
										goto IL_212d;
										IL_212d:
										GH8iJvE1KjBtdq7Mib6q(xmlTextReader);
										num20 = 2;
										goto IL_20f8;
										IL_20f8:
										switch (num20)
										{
										case 1:
											goto end_IL_20d3;
										case 2:
											goto end_IL_20d3;
										}
										goto IL_212d;
										end_IL_20d3:;
									}
									goto case 3;
								case 93:
									throw new InvalidOperationException((string)U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281605844)));
								case 72:
								case 102:
									if (storeComponentUnpackStatus != StoreComponentUnpackStatus.Unsigned)
									{
										num6 = 89;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
										{
											num6 = 66;
										}
										break;
									}
									goto case 6;
								case 66:
									cancellationToken.ThrowIfCancellationRequested();
									num6 = 55;
									break;
								case 76:
									metadataNotIsUnique = new HashSet<Guid>();
									num6 = 34;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
									{
										num6 = 18;
									}
									break;
								case 69:
								case 78:
									cancellationToken = hb8IciE1dPjQVL0HJ6Vx(parameters);
									num6 = 37;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
									{
										num6 = 45;
									}
									break;
								case 35:
								case 40:
									AddMessage(new DeployLogMessage(DeployLogMessageType.Info, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146240179)), endProcess: true, endStage: true));
									num6 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
									{
										num6 = 14;
									}
									break;
								case 17:
									throw new InvalidOperationException((string)U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218209130)));
								case 26:
								case 79:
									LDpLgeE1J1pKeCQ2WwM1(exportImportFileManager, configImportSettings.FileName, NUn1HRE1nboQISCQgj1B(0x4EA5403C ^ 0x4EA4E784), NUn1HRE1nboQISCQgj1B(-1867198571 ^ -1867468905));
									num6 = 19;
									break;
								case 45:
									cancellationToken.ThrowIfCancellationRequested();
									num6 = 98;
									break;
								case 28:
									return;
								case 54:
									wvWV5EE1m0sGgDNVcSf3(zipService, text2, CS_0024_003C_003E8__locals1.serverFolderName);
									num6 = 26;
									break;
								case 89:
									if (storeComponentUnpackStatus == StoreComponentUnpackStatus.FreeSigned)
									{
										num6 = 6;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
										{
											num6 = 1;
										}
										break;
									}
									goto case 18;
								case 24:
									if (text == null)
									{
										num6 = 101;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
										{
											num6 = 59;
										}
										break;
									}
									goto case 5;
								case 18:
									if (storeComponentUnpackStatus != StoreComponentUnpackStatus.WrongSignatures)
									{
										((ILogger)MlNMGBE1y8ECm86WgVkD()).Error(CJiYGKE1M9HgOO5j0vIa(NUn1HRE1nboQISCQgj1B(-70037984 ^ -69784938), storeComponentUnpackStatus));
										num6 = 17;
										break;
									}
									num8 = 58;
									goto IL_0107;
								case 59:
									cancellationToken = parameters.CancellationToken;
									num6 = 66;
									break;
								case 83:
									FillImportData();
									num6 = 76;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
									{
										num6 = 58;
									}
									break;
								case 53:
									if (!XmlDataExists(importSettings))
									{
										num6 = 22;
										break;
									}
									goto case 81;
								case 65:
									if (importSettings.TestResult != null)
									{
										num6 = 41;
										break;
									}
									goto case 35;
								case 77:
									switch (storeComponentUnpackStatus)
									{
									default:
										num6 = 72;
										goto end_IL_010b;
									case StoreComponentUnpackStatus.Success:
										break;
									case StoreComponentUnpackStatus.ActivationError:
										num6 = 57;
										goto end_IL_010b;
									}
									goto case 62;
								case 4:
									if (!manifest.Packages.Any())
									{
										num6 = 21;
										break;
									}
									goto default;
								case 55:
									if ((configImportSettings = importSettings as IConfigImportSettings) == null)
									{
										num8 = 3;
										goto IL_0107;
									}
									goto case 70;
								case 61:
									xmlTextReader = new XmlTextReader(text);
									num6 = 103;
									break;
								case 84:
									CS_0024_003C_003E8__locals1._003C_003E4__this = this;
									num6 = 33;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
									{
										num6 = 82;
									}
									break;
								case 5:
									if (jgeG7iE1AJJVuAtTxp9u(text))
									{
										num6 = 61;
										break;
									}
									goto case 3;
								case 68:
									_003C_003Ec__DisplayClass67_.packagingComponent = packageService.GetComponent();
									num6 = 29;
									break;
								case 7:
								case 27:
									CS_0024_003C_003E8__locals1.zipFileName = null;
									num6 = 43;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
									{
										num6 = 3;
									}
									break;
								case 80:
									if (CFAxwhE10s00iyrA5l0u(manifest) == ElmaStoreComponentActivationType.Paid)
									{
										num6 = 64;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
										{
											num6 = 56;
										}
										break;
									}
									goto IL_2781;
								case 11:
									CS_0024_003C_003E8__locals1.manifestImage = null;
									num6 = 59;
									break;
								default:
									if (configImportSettings.FakeManifest == null)
									{
										num6 = 93;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
										{
											num6 = 99;
										}
										break;
									}
									goto case 48;
								case 63:
									messages.Add(new DeployLogMessage(DeployLogMessageType.Info, SR.T((string)NUn1HRE1nboQISCQgj1B(-606654180 ^ -606904326)), endProcess: true));
									num6 = 100;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
									{
										num6 = 47;
									}
									break;
								case 91:
									jgeG7iE1AJJVuAtTxp9u(text3);
									num6 = 13;
									break;
								case 1:
								case 13:
									if (manifest != null)
									{
										num8 = 46;
										goto IL_0107;
									}
									goto case 69;
								case 12:
									if (CS_0024_003C_003E8__locals1.zipFileName != null)
									{
										num8 = 47;
										goto IL_0107;
									}
									goto case 86;
								case 30:
									return;
								case 86:
									AddMessage(new DeployLogMessage(DeployLogMessageType.Empty, string.Format(""), endProcess: true, endStage: true));
									num8 = 30;
									goto IL_0107;
								case 19:
									text = (string)LDpLgeE1J1pKeCQ2WwM1(exportImportFileManager, configImportSettings.FileName, NUn1HRE1nboQISCQgj1B(0x3B36AB09 ^ 0x3B32F4FD), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548FCE88));
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
									{
										num6 = 1;
									}
									break;
								case 32:
									importExtensions.Each(delegate(IConfigImportExtension e)
									{
										int num42 = 1;
										int num43 = num42;
										while (true)
										{
											switch (num43)
											{
											default:
												return;
											case 1:
												tIfLGbEpFRVa2bFp3Zij(e, new PreStartImportParameters(messages, systemMessages, importSettings));
												num43 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
												{
													num43 = 0;
												}
												break;
											case 0:
												return;
											}
										}
									});
									num8 = 11;
									goto IL_0107;
								case 33:
									CS_0024_003C_003E8__locals1.serverFolderName = "";
									num6 = 20;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
									{
										num6 = 32;
									}
									break;
								case 23:
									return;
								case 56:
									CS_0024_003C_003E8__locals1.zipFileName = (string)Y12gHtE1HlUGeXH6LxZY(exportImportFileManager, O2oXytE162AAMiZL2QmT(configImportSettings));
									num6 = 92;
									break;
								case 98:
									if (step == ImportStep.Prepare)
									{
										num8 = 12;
										goto IL_0107;
									}
									goto case 24;
								case 6:
									if (manifest != null)
									{
										num8 = 80;
										goto IL_0107;
									}
									goto IL_2781;
								case 64:
									throw new InvalidOperationException(SR.T((string)NUn1HRE1nboQISCQgj1B(-521266112 ^ -521504696)));
								case 88:
								{
									List<TestImportMessages> tagMessages;
									bool num7 = CheckManifestTag(out tagMessages);
									tagMessages?.ForEach(delegate(TestImportMessages m)
									{
										int num46 = 1;
										int num47 = num46;
										while (true)
										{
											switch (num47)
											{
											default:
												return;
											case 0:
												return;
											case 1:
												AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string)Od4VdXE1NZR6dcJmVHKO(m), endProcess: true));
												num47 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
												{
													num47 = 0;
												}
												break;
											}
										}
									});
									if (!num7)
									{
										return;
									}
									num6 = 69;
									break;
								}
								case 41:
									if (!importSettings.TestResult.Any((TestImportMessages t) => _003C_003Ec.mJ2Ky68npRyYQ6FnBQOg(t)))
									{
										num6 = 35;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
										{
											num6 = 13;
										}
										break;
									}
									goto case 39;
								case 39:
									list = manifest.Packages.Where(_003C_003Ec__DisplayClass67_._003CRunImport_003Eb__6).Select(delegate(PackageManifest p)
									{
										PackageInstallOperationInfo packageInstallOperationInfo = new PackageInstallOperationInfo();
										_003C_003Ec.gAx15A8naZqvMwxrcCFc(packageInstallOperationInfo, p.Id);
										_003C_003Ec.QXkgLp8ntvfbbD7sVkTZ(packageInstallOperationInfo, _003C_003Ec.g5fpXx8nDQNtmllOA4mv(p));
										_003C_003Ec.zUlkSP8nwdncnhwL5yBb(packageInstallOperationInfo, PackageOperationType.Install);
										return packageInstallOperationInfo;
									}).ToList();
									num6 = 52;
									break;
								case 31:
								{
									DeployLogMessage deployLogMessage = new DeployLogMessage(DeployLogMessageType.Warn, SR.T((string)NUn1HRE1nboQISCQgj1B(-643786247 ^ -643498029), string.Join((string)NUn1HRE1nboQISCQgj1B(0xE1229CF ^ 0xE1225CD), list.Select((PackageInstallOperationInfo p) => (string)_003C_003Ec.AHyCwq8nAZCDsRlAcNoC(new string[5]
									{
										z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487381192),
										(string)_003C_003Ec.Ef3V7e8n4O6N39Xym68c(p),
										z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70021585),
										(string)_003C_003Ec.unBkTP8n6eikPopIbMVT(p),
										(string)_003C_003Ec.kAx2j18nHeh7IC2RH0GP(-1824388195 ^ -1824385341)
									})))), endProcess: true, endStage: true, needRestart: true);
									ay0gPXE1YTK4wbO5QyYJ(deployLogMessage, new PackageInstallInfo
									{
										Operations = list,
										UpdatingUid = dXVsmmE1jF2iJ9LaQlCe()
									});
									AddMessage(deployLogMessage);
									num6 = 23;
									break;
								}
								case 100:
									return;
									IL_282c:
									unpackedPackagesFolder = (string)obj;
									num6 = 49;
									break;
									IL_2781:
									AddMessage(new DeployLogMessage(DeployLogMessageType.Info, (string)((storeComponentUnpackStatus == StoreComponentUnpackStatus.Unsigned) ? U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-629844702 ^ -630116010)) : U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-1978478350 ^ -1978223840))), endProcess: false));
									num8 = 54;
									goto IL_0107;
									IL_0107:
									num6 = num8;
									break;
									end_IL_010b:
									break;
								}
							}
						}
						finally
						{
							if (callContextSessionOwner != null)
							{
								int num21 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
								{
									num21 = 0;
								}
								while (true)
								{
									switch (num21)
									{
									default:
										GH8iJvE1KjBtdq7Mib6q(callContextSessionOwner);
										num21 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
										{
											num21 = 0;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
					}
				}
				catch (OperationCanceledException)
				{
					int num22 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num22 = 0;
					}
					while (true)
					{
						switch (num22)
						{
						default:
							return;
						case 1:
							AddMessage(new DeployLogMessage(DeployLogMessageType.Error, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-1317790512 ^ -1318030546)), endProcess: true));
							num22 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num22 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
				catch (Exception ex4)
				{
					int num23 = 2;
					int num24 = num23;
					while (true)
					{
						switch (num24)
						{
						case 2:
							mpPoVWE1OsoeCdWeb6OT(ImportLog, string.Format((string)NUn1HRE1nboQISCQgj1B(-1108654032 ^ -1108395986), Ye6XkoE12l2wWmACTc0I(ex4)), ex4);
							num24 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num24 = 0;
							}
							continue;
						case 1:
							return;
						}
						AddMessage(new DeployLogMessage(DeployLogMessageType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD12068), ex4.Message), endProcess: true));
						num24 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num24 = 1;
						}
					}
				}
				finally
				{
					CI84eLE1w15ESyMY8UaR(runWithSoftDeletableService, value);
					int num25 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num25 = 0;
					}
					switch (num25)
					{
					case 0:
						break;
					}
				}
			case 6:
				messages = parameters.LogMessages;
				num2 = 10;
				break;
			case 3:
				return;
			case 12:
				value = xeCFBvE1tQFZShmibxRV(runWithSoftDeletableService);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 3;
				}
				break;
			case 8:
				try
				{
					while (true)
					{
						IL_2c66:
						int num3;
						if (!fagugcE1aZARwy0aBgiG(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
							{
								num3 = 0;
							}
							goto IL_2bbc;
						}
						goto IL_2c8c;
						IL_2c8c:
						current = enumerator.Current;
						num3 = 6;
						goto IL_2bbc;
						IL_2bbc:
						while (true)
						{
							switch (num3)
							{
							case 11:
								Y2royjE1plb4gjxp3MMP(ImportLog, string.Format((string)NUn1HRE1nboQISCQgj1B(-740338220 ^ -740608944), Od4VdXE1NZR6dcJmVHKO(current)));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
								{
									num3 = 3;
								}
								continue;
							case 6:
								if (current != null)
								{
									num3 = 9;
									continue;
								}
								goto IL_2c66;
							case 3:
							case 4:
							case 7:
							case 10:
								goto IL_2c66;
							case 8:
								goto IL_2c8c;
							case 9:
								testImportMessagesType = yWhCiTE11R9j23tRJZIM(current);
								num3 = 5;
								continue;
							case 2:
								goto IL_2cb2;
							case 5:
								switch (testImportMessagesType)
								{
								case TestImportMessagesType.Error:
									break;
								case TestImportMessagesType.Warning:
									goto IL_2cb2;
								default:
									goto IL_2d21;
								case TestImportMessagesType.InfoCommon:
								case TestImportMessagesType.InfoMetadata:
								case TestImportMessagesType.InfoLose:
									goto IL_2d3b;
								}
								goto case 11;
							case 1:
								goto IL_2d3b;
							case 0:
								break;
								IL_2d3b:
								Y2royjE1plb4gjxp3MMP(ImportLog, Ylt4G6E13n0iSBWhEp4K(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -868063904), Od4VdXE1NZR6dcJmVHKO(current)));
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
								{
									num3 = 0;
								}
								continue;
								IL_2d21:
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num3 = 7;
								}
								continue;
								IL_2cb2:
								Y2royjE1plb4gjxp3MMP(ImportLog, Ylt4G6E13n0iSBWhEp4K(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289460430), Od4VdXE1NZR6dcJmVHKO(current)));
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
								{
									num3 = 10;
								}
								continue;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num4 = 1;
						}
						goto IL_2dc4;
					}
					goto IL_2df9;
					IL_2df9:
					GH8iJvE1KjBtdq7Mib6q(enumerator);
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num4 = 2;
					}
					goto IL_2dc4;
					IL_2dc4:
					switch (num4)
					{
					case 1:
						goto end_IL_2d9f;
					case 2:
						goto end_IL_2d9f;
					}
					goto IL_2df9;
					end_IL_2d9f:;
				}
				goto case 6;
			case 9:
				return;
			case 2:
				LHf4VrE1ediZPOJHUfPP(parameters, NUn1HRE1nboQISCQgj1B(-1751176224 ^ -1751127698));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (h9ykD5E1Px7Gft1hHX4m(importSettings) == 1)
				{
					num2 = 7;
					break;
				}
				goto case 6;
			case 7:
				if (importSettings.TestResult != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 11:
				AddMessage(new DeployLogMessage(DeployLogMessageType.Error, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(0x7C1EE318 ^ 0x7C1A82A8)), endProcess: true));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				if (!NWvLyhE1D9UIVRmgX9sH())
				{
					num2 = 12;
					break;
				}
				goto case 11;
			}
		}
	}

	private void RunTest(string key, CancellationToken cancellationToken)
	{
		//Discarded unreachable code: IL_028a, IL_02ad, IL_033d, IL_034c, IL_0412, IL_0454, IL_056f, IL_05a7, IL_05b6, IL_05e2, IL_067f, IL_068e, IL_0787, IL_0796, IL_07e3, IL_083a, IL_09ff, IL_0b7e, IL_0b9e, IL_0bad, IL_0bbd, IL_0bcc, IL_0bdc, IL_0c94, IL_0d2a, IL_0ebe, IL_0ed1, IL_0ee0, IL_0f6d, IL_0f7c, IL_0ffe, IL_1009, IL_1014, IL_1023, IL_102e, IL_1164, IL_1173, IL_11b6, IL_11c5, IL_122f, IL_12bf, IL_12ce, IL_12f0, IL_12ff, IL_1364, IL_13e9, IL_13fc, IL_1431, IL_1440, IL_1450, IL_145f, IL_14c1, IL_1501, IL_1510, IL_151c, IL_169f, IL_16e9, IL_1796, IL_17e0, IL_17ef, IL_180c, IL_18d3, IL_18e2, IL_18ed, IL_19d7, IL_19ea, IL_1a1e, IL_1a3d, IL_1a4c, IL_1a79, IL_1aae, IL_1abd, IL_1b7b, IL_1c63, IL_1cb3, IL_1cc2, IL_1cd1, IL_1cf3, IL_1dac, IL_1dcb, IL_1dda, IL_1e28, IL_1e47, IL_1e73, IL_1ef2, IL_1f01, IL_2302, IL_2344, IL_23a0, IL_23d1, IL_2489, IL_24c4, IL_24d3, IL_2524, IL_255a, IL_2569, IL_258e, IL_259d, IL_26ce, IL_26dd, IL_26e8, IL_27b7, IL_27ca, IL_27d9, IL_27e9, IL_27f8, IL_2822, IL_296b, IL_297a, IL_2a16, IL_2a92, IL_2aa1, IL_2b6a, IL_2b79, IL_2b88, IL_2c64, IL_2c77, IL_2c86, IL_2cad, IL_2cbc, IL_2dbc, IL_2e3a, IL_2e49, IL_2e58, IL_2e7e, IL_2e8d, IL_2e9d, IL_2eac, IL_2ee7, IL_2f55, IL_3009, IL_3117, IL_3147, IL_3156, IL_3162, IL_3248, IL_3257, IL_3267, IL_33cd, IL_343a, IL_3449
		int num = 41;
		_003C_003Ec__DisplayClass68_0 _003C_003Ec__DisplayClass68_ = default(_003C_003Ec__DisplayClass68_0);
		string text = default(string);
		BPMAppManifest bPMAppManifest = default(BPMAppManifest);
		ImportLicenseInfo importLicenseInfo2 = default(ImportLicenseInfo);
		string unpackedPackagesFolder = default(string);
		_003C_003Ec__DisplayClass68_2 _003C_003Ec__DisplayClass68_3 = default(_003C_003Ec__DisplayClass68_2);
		List<PackageInfo> list = default(List<PackageInfo>);
		_003C_003Ec__DisplayClass68_1 _003C_003Ec__DisplayClass68_2 = default(_003C_003Ec__DisplayClass68_1);
		string configFile = default(string);
		ImportLicenseInfo importLicenseInfo = default(ImportLicenseInfo);
		AppDomain domain = default(AppDomain);
		IEnumerable<string> activationKeys = default(IEnumerable<string>);
		Func<DateTime?> getMainUnitExpiration = default(Func<DateTime?>);
		ComponentManager current = default(ComponentManager);
		XmlReader xmlReader2 = default(XmlReader);
		string serverFilesFileName = default(string);
		StoreComponentUnpackStatus storeComponentUnpackStatus = default(StoreComponentUnpackStatus);
		IBPMApp iBPMApp = default(IBPMApp);
		ElmaStoreComponentManifest elmaStoreComponentManifest = default(ElmaStoreComponentManifest);
		PackagesBAChapter packagesBAChapter = default(PackagesBAChapter);
		string serverFolderName = default(string);
		XmlReader xmlReader = default(XmlReader);
		IMetadata[] array2 = default(IMetadata[]);
		List<IReadMetadataResult> list2 = default(List<IReadMetadataResult>);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		XNodeWrapper xNodeWrapper = default(XNodeWrapper);
		_003C_003Ec__DisplayClass68_4 CS_0024_003C_003E8__locals0;
		List<IEntityImportSaveActions>.Enumerator enumerator3 = default(List<IEntityImportSaveActions>.Enumerator);
		List<IEntityImportSaveActions> list3 = default(List<IEntityImportSaveActions>);
		List<TestImportMessages> instance = default(List<TestImportMessages>);
		string text3 = default(string);
		_003C_003Ec__DisplayClass68_3 CS_0024_003C_003E8__locals1;
		bool flag = default(bool);
		bool flag2 = default(bool);
		HashSet<Guid> hashSet = default(HashSet<Guid>);
		Guid result = default(Guid);
		string attribute = default(string);
		HashSet<Guid>.Enumerator enumerator = default(HashSet<Guid>.Enumerator);
		Guid current3 = default(Guid);
		string text2 = default(string);
		Dictionary<string, string>.Enumerator enumerator2 = default(Dictionary<string, string>.Enumerator);
		string[] array = default(string[]);
		Guid result2 = default(Guid);
		KeyValuePair<string, string> current2 = default(KeyValuePair<string, string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj5;
				object obj;
				switch (num2)
				{
				case 106:
					if (((ElmaStoreComponentManifest)CxSgSmENKwdloll3Eqod(_003C_003Ec__DisplayClass68_.configImportSettings)).Packages.Any())
					{
						num2 = 73;
						continue;
					}
					goto case 18;
				case 121:
					text = (string)Y12gHtE1HlUGeXH6LxZY(exportImportFileManager, O2oXytE162AAMiZL2QmT(_003C_003Ec__DisplayClass68_.configImportSettings));
					num2 = 105;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 25;
					}
					continue;
				case 47:
					try
					{
						bPMAppManifest = ClassSerializationHelper.DeserializeObjectByXml<BPMAppManifest>((string)U5UHMaE1S4JqtTam5itl(manifest));
						int num24 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num24 = 0;
						}
						switch (num24)
						{
						case 0:
							break;
						}
					}
					catch (Exception exception)
					{
						int num25 = 2;
						while (true)
						{
							switch (num25)
							{
							default:
								TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FBB939))));
								num25 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
								{
									num25 = 1;
								}
								break;
							case 2:
								ImportLog.Error(NUn1HRE1nboQISCQgj1B(-1317790512 ^ -1318031674), exception);
								num25 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
								{
									num25 = 0;
								}
								break;
							case 1:
								return;
							}
						}
					}
					goto case 120;
				case 3:
					if (_003C_003Ec__DisplayClass68_.configImportSettings.FileName != null)
					{
						num2 = 23;
						continue;
					}
					obj5 = "";
					goto IL_3531;
				case 33:
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-1217523399 ^ -1217760731))));
					num2 = 12;
					continue;
				case 69:
					importLicenseInfo2 = new ImportLicenseInfo();
					num2 = 9;
					continue;
				case 68:
					importExtensions.Each(_003C_003Ec__DisplayClass68_._003CRunTest_003Eb__5);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 78;
					}
					continue;
				case 103:
					try
					{
						IFSTransaction iFSTransaction = (IFSTransaction)sQhYdaENpjrxWDDtmkLv(((PackagingSettings)w3Hq0YEN31mFVeXGtS6c(packageService)).Root);
						int num26 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num26 = 0;
						}
						switch (num26)
						{
						default:
							try
							{
								TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-87337865 ^ -87087209))));
								int num27 = 4;
								while (true)
								{
									switch (num27)
									{
									case 4:
										unpackedPackagesFolder = (string)Qv8oHUE1ge6GYP1mkdeN(_003C_003Ec__DisplayClass68_.serverFolderName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC5226E));
										num27 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
										{
											num27 = 3;
										}
										continue;
									case 3:
										packageService.SaveStoreComponentFileToConfiguration(manifest, text, unpackedPackagesFolder);
										num27 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
										{
											num27 = 0;
										}
										continue;
									case 1:
										if (_003C_003Ec__DisplayClass68_3.packagingComponent.PrepareInstallPackages(list, updateDependencies: false) != null)
										{
											num27 = 2;
											continue;
										}
										break;
									case 2:
									{
										TestImportMessages testImportMessages3 = new TestImportMessages(TestImportMessagesType.InfoReboote, SR.T((string)NUn1HRE1nboQISCQgj1B(-1870892489 ^ -1871182179)));
										R23cfsENaQGrCoLhCNwv(testImportMessages3, true);
										TestMessagesAdd(testImportMessages3);
										num27 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
										{
											num27 = 0;
										}
										continue;
									}
									case 0:
										break;
									}
									break;
								}
							}
							finally
							{
								if (iFSTransaction != null)
								{
									int num28 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
									{
										num28 = 0;
									}
									while (true)
									{
										switch (num28)
										{
										default:
											GH8iJvE1KjBtdq7Mib6q(iFSTransaction);
											num28 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
											{
												num28 = 0;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
							break;
						case 1:
							break;
						}
					}
					catch (Exception ex2)
					{
						int num29 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num29 = 1;
						}
						while (true)
						{
							switch (num29)
							{
							default:
								mpPoVWE1OsoeCdWeb6OT(ImportLog, ex2.Message, ex2);
								num29 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
								{
									num29 = 2;
								}
								break;
							case 1:
								TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)NUn1HRE1nboQISCQgj1B(0x34A6D230 ^ 0x34A2A75C), ex2.Message)));
								num29 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
								{
									num29 = 0;
								}
								break;
							case 2:
								return;
							}
						}
					}
					goto case 21;
				case 48:
					if (manifest != null)
					{
						num2 = 48;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 51;
						}
						continue;
					}
					goto IL_372c;
				case 115:
					_003C_003Ec__DisplayClass68_2 = new _003C_003Ec__DisplayClass68_1();
					num2 = 112;
					continue;
				case 2:
					if (!CheckHash(configFile, (string)LDpLgeE1J1pKeCQ2WwM1(exportImportFileManager, O2oXytE162AAMiZL2QmT(_003C_003Ec__DisplayClass68_.configImportSettings), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309665788), NUn1HRE1nboQISCQgj1B(-2138958856 ^ -2138682308))))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 52;
						}
						continue;
					}
					goto case 55;
				case 97:
					importLicenseInfo = CheckOrActivateModules(_003C_003Ec__DisplayClass68_.serverFolderName, key, out domain);
					num2 = 108;
					continue;
				case 108:
					if (importLicenseInfo != null)
					{
						num2 = 5;
						continue;
					}
					goto IL_07e9;
				case 86:
				case 118:
				{
					manifest = ElmaStoreComponentsBuilder.Read(text, activationKeys, getMainUnitExpiration, needPackages: false, null, needIcon: false, out var _, out var _);
					num2 = 116;
					continue;
				}
				case 89:
					serviceData = new Dictionary<string, string>();
					num2 = 42;
					continue;
				case 28:
					_003C_003Ec__DisplayClass68_3 = new _003C_003Ec__DisplayClass68_2();
					num2 = 60;
					continue;
				case 23:
					obj5 = Jax2EbENI7Y1CXYVG1TO(exportImportFileManager, O2oXytE162AAMiZL2QmT(_003C_003Ec__DisplayClass68_.configImportSettings));
					goto IL_3531;
				case 79:
					return;
				case 113:
					if (current == null)
					{
						num2 = 86;
						continue;
					}
					goto case 91;
				case 95:
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Warning, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-35995181 ^ -35735735))));
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 2;
					}
					continue;
				case 94:
					xmlReader2 = GetXmlReader(importSettings);
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 64;
					}
					continue;
				case 8:
					getMainUnitExpiration = null;
					num2 = 113;
					continue;
				case 29:
					serverFilesFileName = exportImportFileManager.CreateFileName((string)O2oXytE162AAMiZL2QmT(_003C_003Ec__DisplayClass68_.configImportSettings), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A1A533), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138430854));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 2;
					}
					continue;
				case 34:
					switch (storeComponentUnpackStatus)
					{
					case StoreComponentUnpackStatus.ActivationError:
						num2 = 69;
						continue;
					case StoreComponentUnpackStatus.Success:
						num2 = 96;
						continue;
					}
					goto case 100;
				case 120:
					if (bPMAppManifest == null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 87;
				case 5:
					if (domain != null)
					{
						num = 77;
						break;
					}
					goto IL_07e9;
				case 116:
					if (manifest == null)
					{
						num2 = 49;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 98;
				case 40:
					_003C_003Ec__DisplayClass68_._003C_003E4__this = this;
					num2 = 99;
					continue;
				case 20:
					if (_003C_003Ec__DisplayClass68_.configImportSettings != null)
					{
						num2 = 119;
						continue;
					}
					goto case 27;
				case 73:
					if (uv1b8RENXhA4k0buxlZA(_003C_003Ec__DisplayClass68_.configImportSettings) == null)
					{
						num2 = 67;
						continue;
					}
					goto case 31;
				case 112:
					_003C_003Ec__DisplayClass68_2.chapter = ((BPMAppFakeManifest)uv1b8RENXhA4k0buxlZA(_003C_003Ec__DisplayClass68_.configImportSettings)).GetOrCreateChapterByUid(PackageExportConsts.ExportExtensionUid, "");
					num2 = 50;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 82;
					}
					continue;
				case 87:
					iBPMApp = (IBPMApp)CYvTT4ENRegxpcoT0NOp(bpmAppManager, aJKWvhENiAaPdhKQ1Tw8(manifest));
					num2 = 88;
					continue;
				case 7:
					if (u1lVu1E1rkXXYmfryECy(key))
					{
						num2 = 111;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 56;
				case 105:
					current = ComponentManager.Current;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 14;
					}
					continue;
				case 85:
					if (!(importSettings is TestModuleImportSettings))
					{
						num2 = 39;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto IL_0d7b;
				case 72:
					zipService.ExtractZipFolder(text, _003C_003Ec__DisplayClass68_.serverFolderName);
					num2 = 45;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 93;
					}
					continue;
				case 71:
					throw new InvalidOperationException((string)U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1318028824)));
				case 19:
				case 93:
				case 111:
					if (manifest == null)
					{
						num2 = 74;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 64;
						}
						continue;
					}
					goto case 28;
				case 1:
					configFile = (string)LDpLgeE1J1pKeCQ2WwM1(exportImportFileManager, O2oXytE162AAMiZL2QmT(_003C_003Ec__DisplayClass68_.configImportSettings), NUn1HRE1nboQISCQgj1B(-309639236 ^ -309665788), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FBAB5B));
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 27;
					}
					continue;
				case 81:
					return;
				case 119:
					metadataNotIsUnique = new HashSet<Guid>();
					num2 = 70;
					continue;
				case 41:
					_003C_003Ec__DisplayClass68_ = new _003C_003Ec__DisplayClass68_0();
					num2 = 40;
					continue;
				case 109:
					getMainUnitExpiration = ((IModuleManager)wCVyoYENSJwxquCkdonA(current)).GetMainLicensedUnitExpiration;
					num2 = 118;
					continue;
				case 53:
					return;
				case 11:
				case 110:
					if (bPMAppManifest == null)
					{
						num2 = 65;
						continue;
					}
					goto case 107;
				case 92:
					if (storeComponentUnpackStatus == StoreComponentUnpackStatus.FreeSigned)
					{
						num2 = 48;
						continue;
					}
					goto case 54;
				case 10:
					if (_003C_003Ec__DisplayClass68_3.packagingComponent == null)
					{
						num2 = 6;
						continue;
					}
					list = (from p in manifest.Packages.Where(_003C_003Ec__DisplayClass68_3._003CRunTest_003Eb__9)
						select new PackageInfo((string)_003C_003Ec.sl6Svs8nUD5bCfWyrVGX(p), (SemanticVersion)_003C_003Ec.bo5wLP8nslCursAtGuO7(p))).ToList();
					num2 = 37;
					continue;
				case 9:
					InitImportLicenseInfo(importLicenseInfo2);
					num2 = 16;
					continue;
				case 114:
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(0x638095EB ^ 0x6384F45B))));
					num2 = 4;
					continue;
				case 70:
					if (!NWvLyhE1D9UIVRmgX9sH())
					{
						num2 = 30;
						continue;
					}
					goto case 114;
				case 45:
				{
					TestImportMessages testImportMessages2 = new TestImportMessages(TestImportMessagesType.UserAction, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-477139494 ^ -477422004)));
					q5iAW0ENPtJmnbMGvfd7(testImportMessages2, LicenseImportTestUserAction.UID);
					IFB9vrEN1cmMT8UtGtog(testImportMessages2, importLicenseInfo);
					TestMessagesAdd(testImportMessages2);
					num2 = 38;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 79;
					}
					continue;
				}
				case 39:
					elmaStoreComponentManifest = moduleManager.GetInstalledComponentManifests().FirstOrDefault(_003C_003Ec__DisplayClass68_._003CRunTest_003Eb__6);
					num2 = 76;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 5;
					}
					continue;
				case 102:
					if (!u1lVu1E1rkXXYmfryECy(U5UHMaE1S4JqtTam5itl(manifest)))
					{
						num2 = 47;
						continue;
					}
					goto case 120;
				case 16:
					if (manifest != null)
					{
						num2 = 75;
						continue;
					}
					goto case 35;
				case 100:
					if (storeComponentUnpackStatus != StoreComponentUnpackStatus.Unsigned)
					{
						num2 = 92;
						continue;
					}
					goto case 48;
				case 83:
					return;
				case 117:
					if (!rWCV4XENqkuvYHfu1rRG(iBPMApp))
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 11;
				case 46:
					cancellationToken.ThrowIfCancellationRequested();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 17;
					}
					continue;
				case 96:
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-1633514411 ^ -1633226873))));
					num2 = 7;
					continue;
				case 82:
					packagesBAChapter.Packages.ForEach(_003C_003Ec__DisplayClass68_2._003CRunTest_003Eb__8);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 17;
					}
					continue;
				case 25:
					if (CheckImportFiles(serverFilesFileName, serverFolderName))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 95;
				case 60:
					Djk57qE1lBxyJ81fVK0Z(packageService);
					num2 = 32;
					continue;
				case 24:
				case 36:
					_003C_003Ec__DisplayClass68_.postCompleteMessages = new List<TestImportMessages>();
					num2 = 68;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 7;
					}
					continue;
				case 54:
					if (storeComponentUnpackStatus == StoreComponentUnpackStatus.WrongSignatures)
					{
						num2 = 80;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 37;
						}
					}
					else
					{
						xQ7nFOENWZ1yyIBkqRi4(MlNMGBE1y8ECm86WgVkD(), CJiYGKE1M9HgOO5j0vIa(NUn1HRE1nboQISCQgj1B(-583745292 ^ -584014782), storeComponentUnpackStatus));
						num2 = 71;
					}
					continue;
				case 59:
					try
					{
						Kdm5EqENAXdSMui2cTaL(xmlReader, NUn1HRE1nboQISCQgj1B(0x7C1EE318 ^ 0x7C1A88C2));
						int num12 = 7;
						while (true)
						{
							object obj4;
							object obj3;
							switch (num12)
							{
							case 11:
								if (!WaSmnAE1cpYU3LOfjiR7(xmlReader))
								{
									num12 = 4;
									continue;
								}
								goto case 6;
							case 5:
								WFMAx6E1zDIJWZIkcCR2(xmlReader);
								num12 = 10;
								continue;
							case 10:
								if (array2.Length == 0)
								{
									num12 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
									{
										num12 = 0;
									}
									continue;
								}
								obj4 = MetadataServiceContext.Extend(array2);
								goto IL_155f;
							case 3:
								if (r9oW4AEN7HSk5JJgMoq0(list2) > 0)
								{
									int num22 = 9;
									num12 = num22;
									continue;
								}
								goto case 2;
							case 4:
								qlGUxwENGSOyZXd6OKWI(xmlReader);
								num12 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
								{
									num12 = 2;
								}
								continue;
							case 2:
								obj3 = null;
								goto IL_159e;
							default:
								obj4 = null;
								goto IL_155f;
							case 8:
								try
								{
									while (true)
									{
										IL_1147:
										int num20;
										if (xmlReader.NodeType == XmlNodeType.EndElement)
										{
											num20 = 2;
											goto IL_1032;
										}
										goto IL_1239;
										IL_1032:
										while (true)
										{
											switch (num20)
											{
											case 26:
												ReadMetadataBlock(xmlReader, isSystemMd: true, _003C_003Ec__DisplayClass68_.serverFolderName, isTestRead: true);
												num20 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
												{
													num20 = 6;
												}
												continue;
											case 17:
												break;
											case 13:
												list2.AddRange(ReadMetadataBlock(xmlReader, isSystemMd: false, _003C_003Ec__DisplayClass68_.serverFolderName, isTestRead: true));
												num20 = 11;
												continue;
											case 29:
												goto IL_1147;
											case 9:
											case 22:
											case 33:
												goto IL_117e;
											case 3:
											case 24:
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												num20 = 18;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
												{
													num20 = 29;
												}
												continue;
											case 7:
												qlGUxwENGSOyZXd6OKWI(xmlReader);
												num20 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
												{
													num20 = 0;
												}
												continue;
											case 25:
												goto IL_11f2;
											case 34:
												xmlReader.Read();
												num20 = 3;
												continue;
											case 14:
												goto IL_1239;
											case 8:
												qlGUxwENGSOyZXd6OKWI(xmlReader);
												num20 = 19;
												continue;
											case 31:
												if (!aHWlqJE1LYQIoxkGNkvB(xmlReader))
												{
													num20 = 15;
													continue;
												}
												goto case 1;
											default:
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												num20 = 28;
												continue;
											case 5:
											case 18:
											case 23:
												xmlReader.Skip();
												num20 = 20;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
												{
													num20 = 19;
												}
												continue;
											case 19:
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												num20 = 13;
												continue;
											case 21:
												if (!RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(xmlReader), NUn1HRE1nboQISCQgj1B(-576149596 ^ -575874126)))
												{
													num20 = 18;
													continue;
												}
												goto case 27;
											case 4:
												xmlReader.Read();
												num20 = 10;
												continue;
											case 6:
											case 11:
											case 20:
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												num20 = 12;
												continue;
											case 10:
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												num20 = 7;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
												{
													num20 = 26;
												}
												continue;
											case 27:
												if (WaSmnAE1cpYU3LOfjiR7(xmlReader))
												{
													num20 = 5;
													continue;
												}
												goto case 4;
											case 32:
												if (!xmlReader.IsEmptyElement)
												{
													num20 = 8;
													continue;
												}
												goto case 15;
											case 12:
											case 28:
												if (u8mPV3ENBOqyjN9FPD2H(xmlReader) == XmlNodeType.EndElement)
												{
													num20 = 34;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
													{
														num20 = 19;
													}
													continue;
												}
												goto case 31;
											case 15:
											case 16:
											case 30:
												if (aHWlqJE1LYQIoxkGNkvB(xmlReader))
												{
													num20 = 21;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
													{
														num20 = 20;
													}
													continue;
												}
												goto case 5;
											case 1:
												if (!RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(xmlReader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -584008946)))
												{
													num20 = 16;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
													{
														num20 = 6;
													}
													continue;
												}
												goto case 32;
											case 2:
												goto end_IL_1147;
											}
											break;
										}
										goto IL_10f4;
										IL_1239:
										if (!aHWlqJE1LYQIoxkGNkvB(xmlReader))
										{
											num20 = 9;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
											{
												num20 = 6;
											}
											goto IL_1032;
										}
										goto IL_10f4;
										IL_11f2:
										if (!WaSmnAE1cpYU3LOfjiR7(xmlReader))
										{
											num20 = 7;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
											{
												num20 = 2;
											}
											goto IL_1032;
										}
										goto IL_117e;
										IL_117e:
										xmlReader.Skip();
										num20 = 24;
										goto IL_1032;
										IL_10f4:
										if (!RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(xmlReader), NUn1HRE1nboQISCQgj1B(-234299632 ^ -234061444)))
										{
											num20 = 22;
											goto IL_1032;
										}
										goto IL_11f2;
										continue;
										end_IL_1147:
										break;
									}
								}
								finally
								{
									int num21;
									if (metadataServiceContext == null)
									{
										num21 = 2;
										goto IL_14c5;
									}
									goto IL_14db;
									IL_14c5:
									switch (num21)
									{
									case 2:
										goto end_IL_14b0;
									case 1:
										goto end_IL_14b0;
									}
									goto IL_14db;
									IL_14db:
									((IDisposable)metadataServiceContext).Dispose();
									num21 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
									{
										num21 = 1;
									}
									goto IL_14c5;
									end_IL_14b0:;
								}
								goto case 6;
							case 7:
								list2 = new List<IReadMetadataResult>();
								num12 = 11;
								continue;
							case 6:
								cancellationToken.ThrowIfCancellationRequested();
								num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
								{
									num12 = 3;
								}
								continue;
							case 9:
								obj3 = MetadataServiceContext.Extend(list2.Select((IReadMetadataResult r) => (IMetadata)_003C_003Ec.U03Dh68OFFXjpnOgwTHw(r)));
								goto IL_159e;
							case 1:
								{
									try
									{
										int num13;
										if (r9oW4AEN7HSk5JJgMoq0(list2) <= 0)
										{
											num13 = 13;
											goto IL_15d6;
										}
										goto IL_1cfd;
										IL_15d6:
										while (true)
										{
											switch (num13)
											{
											case 4:
											case 13:
												Kdm5EqENAXdSMui2cTaL(xmlReader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FF67D1));
												num13 = 19;
												continue;
											case 21:
												if (!((string)zmwHRHE1UslqZB4OAIKq(xmlReader) == (string)NUn1HRE1nboQISCQgj1B(-1317790512 ^ -1318042948)))
												{
													num13 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
													{
														num13 = 1;
													}
													continue;
												}
												goto case 33;
											case 3:
												xNodeWrapper = new XNodeWrapper(xmlReader);
												num13 = 36;
												continue;
											case 33:
												if (xmlReader.IsEmptyElement)
												{
													num13 = 25;
													continue;
												}
												goto case 31;
											case 8:
											case 35:
												xmlReader.Skip();
												num13 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
												{
													num13 = 9;
												}
												continue;
											case 14:
												if (!RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(xmlReader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -542012027)))
												{
													num13 = 35;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
													{
														num13 = 8;
													}
													continue;
												}
												goto case 7;
											case 23:
											case 24:
												if (xmlReader.NodeType == XmlNodeType.EndElement)
												{
													num13 = 27;
													continue;
												}
												goto case 15;
											case 15:
												if (aHWlqJE1LYQIoxkGNkvB(xmlReader))
												{
													num13 = 14;
													continue;
												}
												goto case 8;
											case 10:
												qPNZx7ENFAG8vQyPD8WG(xmlReader);
												num13 = 6;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
												{
													num13 = 5;
												}
												continue;
											case 36:
												try
												{
													CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass68_4();
													int num14 = 3;
													while (true)
													{
														switch (num14)
														{
														case 5:
															enumerator3 = list3.GetEnumerator();
															num14 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
															{
																num14 = 0;
															}
															continue;
														case 4:
															if (cjH4cTEN0fYhlHDoay6K(list3) > 0)
															{
																num14 = 5;
																continue;
															}
															break;
														case 1:
															list3 = entityImportSaveActionExtensions.Where((IEntityImportSaveActions ex) => _003C_003Ec__DisplayClass68_4.aj3SWC8O4WcK99K73cTp(ex, CS_0024_003C_003E8__locals0.typeUid)).ToList();
															num14 = 3;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
															{
																num14 = 4;
															}
															continue;
														case 3:
															CS_0024_003C_003E8__locals0.typeUid = GcF7yXENxNLhroPmfDBc(xNodeWrapper);
															num14 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
															{
																num14 = 1;
															}
															continue;
														default:
															try
															{
																while (true)
																{
																	IL_1968:
																	int num15;
																	if (!enumerator3.MoveNext())
																	{
																		num15 = 1;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
																		{
																			num15 = 1;
																		}
																		goto IL_18f1;
																	}
																	goto IL_190b;
																	IL_190b:
																	IEntityImportSaveActions current4 = enumerator3.Current;
																	XmlReader reader = (XmlReader)Sdl6aMENmVGGrvXFIkq6(xNodeWrapper);
																	instance = new List<TestImportMessages>();
																	current4.TestRead(new ImportTestReadData(reader, mergeReplace, serviceData, _003C_003Ec__DisplayClass68_.configImportSettings), new ImportTestReadResult(instance, testSystemMessages));
																	num15 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
																	{
																		num15 = 0;
																	}
																	goto IL_18f1;
																	IL_18f1:
																	while (true)
																	{
																		switch (num15)
																		{
																		case 3:
																			break;
																		case 2:
																			goto IL_1968;
																		default:
																			instance.Each(TestMessagesAdd);
																			num15 = 2;
																			continue;
																		case 1:
																			goto end_IL_1968;
																		}
																		break;
																	}
																	goto IL_190b;
																	continue;
																	end_IL_1968:
																	break;
																}
															}
															finally
															{
																((IDisposable)enumerator3).Dispose();
																int num16 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
																{
																	num16 = 0;
																}
																switch (num16)
																{
																case 0:
																	break;
																}
															}
															break;
														case 2:
															break;
														}
														break;
													}
												}
												finally
												{
													int num17;
													if (xNodeWrapper == null)
													{
														num17 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
														{
															num17 = 1;
														}
														goto IL_1a22;
													}
													goto IL_1a57;
													IL_1a57:
													((IDisposable)xNodeWrapper).Dispose();
													num17 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
													{
														num17 = 2;
													}
													goto IL_1a22;
													IL_1a22:
													switch (num17)
													{
													case 1:
														goto end_IL_19fd;
													case 2:
														goto end_IL_19fd;
													}
													goto IL_1a57;
													end_IL_19fd:;
												}
												goto case 9;
											case 22:
												if (!aHWlqJE1LYQIoxkGNkvB(xmlReader))
												{
													num13 = 23;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
													{
														num13 = 29;
													}
													continue;
												}
												goto case 21;
											case 17:
											{
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												int num18 = 5;
												num13 = num18;
												continue;
											}
											case 31:
												text3 = (string)bvLSv2ENhtbgyyFsrZvn(xmlReader, NUn1HRE1nboQISCQgj1B(0x53CB464B ^ 0x53C90E37));
												num13 = 28;
												continue;
											case 5:
											case 37:
												if (u8mPV3ENBOqyjN9FPD2H(xmlReader) == XmlNodeType.EndElement)
												{
													num13 = 20;
													continue;
												}
												goto case 22;
											case 9:
												qlGUxwENGSOyZXd6OKWI(xmlReader);
												num13 = 24;
												continue;
											case 28:
												if (packetVersionService.Check((string)zmwHRHE1UslqZB4OAIKq(xmlReader), text3))
												{
													num13 = 16;
													continue;
												}
												goto case 30;
											case 2:
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												num13 = 23;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
												{
													num13 = 8;
												}
												continue;
											case 27:
												xmlReader.Read();
												num13 = 32;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
												{
													num13 = 22;
												}
												continue;
											case 7:
												if (!WaSmnAE1cpYU3LOfjiR7(xmlReader))
												{
													num13 = 3;
													continue;
												}
												goto case 8;
											case 16:
											case 18:
												qlGUxwENGSOyZXd6OKWI(xmlReader);
												num13 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
												{
													num13 = 2;
												}
												continue;
											case 19:
												xmlReader.Read();
												num13 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
												{
													num13 = 17;
												}
												continue;
											case 11:
											case 12:
											case 25:
											case 29:
												qPNZx7ENFAG8vQyPD8WG(xmlReader);
												num13 = 15;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
												{
													num13 = 34;
												}
												continue;
											default:
												TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoReboote, SR.T((string)NUn1HRE1nboQISCQgj1B(--1333735954 ^ 0x4F7B4E24))));
												num13 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
												{
													num13 = 4;
												}
												continue;
											case 1:
												if (!xZ06MUENQJVAH6dS5LZK(zmwHRHE1UslqZB4OAIKq(xmlReader), NUn1HRE1nboQISCQgj1B(-234299632 ^ -234048690)))
												{
													num13 = 12;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
													{
														num13 = 7;
													}
													continue;
												}
												goto case 33;
											case 6:
											case 32:
											case 34:
												WFMAx6E1zDIJWZIkcCR2(xmlReader);
												num13 = 37;
												continue;
											case 26:
												break;
											case 30:
												TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoLose, SR.T((string)NUn1HRE1nboQISCQgj1B(0x3B36AB09 ^ 0x3B32D61F), zmwHRHE1UslqZB4OAIKq(xmlReader), text3 ?? "")));
												num13 = 10;
												continue;
											case 20:
												goto end_IL_15d6;
											}
											goto IL_1cfd;
											continue;
											end_IL_15d6:
											break;
										}
										goto end_IL_15bb;
										IL_1cfd:
										list2.ForEach(delegate(IReadMetadataResult r)
										{
											int num30 = 1;
											int num31 = num30;
											while (true)
											{
												switch (num31)
												{
												default:
													return;
												case 0:
													return;
												case 1:
													_003C_003Ec.lsI2W08OBWxuRaGyHYfV(r);
													num31 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
													{
														num31 = 0;
													}
													break;
												}
											}
										});
										num13 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
										{
											num13 = 0;
										}
										goto IL_15d6;
										end_IL_15bb:;
									}
									finally
									{
										int num19;
										if (metadataServiceContext == null)
										{
											num19 = 2;
											goto IL_1db0;
										}
										goto IL_1de5;
										IL_1db0:
										switch (num19)
										{
										case 2:
											goto end_IL_1d9b;
										case 1:
											goto end_IL_1d9b;
										}
										goto IL_1de5;
										IL_1de5:
										GH8iJvE1KjBtdq7Mib6q(metadataServiceContext);
										num19 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
										{
											num19 = 1;
										}
										goto IL_1db0;
										end_IL_1d9b:;
									}
									break;
								}
								IL_159e:
								metadataServiceContext = (MetadataServiceContext)obj3;
								num12 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
								{
									num12 = 1;
								}
								continue;
								IL_155f:
								metadataServiceContext = (MetadataServiceContext)obj4;
								num12 = 8;
								continue;
							}
							break;
						}
					}
					finally
					{
						int num23;
						if (xmlReader == null)
						{
							num23 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
							{
								num23 = 1;
							}
							goto IL_1e2c;
						}
						goto IL_1e51;
						IL_1e51:
						((IDisposable)xmlReader).Dispose();
						num23 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num23 = 0;
						}
						goto IL_1e2c;
						IL_1e2c:
						switch (num23)
						{
						default:
							goto end_IL_1e07;
						case 1:
							goto end_IL_1e07;
						case 2:
							break;
						case 0:
							goto end_IL_1e07;
						}
						goto IL_1e51;
						end_IL_1e07:;
					}
					goto case 24;
				case 75:
				{
					List<ModuleDTO> modules = importLicenseInfo2.Modules;
					ModuleDTO obj2 = new ModuleDTO
					{
						Id = (string)aJKWvhENiAaPdhKQ1Tw8(manifest)
					};
					ihtwXOENktR85X0E4iHC(obj2, IqRtZhE17pn25i9D9fqG(manifest));
					uANHrPENnIE3IMkMuXml(obj2, i9i9roE1xW3lOWfH6muS(manifest));
					obj2.Description = (string)e59JbAENOXg0vVwqR4kb(manifest);
					QMlTFpENeSh5rkwGxD0U(obj2, bAL107EN2FfD6UDXUcIG(manifest));
					modules.Add(obj2);
					num2 = 35;
					continue;
				}
				case 42:
					_003C_003Ec__DisplayClass68_.serverFolderName = (string)N88uShENuPBCoL2TD8ZG(exportImportFileManager, O2oXytE162AAMiZL2QmT(_003C_003Ec__DisplayClass68_.configImportSettings));
					num2 = 3;
					continue;
				case 27:
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088046400))));
					num2 = 81;
					continue;
				case 56:
					ob5fH5ENNFxkORnDxB5L(((ComponentManager)amDNUqENT4CF9WJPsTDh()).LicenseManager, key);
					num2 = 19;
					continue;
				case 14:
					activationKeys = null;
					num2 = 8;
					continue;
				case 52:
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoLose, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-561074844 ^ -561325256))));
					num2 = 55;
					continue;
				case 98:
					AddMessage(new DeployLogMessage(DeployLogMessageType.Info, SR.T((string)NUn1HRE1nboQISCQgj1B(-475857671 ^ -475619431), IqRtZhE17pn25i9D9fqG(manifest), i9i9roE1xW3lOWfH6muS(manifest)), endProcess: false));
					num2 = 43;
					continue;
				case 57:
					throw new InvalidOperationException((string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-1979251663 ^ -1979490099)));
				case 37:
					if (!(importSettings is TestModuleImportSettings))
					{
						num2 = 84;
						continue;
					}
					goto IL_3385;
				case 64:
					try
					{
						CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass68_3();
						int num4 = 62;
						while (true)
						{
							int num5;
							switch (num4)
							{
							case 57:
								TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -542004527))));
								num4 = 14;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
								{
									num4 = 69;
								}
								continue;
							case 68:
								if (!hKO1JNENoXjLkkOJaRkc(xmlReader2, NUn1HRE1nboQISCQgj1B(-70037984 ^ -69786030)))
								{
									num4 = 45;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
									{
										num4 = 73;
									}
									continue;
								}
								goto case 1;
							case 24:
								qlGUxwENGSOyZXd6OKWI(xmlReader2);
								num4 = 24;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
								{
									num4 = 37;
								}
								continue;
							case 75:
								flag = false;
								num4 = 76;
								continue;
							case 80:
								if (dTs50nENEjlYgpFBoeKx(xmlReader2, NUn1HRE1nboQISCQgj1B(-475857671 ^ -475901839)))
								{
									num4 = 74;
									continue;
								}
								goto case 60;
							case 34:
							case 36:
							case 38:
							case 55:
								qPNZx7ENFAG8vQyPD8WG(xmlReader2);
								num4 = 88;
								continue;
							case 35:
								if (!flag2)
								{
									num4 = 14;
									continue;
								}
								return;
							case 4:
								ReadServiceData(xmlReader2);
								num4 = 17;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
								{
									num4 = 75;
								}
								continue;
							case 67:
								xmlReader2.Skip();
								num4 = 87;
								continue;
							case 5:
							case 16:
								if (xmlReader2.NodeType == XmlNodeType.EndElement)
								{
									num4 = 35;
									continue;
								}
								goto case 48;
							case 42:
								hashSet.Add(result);
								num4 = 34;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
								{
									num4 = 34;
								}
								continue;
							case 37:
								WFMAx6E1zDIJWZIkcCR2(xmlReader2);
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
								{
									num4 = 5;
								}
								continue;
							case 87:
							case 92:
								WFMAx6E1zDIJWZIkcCR2(xmlReader2);
								num4 = 16;
								continue;
							default:
								if (metadataNotIsUnique.Contains(result))
								{
									num4 = 42;
									continue;
								}
								goto case 34;
							case 64:
								configImportActionExtensions.Each(delegate(IConfigImportActionExtension e)
								{
									int num32 = 1;
									int num33 = num32;
									while (true)
									{
										switch (num33)
										{
										default:
											return;
										case 0:
											return;
										case 1:
											ConfigurationImportExecutor._003C_003Ec__DisplayClass68_3.gGhujU8OpRaewvd3TroM(e, new PreStartTestImportParameters(CS_0024_003C_003E8__locals1.preStartMessages, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.testSystemMessages, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.serverFolderName, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.serviceData, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.manifest, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.importSettings));
											num33 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
											{
												num33 = 0;
											}
											break;
										}
									}
								});
								num4 = 59;
								continue;
							case 58:
								if (!flag)
								{
									num4 = 78;
									continue;
								}
								return;
							case 86:
								hKO1JNENoXjLkkOJaRkc(xmlReader2, NUn1HRE1nboQISCQgj1B(0x4EA5403C ^ 0x4EA5025E));
								num4 = 3;
								continue;
							case 17:
								xmlReader2.Read();
								num4 = 36;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
								{
									num4 = 39;
								}
								continue;
							case 51:
								if (RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(xmlReader2), NUn1HRE1nboQISCQgj1B(-210725949 ^ -210437909)))
								{
									num4 = 66;
									continue;
								}
								goto case 77;
							case 8:
								return;
							case 77:
								if (!RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(xmlReader2), NUn1HRE1nboQISCQgj1B(0x1C9495B4 ^ 0x1C90CA1E)))
								{
									num4 = 71;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
									{
										num4 = 50;
									}
									continue;
								}
								goto case 4;
							case 82:
								if (!MoveToConfigurationData(xmlReader2))
								{
									num4 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
									{
										num4 = 43;
									}
									continue;
								}
								goto case 10;
							case 94:
								return;
							case 47:
								if (!aHWlqJE1LYQIoxkGNkvB(xmlReader2))
								{
									num4 = 29;
									continue;
								}
								goto case 46;
							case 22:
								if (!xmlReader2.IsEmptyElement)
								{
									num4 = 28;
									continue;
								}
								break;
							case 49:
								if (!xmlReader2.IsStartElement())
								{
									num4 = 36;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
									{
										num4 = 38;
									}
									continue;
								}
								goto case 52;
							case 45:
								if (!(attribute != (string)NUn1HRE1nboQISCQgj1B(-1822890472 ^ -1822639874)))
								{
									num4 = 12;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
									{
										num4 = 4;
									}
									continue;
								}
								goto case 6;
							case 27:
							case 31:
								if (u8mPV3ENBOqyjN9FPD2H(xmlReader2) == XmlNodeType.EndElement)
								{
									num4 = 30;
									continue;
								}
								goto case 49;
							case 43:
								TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(0x20261A4F ^ 0x20226205))));
								num4 = 19;
								continue;
							case 72:
								flag2 = false;
								num4 = 24;
								continue;
							case 53:
								if (!WaSmnAE1cpYU3LOfjiR7(xmlReader2))
								{
									num4 = 12;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
									{
										num4 = 17;
									}
									continue;
								}
								goto case 29;
							case 59:
								CS_0024_003C_003E8__locals1.preStartMessages.Each(TestMessagesAdd);
								num4 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
								{
									num4 = 11;
								}
								continue;
							case 84:
								try
								{
									while (true)
									{
										IL_2765:
										int num9;
										if (!enumerator.MoveNext())
										{
											num9 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
											{
												num9 = 1;
											}
											goto IL_26ec;
										}
										goto IL_2706;
										IL_2706:
										current3 = enumerator.Current;
										num9 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
										{
											num9 = 3;
										}
										goto IL_26ec;
										IL_26ec:
										while (true)
										{
											switch (num9)
											{
											case 3:
												TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)NUn1HRE1nboQISCQgj1B(--1333735954 ^ 0x4F7B495E), current3)));
												num9 = 2;
												continue;
											case 2:
												goto IL_2765;
											case 1:
												goto end_IL_2765;
											}
											break;
										}
										goto IL_2706;
										continue;
										end_IL_2765:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
									int num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
									{
										num10 = 0;
									}
									switch (num10)
									{
									case 0:
										break;
									}
								}
								break;
							case 7:
								flag2 |= !ReadImportants(xmlReader2);
								num4 = 92;
								continue;
							case 74:
							case 79:
								qlGUxwENGSOyZXd6OKWI(xmlReader2);
								num4 = 22;
								continue;
							case 30:
								xmlReader2.Read();
								num5 = 9;
								goto IL_208f;
							case 52:
								if (RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(xmlReader2), NUn1HRE1nboQISCQgj1B(0x7459E02 ^ 0x741C00E)))
								{
									num4 = 44;
									continue;
								}
								goto case 34;
							case 23:
							case 32:
								if (u8mPV3ENBOqyjN9FPD2H(xmlReader2) == XmlNodeType.EndElement)
								{
									num4 = 90;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
									{
										num4 = 91;
									}
									continue;
								}
								goto case 47;
							case 29:
							case 65:
								qPNZx7ENFAG8vQyPD8WG(xmlReader2);
								num4 = 61;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
								{
									num4 = 44;
								}
								continue;
							case 66:
								if (WaSmnAE1cpYU3LOfjiR7(xmlReader2))
								{
									num4 = 81;
									continue;
								}
								goto case 72;
							case 60:
								TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)NUn1HRE1nboQISCQgj1B(-2106517564 ^ -2106233218))));
								num5 = 33;
								goto IL_208f;
							case 89:
								if (!CheckImportFileVersion(xmlReader2))
								{
									num4 = 63;
									continue;
								}
								goto case 68;
							case 83:
								if (!G6IvObENHaDGXd3JNhNm(result, O2TnhEEN6x3KU9P2j2aS(NUn1HRE1nboQISCQgj1B(-1870892489 ^ -1871181789))))
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 13;
							case 63:
								TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-35995181 ^ -35735877))));
								num4 = 94;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num4 = 56;
								}
								continue;
							case 39:
								xmlReader2.MoveToContent();
								num4 = 31;
								continue;
							case 26:
								if (RmoLaAE1sJvsY73orXow(text2, NUn1HRE1nboQISCQgj1B(-576149596 ^ -575866664)))
								{
									num4 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num4 = 3;
									}
									continue;
								}
								goto case 67;
							case 18:
								WFMAx6E1zDIJWZIkcCR2(xmlReader2);
								num4 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num4 = 32;
								}
								continue;
							case 9:
							case 61:
								WFMAx6E1zDIJWZIkcCR2(xmlReader2);
								num5 = 23;
								goto IL_208f;
							case 14:
							case 56:
							case 81:
								qlGUxwENGSOyZXd6OKWI(xmlReader2);
								num4 = 85;
								continue;
							case 2:
								WFMAx6E1zDIJWZIkcCR2(xmlReader2);
								num4 = 51;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
								{
									num4 = 19;
								}
								continue;
							case 93:
								try
								{
									while (true)
									{
										IL_2bae:
										int num6;
										if (!enumerator2.MoveNext())
										{
											num6 = 7;
											goto IL_2ab0;
										}
										goto IL_2b00;
										IL_2ab0:
										while (true)
										{
											switch (num6)
											{
											case 3:
												if (!Guid.TryParse(array[0], out result2))
												{
													num6 = 8;
													continue;
												}
												goto case 4;
											case 1:
												break;
											case 5:
												TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675749513), array[1], result2)));
												num6 = 10;
												continue;
											case 4:
												if (((AbstractNHEntityManager<IGlobalScriptModuleHeader, long>)vYexWXENwcwtw6XarFq3()).LoadOrNull(result2) == null)
												{
													num6 = 2;
													continue;
												}
												goto IL_2bae;
											case 8:
											case 9:
											case 10:
												goto IL_2bae;
											case 6:
											{
												array = (string[])VWELw0ENtJ0y07IMwnop(current2.Value, new string[1] { (string)NUn1HRE1nboQISCQgj1B(0x42643203 ^ 0x42604ABD) }, StringSplitOptions.None);
												int num7 = 3;
												num6 = num7;
												continue;
											}
											case 2:
												flag = true;
												num6 = 5;
												continue;
											default:
												if (!current2.Key.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A4176C)))
												{
													num6 = 9;
													continue;
												}
												goto case 6;
											case 7:
												goto end_IL_2bae;
											}
											break;
										}
										goto IL_2b00;
										IL_2b00:
										current2 = enumerator2.Current;
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
										{
											num6 = 0;
										}
										goto IL_2ab0;
										continue;
										end_IL_2bae:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
									{
										num8 = 0;
									}
									switch (num8)
									{
									case 0:
										break;
									}
								}
								goto case 58;
							case 76:
								enumerator2 = serviceData.GetEnumerator();
								num4 = 93;
								continue;
							case 90:
								return;
							case 70:
								qlGUxwENGSOyZXd6OKWI(xmlReader2);
								num4 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
								{
									num4 = 18;
								}
								continue;
							case 85:
								xmlReader2.MoveToContent();
								num4 = 77;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
								{
									num4 = 57;
								}
								continue;
							case 28:
								hashSet = new HashSet<Guid>();
								num4 = 70;
								continue;
							case 44:
								if (WaSmnAE1cpYU3LOfjiR7(xmlReader2))
								{
									num4 = 55;
									continue;
								}
								goto case 86;
							case 91:
								enumerator = hashSet.GetEnumerator();
								num4 = 84;
								continue;
							case 48:
								text2 = (string)zmwHRHE1UslqZB4OAIKq(xmlReader2);
								num4 = 26;
								continue;
							case 12:
							case 21:
							case 41:
							case 73:
								qlGUxwENGSOyZXd6OKWI(xmlReader2);
								num5 = 82;
								goto IL_208f;
							case 20:
							case 71:
							case 78:
								CS_0024_003C_003E8__locals1.preStartMessages = new List<TestImportMessages>();
								num4 = 20;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
								{
									num4 = 64;
								}
								continue;
							case 62:
								CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass68_;
								num4 = 89;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
								{
									num4 = 44;
								}
								continue;
							case 6:
								if (!xfWXwXENbk9MHTq6ErLw(attribute, NUn1HRE1nboQISCQgj1B(-1487388570 ^ -1487135082)))
								{
									num5 = 21;
									goto IL_208f;
								}
								goto case 15;
							case 3:
								if (!Guid.TryParse((string)bvLSv2ENhtbgyyFsrZvn(xmlReader2, NUn1HRE1nboQISCQgj1B(0x3A5D5EF ^ 0x3A5978D)), out result))
								{
									num4 = 36;
									continue;
								}
								goto case 83;
							case 10:
								qlGUxwENGSOyZXd6OKWI(xmlReader2);
								num4 = 2;
								continue;
							case 69:
								return;
							case 33:
								break;
							case 88:
								xmlReader2.MoveToContent();
								num5 = 27;
								goto IL_208f;
							case 11:
								if (!xmlReader2.ReadToNextSibling((string)NUn1HRE1nboQISCQgj1B(-281842504 ^ -281606302)))
								{
									num5 = 57;
									goto IL_208f;
								}
								goto case 54;
							case 19:
								return;
							case 15:
								TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, SR.T((string)NUn1HRE1nboQISCQgj1B(-2107978722 ^ -2107726600), attribute, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1ABDE8))));
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num4 = 41;
								}
								continue;
							case 13:
								TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-629844702 ^ -630116542))));
								num4 = 25;
								continue;
							case 1:
								attribute = xmlReader2.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867470873));
								num4 = 45;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
								{
									num4 = 43;
								}
								continue;
							case 46:
								if (RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(xmlReader2), NUn1HRE1nboQISCQgj1B(0x49E27B8A ^ 0x49E625E6)))
								{
									num4 = 53;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
									{
										num4 = 27;
									}
									continue;
								}
								goto case 29;
							case 54:
								metadataNotIsUnique = (from md in ((IMetadataService)rvE8WJEN4mZfQBu0yf1P()).GetMetadataList().OfType<EntityMetadata>()
									where !_003C_003Ec.EcUdVg8ncLSYjCNAtRoy(md)
									select _003C_003Ec.h1xSJq8nzriTrYakFL1T(md)).ToHashSet();
								num4 = 32;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
								{
									num4 = 40;
								}
								continue;
							case 40:
								metadataNotIsUnique.ExceptWith(ignoreIsUniqueMetadata.SelectMany((IIgnoreIsUniqueMetadata i) => i.GetIgnoredUids()));
								num4 = 80;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
								{
									num4 = 63;
								}
								continue;
							case 50:
								break;
								IL_208f:
								num4 = num5;
								continue;
							}
							break;
						}
					}
					finally
					{
						int num11;
						if (xmlReader2 == null)
						{
							num11 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
							{
								num11 = 0;
							}
							goto IL_311b;
						}
						goto IL_3131;
						IL_3131:
						GH8iJvE1KjBtdq7Mib6q(xmlReader2);
						num11 = 2;
						goto IL_311b;
						IL_311b:
						switch (num11)
						{
						default:
							goto end_IL_30f6;
						case 1:
							break;
						case 0:
							goto end_IL_30f6;
						case 2:
							goto end_IL_30f6;
						}
						goto IL_3131;
						end_IL_30f6:;
					}
					goto case 46;
				case 101:
					if (packagesBAChapter.Packages.Any())
					{
						num = 115;
						break;
					}
					goto case 18;
				case 4:
					return;
				case 30:
					if (serviceData == null)
					{
						num2 = 89;
						continue;
					}
					goto case 42;
				case 78:
					_003C_003Ec__DisplayClass68_.postCompleteMessages.Each(TestMessagesAdd);
					num2 = 63;
					continue;
				case 80:
					xQ7nFOENWZ1yyIBkqRi4(Logger.Log, string.Concat(NUn1HRE1nboQISCQgj1B(0x7C1EE318 ^ 0x7C1A87AE), storeComponentUnpackStatus));
					num2 = 57;
					continue;
				case 15:
					if (_003C_003Ec__DisplayClass68_.configImportSettings.Manifest != null)
					{
						num2 = 106;
						continue;
					}
					goto case 18;
				case 51:
					if (CFAxwhE10s00iyrA5l0u(manifest) == ElmaStoreComponentActivationType.Paid)
					{
						num2 = 62;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto IL_372c;
				case 35:
				{
					TestImportMessages testImportMessages = new TestImportMessages(TestImportMessagesType.UserAction, (string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(0x8317432 ^ 0x83507A4)));
					q5iAW0ENPtJmnbMGvfd7(testImportMessages, LicenseImportTestUserAction.UID);
					IFB9vrEN1cmMT8UtGtog(testImportMessages, importLicenseInfo2);
					TestMessagesAdd(testImportMessages);
					num2 = 38;
					continue;
				}
				case 32:
					_003C_003Ec__DisplayClass68_3.packagingComponent = packageService.GetComponent();
					num2 = 10;
					continue;
				case 43:
				case 49:
					if (manifest == null)
					{
						num2 = 61;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 85;
				default:
					testStep = 1;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 94;
					}
					continue;
				case 66:
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)NUn1HRE1nboQISCQgj1B(-1979251663 ^ -1979484761), elmaStoreComponentManifest.Version)));
					num2 = 83;
					continue;
				case 77:
					if (cO4itPEND26uBMYY4Xs3(importLicenseInfo.Modules) > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 45;
						}
						continue;
					}
					goto IL_07e9;
				case 50:
					return;
				case 107:
					if (!bPMAppManifest.Chapters.Any())
					{
						num2 = 90;
						continue;
					}
					goto case 15;
				case 63:
					return;
				case 26:
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)NUn1HRE1nboQISCQgj1B(0x12441CA4 ^ 0x12406E0A))));
					num2 = 53;
					continue;
				case 44:
					if (packagesBAChapter != null)
					{
						num2 = 61;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 101;
						}
						continue;
					}
					goto case 18;
				case 17:
					testStep = 2;
					num2 = 104;
					continue;
				case 88:
					if (iBPMApp == null)
					{
						num2 = 66;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 110;
						}
						continue;
					}
					goto case 117;
				case 12:
				{
					storeComponentUnpackStatus = UnpackIfSigned(key, ((IModuleManager)wCVyoYENSJwxquCkdonA(amDNUqENT4CF9WJPsTDh())).GetMainLicensedUnitExpiration, text, _003C_003Ec__DisplayClass68_.serverFolderName, out var _);
					num2 = 34;
					continue;
				}
				case 99:
					_003C_003Ec__DisplayClass68_.configImportSettings = importSettings as IConfigImportSettings;
					num2 = 20;
					continue;
				case 55:
					if (!XmlDataExists(_003C_003Ec__DisplayClass68_.configImportSettings))
					{
						num2 = 24;
						continue;
					}
					goto case 25;
				case 104:
					xmlReader = GetXmlReader(importSettings);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 59;
					}
					continue;
				case 76:
					if (elmaStoreComponentManifest != null)
					{
						num2 = 66;
						continue;
					}
					goto IL_0d7b;
				case 38:
					return;
				case 91:
					activationKeys = (from a in ((ILicenseManager)pNvvJOENVWNs5ykXnIr8(current)).GetActivationKeys()
						select a.Value).ToList();
					num2 = 109;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 74;
					}
					continue;
				case 31:
					packagesBAChapter = bPMAppManifest.Chapters.FirstOrDefault((BPMAppManifestChapter c) => _003C_003Ec.fDX8iv8nxqLWdLt7oMUH(c.Uid, PackageExportConsts.ExportExtensionUid)) as PackagesBAChapter;
					num2 = 44;
					continue;
				case 18:
				case 61:
				case 65:
				case 67:
				case 90:
				{
					ElmaStoreComponentManifest elmaStoreComponentManifest2 = manifest;
					if (elmaStoreComponentManifest2 == null)
					{
						num = 58;
						break;
					}
					obj = elmaStoreComponentManifest2.Packages.SelectMany((PackageManifest p) => p.Entities).Concat(manifest.Entities).Select(delegate(EntityManifest e)
					{
						EntityMetadata entityMetadata = new EntityMetadata();
						_003C_003Ec.Pc8ikw8nmKxtAYDlJtvj(entityMetadata, _003C_003Ec.QOGqEy8n0x7G08Jor3MN(e));
						_003C_003Ec.eG3IL88nMe65lGvbNvyp(entityMetadata, _003C_003Ec.WNLoOX8nySG4hFjPNasV(e));
						_003C_003Ec.dlZ3fF8n9xQ4oIgbHPyq(entityMetadata, _003C_003Ec.UEQNiF8nJOH9UT8lL0iT(e));
						_003C_003Ec.knEHlW8nlWm2yb0WZbxG(entityMetadata, _003C_003Ec.b60YKN8ndc9MC6kUGR5U(e));
						_003C_003Ec.Tp2hT28nroEHEWoODHko(entityMetadata, e.DisplayName);
						_003C_003Ec.GOQDYL8n5iPOGxRvBKo8(entityMetadata, (EntityMetadataType)_003C_003Ec.hsaT1U8ngRR9Ri28T2eH(e));
						return entityMetadata;
					})
						.Concat<IMetadata>(manifest.Packages.SelectMany((PackageManifest p) => p.Enums).Select(delegate(EnumManifest e)
						{
							EnumMetadata enumMetadata = new EnumMetadata();
							_003C_003Ec.Pc8ikw8nmKxtAYDlJtvj(enumMetadata, _003C_003Ec.KuAC7N8njKububY8ARxP(e));
							enumMetadata.Namespace = (string)_003C_003Ec.UBTTxC8nYeT7fR9QqDHu(e);
							_003C_003Ec.knEHlW8nlWm2yb0WZbxG(enumMetadata, _003C_003Ec.AnK8JO8nLb5cHv4GP9Ye(e));
							_003C_003Ec.Tp2hT28nroEHEWoODHko(enumMetadata, e.DisplayName);
							return enumMetadata;
						}))
						.ToArray();
					goto IL_36cf;
				}
				case 58:
					obj = null;
					goto IL_36cf;
				case 22:
					obj = Array.Empty<IMetadata>();
					goto IL_36f5;
				case 62:
					throw new InvalidOperationException((string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-787452571 ^ -787216019)));
				case 6:
					throw new InvalidOperationException((string)U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(-882126494 ^ -881871626)));
				case 84:
				{
					List<TestImportMessages> tagMessages;
					bool num3 = CheckManifestTag(out tagMessages);
					tagMessages?.ForEach(TestMessagesAdd);
					if (!num3)
					{
						num2 = 40;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num2 = 50;
						}
						continue;
					}
					goto IL_3385;
				}
				case 21:
				case 74:
					{
						TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, SR.T((string)NUn1HRE1nboQISCQgj1B(0x1FFEF86A ^ 0x1FFA8DB4), (manifest != null) ? manifest.Title : O2oXytE162AAMiZL2QmT(_003C_003Ec__DisplayClass68_.configImportSettings))));
						num2 = 97;
						continue;
					}
					IL_0d7b:
					bPMAppManifest = null;
					num2 = 102;
					continue;
					IL_36cf:
					if (obj == null)
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto IL_36f5;
					IL_3385:
					if (list.Count > 0)
					{
						num2 = 62;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 103;
						}
						continue;
					}
					goto case 21;
					IL_36f5:
					array2 = (IMetadata[])obj;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 33;
					}
					continue;
					IL_372c:
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, (string)((storeComponentUnpackStatus == StoreComponentUnpackStatus.Unsigned) ? U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269A3BBE)) : U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(0x4DC2B14D ^ 0x4DC6D29F)))));
					num2 = 72;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 32;
					}
					continue;
					IL_3531:
					serverFolderName = (string)obj5;
					num = 121;
					break;
					IL_07e9:
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoCommon, (string)U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710307610))));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	private bool CheckHash(string configFile, string hashFile)
	{
		//Discarded unreachable code: IL_00c7, IL_0122, IL_015a, IL_019a, IL_01a9, IL_01b5, IL_01c4, IL_01e5, IL_0225, IL_0234, IL_0240, IL_0286, IL_0295, IL_02a4, IL_02f9, IL_0331, IL_0350, IL_035f, IL_038c, IL_039b, IL_03bd, IL_03cc, IL_03f7, IL_0448, IL_0457
		int num = 2;
		int num2 = num;
		string text2 = default(string);
		FileStream fileStream = default(FileStream);
		bool result = default(bool);
		string text = default(string);
		TextReader textReader = default(TextReader);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					int num3;
					if (!File.Exists(configFile))
					{
						num3 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num3 = 2;
						}
						goto IL_0052;
					}
					goto IL_008c;
					IL_0052:
					while (true)
					{
						switch (num3)
						{
						case 7:
							goto IL_008c;
						case 11:
							try
							{
								SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
								{
									num6 = 1;
								}
								switch (num6)
								{
								case 1:
									try
									{
										text2 = (string)DwYPyeENJMBlG19Nl9wm(jIhUSpENMwCI2UuJor2X(sHA1CryptoServiceProvider.ComputeHash(fileStream)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EC02D4), string.Empty);
										int num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
										{
											num7 = 0;
										}
										switch (num7)
										{
										case 0:
											break;
										}
									}
									finally
									{
										int num8;
										if (sHA1CryptoServiceProvider == null)
										{
											num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
											{
												num8 = 0;
											}
											goto IL_015e;
										}
										goto IL_0174;
										IL_0174:
										((IDisposable)sHA1CryptoServiceProvider).Dispose();
										num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
										{
											num8 = 1;
										}
										goto IL_015e;
										IL_015e:
										switch (num8)
										{
										default:
											goto end_IL_0139;
										case 2:
											break;
										case 0:
											goto end_IL_0139;
										case 1:
											goto end_IL_0139;
										}
										goto IL_0174;
										end_IL_0139:;
									}
									break;
								case 0:
									break;
								}
							}
							finally
							{
								int num9;
								if (fileStream == null)
								{
									num9 = 2;
									goto IL_01e9;
								}
								goto IL_01ff;
								IL_01e9:
								switch (num9)
								{
								case 2:
									goto end_IL_01d4;
								case 1:
									goto end_IL_01d4;
								}
								goto IL_01ff;
								IL_01ff:
								GH8iJvE1KjBtdq7Mib6q(fileStream);
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
								{
									num9 = 1;
								}
								goto IL_01e9;
								end_IL_01d4:;
							}
							goto case 9;
						case 9:
							result = gDL7WbEN9nUHcnxq7pGd(text, text2);
							num3 = 2;
							continue;
						case 1:
							fileStream = File.OpenRead(configFile);
							num3 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num3 = 11;
							}
							continue;
						case 8:
							break;
						case 0:
							break;
						case 4:
							if (string.IsNullOrWhiteSpace(text))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 1;
						case 5:
							try
							{
								text = (string)Xywa7SENyRkpFZJniOQK(textReader);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
							finally
							{
								int num5;
								if (textReader == null)
								{
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
									{
										num5 = 2;
									}
									goto IL_0335;
								}
								goto IL_036a;
								IL_036a:
								GH8iJvE1KjBtdq7Mib6q(textReader);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
								{
									num5 = 0;
								}
								goto IL_0335;
								IL_0335:
								switch (num5)
								{
								default:
									goto end_IL_0310;
								case 2:
									goto end_IL_0310;
								case 1:
									break;
								case 0:
									goto end_IL_0310;
								}
								goto IL_036a;
								end_IL_0310:;
							}
							goto case 4;
						case 10:
							goto IL_03a6;
						case 6:
							break;
						case 3:
							break;
						case 2:
							return result;
						}
						break;
					}
					goto end_IL_0029;
					IL_03a6:
					textReader = new StreamReader(hashFile);
					num3 = 5;
					goto IL_0052;
					IL_008c:
					if (!File.Exists(hashFile))
					{
						int num10 = 6;
						num3 = num10;
						goto IL_0052;
					}
					goto IL_03a6;
					end_IL_0029:;
				}
				catch (Exception ex)
				{
					int num11 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num11 = 0;
					}
					while (true)
					{
						switch (num11)
						{
						default:
							VEOkEdENdZIh7FNhP5g6(ImportLog, NUn1HRE1nboQISCQgj1B(-218496594 ^ -218203046), ex);
							num11 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
							{
								num11 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				break;
			default:
				return true;
			case 1:
				break;
			}
			ImportLog.Info(NUn1HRE1nboQISCQgj1B(0x5DD55050 ^ 0x5DD12E46));
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
			{
				num2 = 0;
			}
		}
	}

	private bool CheckManifestTag(out List<TestImportMessages> tagMessages)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return tagService.ValidateTags(manifest, out tagMessages);
			case 1:
				tagMessages = new List<TestImportMessages>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (manifest != null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			return true;
		}
	}

	private void AddAdditionalFilesInBpmApp(Dictionary<string, string> serviceData, string serverFolderName, string helpFileName, out byte[] additionalFilesContent, out byte[] helpFileContent)
	{
		additionalFilesContent = null;
		helpFileContent = null;
		string text = Path.Combine(serverFolderName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345164918));
		serviceData.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A39D24), out var value);
		bool flag = value == z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7B4C8E);
		string fileFilter = null;
		if (helpFileName != null)
		{
			string path = Path.Combine(text, helpFileName);
			if (File.Exists(path))
			{
				helpFileContent = File.ReadAllBytes(path);
				fileFilter = (flag ? null : (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939374880) + helpFileName));
			}
		}
		if (text != null)
		{
			text = (flag ? Path.Combine(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7E51DA)) : text);
			if (Directory.Exists(text))
			{
				additionalFilesContent = ZipHelper.CreateZipByteArrayFromFolder(text, fileFilter);
			}
		}
	}

	private void AddMessage(DeployLogMessage message)
	{
		//Discarded unreachable code: IL_0042, IL_0051, IL_00b9, IL_00c8
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 5:
					if (Lhmt1VENl6iH7SZeC8q6(message))
					{
						num = 4;
						break;
					}
					goto case 6;
				case 2:
				case 3:
				case 7:
					messages.Add(message);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (!LjGLl0ENrhWxVqQkuvB3(message))
					{
						num = 3;
						break;
					}
					goto case 1;
				case 1:
				case 4:
				{
					EventHandler<EventArgs> onImportFinished = this.OnImportFinished;
					if (onImportFinished == null)
					{
						num2 = 2;
						continue;
					}
					onImportFinished(this, EventArgs.Empty);
					num2 = 7;
					continue;
				}
				}
				break;
			}
		}
	}

	private void ReadFilesSection(XmlReader reader)
	{
		//Discarded unreachable code: IL_01be, IL_01cd, IL_01ee, IL_0272, IL_028c, IL_031e, IL_032d
		int num = 10;
		string text = default(string);
		string text2 = default(string);
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		string value = default(string);
		ConfigImportSettings configImportSettings = default(ConfigImportSettings);
		Guid result2 = default(Guid);
		long result = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 12:
					reader.MoveToContent();
					num2 = 29;
					break;
				case 6:
					if (jgeG7iE1AJJVuAtTxp9u(Qv8oHUE1ge6GYP1mkdeN(text, text2)))
					{
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 11;
						}
						break;
					}
					goto case 3;
				case 21:
					dictionary.Add((string)zmwHRHE1UslqZB4OAIKq(reader), value);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 19;
					}
					break;
				case 10:
					if ((configImportSettings = importSettings as ConfigImportSettings) == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 9;
						}
						break;
					}
					goto case 26;
				case 17:
					mfQ9rOENjCvUksk7HY2H(exportImportFileManager, dictionary[(string)NUn1HRE1nboQISCQgj1B(-1886646897 ^ -1886618033)], Qv8oHUE1ge6GYP1mkdeN(text, text2), result2);
					num2 = 28;
					break;
				case 4:
					result2 = Guid.Empty;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 2;
					}
					break;
				case 11:
					if (Guid.TryParse(text2, out result2))
					{
						num2 = 7;
						break;
					}
					goto case 3;
				case 1:
					if (text2 == null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 27;
						}
						break;
					}
					goto case 11;
				case 23:
					value = (string)WnElerEN52wUNLnne5ls(reader);
					num2 = 21;
					break;
				case 14:
					WFMAx6E1zDIJWZIkcCR2(reader);
					num2 = 20;
					break;
				case 24:
					dictionary = new Dictionary<string, string>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					return;
				case 3:
				case 15:
				case 27:
					reader.Skip();
					num2 = 16;
					break;
				case 7:
					if (!(result2 != Guid.Empty))
					{
						goto end_IL_0012;
					}
					goto case 6;
				case 22:
					if (result != 1)
					{
						num2 = 25;
						break;
					}
					goto case 18;
				case 9:
					return;
				case 18:
					num3 = ((result == (long)step) ? 1 : 0);
					goto IL_03b4;
				case 2:
				{
					object s = bvLSv2ENhtbgyyFsrZvn(reader, NUn1HRE1nboQISCQgj1B(0x638095EB ^ 0x6384F5D9));
					result = 0L;
					long.TryParse((string)s, out result);
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 22;
					}
					break;
				}
				case 25:
					if (result == 2)
					{
						num2 = 18;
						break;
					}
					num3 = 1;
					goto IL_03b4;
				default:
					qlGUxwENGSOyZXd6OKWI(reader);
					num2 = 14;
					break;
				case 26:
					text2 = (string)bvLSv2ENhtbgyyFsrZvn(reader, NUn1HRE1nboQISCQgj1B(-3333094 ^ -3323000));
					num2 = 4;
					break;
				case 28:
					qlGUxwENGSOyZXd6OKWI(reader);
					num2 = 5;
					break;
				case 16:
					return;
				case 8:
					if (!reader.IsEmptyElement)
					{
						num2 = 23;
						break;
					}
					goto case 19;
				case 20:
				case 29:
					if (u8mPV3ENBOqyjN9FPD2H(reader) == XmlNodeType.EndElement)
					{
						num2 = 17;
						break;
					}
					goto case 13;
				case 13:
					if (!dictionary.ContainsKey(reader.Name))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 19;
				case 19:
					{
						qlGUxwENGSOyZXd6OKWI(reader);
						num2 = 12;
						break;
					}
					IL_03b4:
					text = Path.Combine((string)((YUlnlPENgwog33tJmm77(configImportSettings) == null) ? "" : Jax2EbENI7Y1CXYVG1TO(exportImportFileManager, YUlnlPENgwog33tJmm77(configImportSettings))), (string)NUn1HRE1nboQISCQgj1B(0x3630F361 ^ 0x363190A9));
					if (num3 == 0)
					{
						num2 = 15;
						break;
					}
					goto case 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private bool XmlDataExists(IImportSettings settings)
	{
		//Discarded unreachable code: IL_0047, IL_0056, IL_0066
		int num = 4;
		int num2 = num;
		ISystemImportSettings systemImportSettings = default(ISystemImportSettings);
		IConfigImportSettings configImportSettings = default(IConfigImportSettings);
		while (true)
		{
			switch (num2)
			{
			default:
				return !YJcXStENYHAJ5JquIdba(systemImportSettings.FileText);
			case 1:
				return false;
			case 2:
				return jgeG7iE1AJJVuAtTxp9u(LDpLgeE1J1pKeCQ2WwM1(exportImportFileManager, configImportSettings.FileName, NUn1HRE1nboQISCQgj1B(-87337865 ^ -87362609), NUn1HRE1nboQISCQgj1B(0x269E5FCA ^ 0x269A3FC8)));
			case 3:
				if ((systemImportSettings = settings as ISystemImportSettings) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 4:
				if ((configImportSettings = settings as IConfigImportSettings) == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	private XmlReader GetXmlReader(IImportSettings settings)
	{
		//Discarded unreachable code: IL_005f, IL_006e
		int num = 5;
		int num2 = num;
		string text = default(string);
		IConfigImportSettings configImportSettings = default(IConfigImportSettings);
		ISystemImportSettings systemImportSettings = default(ISystemImportSettings);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!jgeG7iE1AJJVuAtTxp9u(text))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return new XmlTextReader(text);
			case 5:
				if ((configImportSettings = settings as IConfigImportSettings) == null)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 2:
				return new XmlTextReader(new StringReader(string.Empty));
			case 4:
				if ((systemImportSettings = settings as ISystemImportSettings) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					break;
				}
				throw new NotSupportedException((string)MpC2ypENUEqLFvj8TIo2(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463E719E), settings.GetType().FullName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088047770)));
			default:
				text = (string)LDpLgeE1J1pKeCQ2WwM1(exportImportFileManager, O2oXytE162AAMiZL2QmT(configImportSettings), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548A0932), NUn1HRE1nboQISCQgj1B(-218496594 ^ -218209876));
				num2 = 3;
				break;
			case 1:
				return new XmlTextReader(new StringReader((string)D4A8O3ENLH2xyKgfYmjC(systemImportSettings)));
			}
		}
	}

	private bool CheckImportFileVersion(XmlReader reader)
	{
		//Discarded unreachable code: IL_00ef, IL_00f9, IL_0108, IL_0125, IL_0134, IL_0144, IL_0153, IL_01bb, IL_01f3, IL_0202
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass76_0 _003C_003Ec__DisplayClass76_ = default(_003C_003Ec__DisplayClass76_0);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass76_ = new _003C_003Ec__DisplayClass76_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass76_.reader = reader;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					int num3;
					if (_003C_003Ec__DisplayClass76_.reader == null)
					{
						num3 = 3;
						goto IL_008a;
					}
					goto IL_00b4;
					IL_0113:
					result = false;
					num3 = 7;
					goto IL_008a;
					IL_00b4:
					if (_003C_003Ec__DisplayClass76_.reader.IsStartElement())
					{
						int num4 = 5;
						num3 = num4;
						goto IL_008a;
					}
					goto IL_0113;
					IL_008a:
					while (true)
					{
						int num5;
						switch (num3)
						{
						case 4:
							num5 = (ExportImportVersion.SupportedVersion.Any(_003C_003Ec__DisplayClass76_._003CCheckImportFileVersion_003Eb__0) ? 1 : 0);
							goto IL_018f;
						case 1:
						case 3:
							goto IL_0113;
						case 5:
						case 6:
							if (!RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(_003C_003Ec__DisplayClass76_.reader), NUn1HRE1nboQISCQgj1B(-1217523399 ^ -1217761333)))
							{
								num3 = 4;
								continue;
							}
							num5 = 1;
							goto IL_018f;
						case 2:
							return result;
						case 7:
							{
								return result;
							}
							IL_018f:
							result = (byte)num5 != 0;
							num3 = 2;
							continue;
						}
						break;
					}
					goto IL_00b4;
				}
				catch (Exception)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							return result;
						}
						result = false;
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num6 = 1;
						}
					}
				}
			default:
				return result;
			}
		}
	}

	private bool CheckImportFiles(string serverFilesFileName, string serverFolderName)
	{
		//Discarded unreachable code: IL_00dd, IL_010a, IL_0132, IL_0195, IL_01a4, IL_0200, IL_0225, IL_0234, IL_0256, IL_0269, IL_0278, IL_030b, IL_0342, IL_0351, IL_0361, IL_03a7, IL_03df, IL_03ee, IL_041a, IL_047c
		int num = 5;
		int num2 = num;
		ConfigImportSettings configImportSettings = default(ConfigImportSettings);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Warning, (string)NUn1HRE1nboQISCQgj1B(0x92F12D5 ^ 0x92B6DC1)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (WfRkM4ENsNuDGjKyu6us(serverFolderName))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 7:
				return true;
			case 8:
				if (jgeG7iE1AJJVuAtTxp9u(serverFilesFileName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 5:
				if ((configImportSettings = importSettings as ConfigImportSettings) != null)
				{
					num2 = 4;
					break;
				}
				goto case 7;
			case 6:
				try
				{
					XmlTextReader xmlTextReader = new XmlTextReader(serverFilesFileName);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num3 = 1;
					}
					switch (num3)
					{
					case 1:
						try
						{
							int num4;
							if (xmlTextReader != null)
							{
								num4 = 15;
								goto IL_0136;
							}
							goto IL_02dc;
							IL_0136:
							while (true)
							{
								switch (num4)
								{
								case 3:
									return result;
								case 14:
									return result;
								default:
									goto end_IL_0136;
								case 18:
									qPNZx7ENFAG8vQyPD8WG(xmlTextReader);
									num4 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
									{
										num4 = 13;
									}
									continue;
								case 12:
									if (RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(xmlTextReader), NUn1HRE1nboQISCQgj1B(-1146510045 ^ -1146239739)))
									{
										num4 = 18;
										continue;
									}
									goto case 10;
								case 15:
									if (!aHWlqJE1LYQIoxkGNkvB(xmlTextReader))
									{
										num4 = 7;
										continue;
									}
									goto case 2;
								case 0:
									goto end_IL_0136;
								case 8:
								case 13:
									WFMAx6E1zDIJWZIkcCR2(xmlTextReader);
									num4 = 4;
									continue;
								case 5:
									qlGUxwENGSOyZXd6OKWI(xmlTextReader);
									num4 = 11;
									continue;
								case 2:
									if (!RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(xmlTextReader), NUn1HRE1nboQISCQgj1B(0xA592A41 ^ 0xA5D4A4D)))
									{
										num4 = 16;
										continue;
									}
									goto case 5;
								case 1:
									if (!aHWlqJE1LYQIoxkGNkvB(xmlTextReader))
									{
										num4 = 17;
										continue;
									}
									goto case 12;
								case 6:
								case 7:
								case 16:
									break;
								case 10:
								case 17:
									result = false;
									num4 = 14;
									continue;
								case 4:
								case 19:
									if (xmlTextReader.NodeType == XmlNodeType.EndElement)
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
										{
											num4 = 0;
										}
										continue;
									}
									goto case 1;
								case 11:
									xmlTextReader.MoveToContent();
									num4 = 19;
									continue;
								case 9:
									goto end_IL_0136;
								}
								goto IL_02dc;
								continue;
								end_IL_0136:
								break;
							}
							goto end_IL_0121;
							IL_02dc:
							result = false;
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
							{
								num4 = 2;
							}
							goto IL_0136;
							end_IL_0121:;
						}
						finally
						{
							if (xmlTextReader != null)
							{
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
								{
									num5 = 1;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										GH8iJvE1KjBtdq7Mib6q(xmlTextReader);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
										{
											num5 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						break;
					case 0:
						break;
					}
				}
				catch (Exception exception)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							return result;
						case 2:
							result = false;
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
							{
								num6 = 1;
							}
							break;
						default:
							ImportLog.Warn(NUn1HRE1nboQISCQgj1B(0x4EA5403C ^ 0x4EA13FB4), exception);
							num6 = 2;
							break;
						}
					}
				}
				goto case 7;
			case 4:
				if (YUlnlPENgwog33tJmm77(configImportSettings) != null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 7;
			default:
				num2 = 6;
				break;
			}
		}
	}

	private bool MoveToConfigurationData(XmlReader reader)
	{
		return dTs50nENEjlYgpFBoeKx(reader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787213607));
	}

	private ReadPacketResult ReadPacket(XmlReader reader, string contentType, string serverFolderName)
	{
		return new ReadPacketResult(this, reader, contentType, serverFolderName);
	}

	private void ReadModulePackage(string serverFolderName)
	{
		//Discarded unreachable code: IL_00d3, IL_00e2, IL_0114, IL_017a, IL_0261, IL_02a0, IL_0303, IL_0312, IL_0322, IL_0331, IL_0341, IL_03b5, IL_03c4, IL_0535
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		int num = 29;
		int num2 = num;
		string text2 = default(string);
		string text4 = default(string);
		string[] array2 = default(string[]);
		int num3 = default(int);
		int num5 = default(int);
		string text3 = default(string);
		string[] array3 = default(string[]);
		int num4 = default(int);
		string text = default(string);
		string text6 = default(string);
		string text5 = default(string);
		string[] array = default(string[]);
		string fileNameWithoutExtension = default(string);
		while (true)
		{
			object obj3;
			object obj;
			switch (num2)
			{
			case 33:
				text2 = string.Empty;
				num2 = 30;
				continue;
			case 4:
				return;
			case 22:
				obj3 = DSkm0rE3WOOlQmiPGhdr(NUn1HRE1nboQISCQgj1B(-1633514411 ^ -1633497513), text4, array2[num3]);
				break;
			case 32:
				return;
			case 6:
				obj = DSkm0rE3WOOlQmiPGhdr(NUn1HRE1nboQISCQgj1B(-1108654032 ^ -1108669902), text2, array2[num3]);
				goto IL_0558;
			case 14:
				if (num5 != 0)
				{
					num2 = 22;
					continue;
				}
				obj3 = array2[num3];
				break;
			case 18:
				num3++;
				num2 = 11;
				continue;
			case 20:
			case 24:
				text3 = array3[num4];
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 25;
				}
				continue;
			case 19:
			case 23:
			case 27:
				num4++;
				num2 = 2;
				continue;
			case 29:
				text = (string)Qv8oHUE1ge6GYP1mkdeN(serverFolderName, NUn1HRE1nboQISCQgj1B(-138018305 ^ -138255327));
				num2 = 28;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 4;
				}
				continue;
			case 2:
			case 15:
				if (num4 >= array3.Length)
				{
					return;
				}
				num2 = 20;
				continue;
			case 21:
				if (jgeG7iE1AJJVuAtTxp9u(text6))
				{
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 12;
					}
					continue;
				}
				goto case 31;
			case 36:
				text6 = (string)Qv8oHUE1ge6GYP1mkdeN(ynrRI4E3FQTH8nXqOERZ(packageService), text5);
				num2 = 21;
				continue;
			case 13:
			case 37:
				if (num3 != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 6;
					}
					continue;
				}
				obj = array2[num3];
				goto IL_0558;
			case 3:
				return;
			case 38:
				array3 = array;
				num2 = 26;
				continue;
			case 39:
				if (array.Length == 0)
				{
					return;
				}
				num2 = 38;
				continue;
			case 26:
				num4 = 0;
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 3;
				}
				continue;
			case 11:
			case 30:
				if (num3 < array2.Length)
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 5;
			default:
				if (num3 >= array2.Length)
				{
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 14;
			case 10:
				num5 = 0;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				continue;
			case 35:
				fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text3);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				num5++;
				num2 = 8;
				continue;
			case 9:
				array2 = (string[])VWELw0ENtJ0y07IMwnop(fileNameWithoutExtension, new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521271676) }, StringSplitOptions.RemoveEmptyEntries);
				num2 = 34;
				continue;
			case 25:
				text5 = (string)QWrRChENzCMMs9wwEEqI(text3);
				num2 = 36;
				continue;
			case 12:
			{
				if (!int.TryParse(array2[num3], out var _))
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				goto case 5;
			}
			case 16:
			{
				List<PackageOperationInfo> list = packagesOperations;
				PackageOperationInfo obj2 = new PackageOperationInfo
				{
					Package = new PackageInfo(text2)
				};
				ffg59cE3oNxWKmNKvRZW(obj2, PackageOperationType.Install);
				vDZinIE3bBM72FviGJOu(obj2, (object)new SemanticVersion(text4));
				list.Add(obj2);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 27;
				}
				continue;
			}
			case 1:
				if (fileNameWithoutExtension == null)
				{
					num2 = 23;
					continue;
				}
				goto case 9;
			case 34:
				num3 = 0;
				num2 = 33;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 31;
				}
				continue;
			case 28:
				if (WfRkM4ENsNuDGjKyu6us(text))
				{
					array = (string[])ySXa4YENcYfIMRLeSA9k(text, NUn1HRE1nboQISCQgj1B(0x7C1EE318 ^ 0x7C1FD070));
					num2 = 39;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 17;
					}
				}
				else
				{
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 32;
					}
				}
				continue;
			case 8:
				num3++;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 17;
				}
				continue;
			case 5:
				text4 = string.Empty;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 7;
				}
				continue;
			case 31:
				{
					nMEpdpE3BJjvSArRdtHY(text3, text6, true);
					num2 = 35;
					continue;
				}
				IL_0558:
				text2 = (string)obj;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 18;
				}
				continue;
			}
			text4 = (string)obj3;
			num2 = 7;
		}
	}

	public static void InitImportLicenseInfo(ImportLicenseInfo info)
	{
		//Discarded unreachable code: IL_0136, IL_0145, IL_01bd, IL_01cc, IL_021f, IL_022e, IL_0525, IL_0534, IL_0549
		int num = 13;
		IPrivilegeModuleAccessGroup privilegeModuleAccessGroup = default(IPrivilegeModuleAccessGroup);
		IModuleManager moduleManager = default(IModuleManager);
		uint? num3 = default(uint?);
		StringBuilder stringBuilder = default(StringBuilder);
		ILicenseInfo licenseInfo = default(ILicenseInfo);
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		IWorkplaceLicenseInfo workplaceLicenseInfo = default(IWorkplaceLicenseInfo);
		IConcurrentLicenseInfo concurrentLicenseInfo = default(IConcurrentLicenseInfo);
		_003C_003Ec__DisplayClass82_0 _003C_003Ec__DisplayClass82_ = default(_003C_003Ec__DisplayClass82_0);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				switch (num2)
				{
				case 4:
					if (privilegeModuleAccessGroup == null)
					{
						num2 = 11;
						continue;
					}
					goto end_IL_0012;
				case 28:
					if (moduleManager.MainApplication == null)
					{
						num2 = 47;
						continue;
					}
					goto case 17;
				case 40:
					if (num3.Value != 0)
					{
						num2 = 20;
						continue;
					}
					return;
				case 46:
					zr3ISrE3IwRcJKpkincc(info, stringBuilder.ToString());
					num2 = 26;
					continue;
				case 21:
					return;
				case 10:
					licenseInfo = (ILicenseInfo)pr84xXE3vuSplVKaukch(licensedUnit);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 1;
					}
					continue;
				case 36:
					workplaceLicenseInfo = licenseInfo as IWorkplaceLicenseInfo;
					num2 = 37;
					continue;
				case 43:
					if (concurrentLicenseInfo == null)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 6;
				case 13:
					_003C_003Ec__DisplayClass82_ = new _003C_003Ec__DisplayClass82_0();
					num2 = 12;
					continue;
				case 26:
					concurrentLicenseInfo = licenseInfo as IConcurrentLicenseInfo;
					num2 = 36;
					continue;
				default:
					info.UsedPrivilegeLicenseCount = concurrentLicenseInfo.UsedPrivilegeCount.ToString();
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					RVA8ZXE3q5etZY4wu2Ic(info, workplaceLicenseInfo.UsedLicenseCount.ToString());
					num2 = 34;
					continue;
				case 35:
					num3 = concurrentLicenseInfo.PrivilegeCount;
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 40;
					}
					continue;
				case 9:
					if (workplaceLicenseInfo != null)
					{
						num2 = 7;
						continue;
					}
					break;
				case 27:
					if (!WDeirNE3XThVD53aYsxc(info))
					{
						return;
					}
					num2 = 14;
					continue;
				case 2:
					goto end_IL_0012;
				case 25:
					num3 = concurrentLicenseInfo.PrivilegeCount;
					egd75hE3kwOaGVV31E1g(info, num3.Value.ToString());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 0;
					}
					continue;
				case 45:
					licenseInfo = null;
					num2 = 29;
					continue;
				case 41:
					if (l2HdSBE3uOQkOJJrUlJc(text) <= 40)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 16;
						}
						continue;
					}
					obj2 = text.Substring(40);
					goto IL_062e;
				case 18:
					if (_003C_003Ec__DisplayClass82_.licModule != null)
					{
						num2 = 3;
						continue;
					}
					goto case 11;
				case 14:
					cZTH1AE3if7RDq5QyRyr(info, U31rekE1XTLRckvqfYJR(NUn1HRE1nboQISCQgj1B(0x2ACE37D ^ 0x2A86371)));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 32;
					}
					continue;
				case 32:
					num3 = concurrentLicenseInfo.PrivilegeCount;
					num2 = 19;
					continue;
				case 31:
					if (licensedUnit == null)
					{
						num2 = 44;
						continue;
					}
					goto case 22;
				case 29:
					moduleManager = (IModuleManager)wCVyoYENSJwxquCkdonA(amDNUqENT4CF9WJPsTDh());
					num2 = 28;
					continue;
				case 37:
					_003C_003Ec__DisplayClass82_.licModule = rYnyfnE3fUT39boDCsoh(moduleManager) as IModule;
					num2 = 43;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 43;
					}
					continue;
				case 19:
					if (!num3.HasValue)
					{
						return;
					}
					num2 = 35;
					continue;
				case 5:
					stringBuilder = new StringBuilder();
					num2 = 42;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 38;
					}
					continue;
				case 22:
					l4EUDBE3CDYQuLHm1YDb(info, lMV2FKE3Qkd7fiCHkdG5(((ComponentManager)amDNUqENT4CF9WJPsTDh()).LicenseManager, licensedUnit));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					privilegeModuleAccessGroup = ComponentManager.Current.GetExtensionPoints<IPrivilegeModuleAccessGroup>().FirstOrDefault(_003C_003Ec__DisplayClass82_._003CInitImportLicenseInfo_003Eb__0);
					num2 = 4;
					continue;
				case 11:
				case 23:
				case 24:
					cZTH1AE3if7RDq5QyRyr(info, SR.T((string)NUn1HRE1nboQISCQgj1B(0x12A5FAC7 ^ 0x12A18525)));
					num2 = 9;
					continue;
				case 6:
					if (u1VlwfE3Vvv6XXFy4qS1(concurrentLicenseInfo))
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 11;
				case 30:
				case 42:
					if (text != null)
					{
						num2 = 39;
						continue;
					}
					goto case 46;
				case 17:
					licensedUnit = (ILicensedUnit)rYnyfnE3fUT39boDCsoh(moduleManager);
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					hWGvmDE3Gn4BXgHlN8qf(info, DSkm0rE3WOOlQmiPGhdr(NUn1HRE1nboQISCQgj1B(-398663332 ^ -398647540), VersionInfo.GetVersion<SR>(), zkdhuIE3hEJ98JPK6N2i()));
					num2 = 38;
					continue;
				case 16:
					obj2 = "";
					goto IL_062e;
				case 39:
					if (l2HdSBE3uOQkOJJrUlJc(text) > 0)
					{
						num2 = 15;
						continue;
					}
					goto case 46;
				case 1:
				case 44:
				case 47:
					text = ((ILicenseManager)pNvvJOENVWNs5ykXnIr8(amDNUqENT4CF9WJPsTDh())).GetActivationToken();
					num2 = 5;
					continue;
				case 20:
					yrJLSXE3Tq7N8OjOjMaQ(info, U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51118227)));
					num2 = 25;
					continue;
				case 38:
					XdBoeSE3EI4WaVJcU2WF(info, pNvvJOENVWNs5ykXnIr8(amDNUqENT4CF9WJPsTDh()) != null && ((ComponentManager)amDNUqENT4CF9WJPsTDh()).LicenseManager.CanAddActivationKey());
					num2 = 45;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 30;
					}
					continue;
				case 15:
				case 33:
					EVt4lWE3Z4jgF3siVdxl(stringBuilder, (text.Length > 40) ? s37kPhE38cDpKS0QOlgh(text, 0, 40) : text);
					num2 = 41;
					continue;
				case 7:
				{
					num3 = workplaceLicenseInfo.WorkplaceCount;
					object obj;
					if (!num3.HasValue)
					{
						obj = U31rekE1XTLRckvqfYJR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6380B011));
					}
					else
					{
						num3 = workplaceLicenseInfo.WorkplaceCount;
						obj = num3.Value.ToString();
					}
					R4vjBiE3RKMMkkWchZj5(info, obj);
					num2 = 8;
					continue;
				}
				case 34:
					break;
					IL_062e:
					text = (string)obj2;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 30;
					}
					continue;
				}
				u2JQ8TE3KuLB5woTtuJt(info, concurrentLicenseInfo != null && u1VlwfE3Vvv6XXFy4qS1(concurrentLicenseInfo));
				num2 = 27;
				continue;
				end_IL_0012:
				break;
			}
			StI3d3E3SWdqBuG1CPIC(info, privilegeModuleAccessGroup.UserGroupUid);
			num = 24;
		}
	}

	private ImportLicenseInfo CheckOrActivateModules(string serverFolderName, string key, out AppDomain domain)
	{
		//Discarded unreachable code: IL_00e1, IL_00f0, IL_012d, IL_017a, IL_0189, IL_0194, IL_0235, IL_026d, IL_027c, IL_0325, IL_0367, IL_0376, IL_0387, IL_04f7, IL_053c, IL_054b, IL_05c4, IL_05e7, IL_0645, IL_0658, IL_07c8, IL_083a, IL_0849, IL_08b0, IL_0938, IL_0a66, IL_0a99, IL_0ae1, IL_0af0, IL_0b00, IL_0b0f, IL_0b1f, IL_0b2e
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected O, but got Unknown
		int num = 27;
		AppDomainSetup appDomainSetup2 = default(AppDomainSetup);
		string text4 = default(string);
		string text6 = default(string);
		Func<bool> func = default(Func<bool>);
		_003C_003Ec__DisplayClass83_0 _003C_003Ec__DisplayClass83_ = default(_003C_003Ec__DisplayClass83_0);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string text = default(string);
		ZipFile val = default(ZipFile);
		IEnumerator enumerator2 = default(IEnumerator);
		string extension = default(string);
		ZipEntry val2 = default(ZipEntry);
		Stream inputStream = default(Stream);
		string item = default(string);
		string[] array = default(string[]);
		string text3 = default(string);
		string text2 = default(string);
		string text5 = default(string);
		string text7 = default(string);
		string[] array2 = default(string[]);
		int num10 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 16:
					domain = (AppDomain)lAe3WQE33xfUgRiWYcWJ(NUn1HRE1nboQISCQgj1B(-1978478350 ^ -1978249088), ((AppDomain)gwQA1rE3Nndgi8YrEZwR()).Evidence, appDomainSetup2);
					num2 = 9;
					continue;
				case 28:
					ykVT3tE3tC790lhiga1q(text4, text6);
					num2 = 35;
					continue;
				case 2:
					func();
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 35;
					}
					continue;
				case 42:
					return _003C_003Ec__DisplayClass83_.licenseInfo;
				case 8:
					try
					{
						while (true)
						{
							int num11;
							if (!fagugcE1aZARwy0aBgiG(enumerator))
							{
								num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
								{
									num11 = 0;
								}
								goto IL_0198;
							}
							goto IL_01d4;
							IL_01d4:
							string current = enumerator.Current;
							string text8 = (string)QWrRChENzCMMs9wwEEqI(current);
							string text9 = (string)Qv8oHUE1ge6GYP1mkdeN(text, text8);
							YfBbJ6E3aI5nH4HXCxZr(current, text9);
							num11 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num11 = 1;
							}
							goto IL_0198;
							IL_0198:
							switch (num11)
							{
							case 1:
								continue;
							case 2:
								goto IL_01d4;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num12 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num12 = 0;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									GH8iJvE1KjBtdq7Mib6q(enumerator);
									num12 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
									{
										num12 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 33;
				case 25:
					func = _003C_003Ec__DisplayClass83_._003CCheckOrActivateModules_003Eb__0;
					num2 = 15;
					continue;
				case 21:
					InitImportLicenseInfo(_003C_003Ec__DisplayClass83_.licenseInfo);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 30;
					}
					continue;
				case 18:
				case 46:
				{
					AppDomainSetup appDomainSetup = new AppDomainSetup();
					DaxF0tE3OVCDogElUtYY(appDomainSetup, text);
					RD6G2IE32tZ6WWHB8i0j(appDomainSetup, text);
					HECWolE31lnxxLyYETPX(appDomainSetup, au5T1vE3PTKkl3bxBXUX(iU4RPvE3eAKMa1rA7U2n(AppDomain.CurrentDomain)));
					appDomainSetup2 = appDomainSetup;
					num2 = 16;
					continue;
				}
				case 15:
					func();
					num2 = 23;
					continue;
				case 24:
					try
					{
						int num5;
						if (IsWebPackage(val))
						{
							num5 = 2;
							goto IL_0329;
						}
						goto IL_033f;
						IL_0329:
						switch (num5)
						{
						case 1:
							break;
						case 2:
							goto end_IL_030e;
						default:
							try
							{
								while (true)
								{
									int num6;
									if (!enumerator2.MoveNext())
									{
										num6 = 2;
										goto IL_0395;
									}
									goto IL_0584;
									IL_0395:
									while (true)
									{
										int num7;
										switch (num6)
										{
										case 1:
											if (geSxO0E30misVx4Vt1O4(extension, NUn1HRE1nboQISCQgj1B(0x6A81B9B4 ^ 0x6A85391C)))
											{
												num6 = 8;
												continue;
											}
											break;
										case 6:
											if (!string.IsNullOrEmpty(extension))
											{
												num6 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
												{
													num6 = 12;
												}
												continue;
											}
											break;
										case 4:
										{
											object obj2 = Qv8oHUE1ge6GYP1mkdeN(text, QWrRChENzCMMs9wwEEqI(MF5xjiE3xPNOhdufWexb(val2)));
											MBc4XVE3yDTVXnZtSs9B(obj2, u5VA1xE3mog8Xu1wLQiS(inputStream));
											item = (string)mNa1uSE3Mt801gueBUO4(obj2);
											num7 = 10;
											goto IL_0391;
										}
										case 7:
											if (!qGCeklE37t6LGeQZCmEi(val2))
											{
												num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
												{
													num6 = 0;
												}
												continue;
											}
											goto case 9;
										case 11:
											_003C_003Ec__DisplayClass83_.assembliesToCheck.Add(item);
											num7 = 3;
											goto IL_0391;
										case 10:
											if (_003C_003Ec__DisplayClass83_.assembliesToCheck.Contains(item))
											{
												num6 = 5;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
												{
													num6 = 3;
												}
												continue;
											}
											goto case 11;
										case 8:
											inputStream = val.GetInputStream(val2);
											num6 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
											{
												num6 = 0;
											}
											continue;
										case 12:
											if (!geSxO0E30misVx4Vt1O4(extension, NUn1HRE1nboQISCQgj1B(-477139494 ^ -477222560)))
											{
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
												{
													num6 = 1;
												}
												continue;
											}
											goto case 8;
										case 9:
											extension = Path.GetExtension((string)MF5xjiE3xPNOhdufWexb(val2));
											num6 = 6;
											continue;
										case 13:
											goto IL_0584;
										case 2:
											goto end_IL_056e;
											IL_0391:
											num6 = num7;
											continue;
										}
										break;
									}
									continue;
									IL_0584:
									val2 = (ZipEntry)cfnLh1E3Af4PkqaALQgI(enumerator2);
									num6 = 7;
									goto IL_0395;
									continue;
									end_IL_056e:
									break;
								}
							}
							finally
							{
								IDisposable disposable = enumerator2 as IDisposable;
								int num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
								{
									num8 = 0;
								}
								while (true)
								{
									switch (num8)
									{
									default:
										goto end_IL_05c8;
									case 0:
										goto end_IL_05c8;
									case 1:
										if (disposable == null)
										{
											num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
											{
												num8 = 0;
											}
											continue;
										}
										break;
									case 3:
										break;
									case 2:
										goto end_IL_05c8;
									}
									GH8iJvE1KjBtdq7Mib6q(disposable);
									num8 = 2;
									continue;
									end_IL_05c8:
									break;
								}
							}
							goto end_IL_030e;
						}
						goto IL_033f;
						IL_033f:
						enumerator2 = (IEnumerator)LuuQQsE3H65RBk43bu5R(val);
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num5 = 0;
						}
						goto IL_0329;
						end_IL_030e:;
					}
					finally
					{
						YcQHh2E3JrCY30spO8BU(val);
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					goto case 29;
				case 23:
					if (u1lVu1E1rkXXYmfryECy(key))
					{
						num2 = 44;
						continue;
					}
					goto case 31;
				default:
					return null;
				case 19:
					array = (string[])ySXa4YENcYfIMRLeSA9k(text3, NUn1HRE1nboQISCQgj1B(-740338220 ^ -740399428));
					num2 = 47;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 18;
					}
					continue;
				case 17:
					if (WfRkM4ENsNuDGjKyu6us(text3))
					{
						num2 = 19;
						continue;
					}
					goto default;
				case 14:
					text4 = (string)Qv8oHUE1ge6GYP1mkdeN(text2, text5);
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 41;
					}
					continue;
				case 1:
					return null;
				case 38:
					_003C_003Ec__DisplayClass83_.licenseInfo = new ImportLicenseInfo();
					num2 = 21;
					continue;
				case 36:
				case 44:
					w21D29E3lpbE9qfnZWe5(domain);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 3;
					}
					continue;
				case 27:
					_003C_003Ec__DisplayClass83_ = new _003C_003Ec__DisplayClass83_0();
					num2 = 26;
					continue;
				case 4:
					text7 = (string)nHIVMlE39gmKKIKiBkve(runtimeApplication.Configuration.Config);
					num = 20;
					break;
				case 32:
				case 40:
					val = new ZipFile(array2[num10]);
					num2 = 24;
					continue;
				case 9:
					text2 = (string)Qv8oHUE1ge6GYP1mkdeN(elHtqlE3pQ6pj78tTVYN(gwQA1rE3Nndgi8YrEZwR()), NUn1HRE1nboQISCQgj1B(0x4A1640F ^ 0x4A0583D));
					num = 45;
					break;
				case 22:
					Directory.CreateDirectory(text);
					num2 = 46;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 40;
					}
					continue;
				case 47:
					if (array.Length != 0)
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 38;
						}
						continue;
					}
					goto case 1;
				case 31:
					_003C_003Ec__DisplayClass83_.assemblyLoader.ActivateNewModules(_003C_003Ec__DisplayClass83_.licenseInfo.Modules, key);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					continue;
				case 39:
					num10 = 0;
					num2 = 13;
					continue;
				case 20:
					ISNyWuE3dTLeOKZTw7bt(_003C_003Ec__DisplayClass83_.assemblyLoader, text7);
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 10;
					}
					continue;
				case 41:
					text6 = Path.Combine(text, text5);
					num = 11;
					break;
				case 10:
					_003C_003Ec__DisplayClass83_.assembliesToCheck = new List<string>();
					num2 = 5;
					continue;
				case 35:
				case 43:
					_003C_003Ec__DisplayClass83_.assemblyLoader = (ImportAssemblyLoader)GhuDecE36Ef9966UwSEM(domain, VCxQFAE34XEFFvJrSBnh(LgMvBTE3wmR5Qgx3LDlf(typeof(ImportAssemblyLoader).TypeHandle).Assembly), LgMvBTE3wmR5Qgx3LDlf(typeof(ImportAssemblyLoader).TypeHandle).FullName);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				case 30:
					text = (string)h76qnTE3n6upSqpSRemL();
					num = 6;
					break;
				case 12:
					obj = NUn1HRE1nboQISCQgj1B(-1824388195 ^ -1824093437);
					goto IL_0b49;
				case 13:
				case 37:
					if (num10 < array2.Length)
					{
						num2 = 40;
						continue;
					}
					goto case 4;
				case 33:
					if (uGbiumE3DIEDV0IQ2XG6())
					{
						num2 = 7;
						continue;
					}
					goto case 12;
				case 11:
					if (!WfRkM4ENsNuDGjKyu6us(text4))
					{
						num2 = 43;
						continue;
					}
					goto case 28;
				case 5:
					array2 = array;
					num2 = 39;
					continue;
				case 6:
					if (WfRkM4ENsNuDGjKyu6us(text))
					{
						num = 18;
						break;
					}
					goto case 22;
				case 29:
					num10++;
					num2 = 37;
					continue;
				case 34:
					text3 = (string)Qv8oHUE1ge6GYP1mkdeN(serverFolderName, NUn1HRE1nboQISCQgj1B(-978351861 ^ -978588459));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 17;
					}
					continue;
				case 45:
					enumerator = ((IEnumerable<string>)ySXa4YENcYfIMRLeSA9k(text2, NUn1HRE1nboQISCQgj1B(0x68BBB53E ^ 0x68BAF1F8))).Union(Directory.GetFiles(text2, (string)NUn1HRE1nboQISCQgj1B(0x48A7E34A ^ 0x48A48F54))).GetEnumerator();
					num2 = 8;
					continue;
				case 26:
					domain = null;
					num2 = 34;
					continue;
				case 3:
					try
					{
						I1XIjTE3rnu3hFXIYVS5(text, true);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								((ILogger)MlNMGBE1y8ECm86WgVkD()).Error(ex.Message, ex);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 42;
				case 7:
					{
						obj = NUn1HRE1nboQISCQgj1B(-1088304168 ^ -1088160970);
						goto IL_0b49;
					}
					IL_0b49:
					text5 = (string)obj;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 14;
					}
					continue;
				}
				break;
			}
		}
	}

	private bool IsWebPackage(ZipFile zipFile)
	{
		return ((IEnumerable)zipFile).Cast<ZipEntry>().Any((ZipEntry zipEntry) => _003C_003Ec.r1FIcc8ObhgiTIAlgmvL(_003C_003Ec.sXLimj8Oo6v8qLnAGHaH(_003C_003Ec.oXVCk48OWoL4AgNdr4EU(zipEntry)), _003C_003Ec.kAx2j18nHeh7IC2RH0GP(-1459557599 ^ -1459283169)));
	}

	private void FillImportData()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				step = (ImportStep)h9ykD5E1Px7Gft1hHX4m(importSettings);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			default:
				serviceData = new Dictionary<string, string>();
				num2 = 2;
				break;
			case 3:
				savedPacketEntities = new List<IEntity>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 4:
				packetError = new List<string>();
				num2 = 3;
				break;
			}
		}
	}

	private void FillServices()
	{
	}

	private void ReadDictionary(XmlReader reader, IDictionary<string, string> dictionary)
	{
		if (!reader.IsEmptyElement)
		{
			reader.Read();
			reader.MoveToContent();
			while (reader.NodeType != XmlNodeType.EndElement)
			{
				dictionary.Add(reader.Name, reader.ReadElementString());
				reader.MoveToContent();
			}
		}
	}

	private bool ReadImportants(XmlReader reader)
	{
		//Discarded unreachable code: IL_0081, IL_0090, IL_01b2, IL_01c1, IL_01d1, IL_0298, IL_02a7
		int num = 17;
		int num2 = num;
		List<ImportantDataClass> list = default(List<ImportantDataClass>);
		ImportantDataClass importantDataClass = default(ImportantDataClass);
		HashSet<Guid> hashSet = default(HashSet<Guid>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				qlGUxwENGSOyZXd6OKWI(reader);
				num2 = 21;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return false;
			default:
				if (!WaSmnAE1cpYU3LOfjiR7(reader))
				{
					num2 = 19;
					break;
				}
				goto case 9;
			case 17:
				if (WaSmnAE1cpYU3LOfjiR7(reader))
				{
					num2 = 16;
					break;
				}
				qlGUxwENGSOyZXd6OKWI(reader);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 10;
				}
				break;
			case 20:
				if (xs3IY4E3gagKtaDBRDsN(list) != 0)
				{
					num2 = 15;
					break;
				}
				goto case 1;
			case 3:
				list = new List<ImportantDataClass>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 4;
				}
				break;
			case 16:
				return true;
			case 10:
				if (WaSmnAE1cpYU3LOfjiR7(reader))
				{
					return true;
				}
				num2 = 3;
				break;
			case 13:
				list.Add(importantDataClass);
				num2 = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 2;
				}
				break;
			case 11:
			case 18:
				WFMAx6E1zDIJWZIkcCR2(reader);
				num2 = 7;
				break;
			case 9:
			case 22:
				qPNZx7ENFAG8vQyPD8WG(reader);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 8;
				}
				break;
			case 12:
				qlGUxwENGSOyZXd6OKWI(reader);
				num2 = 19;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 20;
				}
				break;
			case 8:
				if (importantDataClass != null)
				{
					num2 = 13;
					break;
				}
				goto case 11;
			case 19:
				importantDataClass = ImportantDataClass.Read(reader, hashSet);
				num2 = 8;
				break;
			case 23:
				if (RmoLaAE1sJvsY73orXow(zmwHRHE1UslqZB4OAIKq(reader), NUn1HRE1nboQISCQgj1B(-1858887263 ^ -1858601419)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 9;
			case 6:
			case 7:
				if (u8mPV3ENBOqyjN9FPD2H(reader) == XmlNodeType.EndElement)
				{
					num2 = 12;
					break;
				}
				goto case 2;
			case 21:
				WFMAx6E1zDIJWZIkcCR2(reader);
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 14;
				}
				break;
			case 2:
				if (!aHWlqJE1LYQIoxkGNkvB(reader))
				{
					num2 = 9;
					break;
				}
				goto case 23;
			case 14:
				hashSet = importantData.Select((IImportantData d) => _003C_003Ec.D5121P8Oh3vARnG4gDIv(d)).ToHashSet();
				num2 = 6;
				break;
			case 1:
				return true;
			case 15:
				(from d in list
					group d by d.Module).ForEach(delegate(IGrouping<string, ImportantDataClass> g)
				{
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (g.Key == null) ? SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C4C2D5), g.Select((ImportantDataClass d) => (Version)_003C_003Ec.gt9AgC8OGZMbsEaLY5Jv(d)).Max()) : SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97676384), g.Key, g.Select((ImportantDataClass d) => (Version)_003C_003Ec.gt9AgC8OGZMbsEaLY5Jv(d)).Max())));
				});
				num2 = 5;
				break;
			}
		}
	}

	private void ReadServiceData(XmlReader reader)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				ReadDictionary(reader, serviceData);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private StoreComponentUnpackStatus UnpackIfSigned(string key, Func<DateTime?> getMainUnitExpiration, string componentPath, string serverFolderName, out IEnumerable<StoreComponentVerifiedSignature> signatures)
	{
		signatures = null;
		List<string> list = (from a in ComponentManager.Current.LicenseManager.GetActivationKeys()
			select a.Value).ToList();
		if (!string.IsNullOrEmpty(key))
		{
			list.Add(key);
		}
		StoreComponentUnpackStatus storeComponentUnpackStatus;
		try
		{
			storeComponentUnpackStatus = ElmaStoreComponentsBuilder.UnpackIfSigned(componentPath, serverFolderName, list, getMainUnitExpiration, out signatures);
		}
		catch (Exception exception)
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x511182A9), exception);
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C57B9F3)));
		}
		if (storeComponentUnpackStatus == StoreComponentUnpackStatus.WrongSignatures)
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7243835E) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A6DE32), from s in signatures
				where _003C_003Ec.bwBcww8OE4mSsowjXpM6(s) != StoreComponentSignatureStatus.Success
				select (string)_003C_003Ec.noSPbx8OQ3y6Kmpkv8kr(new object[4]
				{
					_003C_003Ec.kAx2j18nHeh7IC2RH0GP(--1867379187 ^ 0x6F4D0711),
					_003C_003Ec.Vdmxcl8OfbMtYaUFYclc(s),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5D02D1),
					_003C_003Ec.bwBcww8OE4mSsowjXpM6(s)
				})));
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269ADE36)));
		}
		return storeComponentUnpackStatus;
	}

	private IEnumerable<IReadMetadataResult> ReadMetadataBlock(XmlReader reader, bool isSystemMd, string serverFolderName, bool isTestRead = false)
	{
		List<IReadMetadataResult> list = new List<IReadMetadataResult>();
		while (reader.NodeType != XmlNodeType.EndElement)
		{
			if (reader.IsStartElement())
			{
				if (reader.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939356594) && !reader.IsEmptyElement)
				{
					IReadMetadataResult readMetadataResult = ReadMetadata(reader, isSystemMd, serverFolderName, isTestRead);
					if (readMetadataResult != null)
					{
						list.Add(readMetadataResult);
					}
					reader.Read();
				}
				else
				{
					reader.Skip();
				}
			}
			reader.MoveToContent();
		}
		reader.Read();
		return list;
	}

	private IReadMetadataResult ReadMetadata(XmlReader reader, bool isSystemMd, string serverFolderName, bool isTestRead = false)
	{
		//Discarded unreachable code: IL_02f0, IL_02fa, IL_038a, IL_03c2, IL_03d1, IL_044a, IL_047c, IL_04d9, IL_04e8, IL_05c4, IL_05d3
		int num = 16;
		_003C_003Ec__DisplayClass93_0 _003C_003Ec__DisplayClass93_ = default(_003C_003Ec__DisplayClass93_0);
		Type type = default(Type);
		IMetadata metadata = default(IMetadata);
		string text = default(string);
		Dictionary<string, ICollection<string>> dictionary = default(Dictionary<string, ICollection<string>>);
		ICollection<string> value = default(ICollection<string>);
		string text3 = default(string);
		string text2 = default(string);
		IEnumerator<IPostEntityXmlSerializer> enumerator = default(IEnumerator<IPostEntityXmlSerializer>);
		IReadMetadataResult result = default(IReadMetadataResult);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!_003C_003Ec__DisplayClass93_.isTestRead)
					{
						num = 20;
						break;
					}
					goto IL_0563;
				case 19:
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)NUn1HRE1nboQISCQgj1B(0x12441CA4 ^ 0x12409F80)));
					num2 = 27;
					continue;
				case 25:
					WFMAx6E1zDIJWZIkcCR2(reader);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					if (type == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_0563;
				case 13:
					reader.Read();
					num2 = 6;
					continue;
				case 1:
					return null;
				case 20:
					TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)NUn1HRE1nboQISCQgj1B(0x4785BC0D ^ 0x47813EA3)));
					num2 = 13;
					continue;
				case 2:
					metadata = (IMetadata)ClassSerializationHelper.DeserializeObjectByXml(type, text);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 11;
					}
					continue;
				case 22:
					_003C_003Ec__DisplayClass93_.parameters = new ReadMetadataParameters(messages, systemMessages, importSettings, metadata, isSystemMd, dictionary, treeUid, mergeReplace, serviceData, headers, metadataNotIsUnique, manifestExecuteMetadata, serverFolderName, TestMessagesAdd);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 14;
					}
					continue;
				case 15:
					_003C_003Ec__DisplayClass93_.isTestRead = isTestRead;
					num2 = 4;
					continue;
				case 5:
					if (dictionary.TryGetValue(reader.Name, out value))
					{
						num = 18;
						break;
					}
					goto case 12;
				case 12:
					value = (dictionary[(string)zmwHRHE1UslqZB4OAIKq(reader)] = new List<string>());
					num2 = 7;
					continue;
				case 8:
					text3 = (string)s37kPhE38cDpKS0QOlgh(text2, 0, LWLaFGE3YKC3tacalwLC(text2, NUn1HRE1nboQISCQgj1B(0x3B36AB09 ^ 0x3B36E4CF)));
					num = 24;
					break;
				case 28:
					qlGUxwENGSOyZXd6OKWI(reader);
					num2 = 2;
					continue;
				case 21:
					if (!YJcXStENYHAJ5JquIdba(text2))
					{
						StringBuilder stringBuilder = new StringBuilder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671960029));
						EVt4lWE3Z4jgF3siVdxl(stringBuilder, text2);
						text = stringBuilder.ToString();
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 23;
						}
					}
					else
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 5;
						}
					}
					continue;
				case 26:
					try
					{
						while (true)
						{
							int num5;
							if (!fagugcE1aZARwy0aBgiG(enumerator))
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
								{
									num5 = 0;
								}
								goto IL_02fe;
							}
							goto IL_033a;
							IL_033a:
							text = (string)mH9gipE3sSBJNLUNY90m(enumerator.Current, text);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num5 = 1;
							}
							goto IL_02fe;
							IL_02fe:
							switch (num5)
							{
							case 1:
								continue;
							case 2:
								goto IL_033a;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									GH8iJvE1KjBtdq7Mib6q(enumerator);
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num6 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 28;
				case 4:
					dictionary = new Dictionary<string, ICollection<string>>();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					text2 = reader.Value;
					num2 = 8;
					continue;
				case 7:
				case 18:
					value.Add((string)gbAjsZE35XTpSPuhb4Ji(reader));
					num2 = 17;
					continue;
				case 24:
					try
					{
						type = p3aaDkE3LJCUmSmwFnp4(text3);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								result = null;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
								{
									num4 = 2;
								}
								break;
							default:
								qlGUxwENGSOyZXd6OKWI(reader);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
								{
									num4 = 1;
								}
								break;
							case 2:
								return result;
							}
						}
					}
					goto case 11;
				case 16:
					_003C_003Ec__DisplayClass93_ = new _003C_003Ec__DisplayClass93_0();
					num2 = 15;
					continue;
				case 27:
					qlGUxwENGSOyZXd6OKWI(reader);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					if (!pG0aarE3jtcrZQvAaRpl(reader))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 5;
				case 23:
					enumerator = postEntityXmlSerializers.GetEnumerator();
					num2 = 26;
					continue;
				case 6:
					return null;
				case 9:
					qlGUxwENGSOyZXd6OKWI(reader);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 25;
					}
					continue;
				case 3:
					if (reader.MoveToFirstAttribute())
					{
						num2 = 5;
						continue;
					}
					goto case 9;
				case 14:
					{
						return configImportActionExtensions.Select(_003C_003Ec__DisplayClass93_._003CReadMetadata_003Eb__0).FirstOrDefault((IReadMetadataResult r) => r != null);
					}
					IL_0563:
					text2 = (string)QppVMhE3U3kqyr85inJF(text2, 0, LWLaFGE3YKC3tacalwLC(text2, NUn1HRE1nboQISCQgj1B(-1822890472 ^ -1822905890)));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 21;
					}
					continue;
				}
				break;
			}
		}
	}

	static ConfigurationImportExecutor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				hD9alfE3cxTo6Tnfy69c();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				XmlProperty = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521494652);
				num2 = 4;
				break;
			case 1:
				RegularProperty = (string)NUn1HRE1nboQISCQgj1B(-2138160520 ^ -2138390054);
				num2 = 3;
				break;
			case 4:
				ImportLog = (ILogger)pGiZqqE3z2nY8LZD6YWD(NUn1HRE1nboQISCQgj1B(-1487388570 ^ -1487092808));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool FANZfME1I8C8VZ6YVovO()
	{
		return hMiB5FE1uQm4WfVepvcS == null;
	}

	internal static ConfigurationImportExecutor nbPBStE1Va2j339T5FtE()
	{
		return hMiB5FE1uQm4WfVepvcS;
	}

	internal static object U5UHMaE1S4JqtTam5itl(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).BPMAppManifest;
	}

	internal static object GvRGdQE1iuAiuxD2PxRf(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Id;
	}

	internal static object mnstkKE1RmbkZ8XHtSpt()
	{
		return CallContextSessionOwner.Create();
	}

	internal static void xqZoL9E1ql5fDD155gNy(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunBySystemUser((Action)P_1);
	}

	internal static void GH8iJvE1KjBtdq7Mib6q(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object U31rekE1XTLRckvqfYJR(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void jUdVKCE1TQNJBY9uYmb9(object P_0, object P_1)
	{
		((TestImportMessages)P_0).Text = (string)P_1;
	}

	internal static void wt62WtE1k42GRNSw2qm3(object P_0, TestImportMessagesType value)
	{
		((TestImportMessages)P_0).Type = value;
	}

	internal static object NUn1HRE1nboQISCQgj1B(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void mpPoVWE1OsoeCdWeb6OT(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object Ye6XkoE12l2wWmACTc0I(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void LHf4VrE1ediZPOJHUfPP(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static int h9ykD5E1Px7Gft1hHX4m(object P_0)
	{
		return ((IImportSettings)P_0).ImportStep;
	}

	internal static TestImportMessagesType yWhCiTE11R9j23tRJZIM(object P_0)
	{
		return ((TestImportMessages)P_0).Type;
	}

	internal static object Od4VdXE1NZR6dcJmVHKO(object P_0)
	{
		return ((TestImportMessages)P_0).Text;
	}

	internal static object Ylt4G6E13n0iSBWhEp4K(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void Y2royjE1plb4gjxp3MMP(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static bool fagugcE1aZARwy0aBgiG(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool NWvLyhE1D9UIVRmgX9sH()
	{
		return MetadataImportHelper.IsRestartNeeded();
	}

	internal static bool xeCFBvE1tQFZShmibxRV(object P_0)
	{
		return ((RunWithSoftDeletableService)P_0).Turned;
	}

	internal static void CI84eLE1w15ESyMY8UaR(object P_0, bool value)
	{
		((RunWithSoftDeletableService)P_0).Turned = value;
	}

	internal static long NCSjPOE14LFcERlhbSPn(object P_0)
	{
		return ((IRunImportParameters)P_0).SignedUserId;
	}

	internal static object O2oXytE162AAMiZL2QmT(object P_0)
	{
		return ((IConfigImportSettings)P_0).FileName;
	}

	internal static object Y12gHtE1HlUGeXH6LxZY(object P_0, object P_1)
	{
		return ((IExportImportFileManager)P_0).CreateZipFileName((string)P_1);
	}

	internal static bool jgeG7iE1AJJVuAtTxp9u(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object IqRtZhE17pn25i9D9fqG(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Title;
	}

	internal static object i9i9roE1xW3lOWfH6muS(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Version;
	}

	internal static ElmaStoreComponentActivationType CFAxwhE10s00iyrA5l0u(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).ActivationType;
	}

	internal static object wvWV5EE1m0sGgDNVcSf3(object P_0, object P_1, object P_2)
	{
		return ((IZipService)P_0).ExtractZipFolder((string)P_1, (string)P_2);
	}

	internal static object MlNMGBE1y8ECm86WgVkD()
	{
		return Logger.Log;
	}

	internal static object CJiYGKE1M9HgOO5j0vIa(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object LDpLgeE1J1pKeCQ2WwM1(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IExportImportFileManager)P_0).CreateFileName((string)P_1, (string)P_2, (string)P_3);
	}

	internal static object dYeXvrE19eZSUKAbx1sd(object P_0, object P_1)
	{
		return ((IExportImportFileManager)P_0).CreateFileName((string)P_1);
	}

	internal static CancellationToken hb8IciE1dPjQVL0HJ6Vx(object P_0)
	{
		return ((IRunImportParameters)P_0).CancellationToken;
	}

	internal static void Djk57qE1lBxyJ81fVK0Z(object P_0)
	{
		((PackageService)P_0).CheckInitialized();
	}

	internal static bool u1lVu1E1rkXXYmfryECy(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object Qv8oHUE1ge6GYP1mkdeN(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object UODdpwE15Qf06297AiTd(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Guid dXVsmmE1jF2iJ9LaQlCe()
	{
		return Guid.NewGuid();
	}

	internal static void ay0gPXE1YTK4wbO5QyYJ(object P_0, object P_1)
	{
		((DeployLogMessage)P_0).InstallInfo = (PackageInstallInfo)P_1;
	}

	internal static bool aHWlqJE1LYQIoxkGNkvB(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object zmwHRHE1UslqZB4OAIKq(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static bool RmoLaAE1sJvsY73orXow(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool WaSmnAE1cpYU3LOfjiR7(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static XmlNodeType WFMAx6E1zDIJWZIkcCR2(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static void qPNZx7ENFAG8vQyPD8WG(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType u8mPV3ENBOqyjN9FPD2H(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static void xQ7nFOENWZ1yyIBkqRi4(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static bool hKO1JNENoXjLkkOJaRkc(object P_0, object P_1)
	{
		return ((XmlReader)P_0).MoveToAttribute((string)P_1);
	}

	internal static bool xfWXwXENbk9MHTq6ErLw(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object bvLSv2ENhtbgyyFsrZvn(object P_0, object P_1)
	{
		return ((XmlReader)P_0).GetAttribute((string)P_1);
	}

	internal static bool qlGUxwENGSOyZXd6OKWI(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool dTs50nENEjlYgpFBoeKx(object P_0, object P_1)
	{
		return ((XmlReader)P_0).ReadToNextSibling((string)P_1);
	}

	internal static object XMrkgmENfovAAtbNS0Bw(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static bool xZ06MUENQJVAH6dS5LZK(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static bool X15jF8ENCq9JFFU7mBYM(object P_0, object P_1, object P_2)
	{
		return ((PacketVersionService)P_0).Check((string)P_1, (string)P_2);
	}

	internal static object AQbKojENvtPqGhFGxYCO(object P_0)
	{
		return ((List<long>)P_0).ToArray();
	}

	internal static void dyhjy5EN8VoqkehOYLQ1(object P_0)
	{
		P_0();
	}

	internal static int pKSQRRENZbYQwtPx8LrK(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static object N88uShENuPBCoL2TD8ZG(object P_0, object P_1)
	{
		return ((IExportImportFileManager)P_0).CreateFolderName((string)P_1);
	}

	internal static object Jax2EbENI7Y1CXYVG1TO(object P_0, object P_1)
	{
		return ((IExportImportFileManager)P_0).CreateDeployFolderName((string)P_1);
	}

	internal static object pNvvJOENVWNs5ykXnIr8(object P_0)
	{
		return ((ComponentManager)P_0).LicenseManager;
	}

	internal static object wCVyoYENSJwxquCkdonA(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object aJKWvhENiAaPdhKQ1Tw8(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Id;
	}

	internal static object CYvTT4ENRegxpcoT0NOp(object P_0, object P_1)
	{
		return ((BPMAppManager)P_0).LoadOrNull((string)P_1);
	}

	internal static bool rWCV4XENqkuvYHfu1rRG(object P_0)
	{
		return ((IBPMApp)P_0).Installed;
	}

	internal static object CxSgSmENKwdloll3Eqod(object P_0)
	{
		return ((IConfigImportSettings)P_0).Manifest;
	}

	internal static object uv1b8RENXhA4k0buxlZA(object P_0)
	{
		return ((IConfigImportSettings)P_0).FakeManifest;
	}

	internal static object amDNUqENT4CF9WJPsTDh()
	{
		return ComponentManager.Current;
	}

	internal static void ihtwXOENktR85X0E4iHC(object P_0, object P_1)
	{
		((ModuleDTO)P_0).Title = (string)P_1;
	}

	internal static void uANHrPENnIE3IMkMuXml(object P_0, object P_1)
	{
		((ModuleDTO)P_0).Version = (string)P_1;
	}

	internal static object e59JbAENOXg0vVwqR4kb(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Description;
	}

	internal static object bAL107EN2FfD6UDXUcIG(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Author;
	}

	internal static void QMlTFpENeSh5rkwGxD0U(object P_0, object P_1)
	{
		((ModuleDTO)P_0).Author = (string)P_1;
	}

	internal static void q5iAW0ENPtJmnbMGvfd7(object P_0, Guid value)
	{
		((TestImportMessages)P_0).UserActionType = value;
	}

	internal static void IFB9vrEN1cmMT8UtGtog(object P_0, object P_1)
	{
		((TestImportMessages)P_0).AditionalData = P_1;
	}

	internal static Guid ob5fH5ENNFxkORnDxB5L(object P_0, object P_1)
	{
		return ((ILicenseManager)P_0).AddActivationKey((string)P_1);
	}

	internal static object w3Hq0YEN31mFVeXGtS6c(object P_0)
	{
		return ((PackageService)P_0).Settings;
	}

	internal static object sQhYdaENpjrxWDDtmkLv(object P_0)
	{
		return FSTransaction.Create((string)P_0);
	}

	internal static void R23cfsENaQGrCoLhCNwv(object P_0, bool value)
	{
		((TestImportMessages)P_0).NeedInstallPackages = value;
	}

	internal static int cO4itPEND26uBMYY4Xs3(object P_0)
	{
		return ((List<ModuleDTO>)P_0).Count;
	}

	internal static object VWELw0ENtJ0y07IMwnop(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static object vYexWXENwcwtw6XarFq3()
	{
		return GlobalScriptModuleHeaderManager.Instance;
	}

	internal static object rvE8WJEN4mZfQBu0yf1P()
	{
		return MetadataServiceContext.Service;
	}

	internal static Guid O2TnhEEN6x3KU9P2j2aS(object P_0)
	{
		return Guid.Parse((string)P_0);
	}

	internal static bool G6IvObENHaDGXd3JNhNm(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool Kdm5EqENAXdSMui2cTaL(object P_0, object P_1)
	{
		return ((XmlReader)P_0).ReadToFollowing((string)P_1);
	}

	internal static int r9oW4AEN7HSk5JJgMoq0(object P_0)
	{
		return ((List<IReadMetadataResult>)P_0).Count;
	}

	internal static Guid GcF7yXENxNLhroPmfDBc(object P_0)
	{
		return ((XNodeWrapper)P_0).GetTypeUid();
	}

	internal static int cjH4cTEN0fYhlHDoay6K(object P_0)
	{
		return ((List<IEntityImportSaveActions>)P_0).Count;
	}

	internal static object Sdl6aMENmVGGrvXFIkq6(object P_0)
	{
		return ((XNodeWrapper)P_0).GetXmlReader();
	}

	internal static object Xywa7SENyRkpFZJniOQK(object P_0)
	{
		return ((TextReader)P_0).ReadLine();
	}

	internal static object jIhUSpENMwCI2UuJor2X(object P_0)
	{
		return BitConverter.ToString((byte[])P_0);
	}

	internal static object DwYPyeENJMBlG19Nl9wm(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool gDL7WbEN9nUHcnxq7pGd(object P_0, object P_1)
	{
		return string.Equals((string)P_0, (string)P_1);
	}

	internal static void VEOkEdENdZIh7FNhP5g6(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static bool Lhmt1VENl6iH7SZeC8q6(object P_0)
	{
		return ((DeployLogMessage)P_0).EndStage;
	}

	internal static bool LjGLl0ENrhWxVqQkuvB3(object P_0)
	{
		return ((DeployLogMessage)P_0).EndProcess;
	}

	internal static object YUlnlPENgwog33tJmm77(object P_0)
	{
		return ((ConfigImportSettings)P_0).FileName;
	}

	internal static object WnElerEN52wUNLnne5ls(object P_0)
	{
		return ((XmlReader)P_0).ReadString();
	}

	internal static void mfQ9rOENjCvUksk7HY2H(object P_0, object P_1, object P_2, Guid uid)
	{
		((IExportImportFileManager)P_0).LoadFileToCache((string)P_1, (string)P_2, uid);
	}

	internal static bool YJcXStENYHAJ5JquIdba(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object D4A8O3ENLH2xyKgfYmjC(object P_0)
	{
		return ((ISystemImportSettings)P_0).FileText;
	}

	internal static object MpC2ypENUEqLFvj8TIo2(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool WfRkM4ENsNuDGjKyu6us(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object ySXa4YENcYfIMRLeSA9k(object P_0, object P_1)
	{
		return Directory.GetFiles((string)P_0, (string)P_1);
	}

	internal static object QWrRChENzCMMs9wwEEqI(object P_0)
	{
		return Path.GetFileName((string)P_0);
	}

	internal static object ynrRI4E3FQTH8nXqOERZ(object P_0)
	{
		return ((PackageService)P_0).LocalRepositoryPath;
	}

	internal static void nMEpdpE3BJjvSArRdtHY(object P_0, object P_1, bool P_2)
	{
		File.Copy((string)P_0, (string)P_1, P_2);
	}

	internal static object DSkm0rE3WOOlQmiPGhdr(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void ffg59cE3oNxWKmNKvRZW(object P_0, PackageOperationType P_1)
	{
		((PackageOperationInfo)P_0).Type = P_1;
	}

	internal static void vDZinIE3bBM72FviGJOu(object P_0, object P_1)
	{
		((PackageOperationInfo)P_0).InstalledVersion = (SemanticVersion)P_1;
	}

	internal static object zkdhuIE3hEJ98JPK6N2i()
	{
		return VersionInfo.GetEdition();
	}

	internal static void hWGvmDE3Gn4BXgHlN8qf(object P_0, object P_1)
	{
		((ImportLicenseInfo)P_0).Version = (string)P_1;
	}

	internal static void XdBoeSE3EI4WaVJcU2WF(object P_0, bool value)
	{
		((ImportLicenseInfo)P_0).CanAddActivationKey = value;
	}

	internal static object rYnyfnE3fUT39boDCsoh(object P_0)
	{
		return ((IModuleManager)P_0).MainLicensedUnit;
	}

	internal static object lMV2FKE3Qkd7fiCHkdG5(object P_0, object P_1)
	{
		return ((ILicenseManager)P_0).GetRegistrationKey((ILicensedUnit)P_1);
	}

	internal static void l4EUDBE3CDYQuLHm1YDb(object P_0, object P_1)
	{
		((ImportLicenseInfo)P_0).RegistrationKey = (string)P_1;
	}

	internal static object pr84xXE3vuSplVKaukch(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static object s37kPhE38cDpKS0QOlgh(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object EVt4lWE3Z4jgF3siVdxl(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static int l2HdSBE3uOQkOJJrUlJc(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static void zr3ISrE3IwRcJKpkincc(object P_0, object P_1)
	{
		((ImportLicenseInfo)P_0).ActivationToken = (string)P_1;
	}

	internal static bool u1VlwfE3Vvv6XXFy4qS1(object P_0)
	{
		return ((IConcurrentLicenseInfo)P_0).IsConcurrent;
	}

	internal static void StI3d3E3SWdqBuG1CPIC(object P_0, Guid value)
	{
		((ImportLicenseInfo)P_0).PrivilegeAccessGroupUid = value;
	}

	internal static void cZTH1AE3if7RDq5QyRyr(object P_0, object P_1)
	{
		((ImportLicenseInfo)P_0).LicenseCountTitle = (string)P_1;
	}

	internal static void R4vjBiE3RKMMkkWchZj5(object P_0, object P_1)
	{
		((ImportLicenseInfo)P_0).LicenseCount = (string)P_1;
	}

	internal static void RVA8ZXE3q5etZY4wu2Ic(object P_0, object P_1)
	{
		((ImportLicenseInfo)P_0).UsedLicenseCount = (string)P_1;
	}

	internal static void u2JQ8TE3KuLB5woTtuJt(object P_0, bool value)
	{
		((ImportLicenseInfo)P_0).IsConcurrent = value;
	}

	internal static bool WDeirNE3XThVD53aYsxc(object P_0)
	{
		return ((ImportLicenseInfo)P_0).IsConcurrent;
	}

	internal static void yrJLSXE3Tq7N8OjOjMaQ(object P_0, object P_1)
	{
		((ImportLicenseInfo)P_0).PrivilegeLicenseCountTitle = (string)P_1;
	}

	internal static void egd75hE3kwOaGVV31E1g(object P_0, object P_1)
	{
		((ImportLicenseInfo)P_0).PrivilegeLicenseCount = (string)P_1;
	}

	internal static object h76qnTE3n6upSqpSRemL()
	{
		return IOExtensions.GetTempFileNameWithoutExtension();
	}

	internal static void DaxF0tE3OVCDogElUtYY(object P_0, object P_1)
	{
		((AppDomainSetup)P_0).ApplicationBase = (string)P_1;
	}

	internal static void RD6G2IE32tZ6WWHB8i0j(object P_0, object P_1)
	{
		((AppDomainSetup)P_0).PrivateBinPath = (string)P_1;
	}

	internal static object iU4RPvE3eAKMa1rA7U2n(object P_0)
	{
		return ((AppDomain)P_0).SetupInformation;
	}

	internal static object au5T1vE3PTKkl3bxBXUX(object P_0)
	{
		return ((AppDomainSetup)P_0).ConfigurationFile;
	}

	internal static void HECWolE31lnxxLyYETPX(object P_0, object P_1)
	{
		((AppDomainSetup)P_0).ConfigurationFile = (string)P_1;
	}

	internal static object gwQA1rE3Nndgi8YrEZwR()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object lAe3WQE33xfUgRiWYcWJ(object P_0, object P_1, object P_2)
	{
		return AppDomain.CreateDomain((string)P_0, (Evidence)P_1, (AppDomainSetup)P_2);
	}

	internal static object elHtqlE3pQ6pj78tTVYN(object P_0)
	{
		return ((AppDomain)P_0).BaseDirectory;
	}

	internal static void YfBbJ6E3aI5nH4HXCxZr(object P_0, object P_1)
	{
		File.Copy((string)P_0, (string)P_1);
	}

	internal static bool uGbiumE3DIEDV0IQ2XG6()
	{
		return Environment.Is64BitProcess;
	}

	internal static void ykVT3tE3tC790lhiga1q(object P_0, object P_1)
	{
		FileUtils.CopyDirectory((string)P_0, (string)P_1);
	}

	internal static Type LgMvBTE3wmR5Qgx3LDlf(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object VCxQFAE34XEFFvJrSBnh(object P_0)
	{
		return ((Assembly)P_0).FullName;
	}

	internal static object GhuDecE36Ef9966UwSEM(object P_0, object P_1, object P_2)
	{
		return ((AppDomain)P_0).CreateInstanceAndUnwrap((string)P_1, (string)P_2);
	}

	internal static object LuuQQsE3H65RBk43bu5R(object P_0)
	{
		return ((ZipFile)P_0).GetEnumerator();
	}

	internal static object cfnLh1E3Af4PkqaALQgI(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool qGCeklE37t6LGeQZCmEi(object P_0)
	{
		return ((ZipEntry)P_0).get_IsFile();
	}

	internal static object MF5xjiE3xPNOhdufWexb(object P_0)
	{
		return ((ZipEntry)P_0).get_Name();
	}

	internal static bool geSxO0E30misVx4Vt1O4(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static object u5VA1xE3mog8Xu1wLQiS(object P_0)
	{
		return ((Stream)P_0).ReadAllBytes();
	}

	internal static void MBc4XVE3yDTVXnZtSs9B(object P_0, object P_1)
	{
		File.WriteAllBytes((string)P_0, (byte[])P_1);
	}

	internal static object mNa1uSE3Mt801gueBUO4(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static void YcQHh2E3JrCY30spO8BU(object P_0)
	{
		((ZipFile)P_0).Close();
	}

	internal static object nHIVMlE39gmKKIKiBkve(object P_0)
	{
		return ((System.Configuration.Configuration)P_0).FilePath;
	}

	internal static void ISNyWuE3dTLeOKZTw7bt(object P_0, object P_1)
	{
		((ImportAssemblyLoader)P_0).InitComponentManager((string)P_1);
	}

	internal static void w21D29E3lpbE9qfnZWe5(object P_0)
	{
		AppDomain.Unload((AppDomain)P_0);
	}

	internal static void I1XIjTE3rnu3hFXIYVS5(object P_0, bool P_1)
	{
		Directory.Delete((string)P_0, P_1);
	}

	internal static int xs3IY4E3gagKtaDBRDsN(object P_0)
	{
		return ((List<ImportantDataClass>)P_0).Count;
	}

	internal static object gbAjsZE35XTpSPuhb4Ji(object P_0)
	{
		return ((XmlReader)P_0).Value;
	}

	internal static bool pG0aarE3jtcrZQvAaRpl(object P_0)
	{
		return ((XmlReader)P_0).MoveToNextAttribute();
	}

	internal static int LWLaFGE3YKC3tacalwLC(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static Type p3aaDkE3LJCUmSmwFnp4(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static object QppVMhE3U3kqyr85inJF(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static object mH9gipE3sSBJNLUNY90m(object P_0, object P_1)
	{
		return ((IPostEntityXmlSerializer)P_0).UndoReplace((string)P_1);
	}

	internal static void hD9alfE3cxTo6Tnfy69c()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object pGiZqqE3z2nY8LZD6YWD(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}

	internal static void tIfLGbEpFRVa2bFp3Zij(object P_0, object P_1)
	{
		((IConfigImportExtension)P_0).OnPreStartImport((PreStartImportParameters)P_1);
	}

	internal static object sScEJBEpBDW6U2w2MX2Z(object P_0)
	{
		return ((PackageManifest)P_0).Id;
	}

	internal static void popfIhEpWM61FuX4KaTF(object P_0, object P_1)
	{
		((IConfigImportActionExtension)P_0).OnPrePublish((PrePublishParameters)P_1);
	}

	internal static void nKImFUEpo4E81h5qigGH(object P_0, object P_1)
	{
		((IConfigImportExtension)P_0).OnImportSuccessfull((ImportSuccessfullParameters)P_1);
	}
}
