using System;
namespace IDE_Test_Library
{
	public class StringCalculator
	{
		public StringCalculator()
		{
		}

		public int Add(String number)
		{
			var numbers = number.Split(",");
			var result = 0;
			foreach(var num in numbers)
			{
                var success = int.TryParse(num, out int realNumber);
				result += realNumber;
            }


			return result;
					}
	}
}

