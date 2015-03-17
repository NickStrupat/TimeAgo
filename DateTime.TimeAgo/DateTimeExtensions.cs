using System;
using System.Globalization;

namespace TimeAgo {
	internal struct DateTimeFormatStrings {
		public String SecondAgo;
		public String SecondsAgo;
		public String MinuteAgo;
		public String MinutesAgo;
		public String HourAgo;
		public String HoursAgo;
		public String DayAgo;
		public String DaysAgo;
		public String MonthAgo;
		public String MonthsAgo;
		public String YearAgo;
		public String YearsAgo;
	}

	public static class DateTimeExtensions {
		public static String GetTimeAgo(this DateTime dateTime) {
			return dateTime.GetTimeAgo(CultureInfo.CurrentUICulture);
		}

		public static String GetTimeAgo(this DateTime dateTime, CultureInfo cultureInfo) {
			if (cultureInfo == null)
				throw new ArgumentNullException("cultureInfo");
			var timeSpan = DateTime.Now - dateTime;
			var dateTimeFormatStrings = GetFormatString(cultureInfo);
			if (timeSpan.Days > 365) {
				var years = (timeSpan.Days / 365);
				if (timeSpan.Days % 365 != 0)
					years += 1;
				return String.Format(years == 1 ? dateTimeFormatStrings.YearAgo : dateTimeFormatStrings.YearsAgo, years);
			}
			if (timeSpan.Days > 30) {
				var months = (timeSpan.Days / 30);
				if (timeSpan.Days % 31 != 0)
					months += 1;
				return String.Format(months == 1 ? dateTimeFormatStrings.MonthAgo : dateTimeFormatStrings.MonthsAgo, months);
			}
			if (timeSpan.Days > 0)
				return String.Format(timeSpan.Days == 1 ? dateTimeFormatStrings.DayAgo : dateTimeFormatStrings.DaysAgo, timeSpan.Days);
			if (timeSpan.Hours > 0)
				return String.Format(timeSpan.Hours == 1 ? dateTimeFormatStrings.HourAgo : dateTimeFormatStrings.HoursAgo, timeSpan.Hours);
			if (timeSpan.Minutes > 0)
				return String.Format(timeSpan.Minutes == 1 ? dateTimeFormatStrings.MinuteAgo : dateTimeFormatStrings.MinutesAgo, timeSpan.Minutes);
			if (timeSpan.Seconds > 1)
				return String.Format(dateTimeFormatStrings.SecondsAgo, timeSpan.Seconds);
			if (timeSpan.Seconds == 1)
				return String.Format(dateTimeFormatStrings.SecondAgo, timeSpan.Seconds); ;
			throw new NotSupportedException("The DateTime object does not have a supported value.");
		}

