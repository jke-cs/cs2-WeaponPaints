using CounterStrikeSharp.API.Core;
using System.Text.Json.Serialization;

namespace WeaponPaints
{
	public class Additional
	{
		[JsonPropertyName("KnifeEnabled")]
		public bool KnifeEnabled { get; set; } = true;

		[JsonPropertyName("GloveEnabled")]
		public bool GloveEnabled { get; set; } = true;

		[JsonPropertyName("MusicEnabled")]
		public bool MusicEnabled { get; set; } = true;

		[JsonPropertyName("AgentEnabled")]
		public bool AgentEnabled { get; set; } = true;

		[JsonPropertyName("SkinEnabled")]
		public bool SkinEnabled { get; set; } = true;

		[JsonPropertyName("CommandWpEnabled")]
		public bool CommandWpEnabled { get; set; } = true;

		[JsonPropertyName("CommandKillEnabled")]
		public bool CommandKillEnabled { get; set; } = true;

		[JsonPropertyName("CommandKnife")]
		public string CommandKnife { get; set; } = "knife";

		[JsonPropertyName("CommandMusic")]
		public string CommandMusic { get; set; } = "music";

		[JsonPropertyName("CommandGlove")]
		public string CommandGlove { get; set; } = "gloves";

		[JsonPropertyName("CommandAgent")]
		public string CommandAgent { get; set; } = "agents";

		[JsonPropertyName("CommandSkin")]
		public string CommandSkin { get; set; } = "ws";

		[JsonPropertyName("CommandSkinSelection")]
		public string CommandSkinSelection { get; set; } = "skins";

		[JsonPropertyName("CommandRefresh")]
		public string CommandRefresh { get; set; } = "wp";

		[JsonPropertyName("CommandKill")]
		public string CommandKill { get; set; } = "kill";

		[JsonPropertyName("GiveRandomKnife")]
		public bool GiveRandomKnife { get; set; } = false;

		[JsonPropertyName("GiveRandomSkin")]
		public bool GiveRandomSkin { get; set; } = false;

		[JsonPropertyName("ShowSkinImage")]
		public bool ShowSkinImage { get; set; } = true;
	}

	public class WeaponPaintsConfig : BasePluginConfig
	{
		public override int Version { get; set; } = 6;

		[JsonPropertyName("DatabaseHost")]
		public string DatabaseHost { get; set; } = "";

		[JsonPropertyName("DatabasePort")]
		public int DatabasePort { get; set; } = 3306;

		[JsonPropertyName("DatabaseUser")]
		public string DatabaseUser { get; set; } = "";

		[JsonPropertyName("DatabasePassword")]
		public string DatabasePassword { get; set; } = "";

		[JsonPropertyName("DatabaseName")]
		public string DatabaseName { get; set; } = "";

		[JsonPropertyName("CmdRefreshCooldownSeconds")]
		public int CmdRefreshCooldownSeconds { get; set; } = 1;

		[JsonPropertyName("Prefix")]
		public string Prefix { get; set; } = "[SKINS]";

		[JsonPropertyName("Website")]
		public string Website { get; set; } = "example.com/skins";

		[JsonPropertyName("Additional")]
		public Additional Additional { get; set; } = new();
	}
}
