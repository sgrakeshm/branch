using Branch.Apps.ServiceHalo4.Models.Waypoint.Common;

namespace Branch.Apps.ServiceHalo4.Models.Waypoint.ServiceRecord
{
	public class CampaignMode : GameMode
	{
		public DifficultyLevel[] DifficultyLevels { get; set; }

		public Mission[] SinglePlayerMissions { get; set; }

		public Mission[] CoopMissions { get; set; }

		public int TotalTerminalsVisited { get; set; }

		public long NarrativeFlags { get; set; }

		public int? SinglePlayerDaso { get; set; }

		public int? SinglePlayerDifficulty { get; set; }

		public int? CoopDaso { get; set; }

		public int? CoopDifficulty { get; set; }
	}
}
