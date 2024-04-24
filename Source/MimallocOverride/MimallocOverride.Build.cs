// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class MimallocOverride : ModuleRules
{
	public MimallocOverride(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

				
		if (Target.Platform == UnrealTargetPlatform.Win64) {
			PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "lib", "Win64", "mimalloc-redirect.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "lib", "Win64", "mimalloc.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "lib", "Win64", "mimalloc-override.lib"));
			
			RuntimeDependencies.Add("$(TargetOutputDir)/mimalloc-override.dll", Path.Combine(ModuleDirectory, "lib", "Win64", "mimalloc-override.dll"));
			RuntimeDependencies.Add("$(TargetOutputDir)/mimalloc-redirect.dll", Path.Combine(ModuleDirectory, "lib", "Win64", "mimalloc-redirect.dll"));
			RuntimeDependencies.Add("$(TargetOutputDir)/mimalloc.dll", Path.Combine(ModuleDirectory, "lib", "Win64", "mimalloc.dll"));
		}
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
