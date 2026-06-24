using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Audit.History;

[Component(Order = int.MaxValue)]
internal sealed class WorkflowInstanceActionEventMapping : IEntityActionEventMapping
{
	internal static WorkflowInstanceActionEventMapping oVJBULZnyAAFhhi1iEfw;

	public EntitySerializationSettings GetEntitySerializationSettings(Type entityType)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_0116, IL_0125
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (xGlUdGZn51OouTggLTAE(typeof(IWorkflowInstance).TypeHandle).IsAssignableFrom(entityType))
					{
						goto end_IL_0012;
					}
					goto default;
				case 2:
					if (ET0cObZnb8aUgIwJrRah(entityType, null))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				default:
					return null;
				case 3:
				{
					EntitySerializationSettings entitySerializationSettings = new EntitySerializationSettings();
					EntitySerializationSelector entitySerializationSelector = new EntitySerializationSelector();
					Dictionary<string, EntitySerializationSelector> dictionary = new Dictionary<string, EntitySerializationSelector>();
					object key = Xv7J44ZngOXdAcCloe3q(0x246EEF98 ^ 0x246EB1A0);
					EntitySerializationSelector obj = new EntitySerializationSelector
					{
						Properties = new Dictionary<string, EntitySerializationSelector> { 
						{
							(string)Xv7J44ZngOXdAcCloe3q(0x628167BE ^ 0x62810F28),
							new EntitySerializationSelector()
						} }
					};
					uP2sIhZnBGxjvRQN7Aiq(obj, SelectionMode.ByName);
					dictionary.Add((string)key, obj);
					entitySerializationSelector.Properties = dictionary;
					uP2sIhZnBGxjvRQN7Aiq(entitySerializationSelector, SelectionMode.All);
					Oi8yTqZnc8NtB0siaLCN(entitySerializationSettings, entitySerializationSelector);
					return entitySerializationSettings;
				}
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public WorkflowInstanceActionEventMapping()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KUeoBDZnPJ8I1xZ9eNIG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ET0cObZnb8aUgIwJrRah(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type xGlUdGZn51OouTggLTAE(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Xv7J44ZngOXdAcCloe3q(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void uP2sIhZnBGxjvRQN7Aiq(object P_0, SelectionMode P_1)
	{
		((EntitySerializationSelector)P_0).SelectionMode = P_1;
	}

	internal static void Oi8yTqZnc8NtB0siaLCN(object P_0, object P_1)
	{
		((EntitySerializationSettings)P_0).PropertySelector = (EntitySerializationSelector)P_1;
	}

	internal static bool bZgA1BZnmFTeXsjpHotg()
	{
		return oVJBULZnyAAFhhi1iEfw == null;
	}

	internal static WorkflowInstanceActionEventMapping UJUMMQZntkaG0Pr1kFYm()
	{
		return oVJBULZnyAAFhhi1iEfw;
	}

	internal static void KUeoBDZnPJ8I1xZ9eNIG()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
