using UnrealBuildTool;
using System.IO;

public class StevesUEHelpers : ModuleRules
{
	public StevesUEHelpers(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(
            new string[] {
            }
            );


        PrivateIncludePaths.AddRange(
            new string[] {
            }
            );

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"InputCore",
				"EnhancedInput",
				"Slate",
				"SlateCore",
				"UMG",
				"Paper2D",
				"Settings"
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"RenderCore"
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
			}
			);
	}
}
