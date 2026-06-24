using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Build.Construction;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Projects;

public class ModelProjectItem
{
	private ModelProject project;

	private IMetadata metadata;

	private ProjectItemElement mdItem;

	private List<ProjectItemElement> dependentItems;

	private static ModelProjectItem dbvAWpWjhpivvcydbBCr;

	public IMetadata Metadata
	{
		get
		{
			return metadata;
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
					metadata = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal ProjectItemElement MdItem => mdItem;

	internal List<ProjectItemElement> DependentItems => dependentItems;

	internal ModelProjectItem(ModelProject project, IMetadata metadata, ProjectItemElement mdItem)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		G8SbXRWjfBskx1QePR77();
		dependentItems = new List<ProjectItemElement>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.project = project;
				num = 3;
				break;
			case 2:
				this.mdItem = mdItem;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num = 0;
				}
				break;
			case 3:
				this.metadata = metadata;
				num = 2;
				break;
			case 0:
				return;
			}
		}
	}

	public void Save(Action<string> fileAddedAction, Action<string> fileRemovedAction)
	{
		string text = Path.Combine(project.ProjectDir, mdItem.Include);
		string directoryName = Path.GetDirectoryName(text);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		MetadataSerializer.SaveMetadata(metadata, text);
		fileAddedAction?.Invoke(mdItem.Include);
		GeneratedFileInfo[] array = Locator.GetServiceNotNull<IMetadataEditorService>().CreateCodeGenerator(metadata).Generate();
		List<ProjectItemElement> list = new List<ProjectItemElement>(dependentItems);
		bool flag = true;
		GeneratedFileInfo[] array2 = array;
		foreach (GeneratedFileInfo generatedFileInfo in array2)
		{
			_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
			CS_0024_003C_003E8__locals0.genFileName = Path.ChangeExtension(mdItem.Include, generatedFileInfo.Extension);
			File.WriteAllBytes(Path.Combine(project.ProjectDir, CS_0024_003C_003E8__locals0.genFileName), generatedFileInfo.Data);
			fileAddedAction?.Invoke(CS_0024_003C_003E8__locals0.genFileName);
			ProjectItemElement projectItemElement = dependentItems.FirstOrDefault((ProjectItemElement i) => _003C_003Ec__DisplayClass12_0.xTIw3qCFuiWrvYMSkaVt(_003C_003Ec__DisplayClass12_0.fgh4pECFZMQgci11Xgni(i), CS_0024_003C_003E8__locals0.genFileName));
			if (projectItemElement != null)
			{
				list.Remove(projectItemElement);
			}
			else
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317692826)] = Path.GetFileName(mdItem.Include);
				dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882223134)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103E6FE7);
				projectItemElement = project.ProjectGroupCompile.AddItem(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3366284), CS_0024_003C_003E8__locals0.genFileName, dictionary);
				dependentItems.Add(projectItemElement);
			}
			if (flag)
			{
				ProjectMetadataElement projectMetadataElement = ((mdItem.Metadata != null) ? mdItem.Metadata.FirstOrDefault((ProjectMetadataElement mi) => _003C_003Ec.IouV1ACFKic3rpsvglsy(_003C_003Ec.swfEm1CFR3JA2i7MkYMT(mi), _003C_003Ec.n8aMaUCFqIKOccFxvBOD(-398663332 ^ -398629302))) : null);
				if (projectMetadataElement != null)
				{
					projectMetadataElement.Value = Path.GetFileName(CS_0024_003C_003E8__locals0.genFileName);
				}
				else
				{
					mdItem.AddMetadata(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70072010), Path.GetFileName(CS_0024_003C_003E8__locals0.genFileName));
				}
			}
			flag = false;
		}
		foreach (ProjectItemElement item in list)
		{
			Path.Combine(project.ProjectDir, item.Include);
			if (item.Parent is ProjectItemGroupElement projectItemGroupElement)
			{
				projectItemGroupElement.RemoveChild(item);
				fileRemovedAction?.Invoke(item.Include);
			}
			dependentItems.Remove(item);
		}
	}

	internal static void G8SbXRWjfBskx1QePR77()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fPyaiBWjGsNVbNZHWjiE()
	{
		return dbvAWpWjhpivvcydbBCr == null;
	}

	internal static ModelProjectItem Otxf6uWjEhgxHPr37rKO()
	{
		return dbvAWpWjhpivvcydbBCr;
	}
}
