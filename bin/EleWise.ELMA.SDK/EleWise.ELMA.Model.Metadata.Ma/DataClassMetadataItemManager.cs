using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events.Publication;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.Actors;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal class DataClassMetadataItemManager : EntityManager<DataClassMetadataItem, long>, IDataClassMetadataItemManager, IEntityManager<DataClassMetadataItem, long>, IEntityManager<DataClassMetadataItem>, IEntityManager
{
	private sealed class DataClassMetadataPublishingEventHandler : IDataClassMetadataPublishingEventHandler, IEventHandler
	{
		private readonly object dataClassActor;

		private readonly object dataClassesActor;

		private readonly Guid token;

		private readonly TaskCompletionSource<UIMetadataPublishResult> taskCompletionSource;

		internal static object SqiEBqCMfmFOpP5IigtW;

		public Task<UIMetadataPublishResult> Wait => taskCompletionSource.Task;

		public DataClassMetadataPublishingEventHandler(IDataClassesMetadataPublishingActor dataClassesActor, Guid token)
		{
			//Discarded unreachable code: IL_003c, IL_0041
			BC2gVjCMvOg60h1QaNGI();
			taskCompletionSource = new TaskCompletionSource<UIMetadataPublishResult>(TaskCreationOptions.RunContinuationsAsynchronously);
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					this.token = token;
					num = 2;
					continue;
				case 2:
					return;
				}
				this.dataClassesActor = dataClassesActor;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num = 1;
				}
			}
		}

		public DataClassMetadataPublishingEventHandler(IDataClassMetadataPublishingActor dataClassActor, Guid token)
		{
			//Discarded unreachable code: IL_002c, IL_0031
			BC2gVjCMvOg60h1QaNGI();
			taskCompletionSource = new TaskCompletionSource<UIMetadataPublishResult>(TaskCreationOptions.RunContinuationsAsynchronously);
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					this.token = token;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num = 0;
					}
					break;
				case 2:
					this.dataClassActor = dataClassActor;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public Task Complete(Guid publicationToken, UIMetadataPublishResult result)
		{
			//Discarded unreachable code: IL_006f
			int num = 3;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					object obj3 = dataClassActor;
					if (obj3 == null)
					{
						num2 = 4;
						continue;
					}
					obj = x9ywCgCMZPdVkKIa0y0O(obj3);
					break;
				}
				case 3:
					if (!(token != publicationToken))
					{
						num2 = 2;
						continue;
					}
					goto case 6;
				case 6:
					return (Task)BbXeXXCM8Z3slftmRyiq();
				case 2:
					taskCompletionSource.TrySetResult(result);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					continue;
				default:
				{
					object obj2 = dataClassesActor;
					if (obj2 == null)
					{
						num2 = 5;
						continue;
					}
					obj = ((IDataClassesMetadataPublishingActor)obj2).PublishComplete();
					goto IL_00cd;
				}
				case 5:
					obj = null;
					goto IL_00cd;
				case 4:
					{
						return null;
					}
					IL_00cd:
					if (obj != null)
					{
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			return (Task)obj;
		}

		public Task Error(Guid publicationToken, Exception exception)
		{
			int num = 4;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj2;
					switch (num2)
					{
					case 4:
						if (rtT5TKCMuBsFcVwi8RWw(token, publicationToken))
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num2 = 3;
							}
						}
						else
						{
							D28seWCMIr5HlCx0s1Dv(taskCompletionSource, exception);
							num2 = 5;
						}
						continue;
					case 3:
						return (Task)BbXeXXCM8Z3slftmRyiq();
					case 5:
					{
						object obj3 = dataClassesActor;
						if (obj3 == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						obj2 = ((IDataClassesMetadataPublishingActor)obj3).PublishComplete();
						goto IL_00b3;
					}
					case 1:
						obj2 = null;
						goto IL_00b3;
					default:
					{
						object obj = dataClassActor;
						if (obj == null)
						{
							goto end_IL_0012;
						}
						obj2 = x9ywCgCMZPdVkKIa0y0O(obj);
						break;
					}
					case 2:
						{
							return null;
						}
						IL_00b3:
						if (obj2 == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
					return (Task)obj2;
					continue;
					end_IL_0012:
					break;
				}
				num = 2;
			}
		}

		internal static void BC2gVjCMvOg60h1QaNGI()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool kJgfLnCMQBvLfCKbbTrk()
		{
			return SqiEBqCMfmFOpP5IigtW == null;
		}

		internal static DataClassMetadataPublishingEventHandler VMdWRvCMCsONEakiAsUR()
		{
			return (DataClassMetadataPublishingEventHandler)SqiEBqCMfmFOpP5IigtW;
		}

		internal static object BbXeXXCM8Z3slftmRyiq()
		{
			return Task.CompletedTask;
		}

		internal static object x9ywCgCMZPdVkKIa0y0O(object P_0)
		{
			return ((IDataClassMetadataPublishingActor)P_0).PublishComplete();
		}

		internal static bool rtT5TKCMuBsFcVwi8RWw(Guid P_0, Guid P_1)
		{
			return P_0 != P_1;
		}

		internal static bool D28seWCMIr5HlCx0s1Dv(object P_0, object P_1)
		{
			return ((TaskCompletionSource<UIMetadataPublishResult>)P_0).TrySetException((Exception)P_1);
		}
	}

	private readonly DataClassMetadataItemHeaderManager headerManager;

	private readonly IDataClassTypeReferenceManager dataClassTypeReferenceManager;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly IEventHandlerSubscribeService eventHandlerSubscribeService;

	private readonly ConcurrentDictionary<string, DataClassMetadataItem> dataclassCache;

	private static DataClassMetadataItemManager bGGiXIbU5yJmvhKyAABp;

	public new static DataClassMetadataItemManager Instance => Locator.GetServiceNotNull<DataClassMetadataItemManager>();

	public DataClassMetadataItemManager(DataClassMetadataItemHeaderManager headerManager, IDataClassTypeReferenceManager dataClassTypeReferenceManager, IActorModelRuntime actorModelRuntime, IEventHandlerSubscribeService eventHandlerSubscribeService)
	{
		//Discarded unreachable code: IL_003a
		uffWeLbULeaPpmoUYZvX();
		dataclassCache = new ConcurrentDictionary<string, DataClassMetadataItem>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.eventHandlerSubscribeService = eventHandlerSubscribeService;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num = 2;
				}
				break;
			case 5:
			{
				this.dataClassTypeReferenceManager = dataClassTypeReferenceManager;
				int num2 = 3;
				num = num2;
				break;
			}
			case 4:
				this.headerManager = headerManager;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num = 5;
				}
				break;
			case 3:
				this.actorModelRuntime = actorModelRuntime;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			case 2:
				CYZSX7bUsweE30ODsshX(EOi6XibUUr95HR6CuyvZ(), new ResolveEventHandler(CurrentDomainOnAssemblyResolve));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual DataClassMetadataItem Create(Guid moduleUid, Guid groupUid, string displayName)
	{
		int num = 1;
		int num2 = num;
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return Create(dataClassMetadata, groupUid);
			case 4:
				dataClassMetadata.DisplayName = displayName;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				A00PHgbUz2YpG3hi1mcq(dataClassMetadata, displayName.ToTranslitIdent());
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				dataClassMetadata = new DataClassMetadata(moduleUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				fGNEKmbUctl6iu5M3I2j(dataClassMetadata);
				num2 = 4;
				break;
			}
		}
	}

	[Transaction]
	public virtual DataClassMetadataItem Copy(Guid headerUid)
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		MetadataItemGroupUI metadataItemGroupUI = default(MetadataItemGroupUI);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = b1HrOAbsFVdq0xYenMuL(new Random(), 0, 10000);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return Create(dataClassMetadata, (metadataItemGroupUI != null) ? RsbgejbsQMgjvkNHlHYa(metadataItemGroupUI) : Guid.Empty);
			}
			DataClassMetadataItemHeader dataClassMetadataItemHeader = headerManager.Load(headerUid);
			DataClassMetadata dataClassMetadata2 = (DataClassMetadata)((DataClassMetadataItem)KLTb29bsB0CnWx3HfCGc(dataClassMetadataItemHeader)).Metadata;
			dataClassMetadata = ClassSerializationHelper.CloneObjectByXml(dataClassMetadata2);
			dataClassMetadata.InitNew();
			DP0bkmbso13E4GiS9y7D(dataClassMetadata, Eswrt5bsWZj8aenQM4Hy(dataClassMetadata2));
			dataClassMetadata.Name = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886585195), dataClassMetadata.Name, num3);
			vtv0M5bsEGnYkcLWKTRy(dataClassMetadata, Yr70iMbsGUqVl82uOm9I(S3jgkybsbH45HEbjvM1Z(-812025778 ^ -812020908), HyFLqUbshOPJQyZ8fp9D(dataClassMetadata), num3));
			metadataItemGroupUI = (MetadataItemGroupUI)qVXBJtbsf0x6AqI2PfM1(dataClassMetadataItemHeader);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
			{
				num2 = 2;
			}
		}
	}

	public override void Save(DataClassMetadataItem obj)
	{
		//Discarded unreachable code: IL_00ec
		int num = 3;
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		string errorMessage = default(string);
		IUser user = default(IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					base.Save(obj);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 9;
					}
					break;
				case 3:
					rZSNnmbsCloZrW7l4HnH(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672098637));
					num2 = 2;
					break;
				case 6:
					if (dataClassMetadata == null)
					{
						goto end_IL_0012;
					}
					if (obj.Header != null)
					{
						num2 = 11;
						break;
					}
					goto case 10;
				case 12:
					j8GY7PbsRXg9iny7MCQs(FYBFZCbsZSSxFr0rO8jq(obj), true);
					num2 = 7;
					break;
				default:
					gs3ecubsiGE7Lk6nL6Yk(obj, KL2RjObsSvdSwUPoxP8Z());
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 12;
					}
					break;
				case 9:
					return;
				case 10:
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E28876), HyFLqUbshOPJQyZ8fp9D(dataClassMetadata), oOTibmbs8qfP89Zr5JAf(dataClassMetadata)));
				case 11:
					if (!headerManager.ValidateName(i7TrAFbsuqBl1wtMhlQf(FYBFZCbsZSSxFr0rO8jq(obj)), (string)oOTibmbs8qfP89Zr5JAf(dataClassMetadata), out errorMessage))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 5;
						}
					}
					else if (headerManager.ValidateDisplayName(i7TrAFbsuqBl1wtMhlQf(FYBFZCbsZSSxFr0rO8jq(obj)), (string)HyFLqUbshOPJQyZ8fp9D(dataClassMetadata), out errorMessage))
					{
						user = (IUser)S9gQTlbsVxPgyMlR3dER(o6dCpcbsIcxknqsB3iCb(this));
						num2 = 4;
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num2 = 1;
						}
					}
					break;
				case 5:
					throw new Exception(SR.T((string)S3jgkybsbH45HEbjvM1Z(0x1ECE530A ^ 0x1ECEA098), S3jgkybsbH45HEbjvM1Z(-643786247 ^ -643588465)));
				case 1:
					throw new InvalidOperationException(errorMessage);
				case 2:
					dataClassMetadata = iHn9mGbsvrhfWip3fX9t(obj) as DataClassMetadata;
					num2 = 6;
					break;
				case 8:
					throw new InvalidOperationException(errorMessage);
				case 4:
					obj.CreationAuthorId = (long?)user?.GetId();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public UIMetadataPublishResult Publish(string comment, Guid[] headerIds)
	{
		int num = 1;
		int num2 = num;
		TaskAwaiter<UIMetadataPublishResult> awaiter = default(TaskAwaiter<UIMetadataPublishResult>);
		while (true)
		{
			switch (num2)
			{
			default:
				return awaiter.GetResult();
			case 1:
				awaiter = PublishAsync(comment, headerIds).GetAwaiter();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public UIMetadataPublishResult Publish(string comment, Guid headerId)
	{
		int num = 1;
		int num2 = num;
		TaskAwaiter<UIMetadataPublishResult> awaiter = default(TaskAwaiter<UIMetadataPublishResult>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				awaiter = PublishAsync(comment, headerId).GetAwaiter();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return awaiter.GetResult();
			}
		}
	}

	public IEnumerable<DataClassMetadataItem> GetLastPublished()
	{
		return CreateCriteria(FetchOptions.All, base.ImplementationType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A814C24)).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921224335), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDC1686), (JoinType)0, (ICriterion)(object)Restrictions.EqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998568788), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751130558))).Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867153771))).List<DataClassMetadataItem>();
	}

	internal static string ServerAssemblyName(DataClassMetadata metadata)
	{
		return (string)S3jgkybsbH45HEbjvM1Z(-951514650 ^ -951447942) + metadata.FullTypeName;
	}

	public List<RuntimeDataClassModel> LoadRuntimeMetadata(IEnumerable<Guid> itemUids)
	{
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_._003C_003E4__this = this;
		List<RuntimeDataClassModel> list = new List<RuntimeDataClassModel>();
		IList<DataClassMetadataItem> list2 = new List<DataClassMetadataItem>();
		_003C_003Ec__DisplayClass17_.notLoadedItemUids = new List<Guid>();
		foreach (Guid itemUid in itemUids)
		{
			_003C_003Ec__DisplayClass17_.notLoadedItemUids.Add(itemUid);
		}
		if (_003C_003Ec__DisplayClass17_.notLoadedItemUids.Count > 0)
		{
			_003C_003Ec__DisplayClass17_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass17_;
			CS_0024_003C_003E8__locals0.loadedDataClasses = null;
			SR.LocalizableString.RunWithSRLocalizer(delegate
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
						CS_0024_003C_003E8__locals0.loadedDataClasses = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.CreateCriteriaForArraySearch(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.notLoadedItemUids, (string)_003C_003Ec__DisplayClass17_1.ED8aOLCMTwIc7dHosJgj(-475857671 ^ -475884693), null, null).List<DataClassMetadataItem>();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
			list2.AddRange(CS_0024_003C_003E8__locals0.loadedDataClasses);
		}
		foreach (DataClassMetadataItem item in list2)
		{
			if (item != null)
			{
				list.Add(new RuntimeDataClassModel
				{
					MetadataItem = item
				});
			}
		}
		return list;
	}

	[AsyncStateMachine(typeof(_003CPublishAsync_003Ed__18))]
	private Task<UIMetadataPublishResult> PublishAsync(string comment, Guid[] headerIds)
	{
		_003CPublishAsync_003Ed__18 stateMachine = default(_003CPublishAsync_003Ed__18);
		stateMachine._003C_003E4__this = this;
		stateMachine.comment = comment;
		stateMachine.headerIds = headerIds;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<UIMetadataPublishResult>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<UIMetadataPublishResult> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CPublishAsync_003Ed__19))]
	private Task<UIMetadataPublishResult> PublishAsync(string comment, Guid headerId)
	{
		_003CPublishAsync_003Ed__19 stateMachine = default(_003CPublishAsync_003Ed__19);
		stateMachine._003C_003E4__this = this;
		stateMachine.comment = comment;
		stateMachine.headerId = headerId;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<UIMetadataPublishResult>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<UIMetadataPublishResult> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private Assembly CurrentDomainOnAssemblyResolve(object sender, ResolveEventArgs args)
	{
		//Discarded unreachable code: IL_0170, IL_017f, IL_018e
		int num = 2;
		int num2 = num;
		Assembly assembly = default(Assembly);
		DataClassMetadataItem dataClassMetadataItem = default(DataClassMetadataItem);
		AssemblyName assemblyName = default(AssemblyName);
		while (true)
		{
			switch (num2)
			{
			case 8:
				assembly = (Assembly)NJymv5bs3blqO2l4Mpe2(dataClassMetadataItem.AssemblyRaw, tCEJ2AbsNjqAid7MdyIO(dataClassMetadataItem));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				dataClassMetadataItem = ((ICriteria)GP6LdObseGZlltNDQIIx(((ICriteria)b22xVEbsnhK44TqNTv1n(pUON0xbsXDIu2uqyE0Ni(this, null), tfHPjnbskldwdaQnZMq4(S3jgkybsbH45HEbjvM1Z(0x4EDCBA32 ^ 0x4EDD0A62), EieHUCbsTGYYrIkhxu4U(assemblyName)))).Add((ICriterion)tfHPjnbskldwdaQnZMq4(S3jgkybsbH45HEbjvM1Z(0x92F12D5 ^ 0x92C151F), L74UWrbsOfYNqGMry40t(assemblyName).ToString())), Bqy1dybs23ekkVWRSIum(S3jgkybsbH45HEbjvM1Z(-1426094279 ^ -1426140521)))).SetMaxResults(1).UniqueResult<DataClassMetadataItem>();
				num2 = 7;
				break;
			case 2:
				if (!FyoAWtbsKXvq7SvWix95(t0x0MibsquCqSDAvH9Vs(args), S3jgkybsbH45HEbjvM1Z(-521266112 ^ -521331748)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 5:
				if (PC7aUZbs1iKR3aViLr2O(assembly, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 6:
			case 9:
				return assembly;
			case 1:
				return null;
			case 7:
				assembly = (Assembly)Xst44gbsPMMIE61HoAPb(ScriptExecutionHandlerHelper.CreateFullAssemblyName((string)EieHUCbsTGYYrIkhxu4U(assemblyName), L74UWrbsOfYNqGMry40t(assemblyName).ToString(), (string)S3jgkybsbH45HEbjvM1Z(0x103FE975 ^ 0x103F2C93), (string)S3jgkybsbH45HEbjvM1Z(0x638095EB ^ 0x6380850D)), true);
				num2 = 5;
				break;
			case 3:
				assemblyName = new AssemblyName((string)t0x0MibsquCqSDAvH9Vs(args));
				num2 = 4;
				break;
			default:
				if (dataClassMetadataItem == null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 8;
			}
		}
	}

	private DataClassMetadataItem Create(DataClassMetadata metadata, Guid groupUid)
	{
		int num = 4;
		DataClassMetadataItem dataClassMetadataItem = default(DataClassMetadataItem);
		DataClassMetadataItemHeader dataClassMetadataItemHeader = default(DataClassMetadataItemHeader);
		IUser user = default(IUser);
		DataClassTypeReference dataClassTypeReference = default(DataClassTypeReference);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					W7vy29bspT435NmX39Ua(dataClassMetadataItem, metadata);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					jr7qk7bsHxshuXL0CWdf(dataClassMetadataItemHeader, metadata.Name);
					num = 16;
					break;
				case 12:
					LeYekZbsMlNUJ6qfue4U(dataClassMetadataItem, dataClassMetadataItemHeader);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 3;
					}
					continue;
				case 13:
					ncZCBfbs7v8MbKEOuPF0(dataClassMetadataItemHeader, metadata.ModuleUid);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					user = (IUser)S9gQTlbsVxPgyMlR3dER(base.AuthenticationService);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					dataClassMetadataItemHeader = headerManager.Create();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
				{
					DataClassTypeReference obj = new DataClassTypeReference
					{
						MetadataUid = lFii2ObsaMVZhZlFT3yb(metadata)
					};
					IAOBy9bstTEGGl0LlPW8(obj, edCElAbsDNT8YkC7guMN(dataClassMetadataItem));
					dataClassTypeReference = obj;
					num2 = 9;
					continue;
				}
				case 14:
					return dataClassMetadataItem;
				default:
					PatmOLbs6x6pSAEXAxg0(dataClassMetadataItemHeader, metadata.Uid);
					num2 = 2;
					continue;
				case 16:
					PaksrubsADDq9848ErOx(dataClassMetadataItemHeader, metadata.DisplayName);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 13;
					}
					continue;
				case 7:
					base.Save(dataClassMetadataItem);
					num2 = 14;
					continue;
				case 9:
					ISnksAbs44ASRyCShdrh(metadata, XSj4wcbswBaJVXkUTXep(dataClassTypeReferenceManager, dataClassTypeReference).ToString());
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
					continue;
				case 17:
					Igpoq8bsyA5iWxKetfBX(dataClassMetadataItemHeader, ((AbstractNHEntityManager<MetadataItemGroupUI, long>)YHSlvkbsmvYcxpZRgknV()).LoadOrNull(groupUid));
					num2 = 12;
					continue;
				case 8:
					pyg3ZVbs0CU04clKgHmn(dataClassMetadataItemHeader, cHFHK1bsxWIiXbmkD1EJ(dataClassMetadataItem));
					num2 = 10;
					continue;
				case 10:
					dataClassMetadataItemHeader.Draft = dataClassMetadataItem;
					num2 = 17;
					continue;
				case 15:
					gs3ecubsiGE7Lk6nL6Yk(dataClassMetadataItem, KL2RjObsSvdSwUPoxP8Z());
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 11;
					}
					continue;
				case 4:
					dataClassMetadataItem = Create();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					dataClassMetadataItemHeader.CreationAuthorId = dataClassMetadataItem.CreationAuthorId;
					num = 8;
					break;
				case 18:
					dataClassMetadataItem.CreationAuthorId = (long?)user?.GetId();
					num2 = 15;
					continue;
				}
				break;
			}
		}
	}

	internal static void uffWeLbULeaPpmoUYZvX()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object EOi6XibUUr95HR6CuyvZ()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void CYZSX7bUsweE30ODsshX(object P_0, object P_1)
	{
		((AppDomain)P_0).AssemblyResolve += (ResolveEventHandler)P_1;
	}

	internal static bool uqdafvbUjuHo5hwc3UEc()
	{
		return bGGiXIbU5yJmvhKyAABp == null;
	}

	internal static DataClassMetadataItemManager Hftg6mbUYfWSFJLe6WNT()
	{
		return bGGiXIbU5yJmvhKyAABp;
	}

	internal static void fGNEKmbUctl6iu5M3I2j(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static void A00PHgbUz2YpG3hi1mcq(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static int b1HrOAbsFVdq0xYenMuL(object P_0, int P_1, int P_2)
	{
		return ((Random)P_0).Next(P_1, P_2);
	}

	internal static object KLTb29bsB0CnWx3HfCGc(object P_0)
	{
		return ((DataClassMetadataItemHeader)P_0).Draft;
	}

	internal static object Eswrt5bsWZj8aenQM4Hy(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static void DP0bkmbso13E4GiS9y7D(object P_0, object P_1)
	{
		((ClassMetadata)P_0).Namespace = (string)P_1;
	}

	internal static object S3jgkybsbH45HEbjvM1Z(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object HyFLqUbshOPJQyZ8fp9D(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object Yr70iMbsGUqVl82uOm9I(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void vtv0M5bsEGnYkcLWKTRy(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static object qVXBJtbsf0x6AqI2PfM1(object P_0)
	{
		return ((DataClassMetadataItemHeader)P_0).Group;
	}

	internal static Guid RsbgejbsQMgjvkNHlHYa(object P_0)
	{
		return ((MetadataItemGroupUI)P_0).Uid;
	}

	internal static void rZSNnmbsCloZrW7l4HnH(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object iHn9mGbsvrhfWip3fX9t(object P_0)
	{
		return ((DataClassMetadataItem)P_0).Metadata;
	}

	internal static object oOTibmbs8qfP89Zr5JAf(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object FYBFZCbsZSSxFr0rO8jq(object P_0)
	{
		return ((DataClassMetadataItem)P_0).Header;
	}

	internal static Guid i7TrAFbsuqBl1wtMhlQf(object P_0)
	{
		return ((DataClassMetadataItemHeader)P_0).Uid;
	}

	internal static object o6dCpcbsIcxknqsB3iCb(object P_0)
	{
		return ((EntityManager<DataClassMetadataItem, long>)P_0).AuthenticationService;
	}

	internal static object S9gQTlbsVxPgyMlR3dER(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static DateTime KL2RjObsSvdSwUPoxP8Z()
	{
		return DateTime.Now;
	}

	internal static void gs3ecubsiGE7Lk6nL6Yk(object P_0, DateTime value)
	{
		((DataClassMetadataItem)P_0).CreationDate = value;
	}

	internal static void j8GY7PbsRXg9iny7MCQs(object P_0, bool value)
	{
		((DataClassMetadataItemHeader)P_0).IsDirtyItem = value;
	}

	internal static object t0x0MibsquCqSDAvH9Vs(object P_0)
	{
		return ((ResolveEventArgs)P_0).Name;
	}

	internal static bool FyoAWtbsKXvq7SvWix95(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static object pUON0xbsXDIu2uqyE0Ni(object P_0, object P_1)
	{
		return ((EntityManager<DataClassMetadataItem, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object EieHUCbsTGYYrIkhxu4U(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object tfHPjnbskldwdaQnZMq4(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object b22xVEbsnhK44TqNTv1n(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object L74UWrbsOfYNqGMry40t(object P_0)
	{
		return ((AssemblyName)P_0).Version;
	}

	internal static object Bqy1dybs23ekkVWRSIum(object P_0)
	{
		return Order.Desc((string)P_0);
	}

	internal static object GP6LdObseGZlltNDQIIx(object P_0, object P_1)
	{
		return ((ICriteria)P_0).AddOrder((Order)P_1);
	}

	internal static object Xst44gbsPMMIE61HoAPb(object P_0, bool isFullName)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, isFullName);
	}

	internal static bool PC7aUZbs1iKR3aViLr2O(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object tCEJ2AbsNjqAid7MdyIO(object P_0)
	{
		return ((DataClassMetadataItem)P_0).DebugRaw;
	}

	internal static object NJymv5bs3blqO2l4Mpe2(object P_0, object P_1)
	{
		return ComponentManager.LoadAssembly((byte[])P_0, (byte[])P_1);
	}

	internal static void W7vy29bspT435NmX39Ua(object P_0, object P_1)
	{
		((DataClassMetadataItem)P_0).Metadata = P_1;
	}

	internal static Guid lFii2ObsaMVZhZlFT3yb(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid edCElAbsDNT8YkC7guMN(object P_0)
	{
		return ((DataClassMetadataItem)P_0).Uid;
	}

	internal static void IAOBy9bstTEGGl0LlPW8(object P_0, Guid value)
	{
		((DataClassTypeReference)P_0).ItemUid = value;
	}

	internal static long XSj4wcbswBaJVXkUTXep(object P_0, object P_1)
	{
		return ((IDataClassTypeReferenceManager)P_0).Save((DataClassTypeReference)P_1);
	}

	internal static void ISnksAbs44ASRyCShdrh(object P_0, object P_1)
	{
		((DataClassMetadata)P_0).TypeRef = (string)P_1;
	}

	internal static void PatmOLbs6x6pSAEXAxg0(object P_0, Guid value)
	{
		((DataClassMetadataItemHeader)P_0).Uid = value;
	}

	internal static void jr7qk7bsHxshuXL0CWdf(object P_0, object P_1)
	{
		((DataClassMetadataItemHeader)P_0).Name = (string)P_1;
	}

	internal static void PaksrubsADDq9848ErOx(object P_0, object P_1)
	{
		((DataClassMetadataItemHeader)P_0).DisplayName = (string)P_1;
	}

	internal static void ncZCBfbs7v8MbKEOuPF0(object P_0, Guid value)
	{
		((DataClassMetadataItemHeader)P_0).ModuleUid = value;
	}

	internal static DateTime cHFHK1bsxWIiXbmkD1EJ(object P_0)
	{
		return ((DataClassMetadataItem)P_0).CreationDate;
	}

	internal static void pyg3ZVbs0CU04clKgHmn(object P_0, DateTime value)
	{
		((DataClassMetadataItemHeader)P_0).CreationDate = value;
	}

	internal static object YHSlvkbsmvYcxpZRgknV()
	{
		return MetadataItemGroupUIManager.Instance;
	}

	internal static void Igpoq8bsyA5iWxKetfBX(object P_0, object P_1)
	{
		((DataClassMetadataItemHeader)P_0).Group = (MetadataItemGroupUI)P_1;
	}

	internal static void LeYekZbsMlNUJ6qfue4U(object P_0, object P_1)
	{
		((DataClassMetadataItem)P_0).Header = (DataClassMetadataItemHeader)P_1;
	}
}
