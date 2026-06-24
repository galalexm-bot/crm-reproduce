using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Models;

[Serializable]
public class CustomActivityHeaderDTO : EntityDTO<long>
{
	internal static CustomActivityHeaderDTO mAlUjn4uogltXeni4Tl;

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
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 != 0)
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
				case 1:
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 != 0)
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

	public string Published_VersionNumber
	{
		[CompilerGenerated]
		get
		{
			return _003CPublished_VersionNumber_003Ek__BackingField;
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
					_003CPublished_VersionNumber_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTime? Published_CreationDate { get; set; }

	public UserDTO Published_CreationAuthor
	{
		[CompilerGenerated]
		get
		{
			return _003CPublished_CreationAuthor_003Ek__BackingField;
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
					_003CPublished_CreationAuthor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b != 0)
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

	public long FolderId
	{
		[CompilerGenerated]
		get
		{
			return _003CFolderId_003Ek__BackingField;
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
					_003CFolderId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c5274b5f82c74d1e8e92ea099532df1e == 0)
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
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec == 0)
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
				case 0:
					return;
				case 1:
					_003CPublishedId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool ReadOnly
	{
		[CompilerGenerated]
		get
		{
			return _003CReadOnly_003Ek__BackingField;
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
					_003CReadOnly_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 != 0)
					{
						num2 = 0;
					}
					break;
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
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsDirtyCustomActivity
	{
		[CompilerGenerated]
		get
		{
			return _003CIsDirtyCustomActivity_003Ek__BackingField;
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
					_003CIsDirtyCustomActivity_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
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

	public string ColorFirst
	{
		[CompilerGenerated]
		get
		{
			return _003CColorFirst_003Ek__BackingField;
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
					_003CColorFirst_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bce36a95fd341dfb7b4178ccc0544f2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTime? CreationDate { get; set; }

	public string ColorSecond
	{
		[CompilerGenerated]
		get
		{
			return _003CColorSecond_003Ek__BackingField;
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
					_003CColorSecond_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9f9823be58b94730af510f3472045ea6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WebDiagrammerElementColor? ColorFirstPreset { get; set; }

	public WebDiagrammerElementColor? ColorSecondPreset { get; set; }

	[XmlIgnore]
	public Color ColorFirstC
	{
		get
		{
			//Discarded unreachable code: IL_00d4, IL_0106, IL_016a, IL_0179, IL_019c, IL_01b8, IL_01c7
			int num = 1;
			int num2 = num;
			WebDiagrammerElementColor? colorFirstPreset = default(WebDiagrammerElementColor?);
			int color;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!ge7Ng84LHKmgsIiYPRZ(ColorFirst))
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 5:
					if (colorFirstPreset.HasValue)
					{
						num2 = 6;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				default:
					try
					{
						Color color2 = Color.FromArgb(int.Parse((string)iQydxQ4r5TEBLmM6Qyy(ColorFirst, bjWoV64Ja3AZulGYvoc(0x4244DF13 ^ 0x4244B2D3), ""), NumberStyles.AllowHexSpecifier));
						int num3 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => color2, 
							_ => color2, 
						};
					}
					catch (FormatException)
					{
						int num4 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								jqAPVH47m7shEy9D0Vn(Logger.Log, bjWoV64Ja3AZulGYvoc(-361150192 ^ -361159466), new object[1] { Name });
								num4 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 4;
				case 6:
					colorFirstPreset = ColorFirstPreset;
					num2 = 3;
					continue;
				case 2:
					color = 0;
					break;
				case 4:
					colorFirstPreset = ColorFirstPreset;
					num2 = 5;
					continue;
				case 3:
					color = (int)colorFirstPreset.Value;
					break;
				}
				break;
			}
			return WebDiagrammerShapeBackgroundColorPresets.GetColor((WebDiagrammerElementColor)color);
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
					ColorFirst = (string)IUqHqY4597cBOxNLDXn(bjWoV64Ja3AZulGYvoc(0x532DFB0A ^ 0x532D9546), new object[4]
					{
						value.A.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C21F94 ^ 0x1C271FC)),
						value.R.ToString((string)bjWoV64Ja3AZulGYvoc(0x3907FE5 ^ 0x390118D)),
						value.G.ToString((string)bjWoV64Ja3AZulGYvoc(-1363339545 ^ -1363314545)),
						value.B.ToString((string)bjWoV64Ja3AZulGYvoc(-1587393812 ^ -1587403644))
					});
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public Color ColorSecondC
	{
		get
		{
			//Discarded unreachable code: IL_0064, IL_00b6, IL_00e8, IL_0146
			int num = 2;
			WebDiagrammerElementColor? colorSecondPreset = default(WebDiagrammerElementColor?);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 2:
						if (!string.IsNullOrWhiteSpace(ColorSecond))
						{
							num2 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 5;
					case 4:
						num3 = 0;
						break;
					case 1:
						try
						{
							Color color = ooftOh419w1Q4VgfIr6(OIFyOr4gl97Vy2BTe6x(iQydxQ4r5TEBLmM6Qyy(ColorSecond, bjWoV64Ja3AZulGYvoc(--1059430085 ^ 0x3F25F305), ""), NumberStyles.AllowHexSpecifier));
							int num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 == 0)
							{
								num4 = 0;
							}
							return num4 switch
							{
								0 => color, 
								_ => color, 
							};
						}
						catch (FormatException)
						{
							int num5 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									jqAPVH47m7shEy9D0Vn(RihXFr4I13GcqSTC07x(), bjWoV64Ja3AZulGYvoc(0x27A6CAB5 ^ 0x27A6A4C5), new object[1] { Name });
									num5 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 != 0)
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
						goto case 5;
					case 3:
						if (colorSecondPreset.HasValue)
						{
							colorSecondPreset = ColorSecondPreset;
							num2 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto end_IL_0012;
					case 5:
						colorSecondPreset = ColorSecondPreset;
						num2 = 3;
						continue;
					default:
						num3 = (int)colorSecondPreset.Value;
						break;
					}
					return JvuTfE4ZQrY2h349adD((WebDiagrammerElementColor)num3);
					continue;
					end_IL_0012:
					break;
				}
				num = 4;
			}
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
					ColorSecond = (string)IUqHqY4597cBOxNLDXn(bjWoV64Ja3AZulGYvoc(0xFAE81C9 ^ 0xFAEEF85), new object[4]
					{
						value.A.ToString((string)bjWoV64Ja3AZulGYvoc(0x532DFB0A ^ 0x532D9562)),
						value.R.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFAE81C9 ^ 0xFAEEFA1)),
						value.G.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-746011232 ^ -746017848)),
						value.B.ToString((string)bjWoV64Ja3AZulGYvoc(-1411073168 ^ -1411066600))
					});
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc == 0)
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

	public override void CopyChanges(EntityDTO<long> saved)
	{
		Contract.CheckArgument(saved is CustomActivityHeaderDTO, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-408604271 ^ -408592749));
		base.CopyChanges(saved);
		CustomActivityHeaderDTO customActivityHeaderDTO = (CustomActivityHeaderDTO)saved;
		Name = customActivityHeaderDTO.Name;
		FolderId = customActivityHeaderDTO.FolderId;
		IsDirtyCustomActivity = customActivityHeaderDTO.IsDirtyCustomActivity;
		PublishedId = customActivityHeaderDTO.PublishedId;
		CreationDate = customActivityHeaderDTO.CreationDate;
		Published_CreationDate = customActivityHeaderDTO.Published_CreationDate;
		Published_CreationAuthor = customActivityHeaderDTO.Published_CreationAuthor;
		Published_VersionNumber = customActivityHeaderDTO.Published_VersionNumber;
	}

	public virtual void InitNew()
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
			case 3:
				IsDirtyCustomActivity = true;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Uid = KY0PQa4znJNEQprPsKJ();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f1ba867523264a63932ee1e8d0cd4a24 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				FolderId = 0L;
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static CustomActivityHeaderDTO New(long folderId = 0L)
	{
		CustomActivityHeaderDTO customActivityHeaderDTO = new CustomActivityHeaderDTO();
		nwV9j09EV7lU6ojcduR(customActivityHeaderDTO);
		return customActivityHeaderDTO;
	}

	public CustomActivityHeaderDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aMawTd9C4HjexG0jMx3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lT9eRS4lA4O3EbbkaE8()
	{
		return mAlUjn4uogltXeni4Tl == null;
	}

	internal static CustomActivityHeaderDTO r0CHXL4fDqaU7pE4Hav()
	{
		return mAlUjn4uogltXeni4Tl;
	}

	internal static bool ge7Ng84LHKmgsIiYPRZ(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object bjWoV64Ja3AZulGYvoc(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object iQydxQ4r5TEBLmM6Qyy(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void jqAPVH47m7shEy9D0Vn(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).ErrorFormat((string)P_1, (object[])P_2);
	}

	internal static object IUqHqY4597cBOxNLDXn(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static int OIFyOr4gl97Vy2BTe6x(object P_0, NumberStyles P_1)
	{
		return int.Parse((string)P_0, P_1);
	}

	internal static Color ooftOh419w1Q4VgfIr6(int P_0)
	{
		return Color.FromArgb(P_0);
	}

	internal static object RihXFr4I13GcqSTC07x()
	{
		return Logger.Log;
	}

	internal static Color JvuTfE4ZQrY2h349adD(WebDiagrammerElementColor P_0)
	{
		return WebDiagrammerShapeStrokeColorPresets.GetColor(P_0);
	}

	internal static Guid KY0PQa4znJNEQprPsKJ()
	{
		return Guid.NewGuid();
	}

	internal static void nwV9j09EV7lU6ojcduR(object P_0)
	{
		((CustomActivityHeaderDTO)P_0).InitNew();
	}

	internal static void aMawTd9C4HjexG0jMx3()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
