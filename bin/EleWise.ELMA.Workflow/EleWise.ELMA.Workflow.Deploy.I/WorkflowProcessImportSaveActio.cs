using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.DTO.Managers;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Plugins;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Deploy.Import;

public class WorkflowProcessImportSaveActions : EntityImportSaveActions
{
	private class WorkflowImportMetadata
	{
		internal static object mu8iunZ1gdOKCMktEJ6l;

		internal MergeReplace MergeReplace
		{
			[CompilerGenerated]
			get
			{
				return _003CMergeReplace_003Ek__BackingField;
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
					case 1:
						_003CMergeReplace_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		internal WorkflowImportMetadata(ImportEntityPreSaveData data)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			hj8gU7Z1PhQMynnePRT2();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				MergeReplace = (MergeReplace)(SkqXY2Z1XunTsRfZOOsQ(data) ?? new MergeReplace());
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
				{
					num = 1;
				}
			}
		}

		internal WorkflowImportMetadata(ImportTestReadData data)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			hj8gU7Z1PhQMynnePRT2();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					MergeReplace = data.MergeMDReplace ?? new MergeReplace();
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		internal static bool AAfGmXZ1B2U2l2muX6A5()
		{
			return mu8iunZ1gdOKCMktEJ6l == null;
		}

		internal static WorkflowImportMetadata UQTi5dZ1c88tnmaP7wV4()
		{
			return (WorkflowImportMetadata)mu8iunZ1gdOKCMktEJ6l;
		}

		internal static void hj8gU7Z1PhQMynnePRT2()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object SkqXY2Z1XunTsRfZOOsQ(object P_0)
		{
			return ((ImportEntityPreSaveData)P_0).MergeReplace;
		}
	}

	public const string UpdateProcessHeaderKey = "UpdateProcessHeader";

	public const string DeployProcessHeaderKey = "DeployProcessHeader";

	private IEnumerable<IInheriteEntityMetadataGuid> inheriteEntityMetadataGuids;

	public static readonly List<Guid> UIDs;

	private static Guid organizationItemType;

	private static Guid userGroupType;

	private static readonly ILogger ImportLog;

	private bool messagesOn;

	private List<TestImportMessages> testMessages;

	private static WorkflowProcessImportSaveActions YperNvzVlbuwQdUP5El;

