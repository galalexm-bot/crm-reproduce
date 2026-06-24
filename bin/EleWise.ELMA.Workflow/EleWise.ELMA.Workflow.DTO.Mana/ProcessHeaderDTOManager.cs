using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class ProcessHeaderDTOManager : DTOManager, IProcessHeaderDTOManager, IConfigurationService
{
	internal static ProcessHeaderDTOManager pyXQGpNeerY4xGm1Hv6;

	public ProcessHeaderManager ProcessHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeaderManager_003Ek__BackingField;
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
					_003CProcessHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
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

	public virtual ProcessHeaderDTO LoadOrNull(long id)
	{
		return Mapper.Map<IProcessHeader, ProcessHeaderDTO>(ProcessHeaderManager.LoadOrNull(id), new ProcessHeaderDTO());
	}

	public virtual ProcessHeaderDTO LoadOrNull(Guid uid)
	{
		return Mapper.Map<IProcessHeader, ProcessHeaderDTO>(ProcessHeaderManager.LoadOrNull(uid), new ProcessHeaderDTO());
	}

	public virtual ProcessHeaderDTO Save(ProcessHeaderDTO header)
	{
		int num = 1;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			default:
				ProcessHeaderManager.Save(processHeader);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return Mapper.Map<IProcessHeader, ProcessHeaderDTO>(processHeader, new ProcessHeaderDTO());
			case 1:
				processHeader = Mapper.Map<ProcessHeaderDTO, IProcessHeader>(header);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void Publish(ProcessHeaderDTO processHeader, string comment)
	{
		int num = 2;
		int num2 = num;
		IProcessHeader processHeader2 = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			case 2:
				lI4dxiNSwUMsoPwi48y(processHeader, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303601216 ^ -1303626116));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				processHeader2 = Mapper.Map<ProcessHeaderDTO, IProcessHeader>(processHeader);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num2 = 0;
				}
				break;
			default:
				M5wZTjN17U25hMdbhUV(ProcessHeaderManager, processHeader2, comment);
				num2 = 3;
				break;
			case 3:
				return;
			}
		}
	}

	public virtual void Publish(ProcessHeaderDTO[] processHeaders, string comment)
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
				QIyOXeNhS2PiTMEwibI(this, processHeaders, comment, false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void Publish(ProcessHeaderDTO[] processHeaders, string comment, bool generateDocumentation)
	{
		//Discarded unreachable code: IL_007d, IL_0105, IL_0114
		int num = 1;
		int num3 = default(int);
		ProcessHeaderDTO[] array = default(ProcessHeaderDTO[]);
		List<IProcessHeader> list = default(List<IProcessHeader>);
		IProcessHeader item = default(IProcessHeader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 5:
				case 7:
					if (num3 < array.Length)
					{
						num2 = 4;
						continue;
					}
					goto case 10;
				case 1:
					Contract.ArgumentNotNull(processHeaders, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45862605));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					num3++;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
					{
						num2 = 5;
					}
					continue;
				case 10:
					ProcessHeaderManager.Publish(list, comment, generateDocumentation);
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
					{
						num2 = 8;
					}
					continue;
				case 4:
				case 6:
					item = Mapper.Map<ProcessHeaderDTO, IProcessHeader>(array[num3]);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					list = new List<IProcessHeader>();
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 10;
					}
					continue;
				case 8:
					num3 = 0;
					num2 = 7;
					continue;
				case 11:
					array = processHeaders;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 6;
					}
					continue;
				case 9:
					return;
				}
				break;
			}
			list.Add(item);
			num = 3;
		}
	}

	public virtual void Unpublish(long[] processHeaderIds)
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
				Contract.ArgumentNotNull(processHeaderIds, (string)HCgeyxNEAahKZY3qkYS(-763667953 ^ -763638099));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				ProcessHeaderManager.Unpublish(processHeaderIds);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void Delete(long headerId)
	{
		int num = 3;
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				default:
					ProcessHeaderManager.Delete(processHeader);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (processHeader != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 1:
					return;
				}
				break;
			}
			processHeader = ProcessHeaderManager.LoadOrNull(headerId);
			num = 2;
		}
	}

	public virtual void Restore(ProcessHeaderDTO header)
	{
		//Discarded unreachable code: IL_0050, IL_005f
		int num = 2;
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 1:
					if (processHeader == null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 4:
					return;
				case 2:
					processHeader = Mapper.Map<ProcessHeaderDTO, IProcessHeader>(header);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			WaYTcPNwtkOXYHcapNh(ProcessHeaderManager, processHeader);
			num = 4;
		}
	}

	public virtual bool CheckProcessName(long id, long parentId, string name, out string errorMessage)
	{
		return ProcessHeaderManager.CheckProcessName(id, parentId, name, out errorMessage);
	}

	public virtual bool CheckProcessClassName(long id, long parentId, string name, out string errorMessage)
	{
		return ProcessHeaderManager.CheckProcessClassName(id, parentId, name, out errorMessage);
	}

	public virtual bool CheckProcessTableName(long id, long parentId, string name, out string errorMessage)
	{
		return ProcessHeaderManager.CheckProcessTableName(id, parentId, name, out errorMessage);
	}

	public virtual bool CheckProcessMetricTableName(long id, long parentId, string name, out string errorMessage)
	{
		return ProcessHeaderManager.CheckProcessMetricsTableName(id, parentId, name, out errorMessage);
	}

	public virtual bool CheckProcessInstanceMetricsTableName(long id, long parentId, string name, out string errorMessage)
	{
		return ProcessHeaderManager.CheckProcessInstanceMetricsTableName(id, parentId, name, out errorMessage);
	}

	public virtual List<ProcessHeaderDTO> FindAll(string searchString)
	{
		InstanceOf<IProcessHeaderFilter> instanceOf = new InstanceOf<IProcessHeaderFilter>();
		instanceOf.New.SearchString = searchString;
		IProcessHeaderFilter @new = instanceOf.New;
		return (from h in ProcessHeaderManager.Find(@new, FetchOptions.All)
			select Mapper.Map<IProcessHeader, ProcessHeaderDTO>(h, new ProcessHeaderDTO())).ToList();
	}

	public virtual List<ProcessInstanceStatistics> GetExecutingInstanceStatistics(bool onlyObsolete = false)
	{
		return ProcessHeaderManager.GetExecutingInstanceStatistics(onlyObsolete);
	}

	public virtual ProcessInstanceStatistics GetProcessExecutingInstanceStatistics(long headerId, bool onlyObsolete = false)
	{
		return ProcessHeaderManager.GetProcessExecutingInstanceStatistics(headerId, onlyObsolete);
	}

	public virtual long GetPublishingVersionNumber(long headerId)
	{
		return ProcessHeaderManager.GetPublishingVersionNumber(headerId);
	}

	public virtual List<ProcessHeaderDTO> FindDeleted()
	{
		return (from h in ProcessHeaderManager.FindDeleted()
			select Mapper.Map<IProcessHeader, ProcessHeaderDTO>(h, new ProcessHeaderDTO())).ToList();
	}

	public virtual long GetDeletedCount()
	{
		return ProcessHeaderManager.GetDeletedCount();
	}

	public virtual List<ProcessHeaderDTO> LoadSubProcesses(ProcessHeaderDTO header)
	{
		Contract.ArgumentNotNull(header, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EBD0CD));
		IProcessHeader header2 = ProcessHeaderManager.Load(header.Id);
		return (from p in ProcessHeaderManager.LoadSubProcesses(header2)
			select Mapper.Map<IProcessHeader, ProcessHeaderDTO>(p, new ProcessHeaderDTO())).ToList();
	}

	public virtual bool ValidateTableName(Guid ownerUid, string tableName, out string message)
	{
		return ProcessHeaderManager.ValidateTableName(ownerUid, tableName, out message);
	}

	public virtual bool ValidateClassName(string className, out string message)
	{
		return ProcessHeaderManager.ValidateClassName(className, out message);
	}

	public virtual long GetPublishedId(long headerId)
	{
		int num = 1;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return 0L;
			case 1:
				processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)lfUCiZN4HdYnuCTRBos()).Load(headerId);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (exGpi7Nzto3AdV7y7R5(processHeader) != null)
			{
				return ((IEntity<long>)exGpi7Nzto3AdV7y7R5(processHeader)).Id;
			}
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
			{
				num2 = 0;
			}
		}
	}

	public virtual List<Guid> GetPublishedPropertyUids(long headerId)
	{
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(headerId);
		List<Guid> result = new List<Guid>();
		if (processHeader.Context != null)
		{
			AddPropertyUids(processHeader.Context, result);
		}
		return result;
	}

	public virtual List<Guid> GetPublishedPropertySubTypeUid(long headerId)
	{
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(headerId);
		List<Guid> result = new List<Guid>();
		if (processHeader.Context != null)
		{
			AddPropertySubTypeUids(processHeader.Context, result);
		}
		return result;
	}

	public virtual List<Guid> GetPublishedMetricUids(long headerId)
	{
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(headerId);
		List<Guid> result = new List<Guid>();
		AddPropertyUids(processHeader.InstanceMetrics, result);
		AddPropertyUids(processHeader.ProcessMetrics, result);
		return result;
	}

	public virtual List<ProcessHeaderDTO> GetSubprocessTreeList(ProcessHeaderDTO header, bool onlyExternal = false)
	{
		if (header == null)
		{
			return new List<ProcessHeaderDTO>();
		}
		return (from h in ProcessHeaderManager.GetSubprocessTreeList(header.Id, onlyExternal)
			select Mapper.Map<IProcessHeader, ProcessHeaderDTO>(h, new ProcessHeaderDTO())).ToList();
	}

	public virtual ProcessCommonStatistics GetCommonStatistics(bool calculateExecutingCount)
	{
		return (ProcessCommonStatistics)RgTvVhxK1JSnUs8xJLn(ProcessHeaderManager, calculateExecutingCount);
	}

	private void AddPropertyUids(EntityMetadata metadata, List<Guid> result)
	{
		if (metadata == null)
		{
			return;
		}
		result.AddRange(((IEnumerable<EntityPropertyMetadata>)metadata.EntityProperties).Select((EntityPropertyMetadata p) => _003C_003Ec.NCFSBuZeqYYD52BDQ0E8(p)));
		foreach (TablePartMetadata item in (IEnumerable<TablePartMetadata>)metadata.EntityTableParts)
		{
			result.Add(item.TablePartPropertyUid);
			AddPropertyUids(item, result);
		}
	}

	private void AddPropertySubTypeUids(EntityMetadata metadata, List<Guid> result)
	{
		if (metadata == null)
		{
			return;
		}
		result.AddRange(((IEnumerable<EntityPropertyMetadata>)metadata.EntityProperties).Select((EntityPropertyMetadata p) => _003C_003Ec.Sp0fAXZe3f4aykXOkmxT(p)));
		foreach (TablePartMetadata item in (IEnumerable<TablePartMetadata>)metadata.EntityTableParts)
		{
			result.Add(item.TablePartPropertyUid);
			AddPropertyUids(item, result);
		}
	}

	public ProcessHeaderDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Hl8V3kxOXQbGcBx6ITS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool IYvoAKNN3DgACfW05ik()
	{
		return pyXQGpNeerY4xGm1Hv6 == null;
	}

	internal static ProcessHeaderDTOManager N73UwwNxfrhiuK0rmht()
	{
		return pyXQGpNeerY4xGm1Hv6;
	}

	internal static void lI4dxiNSwUMsoPwi48y(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void M5wZTjN17U25hMdbhUV(object P_0, object P_1, object P_2)
	{
		((ProcessHeaderManager)P_0).Publish((IProcessHeader)P_1, (string)P_2);
	}

	internal static void QIyOXeNhS2PiTMEwibI(object P_0, object P_1, object P_2, bool generateDocumentation)
	{
		((ProcessHeaderDTOManager)P_0).Publish((ProcessHeaderDTO[])P_1, (string)P_2, generateDocumentation);
	}

	internal static object HCgeyxNEAahKZY3qkYS(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void WaYTcPNwtkOXYHcapNh(object P_0, object P_1)
	{
		((ProcessHeaderManager)P_0).Restore((IProcessHeader)P_1);
	}

	internal static object lfUCiZN4HdYnuCTRBos()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static object exGpi7Nzto3AdV7y7R5(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static object RgTvVhxK1JSnUs8xJLn(object P_0, bool calculateExecutingCount)
	{
		return ((ProcessHeaderManager)P_0).GetCommonStatistics(calculateExecutingCount);
	}

	internal static void Hl8V3kxOXQbGcBx6ITS()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
