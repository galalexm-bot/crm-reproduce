using System;

namespace EleWise.ELMA.Runtime;

public interface IStartInformation : IDisposable
{
	double Percent { get; set; }

	string Message { get; set; }

	void SetInfo(double percent, string message);

	void StopOperation();
}