	public WorkflowProcessImportSaveActions(IEnumerable<IInheriteEntityMetadataGuid> inheriteEntityMetadataGuids)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		messagesOn = true;
		base._002Ector();
		this.inheriteEntityMetadataGuids = inheriteEntityMetadataGuids;
	}

	public override bool IsSupported(Guid typeGuid)
	{
		return UIDs.Contains(typeGuid);
	}

	private void testMessagesAdd(TestImportMessages message)
	{
		//Discarded unreachable code: IL_0032, IL_0041
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
			case 2:
				if (!messagesOn)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			testMessages.Add(message);
			num2 = 3;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
			{
				num2 = 3;
			}
		}
	}

	private void testMessagesAdd(ICollection<TestImportMessages> message)
	{
		if (!messagesOn || message == null || !message.Any())
		{
			return;
		}
		message.ForEach(delegate(TestImportMessages m)
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
					testMessages.Add(m);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (m == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		});
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		WorkflowImportMetadata workflowImportMetadata = new WorkflowImportMetadata(data);
		testMessages = new List<TestImportMessages>();
		Dictionary<string, string> serviceData = data.ServiceData;
		if (!(entity is IWorkflowProcess workflowProcess))
		{
			return testMessages;
		}
		workflowProcess.VersionNumber = 0L;
		IProcessHeader header = workflowProcess.Header;
		List<string> list = new List<string>();
		if (workflowProcess.Context != null)
		{
			if (!Locator.GetServiceNotNull<IProcessHeaderDTOManager>().CheckProcessTableName(header?.Id ?? 0, (header != null && header.Parent != null) ? header.Parent.Id : 0, workflowProcess.Context.TableName, out var errorMessage))
			{
				ImportLog.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F90BB3), errorMessage, (header != null) ? header.Name : "", (header != null) ? header.Uid.ToString() : ""));
				testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, errorMessage));
			}
			list.Add(workflowProcess.Context.TableName);
		}
		if (workflowProcess.ProcessMetrics != null)
		{
			if (!Locator.GetServiceNotNull<IProcessHeaderDTOManager>().CheckProcessMetricTableName(header?.Id ?? 0, (header != null && header.Parent != null) ? header.Parent.Id : 0, workflowProcess.ProcessMetrics.TableName, out var errorMessage2))
			{
				ImportLog.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1002028028), errorMessage2, (header != null) ? header.Name : "", (header != null) ? header.Uid.ToString() : ""));
				testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, errorMessage2));
			}
			if (list.Contains(workflowProcess.ProcessMetrics.TableName))
			{
				errorMessage2 = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x18428BD3));
				ImportLog.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763743893), errorMessage2, (header != null) ? header.Name : "", (header != null) ? header.Uid.ToString() : ""));
				testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, errorMessage2));
			}
			else
			{
				list.Add(workflowProcess.ProcessMetrics.TableName);
			}
		}
		if (workflowProcess.InstanceMetrics != null)
		{
			if (!Locator.GetServiceNotNull<IProcessHeaderDTOManager>().CheckProcessInstanceMetricsTableName(header?.Id ?? 0, (header != null && header.Parent != null) ? header.Parent.Id : 0, workflowProcess.InstanceMetrics.TableName, out var errorMessage3))
			{
				ImportLog.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x559A02B8), errorMessage3, (header != null) ? header.Name : "", (header != null) ? header.Uid.ToString() : ""));
				testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, errorMessage3));
			}
			if (list.Contains(workflowProcess.InstanceMetrics.TableName))
			{
				errorMessage3 = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638152466));
				ImportLog.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862418142), errorMessage3, (header != null) ? header.Name : "", (header != null) ? header.Uid.ToString() : ""));
				testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, errorMessage3));
			}
			else
			{
				list.Add(workflowProcess.InstanceMetrics.TableName);
			}
		}
		IProcessHeader header2 = workflowProcess.Header;
		List<string> list2 = new List<string>();
		if (workflowProcess.Context != null)
		{
			if (!Locator.GetServiceNotNull<IProcessHeaderDTOManager>().CheckProcessClassName(header2?.Id ?? 0, (header2 != null && header2.Parent != null) ? header2.Parent.Id : 0, workflowProcess.Context.Name, out var errorMessage4))
			{
				ImportLog.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057769949), errorMessage4, (header2 != null) ? header2.Name : "", (header2 != null) ? header2.Uid.ToString() : ""));
				testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, errorMessage4));
			}
			list2.Add(workflowProcess.Context.Name);
		}
		if (workflowProcess.ProcessMetrics != null)
		{
			if (!Locator.GetServiceNotNull<IProcessHeaderDTOManager>().CheckProcessClassName(header2?.Id ?? 0, (header2 != null && header2.Parent != null) ? header2.Parent.Id : 0, workflowProcess.ProcessMetrics.Name, out var errorMessage5))
			{
				ImportLog.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--296112178 ^ 0x11A73B56), errorMessage5, (header2 != null) ? header2.Name : "", (header2 != null) ? header2.Uid.ToString() : ""));
				testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, errorMessage5));
			}
			if (list2.Contains(workflowProcess.ProcessMetrics.Name))
			{
				errorMessage5 = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x49428F46));
				ImportLog.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12E030E), errorMessage5, (header2 != null) ? header2.Name : "", (header2 != null) ? header2.Uid.ToString() : ""));
				testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, errorMessage5));
			}
			else
			{
				list2.Add(workflowProcess.ProcessMetrics.Name);
			}
		}
		if (workflowProcess.InstanceMetrics != null)
		{
			if (!Locator.GetServiceNotNull<IProcessHeaderDTOManager>().CheckProcessClassName(header2?.Id ?? 0, (header2 != null && header2.Parent != null) ? header2.Parent.Id : 0, workflowProcess.InstanceMetrics.Name, out var errorMessage6))
			{
				ImportLog.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D7A277), errorMessage6, (header2 != null) ? header2.Name : "", (header2 != null) ? header2.Uid.ToString() : ""));
				testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, errorMessage6));
			}
			if (list2.Contains(workflowProcess.InstanceMetrics.Name))
			{
				errorMessage6 = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393841358));
				ImportLog.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D522DB), errorMessage6, (header2 != null) ? header2.Name : "", (header2 != null) ? header2.Uid.ToString() : ""));
				testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, errorMessage6));
			}
			else
			{
				list2.Add(workflowProcess.InstanceMetrics.Name);
			}
		}
		CheckProcessContext(workflowImportMetadata, workflowProcess, data.MergeReplace, isTestRead: false);
		if (workflowProcess == null || workflowProcess.Diagram == null || workflowProcess.Diagram.Elements == null)
		{
			return testMessages;
		}
		foreach (InternalSubprocessElement item in workflowProcess.Diagram.Elements.OfType<InternalSubprocessElement>())
		{
			long? correctProcHeadId = GetCorrectProcHeadId(item.ProcessHeaderId, serviceData, item.Uid, workflowProcess.Uid);
			item.ProcessHeaderId = (correctProcHeadId.HasValue ? correctProcHeadId.Value : 0);
		}
		foreach (ExternalSubprocessElement item2 in workflowProcess.Diagram.Elements.OfType<ExternalSubprocessElement>())
		{
			long? correctProcHeadId2 = GetCorrectProcHeadId(item2.ProcessHeaderId, serviceData, item2.Uid, workflowProcess.Uid);
			item2.ProcessHeaderId = (correctProcHeadId2.HasValue ? correctProcHeadId2.Value : 0);
		}
		foreach (DocumentGenerationElement item3 in workflowProcess.Diagram.Elements.OfType<DocumentGenerationElement>())
		{
			if (item3.Templates == null)
			{
				continue;
			}
			foreach (DocumentGenerationTemplateInfo template in item3.Templates)
			{
				if (template.DocumentId.HasValue && template.DocumentId.HasValue)
				{
					string key = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C675B67), template.DocumentId);
					if (!serviceData.ContainsKey(key))
					{
						continue;
					}
					string input = serviceData[key];
					Guid result = Guid.Empty;
					if (!Guid.TryParse(input, out result) || !(result != Guid.Empty))
					{
						continue;
					}
					IDocument document = DocumentManager.Instance.LoadOrNull(result);
					if (document != null && document.Uid != Guid.Empty)
					{
						template.DocumentId = document.Id;
						continue;
					}
					template.DocumentId = null;
					key = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x738097E5), result);
					if (!serviceData.ContainsKey(key))
					{
						continue;
					}
					string input2 = serviceData[key];
					Guid result2 = Guid.Empty;
					if (!Guid.TryParse(input2, out result2) || !(result2 != Guid.Empty))
					{
						continue;
					}
					KeyValuePair<BinaryFile, bool> keyValuePair = DownloadBinaryFile(result2);
					if (keyValuePair.Key != null && keyValuePair.Key.Uid != Guid.Empty)
					{
						if (!keyValuePair.Value)
						{
							DataAccessManager.FileManager.SaveFile(keyValuePair.Key);
						}
						template.TemplateFileId = keyValuePair.Key.Uid.ToString();
						template.FileName = keyValuePair.Key.Name;
						template.TemplateType = GenerationTemplateType.File;
					}
				}
				else
				{
					if (string.IsNullOrWhiteSpace(template.TemplateFileId))
					{
						continue;
					}
					foreach (KeyValuePair<string, string> item4 in serviceData.Where((KeyValuePair<string, string> sd) => sd.Key.StartsWith(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x5599BC78))))
					{
						string[] array = item4.Key.Split('_');
						Guid result3 = Guid.Empty;
						if (array == null || array.Count() != 3 || !Guid.TryParse(array[1], out result3) || !(result3 != Guid.Empty) || !(array[2] == template.TemplateFileId))
						{
							continue;
						}
						KeyValuePair<BinaryFile, bool> keyValuePair2 = DownloadBinaryFile(result3);
						if (keyValuePair2.Key != null && keyValuePair2.Key.Uid != Guid.Empty)
						{
							if (!keyValuePair2.Value)
							{
								DataAccessManager.FileManager.SaveFile(keyValuePair2.Key);
							}
							template.TemplateFileId = keyValuePair2.Key.Uid.ToString();
							template.FileName = keyValuePair2.Key.Name;
						}
					}
				}
			}
		}
		RepairUserAdditionalSettings(workflowProcess.Context, serviceData);
		foreach (SwimlaneElement item5 in workflowProcess.Diagram.Elements.OfType<SwimlaneElement>())
		{
			if (item5.DepartmentId != 0L)
			{
				long? correctWorkerId = GetCorrectWorkerId(item5.DepartmentId, serviceData, organizationItemType);
				item5.DepartmentId = (correctWorkerId.HasValue ? correctWorkerId.Value : 0);
			}
			foreach (Worker worker in item5.Workers)
			{
				long? correctWorkerId2 = GetCorrectWorkerId(worker.WorkerId, serviceData, worker.WorkerType);
				worker.WorkerId = (correctWorkerId2.HasValue ? correctWorkerId2.Value : 0);
			}
			CheckSwmlineUser(item5, data, workflowProcess);
		}
		using (IEnumerator<FlowConnectorElement> enumerator8 = (from e in workflowProcess.Diagram.Elements.OfType<FlowConnectorElement>()
			where e.Recipients != null
			select e).GetEnumerator())
		{
			while (enumerator8.MoveNext())
			{
				_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
				CS_0024_003C_003E8__locals0.element = enumerator8.Current;
				List<Recipient> recipients = CS_0024_003C_003E8__locals0.element.Recipients;
				List<Recipient> list3 = new List<Recipient>();
				foreach (Recipient item6 in recipients)
				{
					long? correctWorkerId3 = GetCorrectWorkerId(item6.RecipientId, serviceData, item6.TypeUid);
					item6.RecipientId = (correctWorkerId3.HasValue ? correctWorkerId3.Value : 0);
					if (!correctWorkerId3.HasValue && item6.TypeUid == organizationItemType)
					{
						list3.Add(item6);
					}
				}
				list3.ForEach(delegate(Recipient r)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							CS_0024_003C_003E8__locals0.element.Recipients.Remove(r);
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
			}
		}
		foreach (UserTaskElement item7 in workflowProcess.Diagram.Elements.OfType<UserTaskElement>().Where(delegate(UserTaskElement e)
		{
			//Discarded unreachable code: IL_003e, IL_004d
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return ((TimeOfExecution)_003C_003Ec.ukZs5dZ19Zrd8DldAYV3(e)).Recipients != null;
				case 1:
					return false;
				case 2:
					if (_003C_003Ec.ukZs5dZ19Zrd8DldAYV3(e) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}))
		{
			foreach (Recipient recipient in item7.TimeOfExecution.Recipients)
			{
				long? correctWorkerId4 = GetCorrectWorkerId(recipient.RecipientId, serviceData, recipient.TypeUid);
				recipient.RecipientId = (correctWorkerId4.HasValue ? correctWorkerId4.Value : 0);
			}
		}
		foreach (IElementWithPropertyMap item8 in workflowProcess.Diagram.Elements.OfType<IElementWithPropertyMap>())
		{
			PropertyMap[] usingPropertyMap = item8.UsingPropertyMap;
			foreach (PropertyMap propertyMap in usingPropertyMap)
			{
				if (propertyMap == null)
				{
					continue;
				}
				foreach (PropertyMapItem item9 in propertyMap.Items)
				{
					if (item9.RightValue is EntityInfoBase)
					{
						if (item9.RightValue is EntityInfo entityInfo)
						{
							item9.RightValue = ReplaceEntityInfo(entityInfo);
						}
						if (item9.RightValue is EntityListInfo entityListInfo)
						{
							EntityListInfo entityListInfo2 = entityListInfo.Clone();
							entityListInfo.Items.Clear();
							entityListInfo.Items.AddRange(entityListInfo2.Items.Select(ReplaceEntityInfo));
						}
					}
				}
			}
		}
		return testMessages;
	}

	private EntityInfo ReplaceEntityInfo(EntityInfo entityInfo)
	{
		//Discarded unreachable code: IL_016e, IL_017d, IL_021a
		int num = 13;
		int num2 = num;
		IEntityManager entityManager = default(IEntityManager);
		Type typeByUidOrNull = default(Type);
		IEntity entity = default(IEntity);
		IMetadataRuntimeService service = default(IMetadataRuntimeService);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
			case 7:
			case 12:
				return entityInfo;
			case 5:
				if (entityManager != null)
				{
					num2 = 8;
					continue;
				}
				goto case 1;
			case 3:
				if (!PxrWqIz2U6LJAq09N0U(typeByUidOrNull, null))
				{
					num2 = 7;
					continue;
				}
				goto case 4;
			case 8:
				obj = OnG0RPziDk0s4vcMliQ(entityManager, idrJd0zFD0NYphBuixK(entityInfo));
				if (obj == null)
				{
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			case 9:
				if (pRHR1Rz7cL5ucmVWx4y(entityInfo.TypeUid, Guid.Empty))
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 1;
			default:
				if (entity != null)
				{
					num2 = 6;
					continue;
				}
				goto case 1;
			case 10:
				if (service != null)
				{
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 1;
			case 6:
			{
				EntityInfo entityInfo2 = new EntityInfo();
				Atn1MWzrSy3pmeCiYN9(entityInfo2, UNb54LzaYphOZMaOWra(entity).ToString());
				w1Q76kzePnZKlK5OyHR(entityInfo2, entity.ToString());
				EmJfZvzNZM3OGGeiPo3(entityInfo2, idrJd0zFD0NYphBuixK(entityInfo));
				ssYNIBzSq7FwPsPIvFZ(entityInfo2, UsR9OPzxAIC6yP9jP5q(entityInfo));
				entityInfo = entityInfo2;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 2:
				service = Locator.GetService<IMetadataRuntimeService>();
				num2 = 10;
				continue;
			case 14:
				typeByUidOrNull = service.GetTypeByUidOrNull(entityInfo.TypeUid);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 0;
				}
				continue;
			case 13:
				if (!pRHR1Rz7cL5ucmVWx4y(entityInfo.Uid, Guid.Empty))
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 12;
					}
					continue;
				}
				goto case 9;
			case 4:
				entityManager = (IEntityManager)l7AI71zo5EPdLYhMJRi(typeByUidOrNull);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
				{
					num2 = 4;
				}
				continue;
			case 11:
				obj = vI13GIzI6u5uK8bhIHw(entityManager, entityInfo.Id);
				break;
			}
			entity = obj as IEntity;
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
			{
				num2 = 0;
			}
		}
	}

	private void RepairUserAdditionalSettings(EntityMetadata md, Dictionary<string, string> serviceData)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals0.serviceData = serviceData;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		if (md == null || CS_0024_003C_003E8__locals0.serviceData == null || !CS_0024_003C_003E8__locals0.serviceData.Any())
		{
			return;
		}
		md.Properties.ForEach(delegate(PropertyMetadata prop)
		{
			//Discarded unreachable code: IL_0058, IL_008e, IL_009d
			int num3 = 7;
			int num4 = num3;
			EntityUserSettings entityUserSettings = default(EntityUserSettings);
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 6:
					entityUserSettings = _003C_003Ec__DisplayClass15_0.zJvNYeZ1GFeamnirEqV6(prop) as EntityUserSettings;
					num4 = 2;
					continue;
				case 5:
					return;
				case 0:
					return;
				case 4:
					return;
				case 7:
					if (prop == null)
					{
						return;
					}
					num4 = 6;
					continue;
				case 1:
					if (entityUserSettings.Workers == null)
					{
						num4 = 5;
						continue;
					}
					break;
				case 2:
					if (entityUserSettings == null)
					{
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
						{
							num4 = 0;
						}
						continue;
					}
					goto case 1;
				case 3:
					break;
				}
				entityUserSettings.Workers.ForEach(delegate(Worker worker)
				{
					int num5 = 2;
					int num6 = num5;
					long? correctWorkerId = default(long?);
					while (true)
					{
						switch (num6)
						{
						default:
							return;
						case 2:
							correctWorkerId = GetCorrectWorkerId(_003C_003Ec__DisplayClass15_0.amQmcvZ17tN8ZUahagpw(worker), CS_0024_003C_003E8__locals0.serviceData, _003C_003Ec__DisplayClass15_0.SJSIpcZ12LurOfOfBaX1(worker));
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
							{
								num6 = 1;
							}
							break;
						case 0:
							return;
						case 1:
							_003C_003Ec__DisplayClass15_0.WVlIOgZ1oaDnoRaOnZsg(worker, correctWorkerId.HasValue ? correctWorkerId.Value : 0);
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
							{
								num6 = 0;
							}
							break;
						}
					}
				});
				num4 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
				{
					num4 = 3;
				}
			}
		});
		md.TableParts.ForEach(delegate(TablePartMetadata tp)
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
					CS_0024_003C_003E8__locals0._003C_003E4__this.RepairUserAdditionalSettings(tp, CS_0024_003C_003E8__locals0.serviceData);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
	}

	private void AddProcessUpdate(IProcessHeader process, ImportTestReadResult result)
	{
		int num = 5;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 6:
					_003C_003Ec__DisplayClass16_.value = vdcCAozEFi8RYXPdhWx(process).ToString();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (result.SystemMessages.Any(_003C_003Ec__DisplayClass16_._003CAddProcessUpdate_003Eb__0))
					{
						return;
					}
					num2 = 3;
					continue;
				case 3:
					result.SystemMessages.Add(new DeploySystemMessage((string)Aid8G7z1OuP9W4kcHQg(-862330810 ^ -862417304), _003C_003Ec__DisplayClass16_.value));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
					num = 4;
					break;
				case 2:
					return;
				case 4:
					if (process != null)
					{
						result.Messages.Add(new TestImportMessages(TestImportMessagesType.InfoLose, SR.T((string)Aid8G7z1OuP9W4kcHQg(0x34EA50D4 ^ 0x34EB3DA0), kSZi6hzhCg6qiQ7wMVE(process))));
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					num = 2;
					break;
				}
				break;
			}
		}
	}

	private void CheckSwmlineUser(SwimlaneElement element, ImportEntityPreSaveData data, IWorkflowProcess process)
	{
		//Discarded unreachable code: IL_0118, IL_01b8, IL_021d, IL_0227, IL_0289, IL_0298, IL_02e3, IL_045a, IL_04c6, IL_04d5
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		_003C_003Ec__DisplayClass17_1 CS_0024_003C_003E8__locals0;
		Guid uid = default(Guid);
		bool flag = default(bool);
		EntityUserSettings entityUserSettings = default(EntityUserSettings);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		SwimlaneType swimlaneType = default(SwimlaneType);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
				num2 = 2;
				break;
			case 2:
				_003C_003Ec__DisplayClass17_.element = element;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_1();
					int num3 = 19;
					while (true)
					{
						int num4;
						object obj;
						switch (num3)
						{
						case 19:
							uid = ((IProcessHeader)ctsKTUzwT7e8b9h9yme(process)).Uid;
							num3 = 15;
							break;
						case 9:
							if (hhcHCuz4MYDckBKDH4x(_003C_003Ec__DisplayClass17_.element) > 0)
							{
								num3 = 23;
								break;
							}
							goto case 8;
						case 5:
						case 7:
						case 22:
						case 23:
							if (flag)
							{
								num3 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
								{
									num3 = 1;
								}
								break;
							}
							return;
						case 3:
							if (entityUserSettings != null)
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
								{
									num3 = 1;
								}
								break;
							}
							goto case 5;
						case 12:
							propertyMetadata = ((ClassMetadata)Ytr3ogzz37773qWR4CC(process)).Properties.FirstOrDefault(_003C_003Ec__DisplayClass17_._003CCheckSwmlineUser_003Eb__1);
							num3 = 7;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
							{
								num3 = 13;
							}
							break;
						case 17:
							if (swimlaneType != SwimlaneType.Dynamic)
							{
								num4 = 5;
								goto IL_0071;
							}
							goto case 12;
						case 4:
							return;
						case 21:
							CS_0024_003C_003E8__locals0.value = uid.ToString();
							num3 = 18;
							break;
						case 2:
							if (!data.SystemMessages.Any(delegate(DeploySystemMessage m)
							{
								int num6 = 1;
								int num7 = num6;
								while (true)
								{
									switch (num7)
									{
									case 1:
										if (!_003C_003Ec__DisplayClass17_1.jJoob6ZhZQgfuhUQJF2M(_003C_003Ec__DisplayClass17_1.uwbOfuZhKduAFxLfYGsv(m), _003C_003Ec__DisplayClass17_1.N6MlsPZhOvs8Ge1MMuMC(-148495695 ^ -148419351)))
										{
											return false;
										}
										num7 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
										{
											num7 = 0;
										}
										break;
									default:
										return (string)_003C_003Ec__DisplayClass17_1.JDB3EGZhvRNxgAXLxca1(m) == CS_0024_003C_003E8__locals0.value;
									}
								}
							}))
							{
								num3 = 16;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
								{
									num3 = 16;
								}
								break;
							}
							return;
						case 10:
							obj = null;
							goto IL_034d;
						case 18:
							flag = false;
							num3 = 6;
							break;
						case 6:
							swimlaneType = _003C_003Ec__DisplayClass17_.element.SwimlaneType;
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
							{
								num3 = 0;
							}
							break;
						case 13:
							if (propertyMetadata != null)
							{
								num3 = 14;
								break;
							}
							goto case 10;
						case 8:
							flag = true;
							num3 = 22;
							break;
						default:
							if (swimlaneType != 0)
							{
								num4 = 17;
								goto IL_0071;
							}
							goto case 9;
						case 15:
							if (_003C_003Ec__DisplayClass17_.element == null)
							{
								num3 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
								{
									num3 = 4;
								}
								break;
							}
							goto case 21;
						case 16:
							data.SystemMessages.Add(new DeploySystemMessage(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708068328), CS_0024_003C_003E8__locals0.value));
							num3 = 11;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
							{
								num3 = 8;
							}
							break;
						case 20:
							flag = true;
							num3 = 7;
							break;
						case 14:
							obj = AWUQw5OKKWpHulEdr54g(propertyMetadata) as EntityUserSettings;
							goto IL_034d;
						case 1:
						{
							List<Worker> workers = entityUserSettings.Workers;
							if (workers.Where((Worker a) => _003C_003Ec.ULeub6Z1jIDXZyU3V035(_003C_003Ec.vAwjJUZ1WLoMySpgm1pL(a), UserGroupDTO.MetadataUid)).Any((Worker a) => _003C_003Ec.Xu5uxyZ16oM1NxYoF5wK(Locator.GetServiceNotNull<IUserGroupDTOManager>(), _003C_003Ec.XAywRKZ1RQaeqfGSuG5f(a)) == null))
							{
								flag = true;
							}
							if (workers.Where((Worker a) => _003C_003Ec.vAwjJUZ1WLoMySpgm1pL(a) == _003C_003Ec.rtTgFFZ1qiq199S2htFV()).Any((Worker a) => _003C_003Ec.V1ZtQLZ13OPsVmbhFDYB(Locator.GetServiceNotNull<IOrganizationItemDTOManager>(), (int)a.WorkerId) == null))
							{
								num3 = 19;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
								{
									num3 = 20;
								}
								break;
							}
							goto case 5;
						}
						case 11:
							return;
							IL_0071:
							num3 = num4;
							break;
							IL_034d:
							entityUserSettings = (EntityUserSettings)obj;
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
							{
								num3 = 3;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							return;
						case 1:
							((ILogger)KbELBNOKOAlYvlwyVrbG()).Error(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75BAD659 ^ 0x75BBB8DB), RHUdEcOKZLjQY5btqJRt(ex)), ex);
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
							{
								num5 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			case 0:
				return;
			}
		}
	}

	public static long? GetCorrectWorkerId(long? workerId, Dictionary<string, string> serviceData, Guid workerType)
	{
		if (!workerId.HasValue)
		{
			return null;
		}
		if (workerType == organizationItemType)
		{
			string key = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398648499) + workerId;
			if (serviceData.ContainsKey(key) && Guid.TryParse(serviceData[key], out var result))
			{
				return Locator.GetServiceNotNull<OrganizationItemManager>().LoadOrNull(result)?.Id;
			}
		}
		if (workerType == userGroupType)
		{
			string key2 = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6D100E) + workerId;
			if (serviceData.ContainsKey(key2) && Guid.TryParse(serviceData[key2], out var result2))
			{
				return Locator.GetServiceNotNull<UserGroupManager>().LoadOrNull(result2)?.Id;
			}
		}
		return null;
	}

	private long? GetCorrectProcHeadId(long? subProcHeaderId, Dictionary<string, string> serviceData, Guid elementUid, Guid processUid)
	{
		if (subProcHeaderId.HasValue)
		{
			string key = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642672497) + subProcHeaderId;
			if (serviceData.ContainsKey(key) && Guid.TryParse(serviceData[key], out var result))
			{
				IProcessHeader processHeader = Locator.GetServiceNotNull<ProcessHeaderManager>().LoadOrNull(result);
				if (processHeader != null && processHeader.Id != 0L)
				{
					return processHeader.Id;
				}
			}
			key = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1360964419), elementUid);
			if (!serviceData.ContainsKey(key))
			{
				serviceData.Add(key, string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E81709), processUid.ToString(), subProcHeaderId));
			}
		}
		return null;
	}

	private KeyValuePair<BinaryFile, bool> DownloadBinaryFile(Guid uid)
	{
		if (uid != Guid.Empty)
		{
			try
			{
				BinaryFile binaryFile = DataAccessManager.FileManager.LoadFile(uid.ToString());
				_ = binaryFile.Name;
				return new KeyValuePair<BinaryFile, bool>(binaryFile, value: true);
			}
			catch (FileNotFoundException)
			{
				return new KeyValuePair<BinaryFile, bool>(Locator.GetServiceNotNull<ICacheFilesService>().GetBinaryFile(uid), value: false);
			}
		}
		return new KeyValuePair<BinaryFile, bool>(null, value: false);
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_0252, IL_02ec, IL_038d, IL_03bf, IL_042a, IL_045a, IL_048d, IL_0565, IL_06a3, IL_0918, IL_0948, IL_0957, IL_0963, IL_0972, IL_09fe, IL_0a0d, IL_0ad5, IL_0bc3, IL_0bd2, IL_0c32, IL_0c64, IL_0ccf, IL_0d01, IL_0d7c, IL_0d8b, IL_0e75, IL_0f2c, IL_1008, IL_1017, IL_10e9, IL_111b, IL_1186, IL_1195, IL_12f3, IL_131b, IL_1325, IL_139b, IL_13aa, IL_142d, IL_143c, IL_14ca, IL_14dd, IL_14ec, IL_1514, IL_155f, IL_1576, IL_15a6, IL_15d9, IL_1670, IL_16d3, IL_16e2, IL_176e, IL_17a5, IL_17b4, IL_1812, IL_1821, IL_1993, IL_19a2, IL_1a1f, IL_1a44, IL_1a53, IL_1b33, IL_1b42
		int num = 70;
		XmlReader xmlReader = default(XmlReader);
		Type type2 = default(Type);
		string text5 = default(string);
		Type type3 = default(Type);
		string text7 = default(string);
		string text4 = default(string);
		string text6 = default(string);
		XmlReader xmlReader2 = default(XmlReader);
		string text10 = default(string);
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
		List<Type> source = default(List<Type>);
		string text11 = default(string);
		string text8 = default(string);
		string text9 = default(string);
		string text2 = default(string);
		bool flag = default(bool);
		WorkflowImportMetadata workflowImportMetadata = default(WorkflowImportMetadata);
		ProcessContext processContext = default(ProcessContext);
		Guid result2 = default(Guid);
		string text = default(string);
		IProcessHeader processHeader = default(IProcessHeader);
		Type type = default(Type);
		string text3 = default(string);
		List<WorkflowForm>.Enumerator enumerator = default(List<WorkflowForm>.Enumerator);
		FormViewItemTransformation formViewItemTransformation = default(FormViewItemTransformation);
		IFormViewItemTransformation formViewItemTransformation2 = default(IFormViewItemTransformation);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 72:
					xmlReader.Read();
					num = 6;
					break;
				case 44:
					if (!xmlReader.IsEmptyElement)
					{
						num2 = 85;
						continue;
					}
					goto case 41;
				case 25:
					if (!(type2 == null))
					{
						num2 = 14;
						continue;
					}
					goto case 27;
				case 17:
					if (xmlReader.IsEmptyElement)
					{
						num2 = 21;
						continue;
					}
					goto case 57;
				case 108:
					owgVbxOKY7SyC83Kjwf0(xmlReader);
					num2 = 40;
					continue;
				case 68:
					text5 = (string)GRxwhFOKWbgpqh5oO0Bp(text5, 0, a84jMCOKuVAkadfcgJSL(text5, Aid8G7z1OuP9W4kcHQg(-1028861977 ^ -1028800575)));
					num2 = 58;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
					{
						num2 = 21;
					}
					continue;
				case 15:
				case 28:
				case 35:
					if (!dhDVWvOKlj2ft3XQooPR(xmlReader))
					{
						num2 = 39;
						continue;
					}
					goto case 48;
				case 45:
					xmlReader.MoveToContent();
					num2 = 19;
					continue;
				case 47:
				case 56:
				case 67:
					if (!string.IsNullOrWhiteSpace(text5))
					{
						num2 = 42;
						continue;
					}
					goto case 24;
				case 36:
					if (!PhAtTlOKsmBVyvEDowMO(xmlReader.Name, Aid8G7z1OuP9W4kcHQg(--1756698829 ^ 0x68B50855)))
					{
						num2 = 115;
						continue;
					}
					goto case 44;
				case 30:
					if (oOk0I8OKyfh61k77grgM(xmlReader))
					{
						num2 = 15;
						continue;
					}
					goto case 66;
				case 78:
					if ((string)RYFBXKOK0pqPhWBoW2xP(xmlReader) == (string)Aid8G7z1OuP9W4kcHQg(0x7AC609FE ^ 0x7AC6B804))
					{
						num2 = 30;
						continue;
					}
					goto case 15;
				case 7:
					try
					{
						type3 = pMc9UQOKnrq3Qwf2K8HD(text7);
						int num16 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
						{
							num16 = 0;
						}
						switch (num16)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num17 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
						{
							num17 = 0;
						}
						while (true)
						{
							switch (num17)
							{
							case 1:
								return;
							}
							testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(0x1C663DA1 ^ 0x1C674C37), new object[2] { text4, text6 })));
							num17 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
							{
								num17 = 1;
							}
						}
					}
					goto case 90;
				case 58:
					try
					{
						KRx0M6OKjFsnb3qApNkG(type3, text5, true);
						int num11 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
						{
							num11 = 0;
						}
						switch (num11)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex3)
					{
						int num12 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
						{
							num12 = 2;
						}
						while (true)
						{
							switch (num12)
							{
							case 1:
								xmlReader2 = (XmlReader)YrNgkKOK6qQG0uLZ9JNO(new StringReader(text5));
								num12 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
								{
									num12 = 0;
								}
								continue;
							default:
								try
								{
									gsWwkMOK8e3HvxFMynpj(xmlReader2);
									int num13 = 25;
									while (true)
									{
										switch (num13)
										{
										case 2:
											D2jsILOKq31OCIIqfvhT(xmlReader2);
											num13 = 21;
											continue;
										case 4:
											D2jsILOKq31OCIIqfvhT(xmlReader2);
											num13 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
											{
												num13 = 10;
											}
											continue;
										case 21:
										case 23:
											if (RTnnFxOKPyhIrLlsSQvV(xmlReader2) == XmlNodeType.EndElement)
											{
												num13 = 7;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
												{
													num13 = 3;
												}
												continue;
											}
											goto case 5;
										case 17:
											if ((string)RYFBXKOK0pqPhWBoW2xP(xmlReader2) == SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x157D5AF4 ^ 0x157DD786))
											{
												num13 = 6;
												continue;
											}
											goto case 15;
										case 22:
											gsWwkMOK8e3HvxFMynpj(xmlReader2);
											num13 = 4;
											continue;
										case 26:
											text10 = "";
											num13 = 24;
											continue;
										case 6:
											text10 = xmlReader2.ReadString();
											num13 = 15;
											continue;
										case 8:
											_003C_003Ec__DisplayClass23_.elementType = (string)ktBR93OKmyki3bsXm2vn(xmlReader2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD312E46));
											num13 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
											{
												num13 = 0;
											}
											continue;
										case 12:
											xmlReader2.MoveToContent();
											num13 = 9;
											continue;
										case 10:
											gsWwkMOK8e3HvxFMynpj(xmlReader2);
											num13 = 5;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
											{
												num13 = 12;
											}
											continue;
										case 24:
											xmlReader2.Read();
											num13 = 19;
											continue;
										case 14:
											_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
											num13 = 8;
											continue;
										default:
											if (hmsxWXOKQUH9dIHa4qhI(source.Where(_003C_003Ec__DisplayClass23_._003CTestRead_003Eb__2).ToList()) == 0)
											{
												num13 = 2;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
												{
													num13 = 13;
												}
												continue;
											}
											goto case 11;
										case 3:
										case 18:
											if (RTnnFxOKPyhIrLlsSQvV(xmlReader2) == XmlNodeType.EndElement)
											{
												num13 = 1;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
												{
													num13 = 0;
												}
												continue;
											}
											goto case 20;
										case 19:
											D2jsILOKq31OCIIqfvhT(xmlReader2);
											num13 = 18;
											continue;
										case 16:
											D2jsILOKq31OCIIqfvhT(xmlReader2);
											num13 = 3;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
											{
												num13 = 0;
											}
											continue;
										case 13:
											text11 = (string)ktBR93OKmyki3bsXm2vn(xmlReader2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684228488));
											num13 = 26;
											continue;
										case 15:
										{
											sQ98KTOKc7l4dcJT1neH(xmlReader2);
											int num14 = 16;
											num13 = num14;
											continue;
										}
										case 9:
											source = ((ComponentManager)Tp7cCaOK3WjSQZ7vfkRP()).GetXsiTypes().ToList();
											num13 = 10;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
											{
												num13 = 23;
											}
											continue;
										case 11:
											sQ98KTOKc7l4dcJT1neH(xmlReader2);
											num13 = 2;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
											{
												num13 = 2;
											}
											continue;
										case 20:
											if (!PhAtTlOKsmBVyvEDowMO(xmlReader2.Name, Aid8G7z1OuP9W4kcHQg(0x141C968 ^ 0x1418FE6)))
											{
												num13 = 14;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
												{
													num13 = 17;
												}
												continue;
											}
											goto case 6;
										case 25:
											owgVbxOKY7SyC83Kjwf0(xmlReader2);
											num13 = 22;
											continue;
										case 5:
											if (PhAtTlOKsmBVyvEDowMO(RYFBXKOK0pqPhWBoW2xP(xmlReader2), v3iYLsOKTLI3o0dotG4v(Aid8G7z1OuP9W4kcHQg(-720457373 ^ -720375831), Array.Empty<object>())))
											{
												num13 = 14;
												continue;
											}
											goto case 11;
										case 1:
											testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(--727842433 ^ 0x2B608C19), new object[4]
											{
												(!EUyv9QOKX3SdGXmIv9pi(text10)) ? g9FahfOKptZmcAojG1ow(Aid8G7z1OuP9W4kcHQg(-17847711 ^ -17901217), text10) : "",
												text11,
												text4,
												text6
											})));
											num13 = 11;
											continue;
										case 7:
											break;
										}
										break;
									}
								}
								finally
								{
									int num15;
									if (xmlReader2 == null)
									{
										num15 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
										{
											num15 = 0;
										}
										goto IL_091c;
									}
									goto IL_0932;
									IL_0932:
									zEvfGyOKCSJF9lIx2Rc7(xmlReader2);
									num15 = 2;
									goto IL_091c;
									IL_091c:
									switch (num15)
									{
									default:
										goto end_IL_08f7;
									case 1:
										break;
									case 0:
										goto end_IL_08f7;
									case 2:
										goto end_IL_08f7;
									}
									goto IL_0932;
									end_IL_08f7:;
								}
								break;
							case 2:
								testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)Aid8G7z1OuP9W4kcHQg(-135674354 ^ -135744512), text4, text6, (RSmWaOOKR3gwquLqQx4H(ex3) != null) ? ((Exception)RSmWaOOKR3gwquLqQx4H(ex3)).Message : RHUdEcOKZLjQY5btqJRt(ex3))));
								num12 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
								{
									num12 = 1;
								}
								continue;
							case 3:
								break;
							}
							break;
						}
					}
					goto case 24;
				case 63:
					text5 = (string)EprcxtOKJ566Jg0G8yiR(xmlReader);
					num2 = 116;
					continue;
				case 65:
					text6 = "";
					num2 = 37;
					continue;
				case 49:
					gsWwkMOK8e3HvxFMynpj(xmlReader);
					num2 = 16;
					continue;
				case 113:
					if (!EUyv9QOKX3SdGXmIv9pi(text8))
					{
						num2 = 22;
						continue;
					}
					goto case 55;
				case 2:
					testMessages = result.Messages;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
					{
						num2 = 46;
					}
					continue;
				case 22:
					text9 = text8.Substring(0, a84jMCOKuVAkadfcgJSL(text8, Aid8G7z1OuP9W4kcHQg(-17847711 ^ -17900985)));
					num2 = 79;
					continue;
				case 43:
					if (xmlReader.IsEmptyElement)
					{
						num2 = 64;
						continue;
					}
					goto case 81;
				case 59:
					text2 = (string)EprcxtOKJ566Jg0G8yiR(xmlReader);
					num2 = 38;
					continue;
				case 105:
					gsWwkMOK8e3HvxFMynpj(xmlReader);
					num2 = 9;
					continue;
				case 24:
				case 109:
					if (!flag)
					{
						num2 = 81;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
						{
							num2 = 113;
						}
						continue;
					}
					goto case 55;
				case 50:
				case 89:
					CheckMetadataProperties(workflowImportMetadata, processContext, new MergeReplace(), isTestRead: true);
					num2 = 34;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
					{
						num2 = 5;
					}
					continue;
				case 76:
					if (Guid.TryParse(text4, out result2))
					{
						num2 = 26;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 47;
				case 46:
					text = "";
					num2 = 43;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 99;
					}
					continue;
				case 80:
					if (oOk0I8OKyfh61k77grgM(xmlReader))
					{
						num2 = 94;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
						{
							num2 = 84;
						}
						continue;
					}
					goto case 11;
				case 111:
					MergeMetadataProperties(workflowImportMetadata, processContext, (EntityMetadata)PnfpQQOKf49VJnYFaTrq(processHeader), new MergeReplace(), isTestRead: true);
					num2 = 83;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 39;
					}
					continue;
				case 79:
					try
					{
						type2 = pMc9UQOKnrq3Qwf2K8HD(text9);
						int num18 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
						{
							num18 = 0;
						}
						switch (num18)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num19 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
						{
							num19 = 0;
						}
						while (true)
						{
							switch (num19)
							{
							case 1:
								return;
							}
							testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)Aid8G7z1OuP9W4kcHQg(-420003255 ^ -420073209), text4, text6)));
							num19 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
							{
								num19 = 0;
							}
						}
					}
					goto case 25;
				case 34:
				case 83:
					if (processHeader == null)
					{
						num2 = 47;
						continue;
					}
					goto case 73;
				case 87:
					owgVbxOKY7SyC83Kjwf0(xmlReader);
					num2 = 41;
					continue;
				case 75:
					testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708075010), new object[2] { text4, text6 })));
					num2 = 112;
					continue;
				case 55:
				case 91:
					if (!EUyv9QOKX3SdGXmIv9pi(text2))
					{
						num2 = 93;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
						{
							num2 = 89;
						}
						continue;
					}
					return;
				case 116:
					xmlReader.Read();
					num2 = 35;
					continue;
				case 37:
					text5 = "";
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 3;
					}
					continue;
				case 41:
				case 115:
					if (dhDVWvOKlj2ft3XQooPR(xmlReader))
					{
						num2 = 78;
						continue;
					}
					goto case 15;
				case 61:
					if (xmlReader.GetAttribute((string)Aid8G7z1OuP9W4kcHQg(0x595C500A ^ 0x595D3FAE)) == null)
					{
						num2 = 36;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
						{
							num2 = 51;
						}
						continue;
					}
					goto case 49;
				case 96:
					gsWwkMOK8e3HvxFMynpj(xmlReader);
					num2 = 110;
					continue;
				case 57:
					owgVbxOKY7SyC83Kjwf0(xmlReader);
					num2 = 18;
					continue;
				case 1:
					xmlReader.Read();
					num2 = 87;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
					{
						num2 = 76;
					}
					continue;
				case 40:
					gsWwkMOK8e3HvxFMynpj(xmlReader);
					num2 = 52;
					continue;
				case 98:
					text6 = (string)kZxGqIOKB6t6HRM6ukhG(xmlReader);
					num2 = 96;
					continue;
				case 3:
					text8 = "";
					num2 = 8;
					continue;
				case 13:
				case 19:
					if (RTnnFxOKPyhIrLlsSQvV(xmlReader) == XmlNodeType.EndElement)
					{
						num2 = 33;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
						{
							num2 = 103;
						}
						continue;
					}
					goto case 92;
				case 114:
					xmlReader.Read();
					num2 = 108;
					continue;
				case 31:
					text8 = (string)EprcxtOKJ566Jg0G8yiR(xmlReader);
					num2 = 77;
					continue;
				case 32:
					gsWwkMOK8e3HvxFMynpj(xmlReader);
					num = 101;
					break;
				case 62:
					if (flag)
					{
						num2 = 38;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
						{
							num2 = 95;
						}
						continue;
					}
					goto case 106;
				case 97:
					if (xmlReader.Name == SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x7591D76))
					{
						num2 = 38;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
						{
							num2 = 80;
						}
						continue;
					}
					goto case 29;
				case 27:
					testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(0x3C1FFB55 ^ 0x3C1E881B), new object[2] { text4, text6 })));
					num2 = 55;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 91;
					}
					continue;
				case 8:
					text2 = "";
					num2 = 114;
					continue;
				case 14:
				case 60:
					text8 = (string)GRxwhFOKWbgpqh5oO0Bp(text8, 0, text8.IndexOf((string)Aid8G7z1OuP9W4kcHQg(-29981480 ^ -29887234)));
					num2 = 12;
					continue;
				case 4:
				{
					object obj2 = RYFBXKOK0pqPhWBoW2xP(xmlReader);
					ParameterExpression parameterExpression = (ParameterExpression)AhQcrtOKb3GMwth4EoaJ(X8o7rnOKtORi5R6Z0snP(typeof(IWorkflowProcess).TypeHandle), Aid8G7z1OuP9W4kcHQg(-22348816 ^ -22288418));
					if (!((string)obj2 == LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowProcess, object>>((Expression)wnDAvKOKgLh9EG6aqqTt(parameterExpression, (MethodInfo)U0y7KTOK5p987MNbmKnQ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))))
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
						{
							num2 = 82;
						}
						continue;
					}
					goto case 43;
				}
				case 64:
				case 82:
				case 110:
					if (!dhDVWvOKlj2ft3XQooPR(xmlReader))
					{
						num2 = 104;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 71;
				case 5:
					try
					{
						type = pMc9UQOKnrq3Qwf2K8HD(text3);
						int num9 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num10 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
						{
							num10 = 0;
						}
						while (true)
						{
							switch (num10)
							{
							case 1:
								return;
							}
							testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386413054), text4, text6)));
							num10 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
							{
								num10 = 1;
							}
						}
					}
					goto case 100;
				case 11:
					if (ktBR93OKmyki3bsXm2vn(xmlReader, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002026417)) != null)
					{
						num2 = 86;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
						{
							num2 = 56;
						}
						continue;
					}
					goto case 29;
				case 112:
					return;
				case 74:
					text = (string)EprcxtOKJ566Jg0G8yiR(xmlReader);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
					{
						num2 = 1;
					}
					continue;
				case 85:
					if (xmlReader.GetAttribute(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720380173)) != null)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 41;
				case 88:
					return;
				case 103:
					flag = Locator.GetServiceNotNull<IFeatureFlagService>().Enabled(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x42307EE0), defaultEnabled: false);
					num2 = 69;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
					{
						num2 = 107;
					}
					continue;
				case 6:
					xmlReader.MoveToElement();
					num2 = 63;
					continue;
				case 16:
					owgVbxOKY7SyC83Kjwf0(xmlReader);
					num2 = 31;
					continue;
				case 12:
					try
					{
						WorkflowFormsContainer workflowFormsContainer = KRx0M6OKjFsnb3qApNkG(type2, text8, true) as WorkflowFormsContainer;
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 3:
								try
								{
									while (true)
									{
										IL_13c6:
										int num6;
										if (!enumerator.MoveNext())
										{
											num6 = 8;
											goto IL_1329;
										}
										goto IL_136e;
										IL_1329:
										while (true)
										{
											switch (num6)
											{
											case 7:
												return;
											case 9:
												formViewItemTransformation = (FormViewItemTransformation)nPRkIAOKM3xabXkoPpj2(formViewItemTransformation2);
												num6 = 5;
												continue;
											case 4:
												break;
											case 1:
												if (formViewItemTransformation2 != null)
												{
													num6 = 9;
													continue;
												}
												goto IL_13c6;
											default:
												goto IL_13c6;
											case 5:
												if (formViewItemTransformation != null)
												{
													num6 = 3;
													continue;
												}
												goto IL_13c6;
											case 6:
												testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(0x65B7F624 ^ 0x65B68658), new object[1] { text6 })));
												num6 = 7;
												continue;
											case 3:
												if (formViewItemTransformation.Items.OfType<ViewItemTransformationChange>().FirstOrDefault(delegate(ViewItemTransformationChange f)
												{
													//Discarded unreachable code: IL_002d, IL_003c
													int num20 = 1;
													int num21 = num20;
													while (true)
													{
														switch (num21)
														{
														case 2:
															return (RuntimeVersion)_003C_003Ec.O1fSBBZ1Qq5HCXWa0nMH(f) == RuntimeVersion.Version2;
														default:
															return false;
														case 1:
															if (!_003C_003Ec.cpgqmjZ1TLo74u2dhvGb(f.PropertyName, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542106512)))
															{
																num21 = 0;
																if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
																{
																	num21 = 0;
																}
																break;
															}
															goto case 2;
														}
													}
												}) == null)
												{
													num6 = 0;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
													{
														num6 = 0;
													}
													continue;
												}
												goto case 6;
											case 8:
												goto end_IL_13c6;
											}
											break;
										}
										goto IL_136e;
										IL_136e:
										formViewItemTransformation2 = enumerator.Current as IFormViewItemTransformation;
										num6 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
										{
											num6 = 0;
										}
										goto IL_1329;
										continue;
										end_IL_13c6:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
									int num7 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
									{
										num7 = 0;
									}
									switch (num7)
									{
									case 0:
										break;
									}
								}
								break;
							case 4:
								enumerator = workflowFormsContainer.Items.GetEnumerator();
								num5 = 3;
								continue;
							case 2:
								break;
							default:
								if (workflowFormsContainer == null)
								{
									num5 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
									{
										num5 = 2;
									}
									continue;
								}
								goto case 4;
							case 1:
								break;
							}
							break;
						}
					}
					catch (Exception)
					{
						int num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 55;
				case 10:
					try
					{
						ClassSerializationHelper.DeserializeObjectByXml(type, text2);
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					catch (Exception ex)
					{
						int num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF5A5DE), new object[3]
								{
									text4,
									text6,
									(RSmWaOOKR3gwquLqQx4H(ex) != null) ? ((Exception)RSmWaOOKR3gwquLqQx4H(ex)).Message : RHUdEcOKZLjQY5btqJRt(ex)
								})));
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					}
				case 18:
					text4 = (string)kZxGqIOKB6t6HRM6ukhG(xmlReader);
					num2 = 105;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
					{
						num2 = 33;
					}
					continue;
				case 48:
					if (PhAtTlOKsmBVyvEDowMO(RYFBXKOK0pqPhWBoW2xP(xmlReader), Aid8G7z1OuP9W4kcHQg(-667465279 ^ -667426231)))
					{
						num2 = 84;
						continue;
					}
					goto case 39;
				case 42:
					text7 = (string)Cb6F4sOKDgMgGo8uEZMU(text5, 0, a84jMCOKuVAkadfcgJSL(text5, Aid8G7z1OuP9W4kcHQg(0x1C7F6FED ^ 0x1C7E1FCB)));
					num = 7;
					break;
				case 99:
					text4 = "";
					num2 = 60;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
					{
						num2 = 65;
					}
					continue;
				case 106:
					if (processContext.ViewModelMetadata == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 117;
				case 52:
					owgVbxOKY7SyC83Kjwf0(xmlReader);
					num = 13;
					break;
				case 54:
					return;
				default:
					if (processHeader != null)
					{
						num2 = 33;
						continue;
					}
					goto case 50;
				case 38:
					gsWwkMOK8e3HvxFMynpj(xmlReader);
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num2 = 29;
					}
					continue;
				case 73:
					AddProcessUpdate(processHeader, result);
					num = 56;
					break;
				case 84:
					if (!oOk0I8OKyfh61k77grgM(xmlReader))
					{
						num2 = 61;
						continue;
					}
					goto case 39;
				case 23:
					testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420072481), new object[2] { text4, text6 })));
					num2 = 109;
					continue;
				case 81:
					owgVbxOKY7SyC83Kjwf0(xmlReader);
					num2 = 98;
					continue;
				case 101:
					xmlReader.MoveToElement();
					num2 = 74;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
					{
						num2 = 3;
					}
					continue;
				case 86:
					gsWwkMOK8e3HvxFMynpj(xmlReader);
					num2 = 69;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 102;
					}
					continue;
				case 66:
					if (ktBR93OKmyki3bsXm2vn(xmlReader, Aid8G7z1OuP9W4kcHQg(0x4FD00585 ^ 0x4FD16A21)) == null)
					{
						num2 = 28;
						continue;
					}
					goto case 72;
				case 71:
				{
					object obj5 = RYFBXKOK0pqPhWBoW2xP(xmlReader);
					ParameterExpression parameterExpression = (ParameterExpression)AhQcrtOKb3GMwth4EoaJ(X8o7rnOKtORi5R6Z0snP(typeof(IWorkflowProcess).TypeHandle), Aid8G7z1OuP9W4kcHQg(-10408775 ^ -10473321));
					if (PhAtTlOKsmBVyvEDowMO(obj5, LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowProcess, object>>((Expression)wnDAvKOKgLh9EG6aqqTt(parameterExpression, (MethodInfo)U0y7KTOK5p987MNbmKnQ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))))
					{
						num2 = 17;
						continue;
					}
					goto case 9;
				}
				case 69:
					xmlReader = (XmlReader)nWlybjOKvpdwia8l2912(data);
					num2 = 2;
					continue;
				case 100:
					if (!TpPU2KOK9nUgkRuy3LLE(type, null))
					{
						text2 = (string)GRxwhFOKWbgpqh5oO0Bp(text2, 0, text2.IndexOf(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002018355)));
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
						{
							num2 = 10;
						}
					}
					else
					{
						num2 = 75;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
						{
							num2 = 43;
						}
					}
					continue;
				case 29:
				case 94:
					if (xmlReader.IsStartElement())
					{
						num = 4;
						break;
					}
					goto case 64;
				case 93:
					text3 = text2.Substring(0, a84jMCOKuVAkadfcgJSL(text2, Aid8G7z1OuP9W4kcHQg(-10408775 ^ -10462049)));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num2 = 5;
					}
					continue;
				case 77:
					gsWwkMOK8e3HvxFMynpj(xmlReader);
					num2 = 53;
					continue;
				case 92:
					if (xmlReader.IsStartElement())
					{
						num2 = 36;
						continue;
					}
					goto case 41;
				case 102:
					owgVbxOKY7SyC83Kjwf0(xmlReader);
					num2 = 59;
					continue;
				case 9:
				case 21:
				case 104:
					sQ98KTOKc7l4dcJT1neH(xmlReader);
					num2 = 45;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 4;
					}
					continue;
				case 117:
					testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542096538), new object[1] { text6 })));
					num2 = 54;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num2 = 52;
					}
					continue;
				case 107:
					if (EUyv9QOKX3SdGXmIv9pi(text))
					{
						num2 = 51;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
						{
							num2 = 67;
						}
						continue;
					}
					goto case 76;
				case 33:
					if (processHeader.Context == null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
						{
							num2 = 50;
						}
						continue;
					}
					goto case 111;
				case 70:
					workflowImportMetadata = new WorkflowImportMetadata(data);
					num = 69;
					break;
				case 39:
				case 51:
				case 53:
					if (xmlReader.IsStartElement())
					{
						num2 = 97;
						continue;
					}
					goto case 29;
				case 90:
					if (TpPU2KOK9nUgkRuy3LLE(type3, null))
					{
						num2 = 23;
						continue;
					}
					goto case 68;
				case 20:
				{
					Type tp = pMc9UQOKnrq3Qwf2K8HD(Cb6F4sOKDgMgGo8uEZMU(text, 0, a84jMCOKuVAkadfcgJSL(text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F910F1))));
					text = text.Remove(0, a84jMCOKuVAkadfcgJSL(text, Aid8G7z1OuP9W4kcHQg(0x361628FF ^ 0x361758D9)));
					StringBuilder stringBuilder = new StringBuilder((string)Aid8G7z1OuP9W4kcHQg(-2002063381 ^ -2002018361));
					MgwdHfOKH74kpWs9pTbw(stringBuilder, text);
					string xml = stringBuilder.ToString();
					processContext = ClassSerializationHelper.DeserializeObjectByXml(tp, xml) as ProcessContext;
					num2 = 62;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 16;
					}
					continue;
				}
				case 26:
					processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)CjVpfZOKduoNXDQWmnmK()).LoadOrNull(result2);
					num2 = 20;
					continue;
				}
				break;
			}
		}
	}

	public virtual IEnumerable<IPropertyMetadata> GetPropertiesAndTableParts(EntityMetadata md)
	{
		List<IPropertyMetadata> list = new List<IPropertyMetadata>();
		if (md.EntityProperties != null)
		{
			list.AddRange(md.Properties);
		}
		if (md.EntityTableParts != null)
		{
			list.AddRange(md.TableParts);
		}
		list.Sort(delegate(IPropertyMetadata p1, IPropertyMetadata p2)
		{
			//Discarded unreachable code: IL_00a6, IL_00b5, IL_012a, IL_0139
			int num = 8;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (!_003C_003Ec.AVRx5sZ1CKd1dowACMaD(_003C_003Ec.JUnkDZZ1pAGG4HqfqLT4(p1), null))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				case 6:
					if (_003C_003Ec.BYefalZ1MQxuKSgwicgw(p1) < p2.Order)
					{
						num2 = 5;
						break;
					}
					goto default;
				case 3:
					if (_003C_003Ec.BYefalZ1MQxuKSgwicgw(p1) == _003C_003Ec.BYefalZ1MQxuKSgwicgw(p2))
					{
						return 0;
					}
					num2 = 6;
					break;
				case 2:
					return 1;
				case 1:
					if (!_003C_003Ec.AVRx5sZ1CKd1dowACMaD(_003C_003Ec.JUnkDZZ1pAGG4HqfqLT4(p2), null))
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 3;
				default:
					return 1;
				case 5:
					return -1;
				case 4:
					if (p1.DeclaringType.IsAssignableFrom(_003C_003Ec.JUnkDZZ1pAGG4HqfqLT4(p2)))
					{
						return -1;
					}
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 2;
					}
					break;
				case 8:
					if (!(p1.DeclaringType == _003C_003Ec.JUnkDZZ1pAGG4HqfqLT4(p2)))
					{
						num2 = 7;
						break;
					}
					goto case 3;
				}
			}
		});
		return list;
	}

	private bool CheckNewProperty(WorkflowImportMetadata workflowImportMetadata, PropertyMetadata propertyImported, EntityMetadata md, MergeReplace mergeReplace)
	{
		//Discarded unreachable code: IL_0281, IL_03fb, IL_040a, IL_04c1, IL_0586, IL_0595, IL_060f, IL_071e, IL_072d, IL_07bc, IL_07ee, IL_0826, IL_0884, IL_0893, IL_094c, IL_0fdc, IL_109c, IL_10ab, IL_10e1, IL_10f0, IL_1100
		int num = 69;
		TestImportMessages testImportMessages = default(TestImportMessages);
		_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = default(_003C_003Ec__DisplayClass25_0);
		string message = default(string);
		bool flag = default(bool);
		EntitySettings entitySettings = default(EntitySettings);
		string text2 = default(string);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		EntityMetadata entityMetadata = default(EntityMetadata);
		_003C_003Ec__DisplayClass25_1 _003C_003Ec__DisplayClass25_2 = default(_003C_003Ec__DisplayClass25_1);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 36:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)WIPWjbOKxanG8scgYeOW(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393836472))));
					num2 = 64;
					continue;
				case 75:
					testImportMessages = MetadataImportHelper.ValidateFieldName((string)uyMUr1OKNpSj65Ki3jgK(_003C_003Ec__DisplayClass25_.propertyImported.Settings as EntitySettings));
					num2 = 23;
					continue;
				case 61:
					if (!MetadataImportHelper.CheckPropertyFieldName(((IEnumerable<IMetadata>)GetPropertiesAndTableParts(md)).ToList(), _003C_003Ec__DisplayClass25_.propertyImported, (AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass25_.propertyImported) as SimpleTypeSettings).FieldName, out message))
					{
						num2 = 52;
						continue;
					}
					goto case 30;
				case 44:
					testMessagesAdd(testImportMessages);
					num2 = 43;
					continue;
				case 59:
					if (((IMetadataService)FQjeTZOK7BIlGQyLuIcR()).GetMetadataList().All(_003C_003Ec__DisplayClass25_._003CCheckNewProperty_003Eb__1))
					{
						num2 = 73;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
						{
							num2 = 46;
						}
						continue;
					}
					goto default;
				case 32:
					if (testImportMessages != null)
					{
						num2 = 4;
						continue;
					}
					goto case 75;
				case 76:
					flag = true;
					num2 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 26;
					}
					continue;
				case 10:
					if (entitySettings != null)
					{
						num2 = 25;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
						{
							num2 = 40;
						}
						continue;
					}
					goto case 11;
				case 46:
					text2 = MetadataImportHelper.NewRelationTableName((AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass25_.propertyImported) as EntitySettings).RelationTableName, _003C_003Ec__DisplayClass25_.propertyImported.Uid, AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass25_.propertyImported) as EntitySettings);
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
					{
						num2 = 2;
					}
					continue;
				case 13:
					if (entitySettings.RelationType != RelationType.ManyToManyInverse)
					{
						num2 = 61;
						continue;
					}
					goto case 30;
				case 82:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514218432), new object[7]
					{
						IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass25_.propertyImported),
						md.DisplayName,
						message,
						VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass25_.propertyImported),
						xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass25_.propertyImported),
						xMYS07OKVMuVyG7Ql4Ms(md),
						IUSpFfOKkxevy24kDgFt(md)
					})));
					num2 = 20;
					continue;
				case 18:
					if (entitySettings.RelationType == RelationType.OneToMany)
					{
						num = 12;
						break;
					}
					goto case 56;
				case 45:
					if (uSYqBQOKii9AQWOwsiIr(AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass25_.propertyImported) as EntitySettings) == RelationType.ManyToMany)
					{
						num2 = 31;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
						{
							num2 = 27;
						}
						continue;
					}
					goto case 25;
				case 67:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6D0B8A), new object[7]
					{
						IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass25_.propertyImported),
						VPPWCkOKUPkLafudjele(md),
						WIPWjbOKxanG8scgYeOW(Aid8G7z1OuP9W4kcHQg(-197778752 ^ -197698968)),
						VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass25_.propertyImported),
						xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass25_.propertyImported),
						xMYS07OKVMuVyG7Ql4Ms(md),
						md.Uid
					})));
					num2 = 84;
					continue;
				case 19:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(--296112178 ^ 0x11A7268C), new object[7]
					{
						IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass25_.propertyImported),
						VPPWCkOKUPkLafudjele(md),
						text2,
						VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass25_.propertyImported),
						_003C_003Ec__DisplayClass25_.propertyImported.Name,
						xMYS07OKVMuVyG7Ql4Ms(md),
						IUSpFfOKkxevy24kDgFt(md)
					})));
					num2 = 39;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num2 = 53;
					}
					continue;
				case 84:
					flag = true;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 0;
					}
					continue;
				case 23:
					if (testImportMessages == null)
					{
						num2 = 65;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
						{
							num2 = 64;
						}
						continue;
					}
					goto case 44;
				case 68:
					_003C_003Ec__DisplayClass25_.propertyImported = propertyImported;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					if (testImportMessages == null)
					{
						num2 = 55;
						continue;
					}
					goto case 37;
				case 63:
					if (entitySettings.RelationType != RelationType.ManyToMany)
					{
						num2 = 5;
						continue;
					}
					goto case 30;
				case 6:
					message = "";
					num2 = 22;
					continue;
				case 17:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)Aid8G7z1OuP9W4kcHQg(0x51EF0063 ^ 0x51EE74FD), IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass25_.propertyImported), md.DisplayName, uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(0x12F686A ^ 0x12E1D0C), new object[1] { SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EACC57) }), VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass25_.propertyImported), xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass25_.propertyImported), xMYS07OKVMuVyG7Ql4Ms(md), IUSpFfOKkxevy24kDgFt(md))));
					num2 = 8;
					continue;
				case 42:
					flag = true;
					num2 = 57;
					continue;
				case 27:
					w4jpwcOKeldUg7phARtq(AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass25_.propertyImported) as EntitySettings, text2);
					num2 = 66;
					continue;
				case 28:
					flag = true;
					num2 = 60;
					continue;
				case 5:
				case 70:
					if (entitySettings != null)
					{
						num2 = 13;
						continue;
					}
					goto case 61;
				case 39:
					if (!(typeDescriptor is EnumDescriptor))
					{
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
						{
							num2 = 49;
						}
						continue;
					}
					goto case 7;
				case 15:
					try
					{
						entityMetadata = nZYWa6OKoMNNJAT799DV(FQjeTZOK7BIlGQyLuIcR(), mergeReplace.GetUidReplaceMD(yHRaQJOK2F2emajPpM7i(_003C_003Ec__DisplayClass25_.propertyImported)), true) as EntityMetadata;
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (TypeNotFoundException)
					{
						int num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								entityMetadata = null;
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 41;
				case 12:
					_003C_003Ec__DisplayClass25_2 = new _003C_003Ec__DisplayClass25_1();
					num2 = 15;
					continue;
				case 25:
				case 29:
					typeDescriptor = (ITypeDescriptor)XR84ZyOKSpkYfhhGm4Lo(FQjeTZOK7BIlGQyLuIcR(), kriSWxOKAPZ64tKMP3Ct(_003C_003Ec__DisplayClass25_.propertyImported), yHRaQJOK2F2emajPpM7i(_003C_003Ec__DisplayClass25_.propertyImported));
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
					{
						num2 = 77;
					}
					continue;
				case 57:
				case 65:
					if (!PhAtTlOKsmBVyvEDowMO((_003C_003Ec__DisplayClass25_.propertyImported.Settings as EntitySettings).ChildColumnName, (_003C_003Ec__DisplayClass25_.propertyImported.Settings as EntitySettings).ParentColumnName))
					{
						num2 = 25;
						continue;
					}
					goto case 36;
				case 69:
					_003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
					num2 = 68;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
					{
						num2 = 11;
					}
					continue;
				default:
					return !flag;
				case 47:
					if (bvt800OKrjCTJXhxGQ7N(testImportMessages) == TestImportMessagesType.Error)
					{
						num2 = 71;
						continue;
					}
					goto case 75;
				case 83:
					if (_003C_003Ec__DisplayClass25_.propertyImported.Settings == null)
					{
						num2 = 29;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
						{
							num2 = 56;
						}
						continue;
					}
					goto case 18;
				case 55:
				case 66:
				case 72:
					testImportMessages = MetadataImportHelper.ValidateFieldName((_003C_003Ec__DisplayClass25_.propertyImported.Settings as EntitySettings).ChildColumnName);
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 32;
					}
					continue;
				case 50:
					flag = true;
					num = 79;
					break;
				case 43:
					if (bvt800OKrjCTJXhxGQ7N(testImportMessages) == TestImportMessagesType.Error)
					{
						num = 42;
						break;
					}
					goto case 57;
				case 8:
					flag = true;
					num2 = 48;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 81;
					}
					continue;
				case 20:
					flag = true;
					num2 = 34;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num2 = 74;
					}
					continue;
				case 38:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(-351369538 ^ -351276512), new object[7]
					{
						IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass25_.propertyImported),
						VPPWCkOKUPkLafudjele(md),
						SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614D80C5)),
						VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass25_.propertyImported),
						_003C_003Ec__DisplayClass25_.propertyImported.Name,
						xMYS07OKVMuVyG7Ql4Ms(md),
						IUSpFfOKkxevy24kDgFt(md)
					})));
					num2 = 58;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
					{
						num2 = 12;
					}
					continue;
				case 81:
					entitySettings = AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass25_.propertyImported) as EntitySettings;
					num2 = 10;
					continue;
				case 77:
					if (typeDescriptor != null)
					{
						num2 = 48;
						continue;
					}
					goto case 67;
				case 37:
					testMessagesAdd(testImportMessages);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					if (entitySettings == null)
					{
						num2 = 70;
						continue;
					}
					goto case 63;
				case 16:
					flag = true;
					num2 = 30;
					continue;
				case 35:
				case 78:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T((string)Aid8G7z1OuP9W4kcHQg(-1361036319 ^ -1360966589), IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass25_.propertyImported), VPPWCkOKUPkLafudjele(md), text2, VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass25_.propertyImported), xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass25_.propertyImported), xMYS07OKVMuVyG7Ql4Ms(md), IUSpFfOKkxevy24kDgFt(md))));
					num = 27;
					break;
				case 41:
					_003C_003Ec__DisplayClass25_2.keyUid = c33nLJOKFGeHJ51N8BXG(mergeReplace, yHRaQJOK2F2emajPpM7i(_003C_003Ec__DisplayClass25_.propertyImported), (AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass25_.propertyImported) as EntitySettings).KeyColumnUid);
					num2 = 27;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 62;
					}
					continue;
				case 30:
					if (!pluhvLOKGJDN34fMFLMB(kriSWxOKAPZ64tKMP3Ct(_003C_003Ec__DisplayClass25_.propertyImported), EntityDescriptor.UID))
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 83;
				case 24:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(-1965291699 ^ -1965198381), new object[7]
					{
						IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass25_.propertyImported),
						VPPWCkOKUPkLafudjele(md),
						message,
						VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass25_.propertyImported),
						_003C_003Ec__DisplayClass25_.propertyImported.Name,
						xMYS07OKVMuVyG7Ql4Ms(md),
						IUSpFfOKkxevy24kDgFt(md)
					})));
					num2 = 50;
					continue;
				case 60:
					if (bvt800OKrjCTJXhxGQ7N(testImportMessages) == TestImportMessagesType.InfoMetadata)
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
						{
							num2 = 46;
						}
						continue;
					}
					goto case 55;
				case 52:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(0x1927DA93 ^ 0x1926AE0D), new object[7]
					{
						IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass25_.propertyImported),
						VPPWCkOKUPkLafudjele(md),
						message,
						VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass25_.propertyImported),
						xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass25_.propertyImported),
						xMYS07OKVMuVyG7Ql4Ms(md),
						md.Uid
					})));
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
					{
						num2 = 16;
					}
					continue;
				case 31:
					text = (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(0x65B7F624 ^ 0x65B6800E), new object[6]
					{
						IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass25_.propertyImported),
						VPPWCkOKUPkLafudjele(md),
						VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass25_.propertyImported),
						_003C_003Ec__DisplayClass25_.propertyImported.Name,
						xMYS07OKVMuVyG7Ql4Ms(md),
						IUSpFfOKkxevy24kDgFt(md)
					});
					num2 = 34;
					continue;
				case 40:
					if (entitySettings.RelationType != RelationType.OneToMany)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 30;
				case 79:
					if (!MetadataImportHelper.CheckPropertyName(((IEnumerable<IMetadata>)GetPropertiesAndTableParts(md)).ToList(), _003C_003Ec__DisplayClass25_.propertyImported, md.Name, (string)xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass25_.propertyImported), out message))
					{
						num = 82;
						break;
					}
					goto case 74;
				case 56:
				case 58:
				case 80:
					if (AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass25_.propertyImported) is EntitySettings)
					{
						num2 = 45;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 25;
				case 3:
					if (inheriteEntityMetadataGuids.Any(_003C_003Ec__DisplayClass25_._003CCheckNewProperty_003Eb__0))
					{
						num2 = 83;
						continue;
					}
					goto case 56;
				case 71:
					flag = true;
					num2 = 75;
					continue;
				case 73:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)Aid8G7z1OuP9W4kcHQg(-980570076 ^ -980630342), IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass25_.propertyImported), VPPWCkOKUPkLafudjele(md), uSlr4TOKL8j3SPDxBl3n(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430557421), new object[1] { _003C_003Ec__DisplayClass25_.propertyImported.SubTypeUid }), VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass25_.propertyImported), xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass25_.propertyImported), md.Name, md.Uid)));
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 76;
					}
					continue;
				case 74:
					if (((string)xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass25_.propertyImported)).Equals((string)Aid8G7z1OuP9W4kcHQg(-1430645277 ^ -1430629531), StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 17;
						continue;
					}
					goto case 81;
				case 62:
					if (entityMetadata != null)
					{
						num2 = 26;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 38;
				case 1:
					if (testImportMessages.Type == TestImportMessagesType.Error)
					{
						num2 = 28;
						continue;
					}
					goto case 60;
				case 53:
					flag = true;
					num2 = 72;
					continue;
				case 21:
					if (!MetadataImportHelper.CheckPropertyDisplayName(((IEnumerable<IMetadata>)GetPropertiesAndTableParts(md)).ToList(), _003C_003Ec__DisplayClass25_.propertyImported, _003C_003Ec__DisplayClass25_.propertyImported.DisplayName, out message))
					{
						num2 = 24;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 79;
				case 7:
				case 14:
					if (cOJREPOK15aCDOHnPPNO(_003C_003Ec__DisplayClass25_.propertyImported))
					{
						num2 = 51;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 59;
				case 64:
					flag = true;
					num2 = 29;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
					{
						num2 = 10;
					}
					continue;
				case 9:
					if (!EUyv9QOKX3SdGXmIv9pi(text2))
					{
						num2 = 69;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
						{
							num2 = 78;
						}
						continue;
					}
					goto case 19;
				case 33:
					if (entityMetadata.Properties.Any(_003C_003Ec__DisplayClass25_2._003CCheckNewProperty_003Eb__2))
					{
						num2 = 80;
						continue;
					}
					goto case 38;
				case 34:
					testImportMessages = (TestImportMessages)wvFiO3OKaqe86idbgE45(IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass25_.propertyImported), zaqF01OKIuqJn1PZnUP6(_003C_003Ec__DisplayClass25_.propertyImported.Settings as EntitySettings), default(Guid), text);
					num = 2;
					break;
				case 22:
					flag = false;
					num = 21;
					break;
				case 48:
				case 54:
					if (typeDescriptor is EntityDescriptor)
					{
						num2 = 7;
						continue;
					}
					goto case 39;
				case 4:
					testMessagesAdd(testImportMessages);
					num = 47;
					break;
				}
				break;
			}
		}
	}

	private bool CheckNewTablePart(WorkflowImportMetadata workflowImportMetadata, TablePartMetadata tablepartImported, EntityMetadata md, MergeReplace mergeReplace)
	{
		//Discarded unreachable code: IL_01c6, IL_01d0, IL_02a5, IL_02b8, IL_0312, IL_0622, IL_0631, IL_0765, IL_076f, IL_0834, IL_0847
		int num = 32;
		bool flag = default(bool);
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = default(_003C_003Ec__DisplayClass26_0);
		string message = default(string);
		List<PropertyMetadata>.Enumerator enumerator2 = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current2 = default(PropertyMetadata);
		TestImportMessages testImportMessages = default(TestImportMessages);
		string text = default(string);
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					flag = true;
					num2 = 15;
					continue;
				case 29:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(-1108877388 ^ -1108957448), new object[7]
					{
						IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass26_.tablepartImported),
						VPPWCkOKUPkLafudjele(md),
						message,
						VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass26_.tablepartImported),
						xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass26_.tablepartImported),
						md.Name,
						IUSpFfOKkxevy24kDgFt(md)
					})));
					num2 = 7;
					continue;
				case 2:
					if (MetadataImportHelper.CheckPropertyName(((IEnumerable<IMetadata>)GetPropertiesAndTableParts(md)).ToList(), _003C_003Ec__DisplayClass26_.tablepartImported, md.Name, (string)EkcNhEOKhOYZHsGTA9uu(_003C_003Ec__DisplayClass26_.tablepartImported), out message))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 29;
				case 6:
					flag = true;
					num2 = 30;
					continue;
				case 26:
					enumerator2 = _003C_003Ec__DisplayClass26_.tablepartImported.Properties.GetEnumerator();
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
								{
									num5 = 2;
								}
								goto IL_01d4;
							}
							goto IL_0239;
							IL_0239:
							current2 = enumerator2.Current;
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
							{
								num5 = 0;
							}
							goto IL_01d4;
							IL_01d4:
							while (true)
							{
								switch (num5)
								{
								case 1:
									if (!CheckNewProperty(workflowImportMetadata, current2, _003C_003Ec__DisplayClass26_.tablepartImported, mergeReplace))
									{
										num5 = 4;
										continue;
									}
									break;
								case 3:
									goto IL_0239;
								case 4:
									flag = true;
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
									{
										num5 = 0;
									}
									continue;
								case 2:
									goto end_IL_01f2;
								}
								break;
							}
							continue;
							end_IL_01f2:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 12;
				case 31:
					_003C_003Ec__DisplayClass26_.tablepartImported = tablepartImported;
					num2 = 23;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 10;
					}
					continue;
				case 10:
					if (bvt800OKrjCTJXhxGQ7N(testImportMessages) == TestImportMessagesType.Error)
					{
						num2 = 25;
						continue;
					}
					goto case 22;
				case 11:
					testMessagesAdd(testImportMessages);
					num2 = 10;
					continue;
				case 3:
				case 27:
					if (OCgpPkOKEpAmo11d2IFv(xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass26_.tablepartImported), Aid8G7z1OuP9W4kcHQg(0x51EF0063 ^ 0x51EF46E5), StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 9;
				case 25:
					flag = true;
					num2 = 22;
					continue;
				case 1:
					flag = false;
					num2 = 24;
					continue;
				case 19:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(0x4FD00585 ^ 0x4FD17CC9), new object[7]
					{
						_003C_003Ec__DisplayClass26_.tablepartImported.Uid,
						md.DisplayName,
						message,
						VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass26_.tablepartImported),
						xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass26_.tablepartImported),
						xMYS07OKVMuVyG7Ql4Ms(md),
						md.Uid
					})));
					num2 = 28;
					continue;
				case 9:
					if (!GetPropertiesAndTableParts(md).OfType<ITablePartMetadata>().Any(_003C_003Ec__DisplayClass26_._003CCheckNewTablePart_003Eb__0))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 7:
					flag = true;
					num2 = 24;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
					{
						num2 = 27;
					}
					continue;
				case 8:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(-2111219045 ^ -2111298601), new object[7]
					{
						IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass26_.tablepartImported),
						md.DisplayName,
						WIPWjbOKxanG8scgYeOW(Aid8G7z1OuP9W4kcHQg(-360662087 ^ -360595031)),
						VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass26_.tablepartImported),
						xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass26_.tablepartImported),
						xMYS07OKVMuVyG7Ql4Ms(md),
						IUSpFfOKkxevy24kDgFt(md)
					})));
					num2 = 6;
					continue;
				case 28:
					flag = true;
					num = 2;
					break;
				case 14:
					if (testImportMessages != null)
					{
						num2 = 17;
						continue;
					}
					goto case 15;
				case 17:
					testMessagesAdd(testImportMessages);
					num2 = 20;
					continue;
				case 24:
					if (!MetadataImportHelper.CheckPropertyDisplayName(((IEnumerable<IMetadata>)GetPropertiesAndTableParts(md)).ToList(), _003C_003Ec__DisplayClass26_.tablepartImported, (string)VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass26_.tablepartImported), out message))
					{
						num2 = 19;
						continue;
					}
					goto case 2;
				case 16:
					testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(-106528299 ^ -106432359), new object[7]
					{
						_003C_003Ec__DisplayClass26_.tablepartImported.Uid,
						md.DisplayName,
						uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(-43932417 ^ -43986535), new object[1] { Aid8G7z1OuP9W4kcHQg(0x361628FF ^ 0x36175D5B) }),
						_003C_003Ec__DisplayClass26_.tablepartImported.DisplayName,
						xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass26_.tablepartImported),
						xMYS07OKVMuVyG7Ql4Ms(md),
						IUSpFfOKkxevy24kDgFt(md)
					})));
					num2 = 21;
					continue;
				case 21:
					flag = true;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 9;
					}
					continue;
				case 32:
					_003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
					num2 = 31;
					continue;
				case 4:
					if (testImportMessages != null)
					{
						num = 11;
						break;
					}
					goto case 22;
				case 12:
					return !flag;
				default:
					testImportMessages = (TestImportMessages)fojxNMOKwN7GJllx0eo6(md, xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass26_.tablepartImported), IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass26_.tablepartImported));
					num2 = 14;
					continue;
				case 15:
					text = (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(0x4940763B ^ 0x49410C4F), new object[6]
					{
						IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass26_.tablepartImported),
						VPPWCkOKUPkLafudjele(md),
						_003C_003Ec__DisplayClass26_.tablepartImported.DisplayName,
						xMYS07OKVMuVyG7Ql4Ms(_003C_003Ec__DisplayClass26_.tablepartImported),
						xMYS07OKVMuVyG7Ql4Ms(md),
						IUSpFfOKkxevy24kDgFt(md)
					});
					num2 = 18;
					continue;
				case 18:
					testImportMessages = (TestImportMessages)wvFiO3OKaqe86idbgE45(_003C_003Ec__DisplayClass26_.tablepartImported.Uid, EUOXtHOK4AuCA3CDgyOj(_003C_003Ec__DisplayClass26_.tablepartImported), IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass26_.tablepartImported), text);
					num2 = 4;
					continue;
				case 13:
					try
					{
						while (true)
						{
							IL_07f2:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 4;
								goto IL_0773;
							}
							goto IL_07c2;
							IL_0773:
							while (true)
							{
								switch (num3)
								{
								default:
									if (!CheckNewTablePart(workflowImportMetadata, current, _003C_003Ec__DisplayClass26_.tablepartImported, mergeReplace))
									{
										num3 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto IL_07f2;
								case 3:
									break;
								case 1:
									flag = true;
									num3 = 2;
									continue;
								case 2:
									goto IL_07f2;
								case 4:
									goto end_IL_07f2;
								}
								break;
							}
							goto IL_07c2;
							IL_07c2:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
							{
								num3 = 0;
							}
							goto IL_0773;
							continue;
							end_IL_07f2:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 26;
				case 22:
					enumerator = _003C_003Ec__DisplayClass26_.tablepartImported.TableParts.GetEnumerator();
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
					{
						num2 = 13;
					}
					continue;
				case 23:
					message = "";
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private void MergeMetadataProperties(WorkflowImportMetadata workflowImportMetadata, EntityMetadata mdImported, EntityMetadata mdBase, MergeReplace mergeReplace, bool isTestRead)
	{
		//Discarded unreachable code: IL_0036, IL_0045, IL_0246, IL_0274, IL_02ba, IL_02f7, IL_0306, IL_0315, IL_0349, IL_0358, IL_0367, IL_0376, IL_0385, IL_03e1, IL_03f0, IL_067f, IL_068e, IL_0728, IL_0873, IL_09fe, IL_0a0d, IL_0a1d, IL_0a2c, IL_0a63, IL_0a72, IL_0af7, IL_0b85, IL_0b94, IL_0bbf, IL_0bfe, IL_0c0d, IL_0d4a, IL_0d59, IL_0d90, IL_0da3, IL_0db2, IL_0dd7, IL_0e54, IL_1025, IL_10bb, IL_10ca, IL_1105, IL_1114, IL_1124, IL_115a, IL_116d, IL_117c
		int num = 1;
		int num2 = num;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_2 = default(_003C_003Ec__DisplayClass27_0);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		List<EntityPropertyMetadata> list2 = default(List<EntityPropertyMetadata>);
		ISet<EntityPropertyMetadata> entityProperties = default(ISet<EntityPropertyMetadata>);
		List<TablePartMetadata>.Enumerator enumerator2 = default(List<TablePartMetadata>.Enumerator);
		List<TablePartMetadata> tableParts = default(List<TablePartMetadata>);
		_003C_003Ec__DisplayClass27_1 _003C_003Ec__DisplayClass27_ = default(_003C_003Ec__DisplayClass27_1);
		List<TablePartMetadata> list = default(List<TablePartMetadata>);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		ISet<TablePartMetadata> entityTableParts = default(ISet<TablePartMetadata>);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					while (true)
					{
						IL_0806:
						int num6;
						if (!enumerator.MoveNext())
						{
							num6 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
							{
								num6 = 7;
							}
							goto IL_0054;
						}
						goto IL_02c4;
						IL_02c4:
						_003C_003Ec__DisplayClass27_2 = new _003C_003Ec__DisplayClass27_0();
						num6 = 38;
						goto IL_0054;
						IL_0054:
						while (true)
						{
							int num7;
							switch (num6)
							{
							case 77:
								if (entityPropertyMetadata.IsSystem)
								{
									num6 = 6;
									continue;
								}
								goto case 60;
							case 33:
							case 74:
								testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, (string)uSlr4TOKL8j3SPDxBl3n(Aid8G7z1OuP9W4kcHQg(0x75BAD659 ^ 0x75BBADAD), new object[6]
								{
									VPPWCkOKUPkLafudjele(mdBase),
									_003C_003Ec__DisplayClass27_2.propertyImported.Uid,
									IUSpFfOKkxevy24kDgFt(entityPropertyMetadata),
									xMYS07OKVMuVyG7Ql4Ms(mdBase),
									VPPWCkOKUPkLafudjele(_003C_003Ec__DisplayClass27_2.propertyImported),
									VPPWCkOKUPkLafudjele(entityPropertyMetadata)
								})));
								num6 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
								{
									num6 = 51;
								}
								continue;
							case 6:
								if (cOJREPOK15aCDOHnPPNO(_003C_003Ec__DisplayClass27_2.propertyImported))
								{
									num7 = 64;
									goto IL_0050;
								}
								goto case 60;
							case 23:
								if (inheriteEntityMetadataGuids.Any(_003C_003Ec__DisplayClass27_2._003CMergeMetadataProperties_003Eb__3))
								{
									num6 = 57;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
									{
										num6 = 45;
									}
									continue;
								}
								goto case 37;
							case 71:
								break;
							case 27:
							case 28:
								GhK5t1OOsD5NMy3P1CYC(_003C_003Ec__DisplayClass27_2.propertyImported, IUSpFfOKkxevy24kDgFt(entityPropertyMetadata));
								num6 = 22;
								continue;
							case 11:
								if (!(AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass27_2.propertyImported) is EntitySettings))
								{
									num7 = 65;
									goto IL_0050;
								}
								goto case 42;
							case 40:
								if (_003C_003Ec__DisplayClass27_2.propertyImported.TypeUid == EntityDescriptor.UID)
								{
									num6 = 70;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
									{
										num6 = 8;
									}
									continue;
								}
								goto case 23;
							case 5:
								if (list2[0] == null)
								{
									num6 = 47;
									continue;
								}
								goto case 54;
							case 44:
							case 47:
								if (list2.Count() > 1)
								{
									num6 = 41;
									continue;
								}
								goto case 73;
							case 62:
								if (!(AWUQw5OKKWpHulEdr54g(entityPropertyMetadata) is EntitySettings))
								{
									num7 = 4;
									goto IL_0050;
								}
								goto case 17;
							case 34:
							case 64:
								if (!pluhvLOKGJDN34fMFLMB(kriSWxOKAPZ64tKMP3Ct(_003C_003Ec__DisplayClass27_2.propertyImported), EntityDescriptor.UID))
								{
									num6 = 20;
									continue;
								}
								goto case 3;
							case 66:
								ASMP90OOY7FUedMiefeD(AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass27_2.propertyImported) as EntitySettings, c33nLJOKFGeHJ51N8BXG(mergeReplace, yemMvSOOK3XhF94CX6Mv(mdBase), otq8jVOOvC9Tnydxl7UK(AWUQw5OKKWpHulEdr54g(entityPropertyMetadata) as EntitySettings)));
								num6 = 48;
								continue;
							case 2:
								mergeReplace.SetUidReplaceProperty(IUSpFfOKkxevy24kDgFt(mdImported), IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass27_2.propertyImported), IUSpFfOKkxevy24kDgFt(entityPropertyMetadata));
								num6 = 49;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
								{
									num6 = 7;
								}
								continue;
							case 54:
								testMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T((string)Aid8G7z1OuP9W4kcHQg(0x6A69C5CD ^ 0x6A68BEC9), xMYS07OKVMuVyG7Ql4Ms(mdBase), IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass27_2.propertyImported), IUSpFfOKkxevy24kDgFt(list2[0]), VPPWCkOKUPkLafudjele(mdBase), _003C_003Ec__DisplayClass27_2.propertyImported.DisplayName, VPPWCkOKUPkLafudjele(list2[0]), _003C_003Ec__DisplayClass27_2.propertyImported.Name, xMYS07OKVMuVyG7Ql4Ms(list2[0]))));
								num6 = 44;
								continue;
							case 14:
								list2 = ((IEnumerable<EntityPropertyMetadata>)entityProperties).Where(_003C_003Ec__DisplayClass27_2._003CMergeMetadataProperties_003Eb__0).ToList();
								num6 = 19;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
								{
									num6 = 26;
								}
								continue;
							case 30:
								if (list2.Count() == 1)
								{
									num6 = 5;
									continue;
								}
								goto case 44;
							case 53:
								TE62V8OOZeGK7I0OXA2k(AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass27_2.propertyImported) as EntitySettings, c33nLJOKFGeHJ51N8BXG(mergeReplace, yemMvSOOK3XhF94CX6Mv(mdBase), S03Q6rOOOMNCreVfH3Ty(entityPropertyMetadata.Settings as EntitySettings)));
								num6 = 37;
								continue;
							case 29:
								if (!(AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass27_2.propertyImported) is EntitySettings))
								{
									num6 = 12;
									continue;
								}
								goto case 56;
							case 35:
								if (!(AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass27_2.propertyImported) is EntitySettings))
								{
									num6 = 48;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
									{
										num6 = 61;
									}
									continue;
								}
								goto case 62;
							case 13:
								if (IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass27_2.propertyImported) != IUSpFfOKkxevy24kDgFt(entityPropertyMetadata))
								{
									num6 = 2;
									continue;
								}
								goto case 49;
							default:
								if (!pluhvLOKGJDN34fMFLMB(kriSWxOKAPZ64tKMP3Ct(_003C_003Ec__DisplayClass27_2.propertyImported), EntityDescriptor.UID))
								{
									num6 = 50;
									continue;
								}
								goto case 29;
							case 25:
								if (entityPropertyMetadata != null)
								{
									num6 = 77;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
									{
										num6 = 51;
									}
									continue;
								}
								goto IL_0806;
							case 1:
								entityPropertyMetadata = list2[0];
								num6 = 25;
								continue;
							case 52:
								if (_003C_003Ec__DisplayClass27_2.propertyImported.Settings is EntitySettings)
								{
									num6 = 19;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
									{
										num6 = 16;
									}
									continue;
								}
								goto case 9;
							case 43:
								w4jpwcOKeldUg7phARtq(AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass27_2.propertyImported) as EntitySettings, (AWUQw5OKKWpHulEdr54g(entityPropertyMetadata) as EntitySettings).RelationTableName);
								num6 = 72;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
								{
									num6 = 52;
								}
								continue;
							case 68:
								if (uSYqBQOKii9AQWOwsiIr(AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass27_2.propertyImported) as EntitySettings) == RelationType.OneToMany)
								{
									num6 = 53;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
									{
										num6 = 26;
									}
									continue;
								}
								goto case 37;
							case 57:
							case 70:
								if (_003C_003Ec__DisplayClass27_2.propertyImported.Settings is EntitySettings)
								{
									num6 = 15;
									continue;
								}
								goto case 37;
							case 10:
								if (_003C_003Ec__DisplayClass27_2.propertyImported == null)
								{
									num6 = 32;
									continue;
								}
								goto case 14;
							case 20:
								if (inheriteEntityMetadataGuids.Any(_003C_003Ec__DisplayClass27_2._003CMergeMetadataProperties_003Eb__2))
								{
									num6 = 3;
									continue;
								}
								goto case 24;
							case 8:
							case 22:
							case 32:
							case 41:
							case 46:
							case 51:
							case 63:
							case 76:
								goto IL_0806;
							case 60:
								if (!pluhvLOKGJDN34fMFLMB(kriSWxOKAPZ64tKMP3Ct(entityPropertyMetadata), kriSWxOKAPZ64tKMP3Ct(_003C_003Ec__DisplayClass27_2.propertyImported)))
								{
									num6 = 74;
									continue;
								}
								goto case 45;
							case 9:
							case 21:
								if (!(AWUQw5OKKWpHulEdr54g(entityPropertyMetadata) is EntitySettings))
								{
									num6 = 11;
									continue;
								}
								goto case 65;
							case 36:
								if (!pluhvLOKGJDN34fMFLMB((mdImported as TablePartMetadata).ParentPropertyUid, IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass27_2.propertyImported)))
								{
									num6 = 27;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
									{
										num6 = 7;
									}
									continue;
								}
								goto case 67;
							case 56:
								if (!(AWUQw5OKKWpHulEdr54g(entityPropertyMetadata) is EntitySettings))
								{
									num6 = 31;
									continue;
								}
								goto case 59;
							case 16:
								CheckNewProperty(workflowImportMetadata, _003C_003Ec__DisplayClass27_2.propertyImported, mdBase, mergeReplace);
								num6 = 8;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
								{
									num6 = 6;
								}
								continue;
							case 39:
								if (!(AWUQw5OKKWpHulEdr54g(entityPropertyMetadata) is EntitySettings))
								{
									num6 = 5;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
									{
										num6 = 24;
									}
									continue;
								}
								goto case 42;
							case 73:
								if (list2.Count() == 1)
								{
									num6 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
									{
										num6 = 1;
									}
									continue;
								}
								goto case 16;
							case 45:
								if (!pluhvLOKGJDN34fMFLMB(yHRaQJOK2F2emajPpM7i(entityPropertyMetadata), yHRaQJOK2F2emajPpM7i(_003C_003Ec__DisplayClass27_2.propertyImported)))
								{
									num6 = 33;
									continue;
								}
								goto case 34;
							case 12:
							case 31:
							case 72:
								if (mdImported is TablePartMetadata)
								{
									num6 = 36;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
									{
										num6 = 6;
									}
									continue;
								}
								goto case 27;
							case 24:
							case 75:
								if (pRHR1Rz7cL5ucmVWx4y(IUSpFfOKkxevy24kDgFt(entityPropertyMetadata), IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass27_2.propertyImported)))
								{
									num6 = 9;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
									{
										num6 = 13;
									}
									continue;
								}
								goto IL_0806;
							case 58:
								list2 = ((IEnumerable<EntityPropertyMetadata>)entityProperties).Where(_003C_003Ec__DisplayClass27_2._003CMergeMetadataProperties_003Eb__1).ToList();
								num6 = 30;
								continue;
							case 26:
								if (list2.Count() > 1)
								{
									num6 = 63;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
									{
										num6 = 34;
									}
									continue;
								}
								goto case 55;
							case 17:
								if (!pRHR1Rz7cL5ucmVWx4y(otq8jVOOvC9Tnydxl7UK(AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass27_2.propertyImported) as EntitySettings), Guid.Empty))
								{
									num6 = 14;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
									{
										num6 = 18;
									}
									continue;
								}
								goto case 66;
							case 59:
								if (uSYqBQOKii9AQWOwsiIr(_003C_003Ec__DisplayClass27_2.propertyImported.Settings as EntitySettings) == RelationType.ManyToMany)
								{
									num6 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
									{
										num6 = 43;
									}
									continue;
								}
								goto case 12;
							case 15:
								if (!(AWUQw5OKKWpHulEdr54g(entityPropertyMetadata) is EntitySettings))
								{
									num6 = 69;
									continue;
								}
								goto case 68;
							case 50:
								if (inheriteEntityMetadataGuids.Any(_003C_003Ec__DisplayClass27_2._003CMergeMetadataProperties_003Eb__4))
								{
									num6 = 29;
									continue;
								}
								goto case 12;
							case 67:
								tYblxhOO8tYvcQRMO1JT(mdImported as TablePartMetadata, entityPropertyMetadata.Uid);
								num6 = 28;
								continue;
							case 49:
								if (isTestRead)
								{
									num6 = 76;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
									{
										num6 = 68;
									}
									continue;
								}
								goto case 40;
							case 3:
								if (!(AWUQw5OKKWpHulEdr54g(entityPropertyMetadata) is EntitySettings))
								{
									num6 = 21;
									continue;
								}
								goto case 52;
							case 65:
								if (!(AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass27_2.propertyImported) is EntitySettings))
								{
									num6 = 35;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
									{
										num6 = 39;
									}
									continue;
								}
								goto case 24;
							case 42:
								testMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)Aid8G7z1OuP9W4kcHQg(0xB7793C9 ^ 0xB76EF3B), mdBase.DisplayName, IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass27_2.propertyImported), IUSpFfOKkxevy24kDgFt(entityPropertyMetadata), xMYS07OKVMuVyG7Ql4Ms(mdBase), _003C_003Ec__DisplayClass27_2.propertyImported.DisplayName, entityPropertyMetadata.DisplayName)));
								num7 = 46;
								goto IL_0050;
							case 38:
								_003C_003Ec__DisplayClass27_2.propertyImported = enumerator.Current;
								num6 = 10;
								continue;
							case 55:
								if (rQYBv3OKz9mwSrqEroAP(list2) <= 0)
								{
									num6 = 58;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
									{
										num6 = 46;
									}
									continue;
								}
								goto case 44;
							case 19:
								if (uSYqBQOKii9AQWOwsiIr(AWUQw5OKKWpHulEdr54g(entityPropertyMetadata) as EntitySettings) == uSYqBQOKii9AQWOwsiIr(AWUQw5OKKWpHulEdr54g(_003C_003Ec__DisplayClass27_2.propertyImported) as EntitySettings))
								{
									num6 = 9;
									continue;
								}
								goto case 42;
							case 37:
							case 69:
								if (!pluhvLOKGJDN34fMFLMB(kriSWxOKAPZ64tKMP3Ct(_003C_003Ec__DisplayClass27_2.propertyImported), EntityDescriptor.UID))
								{
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
									{
										num6 = 0;
									}
									continue;
								}
								goto case 35;
							case 7:
								goto end_IL_0806;
								IL_0050:
								num6 = num7;
								continue;
							}
							break;
						}
						goto IL_02c4;
						continue;
						end_IL_0806:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num8 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num8 = 0;
					}
					switch (num8)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			case 2:
				enumerator2 = tableParts.GetEnumerator();
				num2 = 3;
				break;
			case 4:
				return;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator2.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
							{
								num3 = 4;
							}
							goto IL_0de5;
						}
						goto IL_10a5;
						IL_10a5:
						_003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_1();
						num3 = 2;
						goto IL_0de5;
						IL_0de5:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return;
							case 11:
								if (list.Count() > 1)
								{
									num3 = 5;
									continue;
								}
								goto case 3;
							case 6:
								if (list.Count() == 1)
								{
									num3 = 22;
									continue;
								}
								goto case 9;
							case 2:
								_003C_003Ec__DisplayClass27_.tablepartImported = enumerator2.Current;
								num3 = 19;
								continue;
							case 13:
								if (!isTestRead)
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 5:
							case 8:
							case 10:
							case 17:
							case 18:
								break;
							default:
								z2BMpcOOySGfV4vyUCiS(_003C_003Ec__DisplayClass27_.tablepartImported, tlMBldOOl6uE4dH9CvtJ(tablePartMetadata));
								num3 = 17;
								continue;
							case 15:
								Y4JhftOOJECy9fRX21VZ(mergeReplace, IUSpFfOKkxevy24kDgFt(mdImported), _003C_003Ec__DisplayClass27_.tablepartImported.Name, xMYS07OKVMuVyG7Ql4Ms(tablePartMetadata));
								num3 = 12;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
								{
									num3 = 12;
								}
								continue;
							case 12:
								BrmH2mOO09NLsrSxCBFC(mergeReplace, mdImported.Uid, tlMBldOOl6uE4dH9CvtJ(_003C_003Ec__DisplayClass27_.tablepartImported), tablePartMetadata.TablePartPropertyUid);
								num3 = 13;
								continue;
							case 21:
								MergeMetadataProperties(workflowImportMetadata, _003C_003Ec__DisplayClass27_.tablepartImported, tablePartMetadata, mergeReplace, isTestRead);
								num3 = 7;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
								{
									num3 = 1;
								}
								continue;
							case 22:
								tablePartMetadata = list[0];
								num3 = 20;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
								{
									num3 = 16;
								}
								continue;
							case 7:
								if (pRHR1Rz7cL5ucmVWx4y(IUSpFfOKkxevy24kDgFt(tablePartMetadata), IUSpFfOKkxevy24kDgFt(_003C_003Ec__DisplayClass27_.tablepartImported)))
								{
									num3 = 11;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
									{
										num3 = 15;
									}
									continue;
								}
								break;
							case 14:
							case 23:
								if (list.Count() > 1)
								{
									num3 = 10;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
									{
										num3 = 8;
									}
									continue;
								}
								goto case 6;
							case 1:
								list = ((IEnumerable<TablePartMetadata>)entityTableParts).Where(_003C_003Ec__DisplayClass27_._003CMergeMetadataProperties_003Eb__6).ToList();
								num3 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
								{
									num3 = 14;
								}
								continue;
							case 9:
								CheckNewTablePart(workflowImportMetadata, _003C_003Ec__DisplayClass27_.tablepartImported, mdBase, mergeReplace);
								num3 = 8;
								continue;
							case 19:
								list = ((IEnumerable<TablePartMetadata>)entityTableParts).Where(_003C_003Ec__DisplayClass27_._003CMergeMetadataProperties_003Eb__5).ToList();
								num3 = 11;
								continue;
							case 16:
								goto IL_10a5;
							case 3:
								if (list.Count() != 0)
								{
									int num4 = 23;
									num3 = num4;
									continue;
								}
								goto case 1;
							case 20:
								if (tablePartMetadata == null)
								{
									num3 = 18;
									continue;
								}
								goto case 21;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 1:
			{
				List<PropertyMetadata> properties = mdImported.Properties;
				entityProperties = mdBase.EntityProperties;
				tableParts = mdImported.TableParts;
				entityTableParts = mdBase.EntityTableParts;
				enumerator = properties.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private void CheckMetadataProperties(WorkflowImportMetadata workflowImportMetadata, EntityMetadata mdImported, MergeReplace mergeReplace, bool isTestRead)
	{
		//Discarded unreachable code: IL_0036, IL_0045, IL_0050, IL_00cc, IL_00f3, IL_0102, IL_0112, IL_0121, IL_0289, IL_029c, IL_02ab, IL_02e0, IL_02ef, IL_02fa, IL_0395, IL_03cb, IL_03de, IL_03ed
		int num = 1;
		int num2 = num;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = default(_003C_003Ec__DisplayClass28_0);
		List<TablePartMetadata>.Enumerator enumerator2 = default(List<TablePartMetadata>.Enumerator);
		List<TablePartMetadata> tableParts = default(List<TablePartMetadata>);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					while (true)
					{
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
							{
								num5 = 2;
							}
							goto IL_0054;
						}
						goto IL_0152;
						IL_0152:
						_003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
						num5 = 8;
						goto IL_0054;
						IL_0054:
						while (true)
						{
							switch (num5)
							{
							case 5:
								if (!pluhvLOKGJDN34fMFLMB(kriSWxOKAPZ64tKMP3Ct(_003C_003Ec__DisplayClass28_.propertyImported), EntityDescriptor.UID))
								{
									num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
									{
										num5 = 6;
									}
									continue;
								}
								goto case 1;
							case 8:
								_003C_003Ec__DisplayClass28_.propertyImported = enumerator.Current;
								num5 = 9;
								continue;
							case 7:
							case 10:
							case 11:
							case 12:
								break;
							default:
								goto IL_0152;
							case 1:
								pi8yaZOOmWu4f6WyhCNk(_003C_003Ec__DisplayClass28_.propertyImported, mergeReplace.GetUidReplaceMD(yHRaQJOK2F2emajPpM7i(_003C_003Ec__DisplayClass28_.propertyImported)));
								num5 = 10;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
								{
									num5 = 2;
								}
								continue;
							case 9:
								if (_003C_003Ec__DisplayClass28_.propertyImported == null)
								{
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
									{
										num5 = 12;
									}
									continue;
								}
								goto case 4;
							case 3:
								if (!isTestRead)
								{
									num5 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
									{
										num5 = 5;
									}
									continue;
								}
								break;
							case 6:
								if (!inheriteEntityMetadataGuids.Any(_003C_003Ec__DisplayClass28_._003CCheckMetadataProperties_003Eb__0))
								{
									num5 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
									{
										num5 = 11;
									}
									continue;
								}
								goto case 1;
							case 4:
							{
								bool num6 = CheckNewProperty(workflowImportMetadata, _003C_003Ec__DisplayClass28_.propertyImported, mdImported, mergeReplace);
								if (!num6 && !isTestRead)
								{
									mdImported.Properties.Remove(_003C_003Ec__DisplayClass28_.propertyImported);
								}
								if (!num6)
								{
									num5 = 7;
									continue;
								}
								goto case 3;
							}
							case 2:
								goto end_IL_012c;
							}
							break;
						}
						continue;
						end_IL_012c:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			case 3:
				return;
			case 2:
				enumerator2 = tableParts.GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				try
				{
					while (true)
					{
						IL_0333:
						int num3;
						if (!enumerator2.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
							{
								num3 = 0;
							}
							goto IL_02fe;
						}
						goto IL_0320;
						IL_0320:
						current = enumerator2.Current;
						num3 = 3;
						goto IL_02fe;
						IL_02fe:
						while (true)
						{
							switch (num3)
							{
							case 2:
								return;
							case 1:
							case 4:
								goto IL_0333;
							case 5:
								CheckNewTablePart(workflowImportMetadata, current, mdImported, mergeReplace);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
								{
									num3 = 1;
								}
								continue;
							case 3:
								if (current == null)
								{
									num3 = 4;
									continue;
								}
								goto case 5;
							}
							break;
						}
						goto IL_0320;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 1:
			{
				List<PropertyMetadata> list = mdImported.Properties.ToList();
				tableParts = mdImported.TableParts;
				enumerator = list.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private void CheckProcessContext(WorkflowImportMetadata workflowImportMetadata, IWorkflowProcess process, MergeReplace mergeReplace, bool isTestRead)
	{
		//Discarded unreachable code: IL_005d, IL_00a1, IL_00e1, IL_00eb, IL_01b7, IL_01ef, IL_01fe, IL_02c0, IL_0321, IL_038e, IL_0426, IL_04ef, IL_04fe, IL_050f, IL_051d, IL_05e9, IL_0621, IL_0630, IL_06aa, IL_0707, IL_071a, IL_0729
		int num = 2;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		WorkflowFormsContainer workflowFormsContainer = default(WorkflowFormsContainer);
		IEnumerator<KeyValuePair<Guid, Guid>> enumerator = default(IEnumerator<KeyValuePair<Guid, Guid>>);
		KeyValuePair<Guid, Guid> current2 = default(KeyValuePair<Guid, Guid>);
		string text = default(string);
		BPMNDiagram bPMNDiagram = default(BPMNDiagram);
		KeyValuePair<Guid, Guid> current = default(KeyValuePair<Guid, Guid>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 12:
				if (processHeader != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 6;
			case 11:
				try
				{
					string text2 = (string)zU5s9BOObIPS8vSM6T2K(process.Forms, true);
					int num7 = 3;
					while (true)
					{
						switch (num7)
						{
						default:
							workflowFormsContainer = ClassSerializationHelper.DeserializeObjectByXml<WorkflowFormsContainer>(text2);
							num7 = 2;
							break;
						case 5:
							try
							{
								while (true)
								{
									IL_012c:
									int num8;
									if (!uH4c8OOOgofvmdRcPLv0(enumerator))
									{
										num8 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
										{
											num8 = 1;
										}
										goto IL_00ef;
									}
									goto IL_0109;
									IL_0109:
									current2 = enumerator.Current;
									num8 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
									{
										num8 = 0;
									}
									goto IL_00ef;
									IL_00ef:
									while (true)
									{
										switch (num8)
										{
										case 2:
											break;
										case 3:
											goto IL_012c;
										default:
											text2 = text2.Replace(current2.Key.ToString(), current2.Value.ToString());
											num8 = 3;
											continue;
										case 1:
											goto end_IL_012c;
										}
										break;
									}
									goto IL_0109;
									continue;
									end_IL_012c:
									break;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									int num9 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
									{
										num9 = 1;
									}
									while (true)
									{
										switch (num9)
										{
										case 1:
											zEvfGyOKCSJF9lIx2Rc7(enumerator);
											num9 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
											{
												num9 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
							goto default;
						case 4:
							process.Forms = workflowFormsContainer;
							num7 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
							{
								num7 = 1;
							}
							break;
						case 2:
							if (workflowFormsContainer != null)
							{
								num7 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
								{
									num7 = 4;
								}
								break;
							}
							return;
						case 3:
							enumerator = (from q in mergeReplace.GetAllUidReplaceProperty()
								where q.Key != q.Value
								select q).GetEnumerator();
							num7 = 5;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
							{
								num7 = 5;
							}
							break;
						case 1:
							return;
						}
					}
				}
				catch (Exception ex2)
				{
					int num10 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
					{
						num10 = 1;
					}
					while (true)
					{
						switch (num10)
						{
						default:
							return;
						case 1:
							kA6ViMOOXt9yNC1Hvgmy(KbELBNOKOAlYvlwyVrbG(), g9FahfOKptZmcAojG1ow(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6CC04061 ^ 0x6CC13E37), RHUdEcOKZLjQY5btqJRt(ex2)));
							num10 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
							{
								num10 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			case 7:
			case 8:
				if (kS9XJpOOtcnT3BPDdujG(process) != null)
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 14:
				MergeMetadataProperties(workflowImportMetadata, (EntityMetadata)Ytr3ogzz37773qWR4CC(process), processHeader.Context, mergeReplace, isTestRead);
				num2 = 8;
				break;
			case 0:
				return;
			case 1:
				return;
			case 5:
				if (cnQR86OOPO4NwcyB1EkG(process) != null)
				{
					num2 = 11;
					break;
				}
				return;
			case 6:
			case 10:
				CheckMetadataProperties(workflowImportMetadata, process.Context, mergeReplace, isTestRead);
				num2 = 7;
				break;
			case 2:
				if (process == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 13;
			case 9:
				return;
			case 13:
				if (Ytr3ogzz37773qWR4CC(process) != null)
				{
					processHeader = (IProcessHeader)ctsKTUzwT7e8b9h9yme(process);
					num2 = 12;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (PnfpQQOKf49VJnYFaTrq(processHeader) == null)
				{
					num2 = 6;
					break;
				}
				goto case 14;
			case 3:
				try
				{
					Type type = kS9XJpOOtcnT3BPDdujG(process).GetType();
					int num3 = 6;
					while (true)
					{
						switch (num3)
						{
						case 6:
							text = (string)zU5s9BOObIPS8vSM6T2K(process.Diagram, true);
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
							{
								num3 = 2;
							}
							continue;
						case 4:
							AfnYuCOOBjKe9hS6FUF5(process, bPMNDiagram);
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
							{
								num3 = 0;
							}
							continue;
						case 7:
							if (bPMNDiagram == null)
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 4;
						default:
							bPMNDiagram = KRx0M6OKjFsnb3qApNkG(type, text, true) as BPMNDiagram;
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
							{
								num3 = 7;
							}
							continue;
						case 1:
							break;
						case 5:
							try
							{
								while (true)
								{
									IL_053b:
									int num4;
									if (!uH4c8OOOgofvmdRcPLv0(enumerator))
									{
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
										{
											num4 = 0;
										}
										goto IL_0521;
									}
									goto IL_05b0;
									IL_05b0:
									current = enumerator.Current;
									num4 = 2;
									goto IL_0521;
									IL_0521:
									while (true)
									{
										switch (num4)
										{
										case 1:
											goto IL_053b;
										case 2:
											text = (string)FevpA6OO5Y8Uv4sSdOED(text, current.Key.ToString(), current.Value.ToString());
											num4 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
											{
												num4 = 0;
											}
											continue;
										case 3:
											goto IL_05b0;
										case 0:
											break;
										}
										break;
									}
									break;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									int num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											zEvfGyOKCSJF9lIx2Rc7(enumerator);
											num5 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
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
							goto default;
						case 2:
							enumerator = (from r in mergeReplace.GetAllUidReplaceMd().Concat(mergeReplace.GetAllUidReplaceProperty())
								where r.Key != r.Value
								select r).GetEnumerator();
							num3 = 5;
							continue;
						case 3:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num6 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							I6BLwqOOciFfKMKIYQlg(KbELBNOKOAlYvlwyVrbG(), string.Format((string)Aid8G7z1OuP9W4kcHQg(0x738ABA6E ^ 0x738BC466), RHUdEcOKZLjQY5btqJRt(ex)), ex);
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
							{
								num6 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 5;
			}
		}
	}

	static WorkflowProcessImportSaveActions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				organizationItemType = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD3123FA));
				num2 = 4;
				continue;
			case 5:
				return;
			case 4:
				userGroupType = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452171043));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				ImportLog = (ILogger)MQ5mpmOOujXZWAMmrbVK(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D522F3));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
				{
					num2 = 5;
				}
				continue;
			case 1:
				OftoerOOdUuDggcXgY2V();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			UIDs = new List<Guid>
			{
				new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077820904)),
				new Guid((string)Aid8G7z1OuP9W4kcHQg(--1418337216 ^ 0x548B652C))
			};
			num2 = 3;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static bool fdXitEzAx43a5qY82uC()
	{
		return YperNvzVlbuwQdUP5El == null;
	}

	internal static WorkflowProcessImportSaveActions WTddHJzG5c9tnb921nv()
	{
		return YperNvzVlbuwQdUP5El;
	}

	internal static bool pRHR1Rz7cL5ucmVWx4y(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool PxrWqIz2U6LJAq09N0U(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object l7AI71zo5EPdLYhMJRi(Type P_0)
	{
		return ModelHelper.GetEntityManagerOrNull(P_0);
	}

	internal static Guid idrJd0zFD0NYphBuixK(object P_0)
	{
		return ((EntityInfo)P_0).Uid;
	}

	internal static object OnG0RPziDk0s4vcMliQ(object P_0, Guid P_1)
	{
		return ((IEntityManager)P_0).LoadOrNull(P_1);
	}

	internal static object vI13GIzI6u5uK8bhIHw(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).LoadOrNull(P_1);
	}

	internal static object UNb54LzaYphOZMaOWra(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void Atn1MWzrSy3pmeCiYN9(object P_0, object P_1)
	{
		((EntityInfo)P_0).Id = (string)P_1;
	}

	internal static void w1Q76kzePnZKlK5OyHR(object P_0, object P_1)
	{
		((EntityInfo)P_0).Title = (string)P_1;
	}

	internal static void EmJfZvzNZM3OGGeiPo3(object P_0, Guid P_1)
	{
		((EntityInfo)P_0).Uid = P_1;
	}

	internal static Guid UsR9OPzxAIC6yP9jP5q(object P_0)
	{
		return ((EntityInfo)P_0).TypeUid;
	}

	internal static void ssYNIBzSq7FwPsPIvFZ(object P_0, Guid P_1)
	{
		((EntityInfo)P_0).TypeUid = P_1;
	}

	internal static object Aid8G7z1OuP9W4kcHQg(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object kSZi6hzhCg6qiQ7wMVE(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}

	internal static Guid vdcCAozEFi8RYXPdhWx(object P_0)
	{
		return ((IProcessHeader)P_0).Uid;
	}

	internal static object ctsKTUzwT7e8b9h9yme(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static long hhcHCuz4MYDckBKDH4x(object P_0)
	{
		return ((SwimlaneElement)P_0).DepartmentId;
	}

	internal static object Ytr3ogzz37773qWR4CC(object P_0)
	{
		return ((IWorkflowProcess)P_0).Context;
	}

	internal static object AWUQw5OKKWpHulEdr54g(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object KbELBNOKOAlYvlwyVrbG()
	{
		return Logger.Log;
	}

	internal static object RHUdEcOKZLjQY5btqJRt(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object nWlybjOKvpdwia8l2912(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static bool owgVbxOKY7SyC83Kjwf0(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static bool gsWwkMOK8e3HvxFMynpj(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool PhAtTlOKsmBVyvEDowMO(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object EprcxtOKJ566Jg0G8yiR(object P_0)
	{
		return ((XmlReader)P_0).Value;
	}

	internal static bool dhDVWvOKlj2ft3XQooPR(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object RYFBXKOK0pqPhWBoW2xP(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static bool oOk0I8OKyfh61k77grgM(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static object ktBR93OKmyki3bsXm2vn(object P_0, object P_1)
	{
		return ((XmlReader)P_0).GetAttribute((string)P_1);
	}

	internal static Type X8o7rnOKtORi5R6Z0snP(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object AhQcrtOKb3GMwth4EoaJ(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object U0y7KTOK5p987MNbmKnQ(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object wnDAvKOKgLh9EG6aqqTt(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object kZxGqIOKB6t6HRM6ukhG(object P_0)
	{
		return ((XmlReader)P_0).ReadString();
	}

	internal static void sQ98KTOKc7l4dcJT1neH(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType RTnnFxOKPyhIrLlsSQvV(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static bool EUyv9QOKX3SdGXmIv9pi(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object CjVpfZOKduoNXDQWmnmK()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static int a84jMCOKuVAkadfcgJSL(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static object Cb6F4sOKDgMgGo8uEZMU(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static Type pMc9UQOKnrq3Qwf2K8HD(object P_0)
	{
		return ReflectionType.GetType((string)P_0);
	}

	internal static object MgwdHfOKH74kpWs9pTbw(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static object uSlr4TOKL8j3SPDxBl3n(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object PnfpQQOKf49VJnYFaTrq(object P_0)
	{
		return ((IProcessHeader)P_0).Context;
	}

	internal static bool TpPU2KOK9nUgkRuy3LLE(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object GRxwhFOKWbgpqh5oO0Bp(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static object KRx0M6OKjFsnb3qApNkG(Type P_0, object P_1, bool P_2)
	{
		return ClassSerializationHelper.DeserializeObjectByXml(P_0, (string)P_1, P_2);
	}

	internal static object RSmWaOOKR3gwquLqQx4H(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}

	internal static object YrNgkKOK6qQG0uLZ9JNO(object P_0)
	{
		return XmlReader.Create((TextReader)P_0);
	}

	internal static XmlNodeType D2jsILOKq31OCIIqfvhT(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static object Tp7cCaOK3WjSQZ7vfkRP()
	{
		return ComponentManager.Current;
	}

	internal static object v3iYLsOKTLI3o0dotG4v(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static int hmsxWXOKQUH9dIHa4qhI(object P_0)
	{
		return ((List<Type>)P_0).Count;
	}

	internal static object g9FahfOKptZmcAojG1ow(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void zEvfGyOKCSJF9lIx2Rc7(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object nPRkIAOKM3xabXkoPpj2(object P_0)
	{
		return ((IFormViewItemTransformation)P_0).Transformation;
	}

	internal static Guid IUSpFfOKkxevy24kDgFt(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object VPPWCkOKUPkLafudjele(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object xMYS07OKVMuVyG7Ql4Ms(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static Guid kriSWxOKAPZ64tKMP3Ct(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool pluhvLOKGJDN34fMFLMB(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object FQjeTZOK7BIlGQyLuIcR()
	{
		return MetadataServiceContext.Service;
	}

	internal static Guid yHRaQJOK2F2emajPpM7i(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object nZYWa6OKoMNNJAT799DV(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataService)P_0).GetMetadata(P_1, P_2);
	}

	internal static Guid c33nLJOKFGeHJ51N8BXG(object P_0, Guid P_1, Guid P_2)
	{
		return ((MergeReplace)P_0).GetUidReplaceProperty(P_1, P_2);
	}

	internal static RelationType uSYqBQOKii9AQWOwsiIr(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static object zaqF01OKIuqJn1PZnUP6(object P_0)
	{
		return ((EntitySettings)P_0).RelationTableName;
	}

	internal static object wvFiO3OKaqe86idbgE45(Guid P_0, object P_1, Guid P_2, object P_3)
	{
		return MetadataImportHelper.ValidateTableName(P_0, (string)P_1, P_2, (string)P_3);
	}

	internal static TestImportMessagesType bvt800OKrjCTJXhxGQ7N(object P_0)
	{
		return ((TestImportMessages)P_0).Type;
	}

	internal static void w4jpwcOKeldUg7phARtq(object P_0, object P_1)
	{
		((EntitySettings)P_0).RelationTableName = (string)P_1;
	}

	internal static object uyMUr1OKNpSj65Ki3jgK(object P_0)
	{
		return ((EntitySettings)P_0).ParentColumnName;
	}

	internal static object WIPWjbOKxanG8scgYeOW(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object XR84ZyOKSpkYfhhGm4Lo(object P_0, Guid P_1, Guid P_2)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(P_1, P_2);
	}

	internal static bool cOJREPOK15aCDOHnPPNO(object P_0)
	{
		return ((PropertyMetadata)P_0).IsSystem;
	}

	internal static object EkcNhEOKhOYZHsGTA9uu(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyName;
	}

	internal static bool OCgpPkOKEpAmo11d2IFv(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static object fojxNMOKwN7GJllx0eo6(object P_0, object P_1, Guid P_2)
	{
		return MetadataImportHelper.ValidateObjectTablePartName((ICodeItemMetadata)P_0, (string)P_1, P_2);
	}

	internal static object EUOXtHOK4AuCA3CDgyOj(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static int rQYBv3OKz9mwSrqEroAP(object P_0)
	{
		return ((List<EntityPropertyMetadata>)P_0).Count;
	}

	internal static Guid yemMvSOOK3XhF94CX6Mv(object P_0)
	{
		return ((EntityMetadata)P_0).TypeUid;
	}

	internal static Guid S03Q6rOOOMNCreVfH3Ty(object P_0)
	{
		return ((EntitySettings)P_0).KeyColumnUid;
	}

	internal static void TE62V8OOZeGK7I0OXA2k(object P_0, Guid P_1)
	{
		((EntitySettings)P_0).KeyColumnUid = P_1;
	}

	internal static Guid otq8jVOOvC9Tnydxl7UK(object P_0)
	{
		return ((EntitySettings)P_0).HierarchyParentUid;
	}

	internal static void ASMP90OOY7FUedMiefeD(object P_0, Guid P_1)
	{
		((EntitySettings)P_0).HierarchyParentUid = P_1;
	}

	internal static void tYblxhOO8tYvcQRMO1JT(object P_0, Guid P_1)
	{
		((EntityMetadata)P_0).ParentPropertyUid = P_1;
	}

	internal static void GhK5t1OOsD5NMy3P1CYC(object P_0, Guid P_1)
	{
		((AbstractMetadata)P_0).Uid = P_1;
	}

	internal static void Y4JhftOOJECy9fRX21VZ(object P_0, Guid P_1, object P_2, object P_3)
	{
		((MergeReplace)P_0).SetNameReplaceProperty(P_1, (string)P_2, (string)P_3);
	}

	internal static Guid tlMBldOOl6uE4dH9CvtJ(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyUid;
	}

	internal static void BrmH2mOO09NLsrSxCBFC(object P_0, Guid P_1, Guid P_2, Guid P_3)
	{
		((MergeReplace)P_0).SetUidReplaceProperty(P_1, P_2, P_3);
	}

	internal static void z2BMpcOOySGfV4vyUCiS(object P_0, Guid P_1)
	{
		((TablePartMetadata)P_0).TablePartPropertyUid = P_1;
	}

	internal static void pi8yaZOOmWu4f6WyhCNk(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).SubTypeUid = P_1;
	}

	internal static object kS9XJpOOtcnT3BPDdujG(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object zU5s9BOObIPS8vSM6T2K(object P_0, bool P_1)
	{
		return ClassSerializationHelper.SerializeObjectByXml(P_0, P_1);
	}

	internal static object FevpA6OO5Y8Uv4sSdOED(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool uH4c8OOOgofvmdRcPLv0(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void AfnYuCOOBjKe9hS6FUF5(object P_0, object P_1)
	{
		((IWorkflowProcess)P_0).Diagram = (WorkflowDiagram)P_1;
	}

	internal static void I6BLwqOOciFfKMKIYQlg(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object cnQR86OOPO4NwcyB1EkG(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static void kA6ViMOOXt9yNC1Hvgmy(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static void OftoerOOdUuDggcXgY2V()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object MQ5mpmOOujXZWAMmrbVK(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
