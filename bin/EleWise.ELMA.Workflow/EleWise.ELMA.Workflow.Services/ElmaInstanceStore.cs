using System;
using System.Activities.DurableInstancing;
using System.Collections.Generic;
using System.IO;
using System.Runtime.DurableInstancing;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Linq;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

internal class ElmaInstanceStore : InstanceStore
{
	private readonly Guid ownerInstanceID;

	private readonly IWorkflowInstanceState state;

	private static ElmaInstanceStore xHkWHiAMYXAs5tmTBEa;

	public ElmaInstanceStore(IWorkflowInstanceState state)
	{
		//Discarded unreachable code: IL_001e
		rMtxXNAVBTmZliViJ8U();
		base._002Ector();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				ownerInstanceID = Guid.NewGuid();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				this.state = state;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override bool TryCommand(InstancePersistenceContext context, InstancePersistenceCommand command, TimeSpan timeout)
	{
		return EndTryCommand((IAsyncResult)gcbYJtAArpWSAMbYSR3(this, context, command, timeout, null, null));
	}

	protected override IAsyncResult BeginTryCommand(InstancePersistenceContext context, InstancePersistenceCommand command, TimeSpan timeout, AsyncCallback callback, object state)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_00e2, IL_00f1, IL_0117, IL_0126, IL_0135, IL_0144
		int num = 13;
		int num2 = num;
		IDictionary<XName, InstanceValue> instanceData = default(IDictionary<XName, InstanceValue>);
		SaveWorkflowCommand saveWorkflowCommand = default(SaveWorkflowCommand);
		while (true)
		{
			switch (num2)
			{
			case 5:
			case 12:
				if (!(command is SaveWorkflowCommand))
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 13:
				if (!(command is CreateWorkflowOwnerCommand))
				{
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 8;
			default:
				return new CompletedAsyncResult<bool>(data: true, callback, state);
			case 3:
			case 7:
				if (!(command is LoadWorkflowCommand))
				{
					num2 = 11;
					continue;
				}
				goto case 6;
			case 1:
				context.LoadedInstance(InstanceState.Initialized, instanceData, null, null, null);
				num2 = 9;
				continue;
			case 6:
				instanceData = Load(context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
				{
					num2 = 1;
				}
				continue;
			case 8:
				pVvZ6UAGhoJkEWnDnMZ(context, ownerInstanceID, ownerInstanceID);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num2 = 4;
				}
				continue;
			case 2:
				Save(context, saveWorkflowCommand.InstanceData);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				break;
			}
			saveWorkflowCommand = (SaveWorkflowCommand)command;
			num2 = 2;
		}
	}

	protected override bool EndTryCommand(IAsyncResult result)
	{
		return CompletedAsyncResult<bool>.End(result);
	}

	private IDictionary<XName, InstanceValue> Load(InstancePersistenceContext context)
	{
		using MemoryStream inStream = MemoryHelper.GetMemoryStream(state.State, writable: false);
		Dictionary<XName, InstanceValue> dictionary = new Dictionary<XName, InstanceValue>();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(inStream);
		foreach (XmlElement item in xmlDocument.GetElementsByTagName(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057793103)))
		{
			XmlElement element = (XmlElement)item.SelectSingleNode(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x140DE7C));
			XName key = (XName)DeserializeObject(element);
			XmlElement element2 = (XmlElement)item.SelectSingleNode(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303601216 ^ -1303541514));
			InstanceValue value = new InstanceValue(DeserializeObject(element2));
			dictionary.Add(key, value);
		}
		return dictionary;
	}

	private void Save(InstancePersistenceContext context, IDictionary<XName, InstanceValue> instanceData)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214243548));
		foreach (KeyValuePair<XName, InstanceValue> instanceDatum in instanceData)
		{
			XmlElement xmlElement = xmlDocument.CreateElement(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430584555));
			XmlElement newChild = SerializeObject(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A68D24F), instanceDatum.Key, xmlDocument);
			xmlElement.AppendChild(newChild);
			XmlElement newChild2 = SerializeObject(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197708468), instanceDatum.Value.Value, xmlDocument);
			xmlElement.AppendChild(newChild2);
			xmlDocument.DocumentElement.AppendChild(xmlElement);
		}
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		xmlDocument.Save(memoryStream);
		state.State = memoryStream.ToArray();
		state.Save();
	}

	private XmlElement SerializeObject(string elementName, object obj, XmlDocument doc)
	{
		//Discarded unreachable code: IL_0050, IL_00d1, IL_00f9, IL_0139, IL_0148, IL_0175, IL_01ad, IL_01bc
		int num = 2;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		StreamReader streamReader = default(StreamReader);
		XmlElement xmlElement = default(XmlElement);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					new NetDataContractSerializer().Serialize(memoryStream, obj);
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							hhmWm4A72RpD8fDPKRv(memoryStream, 0L);
							num3 = 2;
							break;
						case 2:
							streamReader = new StreamReader(memoryStream);
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
							{
								num3 = 1;
							}
							break;
						case 1:
							try
							{
								object obj2 = dEm6hGA2WEFy0kk0DYh(doc, elementName);
								PA19rQAFT9lL1qTQpo7(obj2, nM8U1GAouoi9GrRnQRJ(streamReader));
								xmlElement = (XmlElement)obj2;
								int num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
								{
									num4 = 0;
								}
								return num4 switch
								{
									0 => xmlElement, 
									_ => xmlElement, 
								};
							}
							finally
							{
								int num5;
								if (streamReader == null)
								{
									num5 = 2;
									goto IL_00fd;
								}
								goto IL_0113;
								IL_00fd:
								switch (num5)
								{
								default:
									goto end_IL_00e8;
								case 1:
									break;
								case 2:
									goto end_IL_00e8;
								case 0:
									goto end_IL_00e8;
								}
								goto IL_0113;
								IL_0113:
								((IDisposable)streamReader).Dispose();
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
								{
									num5 = 0;
								}
								goto IL_00fd;
								end_IL_00e8:;
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						int num6 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								((IDisposable)memoryStream).Dispose();
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
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
				}
			default:
				return xmlElement;
			case 2:
				memoryStream = MemoryHelper.GetMemoryStream();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private object DeserializeObject(XmlElement element)
	{
		//Discarded unreachable code: IL_0072, IL_00aa, IL_00ea, IL_00f5, IL_0104
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				memoryStream = (MemoryStream)Ipvf3KAiv7k1vhyMveP();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				NetDataContractSerializer netDataContractSerializer = new NetDataContractSerializer();
				XmlDictionaryWriter xmlDictionaryWriter = (XmlDictionaryWriter)hr9rNiAIdTfTN445kx4(memoryStream);
				s0ulcaAaxprK9G5av48(element, xmlDictionaryWriter);
				kT07ORArNXnCliEwDdm(xmlDictionaryWriter);
				memoryStream.Position = 0L;
				result = sjsCWMAe7YnqWIuZEvX(netDataContractSerializer, memoryStream);
				int num3 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				int num4;
				if (memoryStream == null)
				{
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
					{
						num4 = 0;
					}
					goto IL_00ae;
				}
				goto IL_00c4;
				IL_00c4:
				W9OQM1ANNVI4Vv3ne3a(memoryStream);
				num4 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num4 = 1;
				}
				goto IL_00ae;
				IL_00ae:
				switch (num4)
				{
				default:
					goto end_IL_0089;
				case 2:
					break;
				case 0:
					goto end_IL_0089;
				case 1:
					goto end_IL_0089;
				}
				goto IL_00c4;
				end_IL_0089:;
			}
		}
	}

	internal static void rMtxXNAVBTmZliViJ8U()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool MnXI1UAkd9knA3dDKuZ()
	{
		return xHkWHiAMYXAs5tmTBEa == null;
	}

	internal static ElmaInstanceStore QS1M8SAUjYyIeL9GJS2()
	{
		return xHkWHiAMYXAs5tmTBEa;
	}

	internal static object gcbYJtAArpWSAMbYSR3(object P_0, object P_1, object P_2, TimeSpan P_3, object P_4, object P_5)
	{
		return ((InstanceStore)P_0).BeginTryCommand((InstancePersistenceContext)P_1, (InstancePersistenceCommand)P_2, P_3, (AsyncCallback)P_4, P_5);
	}

	internal static void pVvZ6UAGhoJkEWnDnMZ(object P_0, Guid P_1, Guid P_2)
	{
		((InstancePersistenceContext)P_0).BindInstanceOwner(P_1, P_2);
	}

	internal static void hhmWm4A72RpD8fDPKRv(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static object dEm6hGA2WEFy0kk0DYh(object P_0, object P_1)
	{
		return ((XmlDocument)P_0).CreateElement((string)P_1);
	}

	internal static object nM8U1GAouoi9GrRnQRJ(object P_0)
	{
		return ((TextReader)P_0).ReadToEnd();
	}

	internal static void PA19rQAFT9lL1qTQpo7(object P_0, object P_1)
	{
		((XmlNode)P_0).InnerXml = (string)P_1;
	}

	internal static object Ipvf3KAiv7k1vhyMveP()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static object hr9rNiAIdTfTN445kx4(object P_0)
	{
		return XmlDictionaryWriter.CreateTextWriter((Stream)P_0);
	}

	internal static void s0ulcaAaxprK9G5av48(object P_0, object P_1)
	{
		((XmlNode)P_0).WriteContentTo((XmlWriter)P_1);
	}

	internal static void kT07ORArNXnCliEwDdm(object P_0)
	{
		((XmlWriter)P_0).Flush();
	}

	internal static object sjsCWMAe7YnqWIuZEvX(object P_0, object P_1)
	{
		return ((NetDataContractSerializer)P_0).Deserialize((Stream)P_1);
	}

	internal static void W9OQM1ANNVI4Vv3ne3a(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
