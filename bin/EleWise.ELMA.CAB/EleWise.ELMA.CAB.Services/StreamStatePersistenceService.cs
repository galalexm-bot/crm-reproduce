using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using EleWise.ELMA.CAB.Properties;

namespace EleWise.ELMA.CAB.Services;

public abstract class StreamStatePersistenceService : IStatePersistenceService, IConfigurable
{
	private delegate void OpenStreamDelegate(Stream openedStream);

	public const string UseCryptographyAttribute = "UseCryptography";

	private ICryptographyService cryptoSvc;

	private bool useCryptography;

	[ServiceDependency(Required = false)]
	public ICryptographyService CryptographyService
	{
		get
		{
			if (cryptoSvc == null)
			{
				throw new StatePersistenceException(string.Format(CultureInfo.CurrentCulture, Resources.ServiceMissingExceptionMessage, new object[2]
				{
					typeof(ICryptographyService),
					GetType()
				}));
			}
			return cryptoSvc;
		}
		set
		{
			cryptoSvc = value;
		}
	}

	public virtual void Configure(NameValueCollection settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		if (!string.IsNullOrEmpty(settings["UseCryptography"]) && !bool.TryParse(settings["UseCryptography"], out useCryptography))
		{
			throw new StatePersistenceException(Resources.InvalidCryptographyValue);
		}
	}

	public void Save(State state)
	{
		if (state == null)
		{
			throw new ArgumentNullException("state");
		}
		try
		{
			if (Contains(state.ID))
			{
				Remove(state.ID);
			}
			if (useCryptography)
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				using MemoryStream memoryStream = new MemoryStream();
				binaryFormatter.Serialize(memoryStream, state);
				byte[] data = CryptographyService.EncryptSymmetric(memoryStream.GetBuffer());
				OpenStream(state.ID, delegate(Stream fs)
				{
					fs.Write(data, 0, data.Length);
				});
				return;
			}
			BinaryFormatter fmt = new BinaryFormatter();
			OpenStream(state.ID, delegate(Stream stream)
			{
				fmt.Serialize(stream, state);
			});
		}
		catch (Exception innerException)
		{
			throw new StatePersistenceException(string.Format(CultureInfo.CurrentCulture, Resources.CannotSaveState, new object[1] { state.ID }), innerException);
		}
	}

	public State Load(string id)
	{
		if (!Contains(id))
		{
			throw new StatePersistenceException(string.Format(CultureInfo.CurrentCulture, Resources.StateDoesNotExist, new object[1] { id }));
		}
		try
		{
			if (useCryptography)
			{
				byte[] cipherData = null;
				OpenStream(id, delegate(Stream stream)
				{
					cipherData = new byte[stream.Length];
					stream.Read(cipherData, 0, (int)stream.Length);
				});
				using MemoryStream serializationStream = new MemoryStream(CryptographyService.DecryptSymmetric(cipherData));
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				return (State)binaryFormatter.Deserialize(serializationStream);
			}
			BinaryFormatter fmt = new BinaryFormatter();
			State state = null;
			OpenStream(id, delegate(Stream stream)
			{
				state = (State)fmt.Deserialize(stream);
			});
			return state;
		}
		catch (Exception innerException)
		{
			throw new StatePersistenceException(string.Format(CultureInfo.CurrentCulture, Resources.CannotLoadState, new object[1] { id }), innerException);
		}
	}

	public void Remove(string id)
	{
		try
		{
			RemoveStream(id);
		}
		catch (Exception innerException)
		{
			throw new StatePersistenceException(string.Format(CultureInfo.CurrentCulture, Resources.CannotLoadState, new object[1] { id }), innerException);
		}
	}

	public abstract bool Contains(string id);

	private static void ThrowIfInvalidStream(Stream stm)
	{
		if (stm == null || !stm.CanRead)
		{
			throw new StatePersistenceException(Resources.InvalidStateStream);
		}
	}

	public abstract void RemoveStream(string id);

	protected abstract Stream GetStream(string id);

	protected virtual Stream GetStream(string id, out bool shouldDispose)
	{
		shouldDispose = true;
		return GetStream(id);
	}

	private void OpenStream(string stateId, OpenStreamDelegate operation)
	{
		bool shouldDispose;
		Stream stream = GetStream(stateId, out shouldDispose);
		try
		{
			ThrowIfInvalidStream(stream);
			operation(stream);
		}
		finally
		{
			if (shouldDispose)
			{
				((IDisposable)stream)?.Dispose();
			}
		}
	}
}
