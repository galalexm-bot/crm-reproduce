using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts.DTO.Models;

[Serializable]
public class ProjectFolderItem : ProjectItem
{
	private static ProjectFolderItem GJ9wBKbKQid9cBpULNh5;

	public List<ProjectItem> Items { get; set; }

	public string Namespace
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespace_003Ek__BackingField;
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
					_003CNamespace_003Ek__BackingField = value;
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

	public ProjectFolderItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Hy5Ln2bK8c0FPs2ZHEhA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
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
				Items = new List<ProjectItem>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public bool CheckFileName(string filename)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass9_.filename = filename;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Items.Where((ProjectItem f) => _003C_003Ec.IXCYdtCNk6udFMKc6b7v(f.GetType(), _003C_003Ec.VGgr63CNTrYQKVw05Aev(typeof(ProjectItem).TypeHandle))).Any(_003C_003Ec__DisplayClass9_._003CCheckFileName_003Eb__1);
			}
		}
	}

	public bool CheckFolderName(string foldername)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass10_.foldername = foldername;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return Items.Where((ProjectItem f) => f is ProjectFolderItem).Any(_003C_003Ec__DisplayClass10_._003CCheckFolderName_003Eb__1);
			}
		}
	}

	internal static void Hy5Ln2bK8c0FPs2ZHEhA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool DLomaibKCdL0OKDreYDT()
	{
		return GJ9wBKbKQid9cBpULNh5 == null;
	}

	internal static ProjectFolderItem t4EJynbKvksvu14YvVLC()
	{
		return GJ9wBKbKQid9cBpULNh5;
	}
}
