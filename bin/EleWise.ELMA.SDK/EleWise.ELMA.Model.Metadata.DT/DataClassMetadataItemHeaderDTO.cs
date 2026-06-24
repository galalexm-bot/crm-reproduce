using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.DTO.Models
{
	[Serializable]
	public sealed class DataClassMetadataItemHeaderDTO : EntityDTO<long>
	{
		private static DataClassMetadataItemHeaderDTO QGtXx8brUdxO4gvRoEWD;

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
					case 0:
						return;
					case 1:
						_003CUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
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
						_003CName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string DisplayName
		{
			[CompilerGenerated]
			get
			{
				return _003CDisplayName_003Ek__BackingField;
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
						_003CDisplayName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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

		public bool Deleted
		{
			[CompilerGenerated]
			get
			{
				return _003CDeleted_003Ek__BackingField;
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
						_003CDeleted_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public long DraftId
		{
			[CompilerGenerated]
			get
			{
				return _003CDraftId_003Ek__BackingField;
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
						_003CDraftId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
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

		public long PublishedId
		{
			[CompilerGenerated]
			get
			{
				return _003CPublishedId_003Ek__BackingField;
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
						_003CPublishedId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
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

		public DataClassMetadataItemHeaderDTO()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			zTqETtbrz5HQkWcGTKMe();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void zTqETtbrz5HQkWcGTKMe()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool edpXI5brs1vtmZ4baERQ()
		{
			return QGtXx8brUdxO4gvRoEWD == null;
		}

		internal static DataClassMetadataItemHeaderDTO XROUhGbrcnkCkg76F6du()
		{
			return QGtXx8brUdxO4gvRoEWD;
		}
	}
}
namespace EleWise.ELMA.Model.Metadata.DTO.Managers
{
	internal class DataClassMetadataItemHeaderDTOManager : DTOManager, IDataClassMetadataItemHeaderDTOManager, IConfigurationService
	{
		internal static DataClassMetadataItemHeaderDTOManager cEgeDWbgtKUIZPG6Nmuj;

		public DataClassMetadataItemHeaderManager DataClassMetadataItemHeaderManager
		{
			[CompilerGenerated]
			get
			{
				return _003CDataClassMetadataItemHeaderManager_003Ek__BackingField;
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
						_003CDataClassMetadataItemHeaderManager_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ISecurityService SecurityService
		{
			[CompilerGenerated]
			get
			{
				return _003CSecurityService_003Ek__BackingField;
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
						_003CSecurityService_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public virtual DataClassMetadataItemHeaderDTO Load(long id)
		{
			return Mapper.Map<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>(DataClassMetadataItemHeaderManager.Load(id), new DataClassMetadataItemHeaderDTO());
		}

		public virtual DataClassMetadataItemHeaderDTO LoadOrNull(long id)
		{
			return Mapper.Map<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>(DataClassMetadataItemHeaderManager.LoadOrNull(id), new DataClassMetadataItemHeaderDTO());
		}

		public virtual DataClassMetadataItemHeaderDTO LoadOrNull(Guid uid)
		{
			int num = 3;
			_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						Locator.GetService<ISecurityService>();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
						num2 = 4;
						continue;
					case 5:
						return _003C_003Ec__DisplayClass10_.result;
					case 6:
						_003C_003Ec__DisplayClass10_.result = null;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num2 = 1;
						}
						continue;
					default:
						AvTbEybg69XqFClFMLAh(SecurityService, new Action(_003C_003Ec__DisplayClass10_._003CLoadOrNull_003Eb__0));
						num2 = 5;
						continue;
					case 3:
						break;
					case 4:
						_003C_003Ec__DisplayClass10_.uid = uid;
						num2 = 6;
						continue;
					}
					break;
				}
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num = 2;
			}
		}

		public virtual IEnumerable<DataClassMetadataItemHeaderDTO> FindAll()
		{
			_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.result = new List<DataClassMetadataItemHeaderDTO>();
			SecurityService.RunWithElevatedPrivilegies(delegate
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
						CS_0024_003C_003E8__locals0.result.AddRange((from h in CS_0024_003C_003E8__locals0._003C_003E4__this.DataClassMetadataItemHeaderManager.FindAll()
							select Mapper.Map<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>(h, new DataClassMetadataItemHeaderDTO())).ToList());
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
			return CS_0024_003C_003E8__locals0.result;
		}

		public DataClassMetadataItemHeaderDTOManager()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			EgBFVKbgHlP1XZaOIO7a();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool R7f5PebgwfO1Mrx9jqlL()
		{
			return cEgeDWbgtKUIZPG6Nmuj == null;
		}

		internal static DataClassMetadataItemHeaderDTOManager bS10Subg478HAYoX3Tcj()
		{
			return cEgeDWbgtKUIZPG6Nmuj;
		}

		internal static void AvTbEybg69XqFClFMLAh(object P_0, object P_1)
		{
			((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
		}

		internal static void EgBFVKbgHlP1XZaOIO7a()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}
}
