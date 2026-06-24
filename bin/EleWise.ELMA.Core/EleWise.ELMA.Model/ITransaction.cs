using System;

namespace EleWise.ELMA.Model;

public interface ITransaction : System.IDisposable
{
	void Execute(IOperation operation);
}
