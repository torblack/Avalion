using Avalion.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace Avalion.Items.Weapons
{
	public class Dagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Throws Empty Knifes at a great rate.");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.useStyle = 1;
			item.useAnimation = 20;
			item.useTime = 15;
			item.shootSpeed = 82f;
			item.knockBack = 2.5f;
			item.width = 34;
			item.height = 34;
			item.scale = 1f;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<EmptyDaggers>();
			item.value = 1000000;
			item.noMelee = true; 
			item.noUseGraphic = true; 
			item.melee = true;
			item.autoReuse = false;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            // Add Onfire buff to the NPC for 1 second
            // 60 frames = 1 second
            target.AddBuff(BuffID.Shine, 200);
        }

public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 3 + Main.rand.Next(4);
			float rotation = MathHelper.ToRadians(20);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f;
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType ("EmptyDaggers"), damage, knockBack, player.whoAmI);
			}
			return false;
		}
	}
}
