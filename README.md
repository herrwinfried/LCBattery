<div align="center">
<img style="weight: 150px; height: 150px;" src="Battery/Thunderstore/icon.png">
</div>
<div align="center">
<h1>Battery</h1>
<p>Is your flashlight running out of battery quickly? Maybe it's time to use longer term batteries.</p>
</div>


# Development
[Dotnet](https://dotnet.microsoft.com/) 8.0.204 was used for this project. [netstandard2.1](https://learn.microsoft.com/dotnet/standard/net-standard) was used.

1. Copy the `Assembly-CSharp.dll` and `Unity.Netcode.Runtime.dll` files from "../steamapps/common/Lethal Company/Lethal Company_Data/Managed" to the "ManuelPackage/lib" folder in the Project.
2. Use the `dotnet restore` command
3. **If the project will be edited via GNU/Linux**, please make sure that the `zip` command is working.

# Credits

- [LethalCompanyTemplate](https://github.com/LethalCompanyCommunity/LethalCompanyTemplate)