		private static DateTimeFormatStrings GetFormatString(CultureInfo cultureInfo) {
			switch (cultureInfo.ThreeLetterISOLanguageName) {
				case "afr": // Afrikaans
					return LanguageFormatStrings.Afrikaans;
				case "sqi": // Albanian
					return LanguageFormatStrings.Albanian;
				case "ara": // Arabic
					return LanguageFormatStrings.Arabic;
				case "hye": // Armenian
					return LanguageFormatStrings.Armenian;
				case "aze": // Azerbaijani
					return LanguageFormatStrings.Azerbaijani;
				case "eus": // Basque
					return LanguageFormatStrings.Basque;
				case "bel": // Belarusian
					return LanguageFormatStrings.Belarusian;
				case "bsb": // Bosnian
					return LanguageFormatStrings.Bosnian;
				case "bul": // Bulgarian
					return LanguageFormatStrings.Bulgarian;
				case "cat": // Catalan
					return LanguageFormatStrings.Catalan;
				case "zho": // Chinese
					return LanguageFormatStrings.Chinese;
				case "hrv": // Croatian
					return LanguageFormatStrings.Croatian;
				case "ces": // Czech
					return LanguageFormatStrings.Czech;
				case "dan": // Danish
					return LanguageFormatStrings.Danish;
				case "nld": // Dutch
					return LanguageFormatStrings.Dutch;
				case "eng": // English
					return LanguageFormatStrings.English;
				case "est": // Estonian
					return LanguageFormatStrings.Estonian;
				case "fil": // Filipino
					return LanguageFormatStrings.Filipino;
				case "fin": // Finnish
					return LanguageFormatStrings.Finnish;
				case "fra": // French
					return LanguageFormatStrings.French;
				case "glg": // Galician
					return LanguageFormatStrings.Galician;
				case "kat": // Georgian
					return LanguageFormatStrings.Georgian;
				case "deu": // German
					return LanguageFormatStrings.German;
				case "ell": // Greek
					return LanguageFormatStrings.Greek;
				case "guj": // Gujarati
					return LanguageFormatStrings.Gujarati;
				case "heb": // Hebrew
					return LanguageFormatStrings.Hebrew;
				case "hin": // Hindi
					return LanguageFormatStrings.Hindi;
				case "hun": // Hungarian
					return LanguageFormatStrings.Hungarian;
				case "isl": // Icelandic
					return LanguageFormatStrings.Icelandic;
				case "ibo": // Igbo
					return LanguageFormatStrings.Igbo;
				case "ind": // Indonesian
					return LanguageFormatStrings.Indonesian;
				//case "ivl": // Invariant Language (Invariant Country)
				//	return LanguageFormatStrings.;
				case "gle": // Irish
					return LanguageFormatStrings.Irish;
				case "ita": // Italian
					return LanguageFormatStrings.Italian;
				case "jpn": // Japanese
					return LanguageFormatStrings.Japanese;
				case "kan": // Kannada
					return LanguageFormatStrings.Kannada;
				case "kaz": // Kazakh
					return LanguageFormatStrings.Kazakh;
				case "khm": // Khmer
					return LanguageFormatStrings.Khmer;
				case "kor": // Korean
					return LanguageFormatStrings.Korean;
				//case "kir": // Kyrgyz
				//	return LanguageFormatStrings.Kyrgyz;
				case "lao": // Lao
					return LanguageFormatStrings.Lao;
				case "lav": // Latvian
					return LanguageFormatStrings.Latvian;
				case "lit": // Lithuanian
					return LanguageFormatStrings.Lithuanian;
				case "mkd": // Macedonian (FYROM)
					return LanguageFormatStrings.Macedonian;
				case "mlg": // Malagasy
					return LanguageFormatStrings.Malagasy;
				//case "msa": // Malay
				//	return LanguageFormatStrings.Malay;
				case "mym": // Malayalam
					return LanguageFormatStrings.Malayalam;
				case "mlt": // Maltese
					return LanguageFormatStrings.Maltese;
				case "mri": // Maori
					return LanguageFormatStrings.Maori;
				case "mar": // Marathi
					return LanguageFormatStrings.Marathi;
				case "mon": // Mongolian
					return LanguageFormatStrings.Mongolian;
				//case "nep": // Nepali
				//	return LanguageFormatStrings.;
				case "nob": // Norwegian (Bokmål)
					return LanguageFormatStrings.Norwegian;
				case "nno": // Norwegian (Nynorsk)
					return LanguageFormatStrings.Norwegian;
				case "fas": // Persian
					return LanguageFormatStrings.Persian;
				case "pol": // Polish
					return LanguageFormatStrings.Polish;
				case "por": // Portuguese
					return LanguageFormatStrings.Portuguese;
				//case "pan": // Punjabi
				//	return LanguageFormatStrings.Punjabi;
				case "ron": // Romanian
					return LanguageFormatStrings.Romanian;
				case "rus": // Russian
					return LanguageFormatStrings.Russian;
				//case "gla": // Scottish Gaelic
				//	return LanguageFormatStrings.;
				case "srp": // Serbian
					return LanguageFormatStrings.Serbian;
				case "srn": // Serbian (Cyrillic, Bosnia and Herzegovina)
					return LanguageFormatStrings.Serbian;
				case "srs": // Serbian (Latin, Bosnia and Herzegovina)
					return LanguageFormatStrings.Serbian;
				case "slk": // Slovak
					return LanguageFormatStrings.Slovak;
				case "slv": // Slovenian
					return LanguageFormatStrings.Slovenian;
				case "spa": // Spanish
					return LanguageFormatStrings.Spanish;
				case "swe": // Swedish
					return LanguageFormatStrings.Swedish;
				case "tgk": // Tajik
					return LanguageFormatStrings.Tajik;
				case "tam": // Tamil
					return LanguageFormatStrings.Tamil;
				case "tel": // Telugu
					return LanguageFormatStrings.Telugu;
				case "tha": // Thai
					return LanguageFormatStrings.Thai;
				case "tur": // Turkish
					return LanguageFormatStrings.Turkish;
				case "ukr": // Ukrainian
					return LanguageFormatStrings.Ukrainian;
				case "urd": // Urdu
					return LanguageFormatStrings.Urdu;
				case "uzb": // Uzbek
					return LanguageFormatStrings.Uzbek;
				case "vie": // Vietnamese
					return LanguageFormatStrings.Vietnamese;
				case "cym": // Welsh
					return LanguageFormatStrings.Welsh;
				case "yor": // Yoruba
					return LanguageFormatStrings.Yoruba;
				default:
					throw new NotSupportedException("The provided CultureInfo is not supported.");
			}
		}
	}
}