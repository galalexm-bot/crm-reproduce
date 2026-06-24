using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Globalization.ExtensionPoints;
using EleWise.ELMA.Globalization.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Globalization.Components;

[Component(Order = 20)]
internal class ProcessesExportLocalizationFileExtension : IExportLocalizationFileExtensionPoint
{
	private readonly ProcessHeaderManager processHeaderManager;

	private readonly ProcessGroupManager processGroupManager;

	private readonly string uidString;

	internal static ProcessesExportLocalizationFileExtension WauDUOCLCXcjYoHCeDV;

	public Guid Uid => ProcessesLocalizationLoadCustomSettings.ExtensionUid;

	public string Header => Tabs[(string)S5KyJ7CjICDhOkKXk5M(-1028861977 ^ -1028900539)];

	public IDictionary<string, string> Tabs => new Dictionary<string, string> { 
	{
		SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10364389),
		SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -43930051))
	} };

	public ProcessesExportLocalizationFileExtension(ProcessHeaderManager processHeaderManager, ProcessGroupManager processGroupManager)
	{
		//Discarded unreachable code: IL_003b, IL_0040
		GGkUInCW0XWtDQieYFo();
		uidString = (string)S5KyJ7CjICDhOkKXk5M(0x1AF6F1F2 ^ 0x1AF6B78E);
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				this.processGroupManager = processGroupManager;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.processHeaderManager = processHeaderManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public IDictionary<string, IEnumerable<LocalizableData>> GetAllData()
	{
		return new Dictionary<string, IEnumerable<LocalizableData>> { 
		{
			Tabs[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351375332)],
			FillProcessListGrid()
		} };
	}

	public object GetSettingObj(IDictionary<string, string> settingsJsonData)
	{
		ProcessGlobalizationSettings processGlobalizationSettings = new ProcessGlobalizationSettings();
		Guid[] values = new JsonSerializer().Deserialize<Guid[]>(settingsJsonData[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213F92D5)]);
		ICriteria val = processHeaderManager.CreateCriteriaForArraySearch(values, uidString, null, null).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Id() });
		processGlobalizationSettings.HeaderIds = val.List<long>().ToArray();
		return processGlobalizationSettings;
	}

	private IEnumerable<LocalizableData> FillProcessListGrid()
	{
		IEnumerable<IProcessHeader> collection = processHeaderManager.LoadRootProcessHeads();
		List<IProcessHeader> list = new List<IProcessHeader>();
		AddSubgroups(list, null);
		list.AddRange(collection);
		return from o in list
			orderby o.Name
			select o into md
			select new LocalizableData(md.Uid, (string)_003C_003Ec.P9S5DqZG0iqN4A58IbDS(md));
	}

	private void AddSubgroups(List<IProcessHeader> tempList, IProcessGroup group)
	{
		IEnumerable<IProcessGroup> enumerable;
		if (group == null)
		{
			enumerable = processGroupManager.LoadRootGroups();
		}
		else
		{
			IEnumerable<IProcessGroup> subGroups = (IEnumerable<IProcessGroup>)group.SubGroups;
			enumerable = subGroups;
		}
		IEnumerable<IProcessGroup> enumerable2 = enumerable;
		if (enumerable2 == null)
		{
			return;
		}
		foreach (IProcessGroup item in enumerable2)
		{
			tempList.AddRange((IEnumerable<IProcessHeader>)item.Processes);
			AddSubgroups(tempList, item);
		}
	}

	internal static void GGkUInCW0XWtDQieYFo()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object S5KyJ7CjICDhOkKXk5M(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool wQhsh7CfNEBa7UTwiPO()
	{
		return WauDUOCLCXcjYoHCeDV == null;
	}

	internal static ProcessesExportLocalizationFileExtension zmAiuRC9ZAKrEWvA33K()
	{
		return WauDUOCLCXcjYoHCeDV;
	}
}
