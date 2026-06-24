using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Actors;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services;

[Service]
public class ExternalMembershipImportManager
{
	[Serializable]
	private class ImportModel
	{
		[XmlAttribute]
		private string groups;

		private static object yC21wApxFDnedN3mBlQh;

		[XmlIgnore]
		public IEnumerable<ProcessingItem> ProcessingItems
		{
			get
			{
				return new JsonSerializer().Deserialize<IEnumerable<ProcessingItem>>(userNames);
			}
			set
			{
				userNames = new JsonSerializer().Serialize(value);
			}
		}

		[XmlAttribute]
		private string userNames
		{
			[CompilerGenerated]
			get
			{
				return _003CuserNames_003Ek__BackingField;
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
						_003CuserNames_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		[XmlIgnore]
		public IEnumerable<long> Groups
		{
			get
			{
				return new JsonSerializer().Deserialize<IEnumerable<long>>(groups);
			}
			set
			{
				groups = new JsonSerializer().Serialize(value);
			}
		}

		public Guid AuthProviderGuid
		{
			[CompilerGenerated]
			get
			{
				return _003CAuthProviderGuid_003Ek__BackingField;
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
						_003CAuthProviderGuid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
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

		public Guid Uid
		{
			[CompilerGenerated]
			get
			{
				return _003CUid_003Ek__BackingField;
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
						_003CUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
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

		public ImportModel()
		{
			//Discarded unreachable code: IL_002a
			zw1mqkpxDSqDUFZeEUo4();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					Uid = k5hbHDpxMkv0we3nyTdD();
					int num2 = 3;
					num = num2;
					continue;
				}
				case 3:
					return;
				case 1:
					Groups = Enumerable.Empty<long>();
					num = 2;
					continue;
				}
				ProcessingItems = Enumerable.Empty<ProcessingItem>();
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
				{
					num = 1;
				}
			}
		}

		public ImportModel(IEnumerable<string> users, EditableListModel groups, Guid authProviderUid, ProcessingStatus status)
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
			CS_0024_003C_003E8__locals0.status = status;
			base._002Ector();
			ProcessingItems = users.Select(delegate(string a)
			{
				ProcessingItem processingItem = new ProcessingItem();
				_003C_003Ec__DisplayClass1_0.iYvrSwpK6T9xJ3YqcyfU(processingItem, a);
				_003C_003Ec__DisplayClass1_0.rfUs0YpKl3tunqW6if5J(processingItem, CS_0024_003C_003E8__locals0.status);
				return processingItem;
			});
			Groups = groups.Items.Select((EditableListItem a) => ((string)_003C_003Ec.zhWTw0pKuCeVoVmgYiOP(a)).FromJson<long>());
			AuthProviderGuid = authProviderUid;
			Uid = Guid.NewGuid();
		}

		public ImportModel(IEnumerable<string> users, IEnumerable<long> groups, Guid authProviderUid, ProcessingStatus status)
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
			CS_0024_003C_003E8__locals0.status = status;
			base._002Ector();
			ProcessingItems = users.Select(delegate(string a)
			{
				ProcessingItem processingItem = new ProcessingItem();
				_003C_003Ec__DisplayClass2_0.KLuikcpKjRJX3GIeoQ24(processingItem, a);
				_003C_003Ec__DisplayClass2_0.gE09M4pKHGUJpIPgVHhv(processingItem, CS_0024_003C_003E8__locals0.status);
				return processingItem;
			});
			Groups = groups;
			AuthProviderGuid = authProviderUid;
			Uid = Guid.NewGuid();
		}

		internal static void zw1mqkpxDSqDUFZeEUo4()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static Guid k5hbHDpxMkv0we3nyTdD()
		{
			return Guid.NewGuid();
		}

		internal static bool VjkBWGpx0XJrx4eaQB86()
		{
			return yC21wApxFDnedN3mBlQh == null;
		}

		internal static ImportModel dInpa8pxEfi7Efim8XZh()
		{
			return (ImportModel)yC21wApxFDnedN3mBlQh;
		}
	}

	internal class ProcessingItem
	{
		private static ProcessingItem OTldodpxsJks6QEtpO4B;

