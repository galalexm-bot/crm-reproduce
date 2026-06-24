using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Provider;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Providers;

public abstract class FileStoreProvider : ProviderBase, IFileManager
{
	internal class BinaryFileWrapper : IEntity, IIdentified
	{
		internal static BinaryFileWrapper o2JWBMQNVQ8iOMeb1qPV;

		public BinaryFile File { get; }

		public BinaryFileWrapper(BinaryFile file)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			UWBOegQNRGtlOjRWduIE();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
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
					File = file;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		object IIdentified.GetId()
		{
			return G2g5r0QNqWyQWoGpYhbT(File);
		}

		void IEntity.Delete()
		{
			throw new NotImplementedException();
		}

		IEnumerable<IEntity> IEntity.GetContainedEntities()
		{
			throw new NotImplementedException();
		}

		Guid[] IEntity.GetDirtyPropertyUids()
		{
			throw new NotImplementedException();
		}

		TSettings IEntity.GetPropertySettings<TSettings>(Guid propertyUid)
		{
			throw new NotImplementedException();
		}

		TypeSettings IEntity.GetPropertySettings(Guid propertyUid)
		{
			throw new NotImplementedException();
		}

		TypeSettings IEntity.GetPropertySettings(Guid propertyUid, TypeSettings defaultSettings)
		{
			throw new NotImplementedException();
		}

		object IEntity.GetPropertyValue(Guid propertyUid)
		{
			throw new NotImplementedException();
		}

		T IEntity.GetPropertyValue<T>(Guid propertyUid)
		{
			throw new NotImplementedException();
		}

		IEntity IEntity.GetRootEntity()
		{
			throw new NotImplementedException();
		}

		bool IEntity.IsDirty()
		{
			throw new NotImplementedException();
		}

		bool IEntity.IsNew()
		{
			throw new NotImplementedException();
		}

		TypeSettings IEntity.LoadPropertyInstanceSettings(Guid propertyUid)
		{
			throw new NotImplementedException();
		}

		ITypeSettingsInstanceStore IEntity.LoadSettingsInstanceStore(bool createIfNotExists, bool loadIfNotLoaded)
		{
			throw new NotImplementedException();
		}

		void IEntity.Refresh()
		{
			throw new NotImplementedException();
		}

		void IEntity.Save()
		{
			throw new NotImplementedException();
		}

		void IEntity.SavePropertyInstanceSettings(Guid propertyUid, TypeSettings settings)
		{
			throw new NotImplementedException();
		}

		void IIdentified.SetId(object id)
		{
			throw new NotImplementedException();
		}

		void IEntity.SetPropertyValue(Guid propertyUid, object value)
		{
			throw new NotImplementedException();
		}

		string IEntity.ToString(string format)
		{
			throw new NotImplementedException();
		}

		internal static void UWBOegQNRGtlOjRWduIE()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool SOLsYlQNSyc3siFaaDJt()
		{
			return o2JWBMQNVQ8iOMeb1qPV == null;
		}

		internal static BinaryFileWrapper edNdtMQNicoZS0If4Vm0()
		{
			return o2JWBMQNVQ8iOMeb1qPV;
		}

		internal static object G2g5r0QNqWyQWoGpYhbT(object P_0)
		{
			return ((BinaryFile)P_0).Id;
		}
	}

	private static FileStoreProvider nmAAEjWEoVKxa83xNwY3;

	public abstract string TempFilesPath { get; set; }

	public abstract string FilesPath { get; set; }

	public abstract string PreviewsPath { get; set; }

	public abstract string ContextItemsKey { get; }

	public abstract string ProcessStoreKey { get; }

	protected FileStoreProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public virtual void ReConfigure(RuntimeConfiguration configuration)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IEntity WrapFile(BinaryFile binaryFile)
	{
		return new BinaryFileWrapper(binaryFile);
	}

	public abstract string SaveFile(BinaryFile binaryFile);

	public abstract BinaryFile LoadFile(string id);

	public abstract BinaryFile[] LoadFiles(string[] idList);

	public abstract bool FileExists(string id);

	public abstract long FileSize(string id);

	public abstract string RenameFile(string id, string fileName);

	public abstract BinaryFile CopyFile(BinaryFile sourceBinaryFile);

	public abstract void Encrypt(BinaryFile file, string password, string salt);

	public abstract BinaryFile Decrypt(BinaryFile file, string password);

	public abstract void CancelEncrypt(BinaryFile file, string password);

	internal static bool dkTqLKWEbOngFpNChJJt()
	{
		return nmAAEjWEoVKxa83xNwY3 == null;
	}

	internal static FileStoreProvider QO9h4GWEhloY3i6dA1Fv()
	{
		return nmAAEjWEoVKxa83xNwY3;
	}
}
