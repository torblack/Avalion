using Terraria.ModLoader;

namespace AvalionLegacy
{
	class AvalionLegacy : Mod
	{
		public AvalionLegacy()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