		public string UserName
		{
			[CompilerGenerated]
			get
			{
				return _003CUserName_003Ek__BackingField;
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
						_003CUserName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c != 0)
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

		public ProcessingStatus Status
		{
			[CompilerGenerated]
			get
			{
				return _003CStatus_003Ek__BackingField;
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
						_003CStatus_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 != 0)
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

		public DateTime? StartProcessing { get; set; }

		public long? ExpireProcessingTimestamp { get; set; }

		public ProcessingItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool PJy7L0pxY0X6k5Ej2dB3()
		{
			return OTldodpxsJks6QEtpO4B == null;
		}

		internal static ProcessingItem rlbpEPpxIdylnPY2Tt98()
		{
			return OTldodpxsJks6QEtpO4B;
		}
	}

	internal enum ProcessingStatus
	{
		None,
		Process,
		Complete
	}

	private Guid UID;

	internal static ExternalMembershipImportManager wklrghwXMrDetCHCJFw;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public UserManager UserManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUserManager_003Ek__BackingField;
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
					_003CUserManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	public IExternalMembershipManager ExternalMembershipManager
	{
		[CompilerGenerated]
		get
		{
			return _003CExternalMembershipManager_003Ek__BackingField;
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
					_003CExternalMembershipManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("NotUsed", true)]
	public ILockManager LockManager
	{
		[CompilerGenerated]
		get
		{
			return _003CLockManager_003Ek__BackingField;
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
					_003CLockManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public ITimestampService TimestampService
	{
		[CompilerGenerated]
		get
		{
			return _003CTimestampService_003Ek__BackingField;
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
					_003CTimestampService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	public IActorModelRuntime ActorModelRuntime
	{
		[CompilerGenerated]
		get
		{
			return _003CActorModelRuntime_003Ek__BackingField;
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
					_003CActorModelRuntime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
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

	private int ProcessingCount => SR.GetSetting((string)GBMLimw6897MLGNeWWQ(-1712587919 ^ -1712607701), 50);

	private int ProcessingTimeout => SR.GetSetting((string)GBMLimw6897MLGNeWWQ(0x4B68CDFB ^ 0x4B689847), 50);

	public bool CheckImportProgress(Guid authProviderUid)
	{
		return GetAuthProviderImportInfo(authProviderUid) != null;
	}

	public void AddUsersToImport(IEnumerable<string> users, EditableListModel groups, Guid authProviderUid)
	{
		AddUsersToImport(users, groups.Items.Select((EditableListItem a) => ((string)_003C_003Ec.pSXWSjpxrve7mXXj0muJ(a)).FromJson<long>()), authProviderUid);
	}

	public void AddUsersToImport(IEnumerable<string> users, IEnumerable<long> groups, Guid authProviderUid)
	{
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
		_003C_003Ec__DisplayClass22_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass22_.users = users;
		_003C_003Ec__DisplayClass22_.groups = groups;
		_003C_003Ec__DisplayClass22_.authProviderUid = authProviderUid;
		Task.Run(() => _003C_003Ec__DisplayClass22_._003C_003E4__this.ActorModelRuntime.GetActor<IExternalMembershipImportManagerActor>(0L).AddUsersToImport(_003C_003Ec__DisplayClass22_.users.ToArray(), _003C_003Ec__DisplayClass22_.groups.ToArray(), _003C_003Ec__DisplayClass22_.authProviderUid)).Wait();
	}

	internal void AddUsersToImportInternal(IEnumerable<string> users, IEnumerable<long> groups, Guid authProviderUid)
	{
		AddUsersToImport(new ImportModel(users, groups, authProviderUid, ProcessingStatus.None));
	}

	private void AddUsersToImport(ImportModel model)
	{
		//Discarded unreachable code: IL_0067, IL_0076, IL_0086, IL_00ab
		int num = 8;
		int num2 = num;
		List<ImportModel> list = default(List<ImportModel>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!model.ProcessingItems.Any())
				{
					num2 = 10;
					break;
				}
				list = GetAllImportInfo();
				num2 = 9;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
				{
					num2 = 5;
				}
				break;
			case 7:
				return;
			case 6:
				return;
			case 8:
				if (model.ProcessingItems == null)
				{
					num2 = 7;
					break;
				}
				goto case 1;
			case 3:
				list = new List<ImportModel> { model };
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
			case 5:
				((IBLOBDataManager)mifesOw7XsnQcthR3qf()).SetBLOB(UID, (string)GBMLimw6897MLGNeWWQ(-1586242415 ^ -1586262203), list);
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
				{
					num2 = 6;
				}
				break;
			case 9:
				if (list != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 10:
				return;
			default:
				list.Add(model);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private List<ImportModel> GetAllImportInfo()
	{
		return DataAccessManager.BLOBManager.GetBLOB<List<ImportModel>>(UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6547C338 ^ 0x654790EC));
	}

	private ImportModel GetAuthProviderImportInfo(Guid uid)
	{
		//Discarded unreachable code: IL_005a, IL_0069
		int num = 2;
		int num2 = num;
		List<ImportModel> allImportInfo = default(List<ImportModel>);
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = default(_003C_003Ec__DisplayClass26_0);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (allImportInfo != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 1:
				_003C_003Ec__DisplayClass26_.uid = uid;
				num2 = 4;
				break;
			case 3:
				return null;
			default:
				return allImportInfo.FirstOrDefault(_003C_003Ec__DisplayClass26_._003CGetAuthProviderImportInfo_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				allImportInfo = GetAllImportInfo();
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	private bool SetImportEnd(Guid uid)
	{
		//Discarded unreachable code: IL_00aa, IL_013d, IL_014c
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = default(_003C_003Ec__DisplayClass27_0);
		List<ImportModel> bLOB = default(List<ImportModel>);
		ImportModel item = default(ImportModel);
		while (true)
		{
			switch (num2)
			{
			case 5:
				_003C_003Ec__DisplayClass27_.uid = uid;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
				{
					num2 = 4;
				}
				continue;
			case 6:
				_003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
				num2 = 5;
				continue;
			case 9:
				return false;
			case 1:
				bLOB.Remove(item);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 != 0)
				{
					num2 = 7;
				}
				continue;
			case 4:
				bLOB = DataAccessManager.BLOBManager.GetBLOB<List<ImportModel>>(UID, (string)GBMLimw6897MLGNeWWQ(-2030777218 ^ -2030788694));
				num2 = 11;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
				{
					num2 = 5;
				}
				continue;
			case 7:
				if (bLOB.Count != 0)
				{
					num2 = 3;
					continue;
				}
				break;
			case 8:
				return true;
			case 10:
				item = bLOB.FirstOrDefault(_003C_003Ec__DisplayClass27_._003CSetImportEnd_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				return true;
			case 3:
				((IBLOBDataManager)mifesOw7XsnQcthR3qf()).SetBLOB(UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6AA79E0 ^ 0x6AA2A34), bLOB);
				num2 = 9;
				continue;
			case 11:
				if (bLOB != null)
				{
					num2 = 10;
					continue;
				}
				goto case 8;
			}
			DataAccessManager.BLOBManager.RemoveBLOB<List<ImportModel>>(UID, (string)GBMLimw6897MLGNeWWQ(0x48E9668D ^ 0x48E93559));
			num2 = 2;
		}
	}

	public void StartImportUsers()
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
				ActorModelRuntime.GetActor<IExternalMembershipImportManagerActor>(0L).Start().Wait();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void ImportUsersInternal()
	{
		//Discarded unreachable code: IL_005e, IL_00da, IL_0102, IL_0142, IL_0151, IL_017e, IL_01b6, IL_0268
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = default(_003C_003Ec__DisplayClass29_0);
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			switch (num2)
			{
			case 7:
				try
				{
					CallContextSessionOwner callContextSessionOwner = CallContextSessionOwner.Create();
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					}
					try
					{
						new BackgroundTask(_003C_003Ec__DisplayClass29_._003CImportUsersInternal_003Eb__0, e98dyvwNJRXgbpbLhpi(typeof(IUser).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2E78F5A0 ^ 0x2E78A188), (string)GBMLimw6897MLGNeWWQ(-905821499 ^ -905832723)).Execute();
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						int num5;
						if (callContextSessionOwner == null)
						{
							num5 = 2;
							goto IL_0106;
						}
						goto IL_011c;
						IL_0106:
						switch (num5)
						{
						case 2:
							goto end_IL_00f1;
						case 1:
							goto end_IL_00f1;
						}
						goto IL_011c;
						IL_011c:
						((IDisposable)callContextSessionOwner).Dispose();
						num5 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
						{
							num5 = 1;
						}
						goto IL_0106;
						end_IL_00f1:;
					}
				}
				finally
				{
					if (disposable != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								disposable.Dispose();
								num6 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
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
			default:
				_003C_003Ec__DisplayClass29_._003C_003E4__this = this;
				num2 = 5;
				break;
			case 3:
				return;
			case 5:
				_003C_003Ec__DisplayClass29_.importInfo = GetObjectsForImport();
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				return;
			case 4:
				disposable = (IDisposable)PKDjdVwlJ8CN6BGw2WX();
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (_003C_003Ec__DisplayClass29_.importInfo == null)
				{
					return;
				}
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public void ImportUsers(IEnumerable<string> userNames, IEnumerable<long> groups, Guid authProviderUid)
	{
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
		_003C_003Ec__DisplayClass30_.userNames = userNames;
		UserManager userManager = UserManager;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(EleWise.ELMA.Security.Models.IUser), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965109395 ^ -1965122771));
		ICollection<EleWise.ELMA.Security.Models.IUser> source = userManager.Find(Expression.Lambda<Func<EleWise.ELMA.Security.Models.IUser, bool>>(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[2]
		{
			Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass30_, typeof(_003C_003Ec__DisplayClass30_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))
		}), new ParameterExpression[1] { parameterExpression }));
		using IEnumerator<string> enumerator = _003C_003Ec__DisplayClass30_.userNames.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass30_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass30_1();
			CS_0024_003C_003E8__locals0.userName = enumerator.Current;
			try
			{
				EleWise.ELMA.Security.Models.IUser user = source.FirstOrDefault((EleWise.ELMA.Security.Models.IUser a) => (string)_003C_003Ec__DisplayClass30_1.FgM9b9pBRq0lNGAgdgxi(a) == CS_0024_003C_003E8__locals0.userName);
				bool flag = false;
				if (user == null)
				{
					flag = true;
					user = UserManager.Create();
					user.UserName = CS_0024_003C_003E8__locals0.userName;
				}
				Dictionary<Guid, string> allName = ExternalMembershipManager.GetAllName();
				if ((user.AuthProviderGuid == Guid.Empty || !allName.ContainsKey(user.AuthProviderGuid)) && user.Status == UserStatus.Active)
				{
					user.AuthProviderGuid = authProviderUid;
					ExternalMembershipManager.Sync(user, authProviderUid);
					if (groups != null && flag)
					{
						if (UserManager.CanCreateNewUser())
						{
							UserManager.SaveUserWithGroups(user, "", groups, delegate(IUserGroup g)
							{
								int num = 1;
								int num2 = num;
								while (true)
								{
									switch (num2)
									{
									case 1:
										if (_003C_003Ec.DQq89apxbQ8qWUj9fYlL(_003C_003Ec.c22IAjpxyAmiJ8UAgWy3(g), Guid.Empty))
										{
											return true;
										}
										num2 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
										{
											num2 = 0;
										}
										break;
									default:
										return _003C_003Ec.DQq89apxbQ8qWUj9fYlL(_003C_003Ec.c22IAjpxyAmiJ8UAgWy3(g), InterfaceActivator.UID<IUserGroup>());
									}
								}
							});
						}
						else
						{
							Logger.Log.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1826813434 ^ -1826791872), CS_0024_003C_003E8__locals0.userName));
						}
					}
					else
					{
						UserManager.Save(user, "");
					}
					Logger.Log.Info(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-816887841 ^ -816901307), CS_0024_003C_003E8__locals0.userName));
				}
				else
				{
					Logger.Log.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B47EB6B), CS_0024_003C_003E8__locals0.userName));
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1076846736 ^ -1076835754), CS_0024_003C_003E8__locals0.userName, ex.Message), ex);
			}
		}
	}

