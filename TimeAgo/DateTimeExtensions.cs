using System;
using System.Globalization;

namespace TimeAgo
{
    public static class DateTimeExtensions
    {
        public static String TimeAgo(this DateTime dateTime)
        {
            return dateTime.TimeAgo(CultureInfo.CurrentUICulture);
        }

        public static String TimeAgo(this DateTime dateTime, CultureInfo cultureInfo)
        {
            if (cultureInfo == null)
                throw new ArgumentNullException("cultureInfo");

            var timeSpan = DateTime.Now - dateTime;
            var dateTimeFormatStrings = GetFormatString(cultureInfo);
            if (timeSpan.Days > 365)
            {
                var years = (timeSpan.Days / 365);
                if (timeSpan.Days % 365 != 0)
                    years += 1;
                return String.Format(years == 1 ? dateTimeFormatStrings.YearAgo : dateTimeFormatStrings.YearsAgo, years);
            }
            if (timeSpan.Days > 30)
            {
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
            if (timeSpan.Seconds > 1 || timeSpan.Seconds == 0)
                return String.Format(dateTimeFormatStrings.SecondsAgo, timeSpan.Seconds);
            if (timeSpan.Seconds == 1)
                return String.Format(dateTimeFormatStrings.SecondAgo, timeSpan.Seconds);
            throw new NotSupportedException("The DateTime object does not have a supported value.");
        }

        internal static DateTimeFormatStrings GetFormatString(CultureInfo cultureInfo)
        {
            switch (cultureInfo.TwoLetterISOLanguageName)
            {
                case "af": // Afrikaans
                    return LanguageFormatStrings.Afrikaans;
                case "sq": // Albanian
                    return LanguageFormatStrings.Albanian;
                case "ar": // Arabic
                    return LanguageFormatStrings.Arabic;
                case "hy": // Armenian
                    return LanguageFormatStrings.Armenian;
                case "az": // Azerbaijani
                    return LanguageFormatStrings.Azerbaijani;
                case "eu": // Basque
                    return LanguageFormatStrings.Basque;
                case "be": // Belarusian
                    return LanguageFormatStrings.Belarusian;
                case "bs": // Bosnian
                    return LanguageFormatStrings.Bosnian;
                case "bg": // Bulgarian
                    return LanguageFormatStrings.Bulgarian;
                case "ca": // Catalan
                    return LanguageFormatStrings.Catalan;
                case "zh": // Chinese
                    if (cultureInfo.Name == "zh-Hant" || cultureInfo.Name == "zh-CHT" ||
                        cultureInfo.Parent.Name == "zh-Hant" || cultureInfo.Parent.Name == "zh-CHT")
                        return LanguageFormatStrings.TraditionalChinese;
                    else
                        return LanguageFormatStrings.SimplifiedChinese;
                case "hr": // Croatian
                    return LanguageFormatStrings.Croatian;
                case "cs": // Czech
                    return LanguageFormatStrings.Czech;
                case "da": // Danish
                    return LanguageFormatStrings.Danish;
                case "nl": // Dutch
                    return LanguageFormatStrings.Dutch;
                case "en": // English
                    return LanguageFormatStrings.English;
                case "et": // Estonian
                    return LanguageFormatStrings.Estonian;
                case "fil": // Filipino
                    return LanguageFormatStrings.Filipino;
                case "fi": // Finnish
                    return LanguageFormatStrings.Finnish;
                case "fr": // French
                    return LanguageFormatStrings.French;
                case "gl": // Galician
                    return LanguageFormatStrings.Galician;
                case "ka": // Georgian
                    return LanguageFormatStrings.Georgian;
                case "de": // German
                    return LanguageFormatStrings.German;
                case "el": // Greek
                    return LanguageFormatStrings.Greek;
                case "gu": // Gujarati
                    return LanguageFormatStrings.Gujarati;
                case "he": // Hebrew
                    return LanguageFormatStrings.Hebrew;
                case "hi": // Hindi
                    return LanguageFormatStrings.Hindi;
                case "hu": // Hungarian
                    return LanguageFormatStrings.Hungarian;
                case "is": // Icelandic
                    return LanguageFormatStrings.Icelandic;
                case "ig": // Igbo
                    return LanguageFormatStrings.Igbo;
                case "id": // Indonesian
                    return LanguageFormatStrings.Indonesian;
                case "ga": // Irish
                    return LanguageFormatStrings.Irish;
                case "it": // Italian
                    return LanguageFormatStrings.Italian;
                case "ja": // Japanese
                    return LanguageFormatStrings.Japanese;
                case "kn": // Kannada
                    return LanguageFormatStrings.Kannada;
                case "kk": // Kazakh
                    return LanguageFormatStrings.Kazakh;
                case "km": // Khmer
                    return LanguageFormatStrings.Khmer;
                case "ko": // Korean
                    return LanguageFormatStrings.Korean;
                case "lo": // Lao
                    return LanguageFormatStrings.Lao;
                case "lv": // Latvian
                    return LanguageFormatStrings.Latvian;
                case "lt": // Lithuanian
                    return LanguageFormatStrings.Lithuanian;
                case "mk": // Macedonian (Former Yugoslav Republic of Macedonia)
                    return LanguageFormatStrings.Macedonian;
                case "mg": // Malagasy
                    return LanguageFormatStrings.Malagasy;
                case "ml": // Malayalam
                    return LanguageFormatStrings.Malayalam;
                case "mt": // Maltese
                    return LanguageFormatStrings.Maltese;
                case "mi": // Maori
                    return LanguageFormatStrings.Maori;
                case "mr": // Marathi
                    return LanguageFormatStrings.Marathi;
                case "mn": // Mongolian
                    return LanguageFormatStrings.Mongolian;
                case "ne": // Nepali
                    return LanguageFormatStrings.Nepali;
                case "nb": // N'ko
                    return LanguageFormatStrings.Norwegian;
                case "fa": // Persian
                    return LanguageFormatStrings.Persian;
                case "pl": // Polish
                    return LanguageFormatStrings.Polish;
                case "pt": // Portuguese
                    return LanguageFormatStrings.Portuguese;
                case "ro": // Romanian
                    return LanguageFormatStrings.Romanian;
                case "ru": // Russian
                    return LanguageFormatStrings.Russian;
                case "sr": // Serbian
                    return LanguageFormatStrings.Serbian;
                case "sk": // Slovak
                    return LanguageFormatStrings.Slovak;
                case "sl": // Slovenian
                    return LanguageFormatStrings.Slovenian;
                case "es": // Spanish
                    return LanguageFormatStrings.Spanish;
                case "sv": // Swedish
                    return LanguageFormatStrings.Swedish;
                case "tg": // Tajik
                    return LanguageFormatStrings.Tajik;
                case "ta": // Tamil
                    return LanguageFormatStrings.Tamil;
                case "te": // Telugu
                    return LanguageFormatStrings.Telugu;
                case "th": // Thai
                    return LanguageFormatStrings.Thai;
                case "tr": // Turkish
                    return LanguageFormatStrings.Turkish;
                case "uk": // Ukrainian
                    return LanguageFormatStrings.Ukrainian;
                case "ur": // Urdu
                    return LanguageFormatStrings.Urdu;
                case "uz": // Uzbek
                    return LanguageFormatStrings.Uzbek;
                case "vi": // Vietnamese
                    return LanguageFormatStrings.Vietnamese;
                case "cy": // Welsh
                    return LanguageFormatStrings.Welsh;
                case "yo": // Yoruba
                    return LanguageFormatStrings.Yoruba;
                default:
                    throw new NotSupportedException("The provided CultureInfo is not supported.");
            }
        }
    }
}