using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvalionLeagacy.Items.Weapons.Hardmode
{
	public class TrueRuneBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Comebines all of the effects of every rune blade");
		}

		public override void SetDefaults()
		{
			item.damage = 233;
			item.melee = true;
			item.width = 56;
			item.height = 56;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 12;
			item.value = 27500;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CursedFlameRuneBlade");
			recipe.AddIngredient(mod, "FireRuneBlade");
			recipe.AddIngredient(mod, "FrostburnRuneBlade");
			recipe.AddIngredient(mod, "IchorRuneBlade");
			recipe.AddIngredient(mod, "LifeRuneBlade");
			recipe.AddIngredient(mod, "ShadowFlameRuneBlade");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			int healingAmt = damage/10;
			player.statLife += healingAmt;
			player.HealEffect(healingAmt, true);
			target.AddBuff(39, 360);
			target.AddBuff(24, 360);
			target.AddBuff(44, 360);
			target.AddBuff(69, 360);
			target.AddBuff(153, 360);
		}
	}
}
