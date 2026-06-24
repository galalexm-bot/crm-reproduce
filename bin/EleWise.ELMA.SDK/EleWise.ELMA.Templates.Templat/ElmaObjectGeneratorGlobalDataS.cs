using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Templates.GlobalValueTemplateGenerator;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates.TemplateGenerator;

public class ElmaObjectGeneratorGlobalDataSource : DefaultObjectGeneratorGlobalDataSource
{
	private ClassMetadata dataSourceObjectMetadata;

	private static ElmaObjectGeneratorGlobalDataSource Upinc7B310L4gdrN8EGG;

	public ElmaObjectGeneratorGlobalDataSource(object dataSourceObject)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		Oa6VKdB3pWtPOjPJvoZp();
		base._002Ector(wuMJ5HB3atN5qhIj6CPT(dataSourceObject));
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				dataSourceObjectMetadata = ((dataSourceObject != null) ? (MetadataLoader.LoadMetadata(wuMJ5HB3atN5qhIj6CPT(dataSourceObject).GetType()) as ClassMetadata) : null);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override FormatedValue GetValue(string[] propertyNames)
	{
		//Discarded unreachable code: IL_009b, IL_00aa, IL_00ba, IL_00c9, IL_00da, IL_00e9, IL_00f4, IL_0144, IL_0153, IL_0189, IL_0204, IL_023c, IL_02ae, IL_030b, IL_031a
		switch (1)
		{
		case 1:
			try
			{
				if (propertyNames == null)
				{
					break;
				}
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num = 0;
				}
				IEnumerator<IElmaParserGlobalValue> enumerator = default(IEnumerator<IElmaParserGlobalValue>);
				IEnumerable<IElmaParserGlobalValue> extensionPoints = default(IEnumerable<IElmaParserGlobalValue>);
				FormatedValue formatedValue = default(FormatedValue);
				FormatedValue result = default(FormatedValue);
				while (true)
				{
					switch (num)
					{
					case 5:
						enumerator = extensionPoints.GetEnumerator();
						num = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num = 6;
						}
						continue;
					case 2:
						break;
					case 7:
						break;
					case 6:
						try
						{
							while (true)
							{
								int num2;
								if (!L7BiWSB3wF40tPBYZQ4n(enumerator))
								{
									num2 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
									{
										num2 = 1;
									}
									goto IL_00f8;
								}
								goto IL_0197;
								IL_0197:
								formatedValue = (FormatedValue)jEHWyCB3tVio7F85mmGT(enumerator.Current, propertyNames);
								num2 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
								{
									num2 = 3;
								}
								goto IL_00f8;
								IL_00f8:
								while (true)
								{
									switch (num2)
									{
									case 3:
										if (formatedValue == null)
										{
											num2 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
											{
												num2 = 5;
											}
											continue;
										}
										goto case 2;
									case 4:
										goto IL_0197;
									case 2:
										result = formatedValue;
										num2 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
										{
											num2 = 6;
										}
										continue;
									case 1:
										goto end_IL_015e;
									case 6:
										return result;
									}
									break;
								}
								continue;
								end_IL_015e:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num3 = 1;
								}
								while (true)
								{
									switch (num3)
									{
									case 1:
										enumerator.Dispose();
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
										{
											num3 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						break;
					case 1:
					{
						extensionPoints = ((ComponentManager)RIvbVvB3DeNrftUyEKqw()).GetExtensionPoints<IElmaParserGlobalValue>();
						int num4 = 4;
						num = num4;
						continue;
					}
					case 4:
						if (extensionPoints.Count() <= 0)
						{
							num = 7;
							continue;
						}
						goto case 5;
					default:
						if (propertyNames.Count() <= 0)
						{
							num = 2;
							continue;
						}
						goto case 1;
					case 3:
						break;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				int num5 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num5 = 1;
				}
				while (true)
				{
					switch (num5)
					{
					case 1:
						e1HxbmB3AZPj3kx2MW7r(jKFSruB349eRQZbLduOv(), jiCjiPB3HdAJQWGrIbuk(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867744238), GTmJgrB36QH4OarXWbek(ex)), ex);
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num5 = 0;
						}
						continue;
					case 0:
						break;
					}
					break;
				}
			}
			break;
		}
		FormatedValue formatedValue2 = new FormatedValue();
		zndtamB375iZ53uYbQst(formatedValue2, "");
		return formatedValue2;
	}

	internal static void Oa6VKdB3pWtPOjPJvoZp()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object wuMJ5HB3atN5qhIj6CPT(object P_0)
	{
		return P_0.CastAsRealType();
	}

	internal static bool KQbxWEB3Nuck6x60ZiqX()
	{
		return Upinc7B310L4gdrN8EGG == null;
	}

	internal static ElmaObjectGeneratorGlobalDataSource IVLVgEB33quK7VT0KDPw()
	{
		return Upinc7B310L4gdrN8EGG;
	}

	internal static object RIvbVvB3DeNrftUyEKqw()
	{
		return ComponentManager.Current;
	}

	internal static object jEHWyCB3tVio7F85mmGT(object P_0, object P_1)
	{
		return ((IElmaParserGlobalValue)P_0).Parse((string[])P_1);
	}

	internal static bool L7BiWSB3wF40tPBYZQ4n(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object jKFSruB349eRQZbLduOv()
	{
		return Logger.Log;
	}

	internal static object GTmJgrB36QH4OarXWbek(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object jiCjiPB3HdAJQWGrIbuk(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void e1HxbmB3AZPj3kx2MW7r(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void zndtamB375iZ53uYbQst(object P_0, object P_1)
	{
		((FormatedValue)P_0).Value = P_1;
	}
}
