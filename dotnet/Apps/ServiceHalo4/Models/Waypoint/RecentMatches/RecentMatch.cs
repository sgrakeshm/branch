using System;
using System.Collections.Generic;
using Branch.Packages.Converters;
using Branch.Apps.ServiceHalo4.Models.Waypoint.Common;
using Newtonsoft.Json;

namespace Branch.Apps.ServiceHalo4.Models.Waypoint.RecentMatches
{
	[JsonConverter(
		typeof(IdToAbstractConverter<WarGamesRecentMatch, CampaignRecentMatch, SpartanOpsRecentMatch, WarGamesRecentMatch>),
		new object[] { "ModeId", new string[] { "3", "4", "5", "6" } }
	)]
	public abstract class RecentMatch
	{
		public int Standing { get; set; }

		public int[] TopMedalIds { get; set; }

		public TimeSpan Duration { get; set; }

		public int MapId { get; set; }

		public ImageUrl MapImageUrl { get; set; }

		public int PersonalScore { get; set; }

		public string Id { get; set; }

		public int ModeId { get; set; }

		public string ModeName { get; set; }

		public bool Completed { get; set; }

		public int Result { get; set; }

		public DateTime EndDateUtc { get; set; }
	}
}
