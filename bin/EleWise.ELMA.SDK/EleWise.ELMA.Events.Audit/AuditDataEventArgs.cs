using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Events.Audit;

public abstract class AuditDataEventArgs<T> : AuditEventArgs
{
	public T Data { get; set; }

	public override IDictionary<string, object> ExtendedProperties
	{
		get
		{
			IDictionary<string, object> extendedProperties = base.ExtendedProperties;
			extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1E4F90)] = Data;
			return extendedProperties;
		}
	}

	protected AuditDataEventArgs(T data)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Data = data;
	}
}
