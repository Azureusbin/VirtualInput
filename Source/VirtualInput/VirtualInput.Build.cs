﻿// Some copyright should be here...

using UnrealBuildTool;

public class VirtualInput : ModuleRules
{
	public VirtualInput(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				"ApplicationCore",
				"InputCore"
			}
			);
	}
}