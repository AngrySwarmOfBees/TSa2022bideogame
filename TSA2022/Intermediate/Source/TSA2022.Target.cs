using UnrealBuildTool;

public class TSA2022Target : TargetRules
{
	public TSA2022Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TSA2022");
	}
}
