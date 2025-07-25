using System;

namespace RawBencher
{
	public class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				BenchController.Run(args);
			}
			catch(Exception ex)
			{
				BencherUtils.DisplayException(ex);
			}
		}
	}
}
