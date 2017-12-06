using Avalion.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvalionLeagacy.Items.Weapons.Prehardmode
{
	public class Frostbite : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Inflicts Frostburn on hit");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 250;
			item.shootSpeed = 100f;
			item.knockBack = 2.5f;
			item.damage = 20;
			item.rare = 5;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 1);
			item.shoot = mod.ProjectileType<Frost>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Pykrete", 10);
            recipe.AddIngredient(ItemID.IceBlock, 8);
            recipe.AddIngredient(ItemID.WoodYoyo);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
