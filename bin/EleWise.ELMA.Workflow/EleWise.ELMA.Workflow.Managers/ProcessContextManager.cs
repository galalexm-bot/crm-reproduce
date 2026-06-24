using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class ProcessContextManager : EntityManager<ProcessContext, long>
{
	internal static ProcessContextManager Ii69aonnBdmVbJucGx1;

	public new static ProcessContextManager Instance => Locator.GetServiceNotNull<ProcessContextManager>();

	public override ProcessContext Load(Guid uid)
	{
		return ((ICriteria)dkcmMKnWphhNmawe1q8(((ISession)Qi5RkPnfJPylwSEWTPb(this)).CreateCriteria<ProcessContext>(), Restrictions.Eq((string)eYKhg9n9goIO4O2qxCb(0xD305CC2 ^ 0xD301ABE), (object)uid))).UniqueResult<ProcessContext>();
	}

	public string AllHaveUids()
	{
		//Discarded unreachable code: IL_00a1, IL_00ab, IL_0172, IL_01aa
		int num = 2;
		int num2 = num;
		string text = default(string);
		IEnumerator<IProcessHeader> enumerator = default(IEnumerator<IProcessHeader>);
		IList<IProcessHeader> list = default(IList<IProcessHeader>);
		IProcessHeader current = default(IProcessHeader);
		DetachedCriteria val = default(DetachedCriteria);
		while (true)
		{
			switch (num2)
			{
			default:
				text = (string)YB5fQ9nVKERQYDTysyG(eYKhg9n9goIO4O2qxCb(-667465279 ^ -667433629), kkTTHXnUNJxZcQV3tfS(eYKhg9n9goIO4O2qxCb(0x3C1FFB55 ^ 0x3C1F77FB)));
				num2 = 6;
				break;
			case 6:
				enumerator = list.GetEnumerator();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!xtNt7en7NP04cenjnhB(enumerator))
						{
							num3 = 3;
							goto IL_00af;
						}
						goto IL_0129;
						IL_00af:
						while (true)
						{
							switch (num3)
							{
							case 1:
								text = (string)irfJXqnGXIxOyC5KRlQ(text, YB5fQ9nVKERQYDTysyG(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965258169), kkTTHXnUNJxZcQV3tfS(Bq4xlcnAQZL1QKWvKQS(current))));
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								goto IL_0129;
							case 3:
								return text;
							}
							break;
						}
						continue;
						IL_0129:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
						{
							num3 = 1;
						}
						goto IL_00af;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								zqMo45n2kshSXSa9MYF(enumerator);
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 1:
				list = ((ICriteria)dkcmMKnWphhNmawe1q8(leIysDnCOCL1YKOfAM0(((ISession)Qi5RkPnfJPylwSEWTPb(this)).CreateCriteria<IProcessHeader>((string)eYKhg9n9goIO4O2qxCb(0x5DB28AD2 ^ 0x5DB2EE6C)), eYKhg9n9goIO4O2qxCb(0x65B7F624 ^ 0x65B792E2), eYKhg9n9goIO4O2qxCb(0x56A753C9 ^ 0x56A7DF5F)), HYx6CRnMmg5gQcbPyDa(val))).List<IProcessHeader>();
				num2 = 7;
				break;
			case 4:
				if (EOfk5ynkNtdqmuL4HYP(list) != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 5:
				return text;
			case 7:
				text = null;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				val = (DetachedCriteria)WT7Q4KnpN3IMdD0sbRG(OTf91onqdJLfp0KDaTa(((DetachedCriteria)g7iL04nR2NCo8BWFibP(n9ujMxnjY9g3Bo4c21a(InterfaceActivator.TypeOf<EntityPropertyMetadata>(), eYKhg9n9goIO4O2qxCb(-961162596 ^ -961192242)), eYKhg9n9goIO4O2qxCb(-683713632 ^ -683681798), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -947973883))).Add((ICriterion)XDr9lQn6b4L6a0kYSmX(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002099299), eYKhg9n9goIO4O2qxCb(-947937941 ^ -947973649))), Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F82659), eYKhg9n9goIO4O2qxCb(-2002063381 ^ -2002081385))), MrQUtsnQadt3ERCLwkg(iM0a5Sn3bbELBQXtmO0(), VgdCecnTvZsshXi73bm()));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void UpdateContextTableUids()
	{
		//Discarded unreachable code: IL_0067, IL_009a, IL_00f5, IL_0104
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				((ISession)Qi5RkPnfJPylwSEWTPb(this)).CreateCriteria<IProcessHeader>((string)eYKhg9n9goIO4O2qxCb(0x438A0E43 ^ 0x438A6AFD)).List<IProcessHeader>();
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						throw;
					}
					qN7bxrnFlvWVQRpZgWG(DZ00NynoHU3MUHlqNd4(), string.Format((string)eYKhg9n9goIO4O2qxCb(-801808857 ^ -801778881), ex.Message), ex);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
					{
						num2 = 1;
					}
				}
			}
		}
	}

	public virtual IDictionary<ProcessInfoDTO, IEnumerable<ProcessPropertyInfoDTO>> GetChildPropertyNames(long processHeaderId)
	{
		SerializableDictionary<ProcessInfoDTO, IEnumerable<ProcessPropertyInfoDTO>> serializableDictionary = new SerializableDictionary<ProcessInfoDTO, IEnumerable<ProcessPropertyInfoDTO>>();
		IProcessHeader header = ProcessHeaderManager.Instance.Load(processHeaderId);
		AddChildPropertyNames(serializableDictionary, header);
		return serializableDictionary;
	}

	private void AddChildPropertyNames(IDictionary<ProcessInfoDTO, IEnumerable<ProcessPropertyInfoDTO>> namesDict, IProcessHeader header)
	{
		foreach (IProcessHeader item in ((IEnumerable<IProcessHeader>)header.SubHeaders).Where((IProcessHeader h) => _003C_003Ec.VJvewWZQUPSoR5d6tPaJ(h) != WorkflowProcessStatus.Deleted))
		{
			if (item.Current != null && item.Current.Context != null)
			{
				SerializableList<ProcessPropertyInfoDTO> serializableList = new SerializableList<ProcessPropertyInfoDTO>();
				IList<object[]> source = base.Session.CreateCriteria<EntityPropertyMetadata>().Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA582A8), (object)item.Current.Context)).SetProjection((IProjection[])(object)new IProjection[2]
				{
					(IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x559B2F52)),
					(IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74ABCA65))
				})
					.List<object[]>();
				serializableList.AddRange(source.Select(delegate(object[] ar)
				{
					ProcessPropertyInfoDTO processPropertyInfoDTO = new ProcessPropertyInfoDTO();
					_003C_003Ec.pdSnFbZQV2gSGdPmgya6(processPropertyInfoDTO, (string)ar[0]);
					processPropertyInfoDTO.DisplayName = (string)ar[1];
					return processPropertyInfoDTO;
				}));
				namesDict[new ProcessInfoDTO
				{
					HeaderId = item.Id,
					Name = item.Name
				}] = serializableList;
				AddChildPropertyNames(namesDict, item);
			}
		}
	}

	public ProcessContextManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		o8e15QniKCipjmIsfdK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Qi5RkPnfJPylwSEWTPb(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object eYKhg9n9goIO4O2qxCb(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object dkcmMKnWphhNmawe1q8(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static bool jA0pjHnH2p1Swv3adbs()
	{
		return Ii69aonnBdmVbJucGx1 == null;
	}

	internal static ProcessContextManager OKmgUNnLiViu6x2LgMx()
	{
		return Ii69aonnBdmVbJucGx1;
	}

	internal static object n9ujMxnjY9g3Bo4c21a(Type P_0, object P_1)
	{
		return DetachedCriteria.For(P_0, (string)P_1);
	}

	internal static object g7iL04nR2NCo8BWFibP(object P_0, object P_1, object P_2)
	{
		return ((DetachedCriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static object XDr9lQn6b4L6a0kYSmX(object P_0, object P_1)
	{
		return Restrictions.EqProperty((string)P_0, (string)P_1);
	}

	internal static object OTf91onqdJLfp0KDaTa(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object iM0a5Sn3bbELBQXtmO0()
	{
		return Projections.ProjectionList();
	}

	internal static object VgdCecnTvZsshXi73bm()
	{
		return Projections.Id();
	}

	internal static object MrQUtsnQadt3ERCLwkg(object P_0, object P_1)
	{
		return ((ProjectionList)P_0).Add((IProjection)P_1);
	}

	internal static object WT7Q4KnpN3IMdD0sbRG(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).SetProjection((IProjection)P_1);
	}

	internal static object leIysDnCOCL1YKOfAM0(object P_0, object P_1, object P_2)
	{
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static object HYx6CRnMmg5gQcbPyDa(object P_0)
	{
		return Subqueries.NotExists((DetachedCriteria)P_0);
	}

	internal static int EOfk5ynkNtdqmuL4HYP(object P_0)
	{
		return ((ICollection<IProcessHeader>)P_0).Count;
	}

	internal static object kkTTHXnUNJxZcQV3tfS(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object YB5fQ9nVKERQYDTysyG(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object Bq4xlcnAQZL1QKWvKQS(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}

	internal static object irfJXqnGXIxOyC5KRlQ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool xtNt7en7NP04cenjnhB(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void zqMo45n2kshSXSa9MYF(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object DZ00NynoHU3MUHlqNd4()
	{
		return EleWise.ELMA.Logging.Logger.Log;
	}

	internal static void qN7bxrnFlvWVQRpZgWG(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void o8e15QniKCipjmIsfdK()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
