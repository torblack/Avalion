using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvalionLeagacy.Items.Weapons.Hardmode
{
	public class FireRuneBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Lights enemies on fire");
		}

		public override void SetDefaults()
		{
			item.damage = 57;
			item.melee = true;
			item.width = 42;
			item.height = 42;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 15500;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(2, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(24, 300);
		}
	}
}
