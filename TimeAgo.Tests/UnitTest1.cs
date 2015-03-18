using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeAgo.Tests {
	[TestClass]
	public class UnitTest1 {
		[TestMethod]
		public void TestMethod1() {
			var dateTimeFuncs = new Func<Double, TimeSpan>[] {
				TimeSpan.FromSeconds,
				TimeSpan.FromMinutes,
				TimeSpan.FromHours,
				TimeSpan.FromDays,
				x => TimeSpan.FromDays(30 * x),
				x => TimeSpan.FromDays(365 * x),
			};
			var allCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
			var supportedCultures = new List<CultureInfo>();
			foreach (var culture in allCultures) {
				try {
					var dateTimeFormatStrings = DateTimeExtensions.GetFormatString(culture);
					supportedCultures.Add(culture);
				}
				catch (NotSupportedException) {}
			}
			var distinctSupportedLanguageCultures = supportedCultures.GroupBy(x => x.ThreeLetterISOLanguageName).Select(x => x.First()).ToList();
			foreach (var culture in distinctSupportedLanguageCultures) {
				foreach (var dateTimeFunc in dateTimeFuncs) {
					for (var i = 1; i <= 5; i *= 5) {
						var dateTime = DateTime.Now.Subtract(dateTimeFunc(i));
						var timeAgo = dateTime.TimeAgo(culture);
						Debug.WriteLine(timeAgo);
					}
				}
			}
		}
	}
}
