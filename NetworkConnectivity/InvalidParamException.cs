using System;

namespace NetworkConnectivity
{
	/// <summary>
	/// 传入的参数不能生成网络
	/// </summary>
	class InvalidParamException : ApplicationException
	{
		public InvalidParamException(string message) : base(message) { }
	}
}
