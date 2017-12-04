using Terraria.ModLoader;

namespace PlutoniumMod
{
	class PlutoniumMod : Mod
	{
		public PlutoniumMod()
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
