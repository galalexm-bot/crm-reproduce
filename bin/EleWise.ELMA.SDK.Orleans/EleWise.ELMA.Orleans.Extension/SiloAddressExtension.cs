using System;
using System.Net.Sockets;
using Orleans.Runtime;

namespace EleWise.ELMA.Orleans.Extensions;

internal static class SiloAddressExtension
{
	internal static Guid ToGuid(this SiloAddress siloAddress)
	{
		byte[] addressBytes = siloAddress.get_Endpoint().Address.GetAddressBytes();
		byte[] array = ((siloAddress.get_Endpoint().Address.AddressFamily != AddressFamily.InterNetworkV6) ? new byte[16]
		{
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			addressBytes[2],
			addressBytes[3],
			addressBytes[0],
			addressBytes[1],
			0,
			0
		} : new byte[16]
		{
			addressBytes[2],
			addressBytes[3],
			addressBytes[4],
			addressBytes[5],
			addressBytes[0],
			addressBytes[1],
			addressBytes[8],
			addressBytes[9],
			addressBytes[6],
			addressBytes[7],
			addressBytes[14],
			addressBytes[15],
			addressBytes[12],
			addressBytes[13],
			addressBytes[10],
			addressBytes[11]
		});
		array[0] ^= (byte)siloAddress.get_Generation();
		array[1] ^= (byte)(siloAddress.get_Generation() >> 8);
		array[2] ^= (byte)(siloAddress.get_Generation() >> 16);
		array[3] ^= (byte)(siloAddress.get_Generation() >> 24);
		array[8] ^= (byte)siloAddress.get_Endpoint().Port;
		array[9] ^= (byte)(siloAddress.get_Endpoint().Port >> 8);
		return new Guid(array);
	}
}
