using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Toolbox;

[Component]
public abstract class ViewItemToolboxItem : IViewItemToolboxItem
{
	private static ViewItemToolboxItem flisAwoaBLlSDeqrZ3Pq;

	public abstract string Name { get; }

	public abstract Guid GroupUid { get; }

	public virtual Image Image => null;

	public abstract ViewItem CreateViewItem();

	public abstract bool IsAvailable(IMetadata metadata);

	protected ViewItemToolboxItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool iol1C3oaWLy4CPY0PCWG()
	{
		return flisAwoaBLlSDeqrZ3Pq == null;
	}

	internal static ViewItemToolboxItem YG5940oaol08CwbYslKx()
	{
		return flisAwoaBLlSDeqrZ3Pq;
	}
}
public abstract class ViewItemToolboxItem<TViewItem> : ViewItemToolboxItem where TViewItem : ViewItem
{
	private IMetadataEditorService metadataEditorService;

	private static object i2BHBYoabCo1FYCASTfD;

	private IMetadataEditorService MetadataEditorService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IMetadataEditorService obj;
			IMetadataEditorService metadataEditorService = default(IMetadataEditorService);
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = this.metadataEditorService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					metadataEditorService = (this.metadataEditorService = (Locator.Initialized ? Locator.GetService<IMetadataEditorService>() : null));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					obj = metadataEditorService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public override string Name
	{
		get
		{
			//Discarded unreachable code: IL_003a, IL_0095
			int num = 1;
			int num2 = num;
			ViewItemInfoService viewItemInfoService = default(ViewItemInfoService);
			ViewItemTypeInfo viewItemTypeInfo = default(ViewItemTypeInfo);
			while (true)
			{
				object obj;
				object obj2;
				switch (num2)
				{
				default:
					obj = null;
					goto IL_00c3;
				case 3:
					if (viewItemInfoService == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj2 = viewItemInfoService.GetInfo(typeof(TViewItem));
					break;
				case 5:
					return string.Empty;
				case 4:
					if (viewItemTypeInfo != null)
					{
						return viewItemTypeInfo.Name;
					}
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					obj2 = null;
					break;
				case 1:
					{
						if (!Locator.Initialized)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						obj = Locator.GetService<ViewItemInfoService>();
						goto IL_00c3;
					}
					IL_00c3:
					viewItemInfoService = (ViewItemInfoService)obj;
					num2 = 3;
					continue;
				}
				viewItemTypeInfo = (ViewItemTypeInfo)obj2;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 1;
				}
			}
		}
	}

	public override ViewItem CreateViewItem()
	{
		TViewItem val = Activator.CreateInstance<TViewItem>();
		val.InitNew(null);
		return val;
	}

	public override bool IsAvailable(IMetadata metadata)
	{
		//Discarded unreachable code: IL_0032, IL_00a9
		int num = 2;
		int num2 = num;
		Guid[] uids = default(Guid[]);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				obj = null;
				break;
			case 3:
				return ViewItemMetadataAttribute.IsAvailable(typeof(TViewItem), uids);
			case 2:
				if (!(metadata is ClassMetadata classMetadata))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				obj = GetBaseClassesList(classMetadata, loadImplementation: false).Union(new ClassMetadata[1] { classMetadata }).SelectMany((ClassMetadata m) => (m is EntityMetadata entityMetadata) ? new Guid[2] { entityMetadata.Uid, entityMetadata.ImplementationUid } : new Guid[1] { m.Uid }).ToArray();
				break;
			case 1:
				if (metadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = new Guid[1] { metadata.Uid };
				break;
			}
			uids = (Guid[])obj;
			num2 = 3;
		}
	}

	private List<ClassMetadata> GetBaseClassesList(ClassMetadata metadata, bool loadImplementation = true)
	{
		List<ClassMetadata> list = new List<ClassMetadata>();
		GetBaseClass(metadata, list, loadImplementation);
		return list;
	}

	private void GetBaseClass(ClassMetadata metadata, List<ClassMetadata> res, bool loadImplementation = true)
	{
		if (metadata.BaseClassUid == Guid.Empty)
		{
			return;
		}
		ClassMetadata classMetadata = MetadataEditorService.GetMetadata(metadata.BaseClassUid, loadImplementation) as ClassMetadata;
		if (classMetadata == null)
		{
			classMetadata = MetadataLoader.LoadMetadataOrNull(metadata.BaseClassUid, inherit: false, loadImplementation) as ClassMetadata;
			if (classMetadata == null)
			{
				return;
			}
		}
		res.Add(classMetadata);
		GetBaseClass(classMetadata, res, loadImplementation);
	}

	protected ViewItemToolboxItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Pi20pioahYZfEnV9QFVx()
	{
		return i2BHBYoabCo1FYCASTfD == null;
	}

	internal static object mobE3aoaG6PmShMsuUC6()
	{
		return i2BHBYoabCo1FYCASTfD;
	}
}
