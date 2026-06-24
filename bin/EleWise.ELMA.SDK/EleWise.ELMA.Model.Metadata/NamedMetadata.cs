using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[DataContract]
[DebuggerDisplay("Name: {Name}")]
public abstract class NamedMetadata : AbstractMetadata, INamedMetadata
{
	private string name;

	private SR.LocalizableString displayName;

	private SR.LocalizableString description;

	private static NamedMetadata IK5RpwbJJS0m3uDt11qr;

	[EntityProperty]
	[DefaultValue("")]
	[PublicationBehaviour(PublicationType.Restart)]
	[XmlElement("Name")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[DataMember]
	[Uid("{906F9284-6F99-4215-A32C-BA9BA573DC34}")]
	public virtual string Name
	{
		get
		{
			return name;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					name = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					eJMoOxbJYrIMVsGCKyud(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}
	}

	[EntityProperty]
	[DefaultValue("")]
	[EleWise.ELMA.Globalization.Localizable]
	[DataMember]
	[XmlElement("DisplayName")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[StringSettings(FieldName = "DisplayName")]
	[Uid("{74202162-D32C-4869-AFA9-0DF2EDE0C0D7}")]
	public virtual string DisplayName
	{
		get
		{
			return displayName;
		}
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
					displayName = (SR.LocalizableString)HfhGUObJLERckIMoTlZo(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
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

	[DataMember]
	[EleWise.ELMA.Globalization.Localizable]
	[Uid("{7F8E3A10-7112-478B-981F-B3F712610CCE}")]
	[DefaultValue("")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[StringSettings(FieldName = "Description", MaxValueString = "2147483647", MultiLine = true)]
	[XmlElement("Description")]
	[EntityProperty]
	public virtual string Description
	{
		get
		{
			return description;
		}
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
					description = (SR.LocalizableString)HfhGUObJLERckIMoTlZo(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual List<MetadataImage> Images { get; set; }

	public virtual List<NamedImageMetadata> NamedImages { get; set; }

	public virtual MetadataImage DefaultImage => GetDefaultImage(Images);

	public NamedMetadata()
	{
		//Discarded unreachable code: IL_005a, IL_005f
		KgfelEbJl7Ds3RKyHXW1();
		name = string.Empty;
		displayName = SR.LocalizableString.Empty;
		description = (SR.LocalizableString)IlmlDLbJrhxf03Tqo35Z();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!PRqntubJ5N5SmmXh21gI(zFy3wgbJgRQdTfcQ0Hf9(this)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return (string)AovUbebJjowPfUZQIaYQ(this);
			case 1:
				return DisplayName;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeImages()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return PcnV2KbJUtpgkRGwOFdj(Images) > 0;
			case 1:
				return false;
			case 2:
				if (Images == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeNamedImages()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return NamedImages.Count > 0;
			case 1:
				if (NamedImages == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual MetadataImage GetImage(int size, bool onlyToSize = false)
	{
		//Discarded unreachable code: IL_00e0
		int num = 1;
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
		IEnumerable<MetadataImage> images = default(IEnumerable<MetadataImage>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return null;
				case 2:
					_003C_003Ec__DisplayClass23_.distanceToNearestSize = ((IEnumerable<MetadataImage>)Images).Min((Func<MetadataImage, int>)_003C_003Ec__DisplayClass23_._003CGetImage_003Eb__0);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					images = Images.Where(_003C_003Ec__DisplayClass23_._003CGetImage_003Eb__1);
					num2 = 7;
					continue;
				case 7:
					return GetDefaultImage(images);
				case 6:
					if (Images != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 3;
				case 5:
					if (PcnV2KbJUtpgkRGwOFdj(Images) != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				}
				break;
			}
			_003C_003Ec__DisplayClass23_.size = size;
			num = 6;
		}
	}

	public virtual MetadataImage GetNamedImage(string imageKey)
	{
		//Discarded unreachable code: IL_0035
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_0);
		while (true)
		{
			switch (num2)
			{
			default:
				if (NamedImages == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 2:
				_003C_003Ec__DisplayClass24_.imageKey = imageKey;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
				num2 = 2;
				break;
			case 4:
				return (from i in NamedImages.Where(_003C_003Ec__DisplayClass24_._003CGetNamedImage_003Eb__0)
					select (MetadataImage)_003C_003Ec.XWAuv9CAnHUVUd4A3iRx(i)).FirstOrDefault();
			case 1:
				return null;
			}
		}
	}

	public virtual void AddNamedImage(string imageKey, MetadataImage image)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_0070, IL_007f, IL_00f1
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = default(_003C_003Ec__DisplayClass25_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
			case 10:
				NamedImages.RemoveAll(_003C_003Ec__DisplayClass25_._003CAddNamedImage_003Eb__0);
				num2 = 11;
				continue;
			case 7:
			case 11:
			{
				List<NamedImageMetadata> namedImages = NamedImages;
				NamedImageMetadata obj = new NamedImageMetadata
				{
					ImageKey = _003C_003Ec__DisplayClass25_.imageKey
				};
				S6iHvkbJsWB4FHgbwwSC(obj, image);
				namedImages.Add(obj);
				num2 = 5;
				continue;
			}
			case 3:
				_003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
				num2 = 2;
				continue;
			case 5:
				return;
			case 8:
				if (image != null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 0:
				return;
			case 9:
				if (NamedImages != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			case 1:
				RemoveNamedImage(_003C_003Ec__DisplayClass25_.imageKey);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				_003C_003Ec__DisplayClass25_.imageKey = imageKey;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 7;
				}
				continue;
			case 6:
				break;
			}
			NamedImages = new List<NamedImageMetadata>();
			num2 = 7;
		}
	}

	public virtual void AddNamedImage(NamedImageMetadata image)
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
				AddNamedImage((string)iRvfcKbJc3BxgdhCE74n(image), (MetadataImage)trsUPwbJzZe7sfL2Ntmt(image));
				num2 = 3;
				break;
			case 2:
				if (image == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public virtual void RemoveNamedImage(string imageKey)
	{
		//Discarded unreachable code: IL_005b, IL_006a, IL_00b0
		int num = 3;
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = default(_003C_003Ec__DisplayClass27_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					break;
				case 0:
					return;
				case 4:
					return;
				case 8:
					NamedImages = null;
					num2 = 4;
					continue;
				case 6:
					if (NamedImages != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 7:
					if (NamedImages.Count != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 5:
					return;
				case 1:
					NamedImages.RemoveAll(_003C_003Ec__DisplayClass27_._003CRemoveNamedImage_003Eb__0);
					num2 = 7;
					continue;
				case 2:
					_003C_003Ec__DisplayClass27_.imageKey = imageKey;
					num2 = 6;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
			num = 2;
		}
	}

	internal static void SetDisplayName(NamedMetadata metadata, SR.LocalizableString displayName)
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
				metadata.displayName = displayName;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void SetDescription(NamedMetadata metadata, SR.LocalizableString description)
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
				metadata.description = description;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual void OnNameChanged()
	{
	}

	private MetadataImage GetDefaultImage(IEnumerable<MetadataImage> images)
	{
		if (images == null)
		{
			return null;
		}
		MetadataImage metadataImage = images.FirstOrDefault((MetadataImage i) => _003C_003Ec.BFNFohCAOkanKYXsStqS(i));
		if (metadataImage != null)
		{
			return metadataImage;
		}
		return images.FirstOrDefault();
	}

	internal static void KgfelEbJl7Ds3RKyHXW1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object IlmlDLbJrhxf03Tqo35Z()
	{
		return SR.LocalizableString.Empty;
	}

	internal static bool M0nTN4bJ9jF0P6K4vhkN()
	{
		return IK5RpwbJJS0m3uDt11qr == null;
	}

	internal static NamedMetadata jYqBgnbJdaZkpgTP2uul()
	{
		return IK5RpwbJJS0m3uDt11qr;
	}

	internal static object zFy3wgbJgRQdTfcQ0Hf9(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static bool PRqntubJ5N5SmmXh21gI(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object AovUbebJjowPfUZQIaYQ(object P_0)
	{
		return ((Entity<long>)P_0).ToString();
	}

	internal static void eJMoOxbJYrIMVsGCKyud(object P_0)
	{
		((NamedMetadata)P_0).OnNameChanged();
	}

	internal static object HfhGUObJLERckIMoTlZo(object P_0)
	{
		return (SR.LocalizableString)(string)P_0;
	}

	internal static int PcnV2KbJUtpgkRGwOFdj(object P_0)
	{
		return ((List<MetadataImage>)P_0).Count;
	}

	internal static void S6iHvkbJsWB4FHgbwwSC(object P_0, object P_1)
	{
		((NamedImageMetadata)P_0).Image = (MetadataImage)P_1;
	}

	internal static object iRvfcKbJc3BxgdhCE74n(object P_0)
	{
		return ((NamedImageMetadata)P_0).ImageKey;
	}

	internal static object trsUPwbJzZe7sfL2Ntmt(object P_0)
	{
		return ((NamedImageMetadata)P_0).Image;
	}
}
