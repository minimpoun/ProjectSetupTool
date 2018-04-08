using UnrealBuildTool;
using System.Collections.Generic;

public class TestTarget : TargetRules
{
	public TestTarget (TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		ExtraModuleNames.Add("Test");
	}
}
