### Unreal Engine Empty Cpp
This small repository contains minimal files to enable C++ development within a Unreal Engine project that was setup as a pure Blueprint project.

That's all :)

Here you can see how to use the files, [#6.0 Adding C++ Support - UE5 Manny Integration - ALS Secrets](https://youtu.be/M2JOcPJ_sOs).

Code for the uproject file.
```
, 

	"Modules": [

		{

			"Name": "EmptyCpp",

			"Type": "Runtime",

			"LoadingPhase": "Default"

		}

	]
```
