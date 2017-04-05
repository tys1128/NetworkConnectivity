using System;

namespace NetworkConnectivity
{
	/// <summary>
	/// 传入的参数不能生成网络
	/// </summary>
	public class InvalidParamException : ApplicationException
	{
		public int n, mLower, mUpper;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="n">城市数</param>
		/// <param name="mLower">m的下限</param>
		/// <param name="mUpper">m的上限</param>
		public InvalidParamException(int n,int mLower,int mUpper)
		{
			this.n = n;
			this.mLower = mLower;
			this.mUpper = mUpper;
		}
	}
}