	private ImportModel GetObjectsForImport()
	{
		//Discarded unreachable code: IL_00bf, IL_00ce, IL_01ba, IL_01f7, IL_0206, IL_02e6, IL_0326, IL_0335, IL_0341, IL_0350
		int num = 11;
		List<ImportModel> allImportInfo = default(List<ImportModel>);
		ImportModel importModel = default(ImportModel);
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = default(_003C_003Ec__DisplayClass31_0);
		List<ProcessingItem> list = default(List<ProcessingItem>);
		IEnumerator<ProcessingItem> enumerator = default(IEnumerator<ProcessingItem>);
		ProcessingItem current = default(ProcessingItem);
		List<ProcessingItem> list2 = default(List<ProcessingItem>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!allImportInfo.Any())
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
						{
							num2 = 0;
						}
						continue;
					}
					importModel = allImportInfo.FirstOrDefault();
					num2 = 12;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
					{
						num2 = 18;
					}
					continue;
				case 4:
					return null;
				case 14:
					return importModel;
				case 6:
					return importModel;
				case 12:
					_003C_003Ec__DisplayClass31_.timestampNow = BpndyMwuh3HGAYavsT4(TimestampService);
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 != 0)
					{
						num2 = 16;
					}
					continue;
				case 10:
					allImportInfo = GetAllImportInfo();
					num2 = 15;
					continue;
				case 1:
					if (SetImportEnd(o0FjblwxxJW3E7DPXTm(importModel)))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 6;
				case 11:
					_003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
					num2 = 10;
					continue;
				case 5:
					list = importModel.ProcessingItems.ToList();
					num2 = 12;
					continue;
				case 19:
					importModel.ProcessingItems = list;
					num2 = 7;
					continue;
				case 17:
					hdgeeDwBCclYPq84IbR(L0qpjTwZy24dAmi6kW8(ActorModelRuntime.GetActor<IExternalMembershipImportManagerActor>(0L)));
					num2 = 6;
					continue;
				case 13:
					try
					{
						while (true)
						{
							IL_0293:
							int num3;
							if (!cejypvwHirSEeyI3uBl(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
								{
									num3 = 0;
								}
								goto IL_01c8;
							}
							goto IL_024f;
							IL_024f:
							current = enumerator.Current;
							num3 = 5;
							goto IL_01c8;
							IL_01c8:
							while (true)
							{
								int num4;
								switch (num3)
								{
								case 3:
									break;
								case 2:
									if (q7wVEqwjxwMYBQHy9wD(list2) >= ProcessingCount)
									{
										num3 = 3;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f != 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto IL_0293;
								case 6:
									QZjUTtwLFn3F7A6MBO5(current, ProcessingStatus.Process);
									num3 = 4;
									continue;
								case 7:
									goto IL_024f;
								case 5:
									current.ExpireProcessingTimestamp = lssXXcwetieWAsypS1R(TimestampService, tSP582wm54Jtp5cFb4Z(ProcessingTimeout));
									num4 = 6;
									goto IL_01c4;
								case 1:
									goto IL_0293;
								case 4:
									list2.Add(current);
									num4 = 2;
									goto IL_01c4;
								case 0:
									break;
									IL_01c4:
									num3 = num4;
									continue;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						int num5;
						if (enumerator == null)
						{
							num5 = 2;
							goto IL_02ea;
						}
						goto IL_0300;
						IL_02ea:
						switch (num5)
						{
						default:
							goto end_IL_02d5;
						case 1:
							break;
						case 2:
							goto end_IL_02d5;
						case 0:
							goto end_IL_02d5;
						}
						goto IL_0300;
						IL_0300:
						enumerator.Dispose();
						num5 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
						{
							num5 = 0;
						}
						goto IL_02ea;
						end_IL_02d5:;
					}
					goto case 19;
				case 18:
					if (importModel.ProcessingItems != null)
					{
						num2 = 9;
						continue;
					}
					goto case 1;
				case 15:
					if (allImportInfo == null)
					{
						num2 = 8;
						continue;
					}
					goto case 2;
				case 9:
					if (importModel.ProcessingItems.Any())
					{
						list2 = new List<ProcessingItem>();
						num2 = 5;
						continue;
					}
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					importModel.ProcessingItems = list2;
					num2 = 14;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
					{
						num2 = 12;
					}
					continue;
				case 7:
					((IBLOBDataManager)mifesOw7XsnQcthR3qf()).SetBLOB(UID, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2068904634 ^ -2068883822), allImportInfo);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d != 0)
					{
						num2 = 3;
					}
					continue;
				case 16:
					enumerator = list.Where(_003C_003Ec__DisplayClass31_._003CGetObjectsForImport_003Eb__0).GetEnumerator();
					num2 = 13;
					continue;
				}
				break;
			}
			((Task)L0qpjTwZy24dAmi6kW8(ActorModelRuntime.GetActor<IExternalMembershipImportManagerActor>(0L))).Wait();
			num = 4;
		}
	}

	private void RemoveProcessingObjects(ImportModel model)
	{
		//Discarded unreachable code: IL_008d, IL_009c, IL_0186, IL_0195
		int num = 3;
		int num2 = num;
		ImportModel importModel = default(ImportModel);
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = default(_003C_003Ec__DisplayClass32_0);
		List<ImportModel> allImportInfo = default(List<ImportModel>);
		while (true)
		{
			switch (num2)
			{
			case 11:
				return;
			case 1:
				importModel.ProcessingItems = importModel.ProcessingItems.Where(_003C_003Ec__DisplayClass32_._003CRemoveProcessingObjects_003Eb__1).ToList();
				num2 = 4;
				break;
			case 5:
				return;
			case 9:
				importModel = allImportInfo.FirstOrDefault(_003C_003Ec__DisplayClass32_._003CRemoveProcessingObjects_003Eb__0);
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
				{
					num2 = 10;
				}
				break;
			case 10:
				if (importModel == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
				{
					num2 = 0;
				}
				break;
			case 14:
				allImportInfo = GetAllImportInfo();
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
				{
					num2 = 12;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
				num2 = 2;
				break;
			default:
				((IBLOBDataManager)mifesOw7XsnQcthR3qf()).SetBLOB(UID, (string)GBMLimw6897MLGNeWWQ(0x487E82CC ^ 0x487ED118), allImportInfo);
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
				{
					num2 = 8;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass32_.model = model;
				num2 = 14;
				break;
			case 8:
				return;
			case 7:
				allImportInfo.Remove(importModel);
				num2 = 6;
				break;
			case 13:
				if (!allImportInfo.Any())
				{
					return;
				}
				num2 = 9;
				break;
			case 12:
				if (allImportInfo == null)
				{
					return;
				}
				num2 = 13;
				break;
			case 4:
				if (importModel.ProcessingItems.Any())
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			}
		}
	}

	public ExternalMembershipImportManager()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		UID = new Guid((string)GBMLimw6897MLGNeWWQ(0x71CDF2F ^ 0x71C890D));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool On5lWBwny8o0CyhrQyY()
	{
		return wklrghwXMrDetCHCJFw == null;
	}

	internal static ExternalMembershipImportManager DBkbcKwi2WSXCjhlkHg()
	{
		return wklrghwXMrDetCHCJFw;
	}

	internal static object mifesOw7XsnQcthR3qf()
	{
		return DataAccessManager.BLOBManager;
	}

	internal static object GBMLimw6897MLGNeWWQ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object PKDjdVwlJ8CN6BGw2WX()
	{
		return ELMAContext.CreateIsolated();
	}

	internal static Type e98dyvwNJRXgbpbLhpi(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object L0qpjTwZy24dAmi6kW8(object P_0)
	{
		return ((IExternalMembershipImportManagerActor)P_0).ImportComplete();
	}

	internal static Guid o0FjblwxxJW3E7DPXTm(object P_0)
	{
		return ((ImportModel)P_0).Uid;
	}

	internal static void hdgeeDwBCclYPq84IbR(object P_0)
	{
		((Task)P_0).Wait();
	}

	internal static long BpndyMwuh3HGAYavsT4(object P_0)
	{
		return ((ITimestampService)P_0).GetTimestamp();
	}

	internal static TimeSpan tSP582wm54Jtp5cFb4Z(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static long lssXXcwetieWAsypS1R(object P_0, TimeSpan P_1)
	{
		return ((ITimestampService)P_0).GetTimeStampRelativeToNow(P_1);
	}

	internal static void QZjUTtwLFn3F7A6MBO5(object P_0, ProcessingStatus value)
	{
		((ProcessingItem)P_0).Status = value;
	}

	internal static int q7wVEqwjxwMYBQHy9wD(object P_0)
	{
		return ((List<ProcessingItem>)P_0).Count;
	}

	internal static bool cejypvwHirSEeyI3uBl(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
