// Project:         UnrealEngineEmptyCpp
// Copyright:       Copyright (C) 2022 Achim Turan
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/tuatec/UnrealEngineEmptyCpp
// Original Author: Achim Turan

using UnrealBuildTool;
using System.Collections.Generic;

public class EmptyCppTarget : TargetRules
{
	public EmptyCppTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "EmptyCpp" } );
	}
}
