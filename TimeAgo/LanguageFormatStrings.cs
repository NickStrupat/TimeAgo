using System;

namespace TimeAgo {
	internal static class LanguageFormatStrings {
		internal class VerifiedByNativeSpeakerAttribute : Attribute { }

		private static DateTimeFormatStrings? afrikaans;
		public static DateTimeFormatStrings Afrikaans {
			get {
				return afrikaans ?? (afrikaans = new DateTimeFormatStrings {
					SecondAgo =  "{0} sekonde gelede",
					SecondsAgo = "{0} sekondes gelede",
					MinuteAgo =  "{0} minuut gelede",
					MinutesAgo = "{0} minute gelede",
					HourAgo =    "{0} uur gelede",
					HoursAgo =   "{0} uur gelede",
					DayAgo =     "{0} dag gelede",
					DaysAgo =    "{0} dae gelede",
					MonthAgo =   "{0} maand gelede",
					MonthsAgo =  "{0} maande gelede",
					YearAgo =    "{0} jaar gelede",
					YearsAgo =   "{0} jaar gelede",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? albanian;
		public static DateTimeFormatStrings Albanian {
			get {
				return albanian ?? (albanian = new DateTimeFormatStrings {
					SecondAgo =  "{0} sekondë më parë",
					SecondsAgo = "{0} sekonda më parë",
					MinuteAgo =  "{0} minutë më parë",
					MinutesAgo = "{0} minuta më parë",
					HourAgo =    "{0} orë më parë",
					HoursAgo =   "{0} orë më parë",
					DayAgo =     "{0} ditë më parë",
					DaysAgo =    "{0} ditë më parë",
					MonthAgo =   "{0} muaj më parë",
					MonthsAgo =  "{0} muaj më parë",
					YearAgo =    "{0} vit më parë",
					YearsAgo =   "{0} vjet më parë",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? arabic;
		public static DateTimeFormatStrings Arabic {
			get {
				return arabic ?? (arabic = new DateTimeFormatStrings {
					SecondAgo =  "منذ {0} ثانية",
					SecondsAgo = "{0} ثوان قبل",
					MinuteAgo =  "منذ {0} دقيقة",
					MinutesAgo = "قبل {0} دقائق",
					HourAgo =    "منذ {0} ساعة",
					HoursAgo =   "منذ {0} ساعات",
					DayAgo =     "{0} منذ يوم",
					DaysAgo =    "منذ {0} أيام",
					MonthAgo =   "{0} قبل شهر",
					MonthsAgo =  "قبل {0} أشهر",
					YearAgo =    "{منذ سنة {0}",
					YearsAgo =   "قبل {0} سنوات",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? armenian;
		public static DateTimeFormatStrings Armenian {
			get {
				return armenian ?? (armenian = new DateTimeFormatStrings {
					SecondAgo =  "{0} վայրկյան առաջ",
					SecondsAgo = "{0} վայրկյան առաջ",
					MinuteAgo =  "{0} րոպե առաջ",
					MinutesAgo = "{0} րոպե առաջ",
					HourAgo =    "{0} ժամ առաջ",
					HoursAgo =   "{0} ամիս առաջ",
					DayAgo =     "{0} օր առաջ",
					DaysAgo =    "{0} օր առաջ",
					MonthAgo =   "{0} տարի առաջ",
					MonthsAgo =  "{0} ամիս առաջ",
					YearAgo =    "{0} տարի առաջ",
					YearsAgo =   "{0} տարի առաջ",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? azerbaijani;
		public static DateTimeFormatStrings Azerbaijani {
			get {
				return azerbaijani ?? (azerbaijani = new DateTimeFormatStrings {
					SecondAgo =  "{0} saniyə əvvəl",
					SecondsAgo = "{0} saniyə əvvəl",
					MinuteAgo =  "{0} dəqiqə əvvəl",
					MinutesAgo = "{0} dəqiqə əvvəl",
					HourAgo =    "{0} saat əvvəl",
					HoursAgo =   "{0} saat əvvəl",
					DayAgo =     "{0} gün əvvəl",
					DaysAgo =    "{0} gün əvvəl",
					MonthAgo =   "{0} ay əvvəl",
					MonthsAgo =  "{0} ay əvvəl",
					YearAgo =    "{0} il əvvəl",
					YearsAgo =   "{0} il əvvəl",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? basque;
		public static DateTimeFormatStrings Basque {
			get {
				return basque ?? (basque = new DateTimeFormatStrings {
					SecondAgo =  "Duela {0} bigarren",
					SecondsAgo = "Duela {0} segundo",
					MinuteAgo =  "Duela {0} minutu",
					MinutesAgo = "Duela {0} minutu",
					HourAgo =    "Duela ordu {0}",
					HoursAgo =   "Duela {0} ordu",
					DayAgo =     "Duela {0} egun",
					DaysAgo =    "Duela {0} egun",
					MonthAgo =   "Duela {0} hilabete",
					MonthsAgo =  "Duela {0} hilabete",
					YearAgo =    "Duela urte {0}",
					YearsAgo =   "Duela {0} urte",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? belarusian;
		public static DateTimeFormatStrings Belarusian {
			get {
				return belarusian ?? (belarusian = new DateTimeFormatStrings {
					SecondAgo =  "{0} секунду таму",
					SecondsAgo = "{0} секунд таму",
					MinuteAgo =  "{0} хвіліну таму",
					MinutesAgo = "{0} хвілін таму",
					HourAgo =    "{0}:00 назад",
					HoursAgo =   "{0}:00 назад",
					DayAgo =     "{0} дзень таму",
					DaysAgo =    "{0} дзён таму",
					MonthAgo =   "{0} месяц таму",
					MonthsAgo =  "{0} месяцаў таму",
					YearAgo =    "{0} год таму",
					YearsAgo =   "{0} гадоў таму",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? bosnian;
		public static DateTimeFormatStrings Bosnian {
			get {
				return bosnian ?? (bosnian = new DateTimeFormatStrings {
					SecondAgo =  "{0} sekunda prije",
					SecondsAgo = "Prije {0} sekundi",
					MinuteAgo =  "Prije {0} minutu",
					MinutesAgo = "{0} minuta prije",
					HourAgo =    "{0} sat prije",
					HoursAgo =   "{0} sati prije",
					DayAgo =     "Prije {0} dan",
					DaysAgo =    "Prije {0} dana",
					MonthAgo =   "Prije {0} mjesec",
					MonthsAgo =  "Prije {0} mjeseci",
					YearAgo =    "{0} godina prije",
					YearsAgo =   "Prije {0} godina",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? bulgarian;
		public static DateTimeFormatStrings Bulgarian {
			get {
				return bulgarian ?? (bulgarian = new DateTimeFormatStrings {
					SecondAgo =  "Преди {0} секунди",
					SecondsAgo = "Преди {0} секунди",
					MinuteAgo =  "Преди {0} минути",
					MinutesAgo = "{0} минути преди",
					HourAgo =    "Преди {0} час",
					HoursAgo =   "Преди пет часа",
					DayAgo =     "Преди {0} ден",
					DaysAgo =    "Преди {0} дни",
					MonthAgo =   "{0} Преди месец",
					MonthsAgo =  "Преди {0} месеца",
					YearAgo =    "Преди {0} година",
					YearsAgo =   "Преди {0} години",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? catalan;
		public static DateTimeFormatStrings Catalan {
			get {
				return catalan ?? (catalan = new DateTimeFormatStrings {
					SecondAgo =  "Fa {0} segon",
					SecondsAgo = "Fa {0} segons",
					MinuteAgo =  "Fa {0} minut",
					MinutesAgo = "Fa {0} minuts",
					HourAgo =    "Fa {0} dia",
					HoursAgo =   "Fa {0} hores",
					DayAgo =     "Fa {0} dia",
					DaysAgo =    "Fa {0} dies",
					MonthAgo =   "Fa {0} mes",
					MonthsAgo =  "Fa {0} mesos",
					YearAgo =    "Fa {0} any",
					YearsAgo =   "Fa {0} anys",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? chinese;
        [VerifiedByNativeSpeaker]
		public static DateTimeFormatStrings Chinese {
			get {
				return chinese ?? (chinese = new DateTimeFormatStrings {
					SecondAgo =  "{0} 秒前",
					SecondsAgo = "{0} 秒前",
					MinuteAgo =  "{0} 分钟前",
					MinutesAgo = "{0} 分钟前",
					HourAgo =    "{0} 小时前",
					HoursAgo =   "{0} 小时前",
					DayAgo =     "{0} 天前",
					DaysAgo =    "{0} 天前",
					MonthAgo =   "{0} 个月前",
					MonthsAgo =  "{0} 个月前",
					YearAgo =    "{0} 年前",
					YearsAgo =   "{0} 年前",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? croatian;
		public static DateTimeFormatStrings Croatian {
			get {
				return croatian ?? (croatian = new DateTimeFormatStrings {
					SecondAgo =  "Prije {0}",
					SecondsAgo = "{0} sekundi prije",
					MinuteAgo =  "Prije {0} minute",
					MinutesAgo = "Prije {0} minuta",
					HourAgo =    "Prije {0} sat",
					HoursAgo =   "Prije {0} sati",
					DayAgo =     "Prije {0} dan",
					DaysAgo =    "Prije {0} dana",
					MonthAgo =   "Prije {0} mjesec",
					MonthsAgo =  "Prije {0} mjeseci",
					YearAgo =    "Prije {0} godina",
					YearsAgo =   "Prije {0} godina",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? czech;
		public static DateTimeFormatStrings Czech {
			get {
				return czech ?? (czech = new DateTimeFormatStrings {
					SecondAgo =  "Před {0} sekunda",
					SecondsAgo = "Před {0} sekund",
					MinuteAgo =  "Před {0} minutou",
					MinutesAgo = "Před {0} minutami",
					HourAgo =    "Před {0} hodinou",
					HoursAgo =   "{0} hodiny",
					DayAgo =     "Před {0} dnem",
					DaysAgo =    "Před {0} dny",
					MonthAgo =   "{0} před měsícem",
					MonthsAgo =  "Před {0} měsíci",
					YearAgo =    "Před {0} rokem",
					YearsAgo =   "Před {0} lety",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? danish;
		public static DateTimeFormatStrings Danish {
			get {
				return danish ?? (danish = new DateTimeFormatStrings {
					SecondAgo =  "{0} sekund siden",
					SecondsAgo = "{0} sekunder siden",
					MinuteAgo =  "{0} minut siden",
					MinutesAgo = "{0} minutter siden",
					HourAgo =    "{0} time siden",
					HoursAgo =   "{0} timer siden",
					DayAgo =     "{0} dag siden",
					DaysAgo =    "{0} dage siden",
					MonthAgo =   "{0} Måned siden",
					MonthsAgo =  "{0} måneder siden",
					YearAgo =    "{0} år siden",
					YearsAgo =   "{0} år siden",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? dutch;
		public static DateTimeFormatStrings Dutch {
			get {
				return dutch ?? (dutch = new DateTimeFormatStrings {
					SecondAgo =  "{0} seconde geleden",
					SecondsAgo = "{0} seconden geleden",
					MinuteAgo =  "{0} minuut geleden",
					MinutesAgo = "{0} minuten geleden",
					HourAgo =    "{0} uur geleden",
					HoursAgo =   "{0} uur geleden",
					DayAgo =     "{0} uur geleden",
					DaysAgo =    "{0} dagen geleden",
					MonthAgo =   "{0} maand geleden",
					MonthsAgo =  "{0} maanden geleden",
					YearAgo =    "{0} jaar geleden",
					YearsAgo =   "{0} jaar geleden",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? english;
		public static DateTimeFormatStrings English {
			get {
				return english ?? (english = new DateTimeFormatStrings {
					SecondAgo =  "{0} second ago",
					SecondsAgo = "{0} seconds ago",
					MinuteAgo =  "{0} minute ago",
					MinutesAgo = "{0} minutes ago",
					HourAgo =    "{0} hour ago",
					HoursAgo =   "{0} hours ago",
					DayAgo =     "{0} day ago",
					DaysAgo =    "{0} days ago",
					MonthAgo =   "{0} month ago",
					MonthsAgo =  "{0} months ago",
					YearAgo =    "{0} year ago",
					YearsAgo =   "{0} years ago",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? estonian;
		public static DateTimeFormatStrings Estonian {
			get {
				return estonian ?? (estonian = new DateTimeFormatStrings {
					SecondAgo =  "{0} sekund tagasi",
					SecondsAgo = "{0} tundi tagasi",
					MinuteAgo =  "{0} minut tagasi",
					MinutesAgo = "{0} tundi tagasi",
					HourAgo =    "{0} tund tagasi",
					HoursAgo =   "{0} tundi tagasi",
					DayAgo =     "{0} tund tagasi",
					DaysAgo =    "{0} tundi tagasi",
					MonthAgo =   "{0} kuu tagasi",
					MonthsAgo =  "{0} kuud tagasi",
					YearAgo =    "{0} aasta tagasi",
					YearsAgo =   "{0} aastat tagasi",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? filipino;
		public static DateTimeFormatStrings Filipino {
			get {
				return filipino ?? (filipino = new DateTimeFormatStrings {
					SecondAgo =  "{0} segundo ang nakalipas",
					SecondsAgo = "{0} segundo ang nakalipas",
					MinuteAgo =  "{0} minuto ang nakalipas",
					MinutesAgo = "{0} minuto ang nakalipas",
					HourAgo =    "{0} oras ang nakalipas",
					HoursAgo =   "{0} oras ang nakalipas",
					DayAgo =     "{0} araw ang nakalipas",
					DaysAgo =    "{0} araw ang nakalipas",
					MonthAgo =   "{0} buwan ang nakalipas",
					MonthsAgo =  "{0} buwan na nakalipas",
					YearAgo =    "{0} taon ang nakalipas",
					YearsAgo =   "{0} taon ang nakalipas",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? finnish;
		public static DateTimeFormatStrings Finnish {
			get {
				return finnish ?? (finnish = new DateTimeFormatStrings {
					SecondAgo =  "{0} sekunti sitten",
					SecondsAgo = "{0} sekuntia sitten",
					MinuteAgo =  "{0} minuutti sitten",
					MinutesAgo = "{0} minuuttia sitten",
					HourAgo =    "{0} tunti sitten",
					HoursAgo =   "{0} tuntia sitten",
					DayAgo =     "{0} päivä sitten",
					DaysAgo =    "{0} päivää sitten",
					MonthAgo =   "{0} kuukausi sitten",
					MonthsAgo =  "{0} kuukautta sitten",
					YearAgo =    "{0} vuosi sitten",
					YearsAgo =   "{0} vuotta sitten",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? french;
        [VerifiedByNativeSpeaker]
		public static DateTimeFormatStrings French {
			get {
				return french ?? (french = new DateTimeFormatStrings {
					SecondAgo =  "Il ya {0} seconde",
					SecondsAgo = "Il ya {0} secondes",
					MinuteAgo =  "Il ya {0} minute",
					MinutesAgo = "Il ya {0} minutes",
					HourAgo =    "Il ya {0} heure",
					HoursAgo =   "Il ya {0} heures",
					DayAgo =     "Il ya {0} jour",
					DaysAgo =    "Il ya {0} jours",
					MonthAgo =   "Il ya {0} mois",
					MonthsAgo =  "Il ya {0} mois",
					YearAgo =    "Il ya {0} an",
					YearsAgo =   "Il ya {0} ans",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? galician;
		public static DateTimeFormatStrings Galician {
			get {
				return galician ?? (galician = new DateTimeFormatStrings {
					SecondAgo =  "{0} segundo atrás",
					SecondsAgo = "{0} segundo atrás",
					MinuteAgo =  "{0} hora",
					MinutesAgo = "{0} minutos atrás",
					HourAgo =    "{0} hora",
					HoursAgo =   "{0} horas atrás",
					DayAgo =     "{0} día",
					DaysAgo =    "{0} días atrás",
					MonthAgo =   "{0} mes atrás",
					MonthsAgo =  "{0} meses atrás",
					YearAgo =    "{0} ano atrás",
					YearsAgo =   "{0} anos",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? georgian;
		public static DateTimeFormatStrings Georgian {
			get {
				return georgian ?? (georgian = new DateTimeFormatStrings {
					SecondAgo =  "{0} წამის წინ",
					SecondsAgo = "{0} წამის წინ",
					MinuteAgo =  "{0} წუთის წინ",
					MinutesAgo = "{0} წუთის წინ",
					HourAgo =    "{0} საათის წინ",
					HoursAgo =   "{0} საათის წინ",
					DayAgo =     "{0} დღის წინ",
					DaysAgo =    "{0} დღის წინ",
					MonthAgo =   "{0} თვის წინ",
					MonthsAgo =  "{0} თვის წინ",
					YearAgo =    "{0} წლის წინ",
					YearsAgo =   "{0} წლის წინ",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? german;
		public static DateTimeFormatStrings German {
			get {
				return german ?? (german = new DateTimeFormatStrings {
					SecondAgo =  "Vor {0} Sekunde",
					SecondsAgo = "Vor {0} Sekunden",
					MinuteAgo =  "Vor {0} Minute",
					MinutesAgo = "Vor {0} Minuten",
					HourAgo =    "Vor {0} Stunde",
					HoursAgo =   "Vor {0} Stunden",
					DayAgo =     "Vor {0} Tag",
					DaysAgo =    "Vor {0} Tage",
					MonthAgo =   "Vor {0} Monat",
					MonthsAgo =  "Vor {0} Monaten",
					YearAgo =    "Vor {0} Jahr",
					YearsAgo =   "Vor {0} Jahren",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? greek;
		public static DateTimeFormatStrings Greek {
			get {
				return greek ?? (greek = new DateTimeFormatStrings {
					SecondAgo =  "πριν από {0} δευτερόλεπτο",
					SecondsAgo = "πριν από {0} δευτερόλεπτα",
					MinuteAgo =  "πριν από {0} λεπτό",
					MinutesAgo = "πριν από {0} λεπτά",
					HourAgo =    "πριν από {0} ώρα",
					HoursAgo =   "πριν από {0} ώρες",
					DayAgo =     "{0} ημέρα πριν",
					DaysAgo =    "πριν από {0} ημέρες",
					MonthAgo =   "{0} μήνα πριν",
					MonthsAgo =  "πριν από {0} μήνες",
					YearAgo =    "{0} χρόνο πριν",
					YearsAgo =   "πριν από {0} χρόνια",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? gujarati;
		public static DateTimeFormatStrings Gujarati {
			get {
				return gujarati ?? (gujarati = new DateTimeFormatStrings {
					SecondAgo =  "{0} સેકન્ડ પહેલા",
					SecondsAgo = "{0} સેકન્ડ પહેલા",
					MinuteAgo =  "{0} મિનિટ પહેલા",
					MinutesAgo = "{0} મિનિટ પહેલા",
					HourAgo =    "{0} કલાક પહેલા",
					HoursAgo =   "{0} કલાક પહેલા",
					DayAgo =     "{0} દિવસ પહેલાં",
					DaysAgo =    "{0} દિવસ પહેલા",
					MonthAgo =   "{0} મહિનો પહેલાં",
					MonthsAgo =  "{0} મહિના પહેલા",
					YearAgo =    "{0} વર્ષ પહેલાં",
					YearsAgo =   "{0} વર્ષ પહેલાં",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? hebrew;
		public static DateTimeFormatStrings Hebrew {
			get {
				return hebrew ?? (hebrew = new DateTimeFormatStrings {
					SecondAgo =  "לפני שניה",
					SecondsAgo = "לפני {0} שניות",
					MinuteAgo =  "לפני {0} דקה",
					MinutesAgo = "לפני {0} דקות",
					HourAgo =    "לפני {0} שעה",
					HoursAgo =   "לפני {0} שעות",
					DayAgo =     "לפני {0} יום",
					DaysAgo =    "לפני {0} ימים",
					MonthAgo =   "לפני {0} חודש",
					MonthsAgo =  "לפני {0} חודשים",
					YearAgo =    "{0} לפני שנה",
					YearsAgo =   "לפני {0} שנים",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? hindi;
		public static DateTimeFormatStrings Hindi {
			get {
				return hindi ?? (hindi = new DateTimeFormatStrings {
					SecondAgo =  "{0} सेकंड पहले",
					SecondsAgo = "{0} सेकंड पहले",
					MinuteAgo =  "{0} मिनट पहले",
					MinutesAgo = "{0} मिनट पहले",
					HourAgo =    "{0} घंटे पहले",
					HoursAgo =   "{0} घंटे पहले",
					DayAgo =     "{0} दिन पहले",
					DaysAgo =    "{0} दिन पहले",
					MonthAgo =   "{0} महीने पहले",
					MonthsAgo =  "{0} महीने पहले",
					YearAgo =    "{0} वर्ष पहले",
					YearsAgo =   "{0} साल पहले",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? hungarian;
        [VerifiedByNativeSpeaker]
		public static DateTimeFormatStrings Hungarian {
			get {
				return hungarian ?? (hungarian = new DateTimeFormatStrings {
					SecondAgo =  "{0} másodperccel ezelőtt",
					SecondsAgo = "{0} másodperccel ezelőtt",
					MinuteAgo =  "{0} perccel ezelőtt",
					MinutesAgo = "{0} perccel ezelőtt",
					HourAgo =    "{0} órával ezelőtt",
					HoursAgo =   "{0} órával ezelőtt",
					DayAgo =     "{0} nappal ezelőtt",
					DaysAgo =    "{0} nappal ezelőtt",
					MonthAgo =   "{0} hónappal ezelőtt",
					MonthsAgo =  "{0} hónappal ezelőtt",
					YearAgo =    "{0} évvel ezelőtt",
					YearsAgo =   "{0} évvel ezelőtt",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? icelandic;
		public static DateTimeFormatStrings Icelandic {
			get {
				return icelandic ?? (icelandic = new DateTimeFormatStrings {
					SecondAgo =  "{0} sekúndu síðan",
					SecondsAgo = "{0} sekúndum síðan",
					MinuteAgo =  "{0} mínútu síðan",
					MinutesAgo = "{0} mínútum síðan",
					HourAgo =    "{0} klukkustund síðan",
					HoursAgo =   "{0} klst síðan",
					DayAgo =     "{0} degi síðan",
					DaysAgo =    "{0} dagar síðan",
					MonthAgo =   "{0} mánuður síðan",
					MonthsAgo =  "{0} mánuðum síðan",
					YearAgo =    "{0} ári",
					YearsAgo =   "{0} árum síðan",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? igbo;
		public static DateTimeFormatStrings Igbo {
			get {
				return igbo ?? (igbo = new DateTimeFormatStrings {
					SecondAgo =  "{0} abụọ gara aga",
					SecondsAgo = "{0} sekọnd gara aga",
					MinuteAgo =  "{0} nkeji gara aga",
					MinutesAgo = "{0} nkeji gara aga",
					HourAgo =    "{0} hour gara aga",
					HoursAgo =   "{0} awa gara aga",
					DayAgo =     "{0} ụbọchị gara aga",
					DaysAgo =    "{0} ụbọchị gara aga",
					MonthAgo =   "{0} ọnwa gara aga",
					MonthsAgo =  "{0} ọnwa gara aga",
					YearAgo =    "{0} afọ gara aga",
					YearsAgo =   "{0} afọ gara aga",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? indonesian;
		public static DateTimeFormatStrings Indonesian {
			get {
				return indonesian ?? (indonesian = new DateTimeFormatStrings {
					SecondAgo =  "{0} detik yang lalu",
					SecondsAgo = "{0} detik yang lalu",
					MinuteAgo =  "{0} menit yang lalu",
					MinutesAgo = "{0} menit yang lalu",
					HourAgo =    "{0} jam yang lalu",
					HoursAgo =   "{0} jam yang lalu",
					DayAgo =     "{0} hari lalu",
					DaysAgo =    "{0} hari yang lalu",
					MonthAgo =   "{0} bulan lalu",
					MonthsAgo =  "{0} bulan lalu",
					YearAgo =    "{0} tahun lalu",
					YearsAgo =   "{0} tahun yang lalu",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? irish;
		public static DateTimeFormatStrings Irish {
			get {
				return irish ?? (irish = new DateTimeFormatStrings {
					SecondAgo =  "{0} an dara ó shin",
					SecondsAgo = "{0} soicind ó shin",
					MinuteAgo =  "{0} nóiméad ó shin",
					MinutesAgo = "{0} nóiméad ó shin",
					HourAgo =    "{0} uair an chloig ó shin",
					HoursAgo =   "{0} uair an chloig ó shin",
					DayAgo =     "{0} lá ó shin",
					DaysAgo =    "{0} lá ó shin",
					MonthAgo =   "{0} mí ó shin",
					MonthsAgo =  "{0} mí ó shin",
					YearAgo =    "{0} bhliain ó shin",
					YearsAgo =   "{0} bliana ó shin",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? italian;
		public static DateTimeFormatStrings Italian {
			get {
				return italian ?? (italian = new DateTimeFormatStrings {
					SecondAgo =  "{0} secondo fa",
					SecondsAgo = "{0} secondi fa",
					MinuteAgo =  "{0} minuto fa",
					MinutesAgo = "{0} minuti fa",
					HourAgo =    "{0} ora fa",
					HoursAgo =   "{0} ore fa",
					DayAgo =     "{0} giorno fa",
					DaysAgo =    "{0} giorni fa",
					MonthAgo =   "{0} mese fa",
					MonthsAgo =  "{0} mesi fa",
					YearAgo =    "{0} anno fa",
					YearsAgo =   "{0} anni fa",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? japanese;
		public static DateTimeFormatStrings Japanese {
			get {
				return japanese ?? (japanese = new DateTimeFormatStrings {
					SecondAgo =  "{0} 秒前",
					SecondsAgo = "{0} 秒前",
					MinuteAgo =  "{0} 分前",
					MinutesAgo = "{0} 分前",
					HourAgo =    "{0} 時間前",
					HoursAgo =   "{0} 時間前",
					DayAgo =     "{0} 日前",
					DaysAgo =    "{0} 日前",
					MonthAgo =   "{0} ヶ月前",
					MonthsAgo =  "{0} ヶ月前",
					YearAgo =    "{0} 年前",
					YearsAgo =   "{0} 年前",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? kannada;
		public static DateTimeFormatStrings Kannada {
			get {
				return kannada ?? (kannada = new DateTimeFormatStrings {
					SecondAgo =  "{0} ಸೆಕೆಂಡ್ ಹಿಂದೆ",
					SecondsAgo = "{0} ಸೆಕೆಂಡುಗಳ ಹಿಂದೆ",
					MinuteAgo =  "{0} ನಿಮಿಷ ಹಿಂದೆ",
					MinutesAgo = "{0} ನಿಮಿಷಗಳ ಹಿಂದೆ",
					HourAgo =    "{0} ಗಂಟೆಯ ಹಿಂದೆ",
					HoursAgo =   "{0} ಗಂಟೆಗಳ ಹಿಂದೆ",
					DayAgo =     "{0} ದಿನ ಹಿಂದೆ",
					DaysAgo =    "{0} ದಿನಗಳ ಹಿಂದೆ",
					MonthAgo =   "{0} ತಿಂಗಳ ಹಿಂದೆ",
					MonthsAgo =  "{0} ತಿಂಗಳ ಹಿಂದೆ",
					YearAgo =    "{0} ವರ್ಷದ ಹಿಂದೆ",
					YearsAgo =   "{0} ವರ್ಷಗಳ ಹಿಂದೆ",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? kazakh;
		public static DateTimeFormatStrings Kazakh {
			get {
				return kazakh ?? (kazakh = new DateTimeFormatStrings {
					SecondAgo =  "{0} екінші бұрын",
					SecondsAgo = "{0} секунд бұрын",
					MinuteAgo =  "{0} минут бұрын",
					MinutesAgo = "{0} минут бұрын",
					HourAgo =    "{0} сағат бұрын",
					HoursAgo =   "{0} сағат бұрын",
					DayAgo =     "{0} күн бұрын",
					DaysAgo =    "{0} күн бұрын",
					MonthAgo =   "{0} ай бұрын",
					MonthsAgo =  "{0} ай бұрын",
					YearAgo =    "{0} жыл бұрын",
					YearsAgo =   "{0} жыл бұрын",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? khmer;
		public static DateTimeFormatStrings Khmer {
			get {
				return khmer ?? (khmer = new DateTimeFormatStrings {
					SecondAgo =  "{0} វិនាទីមុន",
					SecondsAgo = "{0} វិនាទីមុន",
					MinuteAgo =  "{0} នាទីមុន",
					MinutesAgo = "{0} នាទីមុន",
					HourAgo =    "{0} ម៉ោងមុន",
					HoursAgo =   "{0} ម៉ោងកន្លងទៅ",
					DayAgo =     "{0} ថ្ងៃមុន",
					DaysAgo =    "{0} ថ្ងៃមុន",
					MonthAgo =   "{0} ខែកន្លង",
					MonthsAgo =  "{0} ខែកន្លងទៅ",
					YearAgo =    "{0} ឆ្នាំមុន",
					YearsAgo =   "{0} ឆ្នាំកន្លងមក",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? korean;
		public static DateTimeFormatStrings Korean {
			get {
				return korean ?? (korean = new DateTimeFormatStrings {
					SecondAgo =  "{0} 초 전",
					SecondsAgo = "{0} 초 전",
					MinuteAgo =  "{0} 분 전",
					MinutesAgo = "{0} 분 전",
					HourAgo =    "{0} 시간 전",
					HoursAgo =   "{0} 시간 전",
					DayAgo =     "{0} 일 전",
					DaysAgo =    "{0} 일 전",
					MonthAgo =   "{0} 달 전",
					MonthsAgo =  "{0} 개월 전",
					YearAgo =    "{0} 년 전",
					YearsAgo =   "{0} 년 전",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? lao;
		public static DateTimeFormatStrings Lao {
			get {
				return lao ?? (lao = new DateTimeFormatStrings {
					SecondAgo =  "{0} ວິນາທີກ່ອນຫນ້ານີ້",
					SecondsAgo = "{0} ວິນາທີກ່ອນຫນ້ານີ້",
					MinuteAgo =  "{0} ນາທີກ່ອນຫນ້ານີ້",
					MinutesAgo = "{0} ນາທີກ່ອນຫນ້ານີ້",
					HourAgo =    "{0} ຊົ່ວໂມງກ່ອນຫນ້ານີ້",
					HoursAgo =   "{0} ຊົ່ວໂມງກ່ອນຫນ້ານີ້",
					DayAgo =     "{0} ມື້ກ່ອນຫນ້ານີ້",
					DaysAgo =    "{0} ມື້ກ່ອນຫນ້ານີ້",
					MonthAgo =   "{0} ເດືອນທີ່ຜ່ານມາ",
					MonthsAgo =  "{0} ເດືອນທີ່ຜ່ານມາ",
					YearAgo =    "{0} ປີກ່ອນຫນ້ານີ້",
					YearsAgo =   "{0} ປີກ່ອນຫນ້ານີ້",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? latvian;
		public static DateTimeFormatStrings Latvian {
			get {
				return latvian ?? (latvian = new DateTimeFormatStrings {
					SecondAgo =  "Pirms {0} sekundes",
					SecondsAgo = "{0} sekundes pirms",
					MinuteAgo =  "{0} stunda pirms",
					MinutesAgo = "{0} minūtes pirms",
					HourAgo =    "Pirms {0} stundas",
					HoursAgo =   "Pirms {0} stundām",
					DayAgo =     "Pirms {0} dienas",
					DaysAgo =    "{0} dienas atpakaļ",
					MonthAgo =   "{0} mēnesis pirms",
					MonthsAgo =  "Pirms {0} mēnešiem",
					YearAgo =    "Pirms {0} gads",
					YearsAgo =   "Pirms {0} gadiem",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? lithuanian;
		public static DateTimeFormatStrings Lithuanian {
			get {
				return lithuanian ?? (lithuanian = new DateTimeFormatStrings {
					SecondAgo =  "Prieš {0} sekundę",
					SecondsAgo = "Prieš {0} sekundes",
					MinuteAgo =  "Prieš {0} minutę",
					MinutesAgo = "Prieš {0} minutes",
					HourAgo =    "Prieš {0} valandą",
					HoursAgo =   "Prieš {0} val",
					DayAgo =     "Prieš {0} dieną",
					DaysAgo =    "{0} days ago",
					MonthAgo =   "Prieš {0} mėnesį",
					MonthsAgo =  "{0} mėnesiai prieš",
					YearAgo =    "Prieš {0} metus",
					YearsAgo =   "Prieš {0} metų",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? macedonian;
		public static DateTimeFormatStrings Macedonian {
			get {
				return macedonian ?? (macedonian = new DateTimeFormatStrings {
					SecondAgo =  "Пред {0} секунда",
					SecondsAgo = "Пред {0} секунди",
					MinuteAgo =  "Пред {0} минута",
					MinutesAgo = "Пред {0} минути",
					HourAgo =    "Пред {0} час",
					HoursAgo =   "Пред {0} часа",
					DayAgo =     "Пред {0} ден",
					DaysAgo =    "Пред {0} дена",
					MonthAgo =   "Пред {0} месец",
					MonthsAgo =  "Пред {0} месеци",
					YearAgo =    "Пред {0} година",
					YearsAgo =   "Пред {0} години",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? malagasy;
		public static DateTimeFormatStrings Malagasy {
			get {
				return malagasy ?? (malagasy = new DateTimeFormatStrings {
					SecondAgo =  "{0} faharoa lasa izay",
					SecondsAgo = "{0} segondra lasa izay",
					MinuteAgo =  "{0} minitra lasa izay",
					MinutesAgo = "{0} minitra lasa izay",
					HourAgo =    "{0} adiny lasa izay",
					HoursAgo =   "{0} adiny lasa izay",
					DayAgo =     "{0} andro lasa izay",
					DaysAgo =    "{0} andro lasa izay",
					MonthAgo =   "{0} volana lasa izay",
					MonthsAgo =  "{0} volana lasa izay",
					YearAgo =    "{0} taona lasa izay",
					YearsAgo =   "{0} taona lasa izay",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? malayalam;
		public static DateTimeFormatStrings Malayalam {
			get {
				return malayalam ?? (malayalam = new DateTimeFormatStrings {
					SecondAgo =  "{0} സെക്കന്റ് മുമ്പ്",
					SecondsAgo = "{0} സെക്കന്റ് മുമ്പ്",
					MinuteAgo =  "{0} മിനിറ്റ് മുമ്പ്",
					MinutesAgo = "{0} മിനിറ്റ് മുമ്പ്",
					HourAgo =    "{0} മണിക്കൂർ മുമ്പ്",
					HoursAgo =   "{0} മണിക്കൂര് മുമ്പ്",
					DayAgo =     "{0} ദിവസം മുമ്പ്",
					DaysAgo =    "{0} ദിവസം മുമ്പ്",
					MonthAgo =   "{0} മാസം മുമ്പ്",
					MonthsAgo =  "{0} മാസം മുമ്പ്",
					YearAgo =    "{0} വർഷം മുമ്പ്",
					YearsAgo =   "{0} വർഷങ്ങൾക്ക് മുൻപ്",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? maltese;
		public static DateTimeFormatStrings Maltese {
			get {
				return maltese ?? (maltese = new DateTimeFormatStrings {
					SecondAgo =  "{0} it-tieni ilu",
					SecondsAgo = "{0} sekondi ilu",
					MinuteAgo =  "{0} minuta ilu",
					MinutesAgo = "{0} minuti ilu",
					HourAgo =    "{0} siegħa ilu",
					HoursAgo =   "{0} sigħat ilu",
					DayAgo =     "{0} jum ilu",
					DaysAgo =    "{0} ijiem ilu",
					MonthAgo =   "{0} xahar ilu",
					MonthsAgo =  "{0} xhur ilu",
					YearAgo =    "{0} sena ilu",
					YearsAgo =   "{0} snin ilu",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? maori;
		public static DateTimeFormatStrings Maori {
			get {
				return maori ?? (maori = new DateTimeFormatStrings {
					SecondAgo =  "{0} tuarua i mua",
					SecondsAgo = "{0} hēkona i mua",
					MinuteAgo =  "{0} meneti i mua",
					MinutesAgo = "{0} meneti i mua",
					HourAgo =    "{0} haora i mua",
					HoursAgo =   "{0} haora i mua",
					DayAgo =     "{0} ra i mua",
					DaysAgo =    "{0} nga ra i mua",
					MonthAgo =   "{0} marama i mua",
					MonthsAgo =  "{0} marama ki muri",
					YearAgo =    "{0} te tau i mua",
					YearsAgo =   "{0} tau ki muri",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? marathi;
		public static DateTimeFormatStrings Marathi {
			get {
				return marathi ?? (marathi = new DateTimeFormatStrings {
					SecondAgo =  "{0} सेकंद पूर्वी",
					SecondsAgo = "{0} सेकंद पूर्वी",
					MinuteAgo =  "{0} मिनिटा पूर्वी",
					MinutesAgo = "{0} मिनिटे पूर्वी",
					HourAgo =    "{0} तास पूर्वी",
					HoursAgo =   "{0} तास पूर्वी",
					DayAgo =     "{0} दिवसा पूर्वी",
					DaysAgo =    "{0} दिवसा पूर्वी",
					MonthAgo =   "{0} महिन्या पूर्वी",
					MonthsAgo =  "{0} महिने पूर्वी",
					YearAgo =    "{0} वर्षा पूर्वी",
					YearsAgo =   "{0} वर्षे पूर्वी",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? mongolian;
		public static DateTimeFormatStrings Mongolian {
			get {
				return mongolian ?? (mongolian = new DateTimeFormatStrings {
					SecondAgo =  "{0} секундын өмнө",
					SecondsAgo = "{0} секунд өмнө",
					MinuteAgo =  "{0} минут өмнө",
					MinutesAgo = "{0} минутын өмнө",
					HourAgo =    "{0} цагийн өмнө",
					HoursAgo =   "{0} цагийн өмнө",
					DayAgo =     "{0} өдрийн өмнө",
					DaysAgo =    "{0} өдрийн өмнө",
					MonthAgo =   "{0} сарын өмнө",
					MonthsAgo =  "{0} сар өмнө",
					YearAgo =    "{0} жил өмнө",
					YearsAgo =   "{0} жилийн өмнө",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? nepali;
		public static DateTimeFormatStrings Nepali {
			get {
				return nepali ?? (nepali = new DateTimeFormatStrings {
					SecondAgo =  "{0} सेकेण्ड अघि",
					SecondsAgo = "{0} सेकेन्ड अघि",
					MinuteAgo =  "{0} मिनट अघि",
					MinutesAgo = "{0} मिनेट अघि",
					HourAgo =    "{0} घंटा अघि",
					HoursAgo =   "{0} घण्टा अघि",
					DayAgo =     "{0} दिन अघि",
					DaysAgo =    "{0} दिनों अघि",
					MonthAgo =   "{0} महीना अघि",
					MonthsAgo =  "{0} महिना अघि",
					YearAgo =    "{0} वर्ष अघि",
					YearsAgo =   "{0} वर्षसम्म अघि",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? norwegian;
		public static DateTimeFormatStrings Norwegian {
			get {
				return norwegian ?? (norwegian = new DateTimeFormatStrings {
					SecondAgo =  "{0} sekund siden",
					SecondsAgo = "{0} sekunder siden",
					MinuteAgo =  "{0} minutt siden",
					MinutesAgo = "{0} minutter siden",
					HourAgo =    "{0} time siden",
					HoursAgo =   "{0} timer siden",
					DayAgo =     "{0} dag siden",
					DaysAgo =    "{0} dager siden",
					MonthAgo =   "{0} måned siden",
					MonthsAgo =  "{0} måneder siden",
					YearAgo =    "{0} år siden",
					YearsAgo =   "{0} år siden",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? persian;
		public static DateTimeFormatStrings Persian {
			get {
				return persian ?? (persian = new DateTimeFormatStrings {
					SecondAgo =  "{0} ثانیه پیش",
					SecondsAgo = "{0} ثانیه قبل",
					MinuteAgo =  "{0} دقیقه قبل",
					MinutesAgo = "{0} دقیقه پیش",
					HourAgo =    "{0} ساعت پیش",
					HoursAgo =   "{0} ساعات پیش",
					DayAgo =     "{0} روز را پیش",
					DaysAgo =    "{0} روز پیش",
					MonthAgo =   "{0} ماه پیش",
					MonthsAgo =  "{0} ماه پیش",
					YearAgo =    "{0} سال پیش",
					YearsAgo =   "{0} سال پیش",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? polish;
		public static DateTimeFormatStrings Polish {
			get {
				return polish ?? (polish = new DateTimeFormatStrings {
					SecondAgo =  "{0} sekundę temu",
					SecondsAgo = "{0} sekund temu",
					MinuteAgo =  "{0} minut temu",
					MinutesAgo = "{0} minut temu",
					HourAgo =    "{0} godzinę temu",
					HoursAgo =   "{0} godzin temu",
					DayAgo =     "{0} dzień temu",
					DaysAgo =    "{0} dni temu",
					MonthAgo =   "{0} miesiąc temu",
					MonthsAgo =  "{0} miesięcy temu",
					YearAgo =    "{0} rok temu",
					YearsAgo =   "{0} lat temu",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? portuguese;
		public static DateTimeFormatStrings Portuguese {
			get {
				return portuguese ?? (portuguese = new DateTimeFormatStrings {
					SecondAgo =  "{0} segundo atrás",
					SecondsAgo = "{0} segondos atrás",
					MinuteAgo =  "{0} minuto atrás",
					MinutesAgo = "{0} minutos atrás",
					HourAgo =    "{0} hora atrás",
					HoursAgo =   "{0} horas atrás",
					DayAgo =     "{0} dia atrás",
					DaysAgo =    "{0} dias atrás",
					MonthAgo =   "{0} mes atrás",
					MonthsAgo =  "{0} meses atrás",
					YearAgo =    "{0} ano atrás",
					YearsAgo =   "{0} anos atrás",
				}).GetValueOrDefault();
			}
		}
		//private static DateTimeFormatStrings? punjabi;
		//public static DateTimeFormatStrings Punjabi {
		//	get {
		//		return punjabi ?? (punjabi = new DateTimeFormatStrings {
		//			SecondAgo =  "{0}",
		//			SecondsAgo = "{0}",
		//			MinuteAgo =  "{0}",
		//			MinutesAgo = "{0}",
		//			HourAgo =    "{0}",
		//			HoursAgo =   "{0}",
		//			DayAgo =     "{0}",
		//			DaysAgo =    "{0}",
		//			MonthAgo =   "{0}",
		//			MonthsAgo =  "{0}",
		//			YearAgo =    "{0}",
		//			YearsAgo =   "{0}",
		//		}).GetValueOrDefault();
		//	}
		//}
		private static DateTimeFormatStrings? romanian;
		public static DateTimeFormatStrings Romanian {
			get {
				return romanian ?? (romanian = new DateTimeFormatStrings {
					SecondAgo =  "În urmă {0} secundă",
					SecondsAgo = "În urmă {0} secunde",
					MinuteAgo =  "{0} minut în urmă",
					MinutesAgo = "{0} minute în urmă",
					HourAgo =    "{0} oră în urmă",
					HoursAgo =   "Acum {0} ore",
					DayAgo =     "{0} zi în urmă",
					DaysAgo =    "{0} zile în urmă",
					MonthAgo =   "{0} lună",
					MonthsAgo =  "{0} luni în urmă",
					YearAgo =    "{0} an în urmă",
					YearsAgo =   "{0} ani în urmă",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? russian;
		public static DateTimeFormatStrings Russian {
			get {
				return russian ?? (russian = new DateTimeFormatStrings {
					SecondAgo =  "{0} секунду назад",
					SecondsAgo = "{0} секунд назад",
					MinuteAgo =  "{0} минута назад",
					MinutesAgo = "{0} минут назад",
					HourAgo =    "{0} часовая назад",
					HoursAgo =   "{0} часов назад",
					DayAgo =     "{0} день назад",
					DaysAgo =    "{0} дней назад",
					MonthAgo =   "{0} месяц назад",
					MonthsAgo =  "{0} месяцев назад",
					YearAgo =    "{0} года назад",
					YearsAgo =   "{0} года назад",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? serbian;
		public static DateTimeFormatStrings Serbian {
			get {
				return serbian ?? (serbian = new DateTimeFormatStrings {
					SecondAgo =  "Аго {0} секунда",
					SecondsAgo = "Aro {0} секунди",
					MinuteAgo =  "Аго {0} минут",
					MinutesAgo = "Аго {0} минута",
					HourAgo =    "Аго {0} час",
					HoursAgo =   "Aro {0} сати",
					DayAgo =     "{0} дан од",
					DaysAgo =    "Пре {0} дана",
					MonthAgo =   "{0} монтх аго",
					MonthsAgo =  "Aro {0} месеци",
					YearAgo =    "{0} год назад",
					YearsAgo =   "Аго {0} година",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? slovak;
		public static DateTimeFormatStrings Slovak {
			get {
				return slovak ?? (slovak = new DateTimeFormatStrings {
					SecondAgo =  "Pred {0} sekunda",
					SecondsAgo = "Pred {0} sekúnd",
					MinuteAgo =  "Pred {0} minútou",
					MinutesAgo = "Pred {0} minútami",
					HourAgo =    "Pred {0} hodinou",
					HoursAgo =   "Pred {0} hodiny",
					DayAgo =     "Pred {0} dňom",
					DaysAgo =    "Pred {0} dňami",
					MonthAgo =   "Pred {0} mesiacom",
					MonthsAgo =  "Pred {0} mesiacmi",
					YearAgo =    "Pred {0} rokom",
					YearsAgo =   "Pred {0} rokmi",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? slovenian;
		public static DateTimeFormatStrings Slovenian {
			get {
				return slovenian ?? (slovenian = new DateTimeFormatStrings {
					SecondAgo =  "Pred {0} sekundo",
					SecondsAgo = "Pred {0} sekundami",
					MinuteAgo =  "Pred {0} minuto",
					MinutesAgo = "{0} minut nazaj",
					HourAgo =    "Pred {0} urni",
					HoursAgo =   "{0} ur nazaj",
					DayAgo =     "{0} dan nazaj",
					DaysAgo =    "{0} dni nazaj",
					MonthAgo =   "{0} mesec ago",
					MonthsAgo =  "Pred {0} meseci",
					YearAgo =    "{0} leto nazaj",
					YearsAgo =   "{0} let nazaj",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? spanish;
        [VerifiedByNativeSpeaker]
		public static DateTimeFormatStrings Spanish {
			get {
				return spanish ?? (spanish = new DateTimeFormatStrings {
					SecondAgo =  "Hace {0} segundo",
					SecondsAgo = "Hace {0} segundos",
					MinuteAgo =  "Hace {0} minuto",
					MinutesAgo = "Hace {0} minutos",
					HourAgo =    "Hace {0} hora",
					HoursAgo =   "Hace {0} horas",
					DayAgo =     "Hace {0} día",
					DaysAgo =    "Hace {0} días",
					MonthAgo =   "Hace {0} mes",
					MonthsAgo =  "Hace {0} meses",
					YearAgo =    "Hace {0} año",
					YearsAgo =   "Hace {0} años",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? swedish;
		public static DateTimeFormatStrings Swedish {
			get {
				return swedish ?? (swedish = new DateTimeFormatStrings {
					SecondAgo =  "{0} sekund sedan För",
					SecondsAgo = "{0} sekunder sedan För",
					MinuteAgo =  "{0} minut sedan",
					MinutesAgo = "{0} minuter sedan",
					HourAgo =    "{0} timme sedan För",
					HoursAgo =   "{0} timmar sedan",
					DayAgo =     "{0} dag sedan",
					DaysAgo =    "{0} dagar sedan",
					MonthAgo =   "{0} månad sedan",
					MonthsAgo =  "{0} månader sedan",
					YearAgo =    "{0} år sedan",
					YearsAgo =   "{0} år sedan",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? tajik;
		public static DateTimeFormatStrings Tajik {
			get {
				return tajik ?? (tajik = new DateTimeFormatStrings {
					SecondAgo =  "{0} сония қабл",
					SecondsAgo = "{0} сония қабл",
					MinuteAgo =  "{0} дақиқа қабл",
					MinutesAgo = "{0} дақиқа қабл",
					HourAgo =    "{0} соат қабл",
					HoursAgo =   "{0} соат дар қабл",
					DayAgo =     "{0} рӯз қабл",
					DaysAgo =    "{0} рӯз қабл",
					MonthAgo =   "{0} моҳ қабл",
					MonthsAgo =  "{0} моҳи қабл",
					YearAgo =    "{0} сол қабл",
					YearsAgo =   "{0} сол қабл",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? tamil;
		public static DateTimeFormatStrings Tamil {
			get {
				return tamil ?? (tamil = new DateTimeFormatStrings {
					SecondAgo =  "{0} இரண்டாவது முன்பு",
					SecondsAgo = "{0} வினாடிகள் முன்பு",
					MinuteAgo =  "{0} நிமிடம் முன்பு",
					MinutesAgo = "{0} நிமிடங்கள் முன்பு",
					HourAgo =    "{0} மணிநேரம் முன்பு",
					HoursAgo =   "{0} மணி நேரம் முன்பு",
					DayAgo =     "{0} நாள் முன்பு",
					DaysAgo =    "{0} நாட்கள் முன்பு",
					MonthAgo =   "{0} மாதம் முன்பு",
					MonthsAgo =  "{0} மாதங்கள் முன்பு",
					YearAgo =    "{0} வருடம் முன்பு",
					YearsAgo =   "{0} ஆண்டுகளுக்கு முன்பு",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? telugu;
		public static DateTimeFormatStrings Telugu {
			get {
				return telugu ?? (telugu = new DateTimeFormatStrings {
					SecondAgo =  "{0} రెండవ క్రితం",
					SecondsAgo = "{0} సెకన్ల క్రితం",
					MinuteAgo =  "{0} నిమిషం క్రితం",
					MinutesAgo = "{0} నిమిషాల క్రితం",
					HourAgo =    "{0} గంట క్రితం",
					HoursAgo =   "{0} గంటల క్రితం",
					DayAgo =     "{0} రోజు క్రితం",
					DaysAgo =    "{0} రోజుల క్రితం",
					MonthAgo =   "{0} నెల క్రితం",
					MonthsAgo =  "{0} నెలల క్రితం",
					YearAgo =    "{0} సంవత్సరం క్రితం",
					YearsAgo =   "{0} సంవత్సరాల క్రితం",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? thai;
		public static DateTimeFormatStrings Thai {
			get {
				return thai ?? (thai = new DateTimeFormatStrings {
					SecondAgo =  "{0} วินาทีที่ผ่านมา",
					SecondsAgo = "{0} วินาทีที่ผ่านมา",
					MinuteAgo =  "{0} นาทีที่ผ่านมา",
					MinutesAgo = "{0} นาทีที่ผ่านมา",
					HourAgo =    "{0} ชั่วโมงผ่านมา",
					HoursAgo =   "{0} ชั่วโมงที่แล้วหา",
					DayAgo =     "{0} วันก่อน",
					DaysAgo =    "{0} วันที่แล้ว",
					MonthAgo =   "{0} เดือนก่อน",
					MonthsAgo =  "{0} เดือนที่ที่ผ่านมา",
					YearAgo =    "{0} ปีที่ผ่านมา",
					YearsAgo =   "{0} ปีที่ผ่านมา",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? turkish;
		public static DateTimeFormatStrings Turkish {
			get {
				return turkish ?? (turkish = new DateTimeFormatStrings {
					SecondAgo =  "{0} saniye önce",
					SecondsAgo = "{0} saniye önce",
					MinuteAgo =  "{0} dakika önce",
					MinutesAgo = "{0} dakika önce",
					HourAgo =    "{0} saat açık önce",
					HoursAgo =   "{0} saatleri önce",
					DayAgo =     "{0} gün önce",
					DaysAgo =    "{0} günü önce",
					MonthAgo =   "{0} ay önce",
					MonthsAgo =  "{0} aylar önce",
					YearAgo =    "{0} yıl önce",
					YearsAgo =   "{0} yıl önce",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? ukrainian;
		public static DateTimeFormatStrings Ukrainian {
			get {
				return ukrainian ?? (ukrainian = new DateTimeFormatStrings {
					SecondAgo =  "{0} секунду тому",
					SecondsAgo = "{0} секунд тому",
					MinuteAgo =  "{0} хвилини тому",
					MinutesAgo = "{0} хвилини тому",
					HourAgo =    "{0}:00 тому",
					HoursAgo =   "{0}:00 тому",
					DayAgo =     "{0} день тому",
					DaysAgo =    "{0} днів тому",
					MonthAgo =   "{0} місяць тому",
					MonthsAgo =  "{0} місяців тому",
					YearAgo =    "{0} рiк назад",
					YearsAgo =   "{0} років тому",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? urdu;
		public static DateTimeFormatStrings Urdu {
			get {
				return urdu ?? (urdu = new DateTimeFormatStrings {
					SecondAgo =  "{0} سیکنڈ پہلے",
					SecondsAgo = "{0} سیکنڈ پہلے",
					MinuteAgo =  "{0} منٹ پہلے",
					MinutesAgo = "{0} منٹ پہلے",
					HourAgo =    "{0} گھنٹے پہلے",
					HoursAgo =   "{0} گھنٹے پہلے",
					DayAgo =     "{0} دن پہلے",
					DaysAgo =    "{0} دن پہلے",
					MonthAgo =   "{0} مہینہ پہلے",
					MonthsAgo =  "{0} ماہ پہلے",
					YearAgo =    "{0} سال پہلے",
					YearsAgo =   "{0} سال پہلے",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? uzbek;
		public static DateTimeFormatStrings Uzbek {
			get {
				return uzbek ?? (uzbek = new DateTimeFormatStrings {
					SecondAgo =  "{0} soniya oldin",
					SecondsAgo = "{0} soniya oldin",
					MinuteAgo =  "{0} daqiqa oldin",
					MinutesAgo = "{0} daqiqa oldin",
					HourAgo =    "{0} soat oldin",
					HoursAgo =   "{0} soat avval",
					DayAgo =     "{0} kun oldin",
					DaysAgo =    "{0} kun oldin",
					MonthAgo =   "{0} oy oldin",
					MonthsAgo =  "{0} oy oldin",
					YearAgo =    "{0} yil oldin",
					YearsAgo =   "{0} yil oldin",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? vietnamese;
		public static DateTimeFormatStrings Vietnamese {
			get {
				return vietnamese ?? (vietnamese = new DateTimeFormatStrings {
					SecondAgo =  "{0} giây trước",
					SecondsAgo = "{0} giây",
					MinuteAgo =  "{0} phút trước",
					MinutesAgo = "{0} phút trước",
					HourAgo =    "{0} giờ trước",
					HoursAgo =   "{0} giờ trước",
					DayAgo =     "{0} ngày trước",
					DaysAgo =    "{0} ngày cách đây",
					MonthAgo =   "{0} tháng trước",
					MonthsAgo =  "{0} vài tháng trước",
					YearAgo =    "{0} năm trước",
					YearsAgo =   "{0} năm trước",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? welsh;
		public static DateTimeFormatStrings Welsh {
			get {
				return welsh ?? (welsh = new DateTimeFormatStrings {
					SecondAgo =  "{0} ail yn ôl",
					SecondsAgo = "{0} eiliad yn ôl",
					MinuteAgo =  "{0} munud yn ôl",
					MinutesAgo = "{0} munud yn ôl",
					HourAgo =    "{0} awr yn ôl",
					HoursAgo =   "{0} awr yn ôl",
					DayAgo =     "{0} diwrnod yn ôl",
					DaysAgo =    "{0} diwrnod yn ôl",
					MonthAgo =   "{0} mis yn ôl",
					MonthsAgo =  "{0} mis yn ôl",
					YearAgo =    "{0} flwyddyn yn ôl",
					YearsAgo =   "{0} mlynedd yn ôl",
				}).GetValueOrDefault();
			}
		}
		private static DateTimeFormatStrings? yoruba;
		public static DateTimeFormatStrings Yoruba {
			get {
				return yoruba ?? (yoruba = new DateTimeFormatStrings {
					SecondAgo =  "{0} keji seyin",
					SecondsAgo = "{0} aaya seyin",
					MinuteAgo =  "{0} iseju seyin",
					MinutesAgo = "{0} iṣẹju seyin",
					HourAgo =    "{0} wakati seyin",
					HoursAgo =   "{0} wakati seyin",
					DayAgo =     "{0} ijọ seyin",
					DaysAgo =    "{0} ijọ seyin",
					MonthAgo =   "{0} osù seyin",
					MonthsAgo =  "{0} osu seyin",
					YearAgo =    "{0} odun kan seyin",
					YearsAgo =   "{0} odun seyin",
				}).GetValueOrDefault();
			}
		}
	}
}