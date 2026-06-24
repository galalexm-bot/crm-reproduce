using System;

namespace EleWise.ELMA.Design.Components;

public interface IProgressDialog : IDisposable
{
	string Message { get; set; }

	void Terminate();
}
