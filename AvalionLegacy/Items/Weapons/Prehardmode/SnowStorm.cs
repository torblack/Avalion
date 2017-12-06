using Avalion.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace AvalionLeagacy.Items.Weapons.Prehardmode
{
	public class SnowStorm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Rapidly throws ice daggers that spit into random directions at a very fast speed.");
		}

		public override void SetDefaults()
		{
			item.damage = 9;
			item.useStyle = 1;
			item.useAnimation = 20;
			item.useTime = 15;
			item.shootSpeed = 35f;
			item.knockBack = 4.5f;
			item.width = 34;
			item.height = 34;
			item.scale = 2f;
			item.rare = 5;
			item.UseSound = SoundID.Item27;
			item.shoot = mod.ProjectileType<SapphireKnifeProj>();
			item.value = 1000000;
			item.noMelee = true; 
			item.noUseGraphic = true; 
			item.melee = true;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Pykrete", 30);
            recipe.AddIngredient(ItemID.IceBlock, 40);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(3) == 0)
            {
                //Emit dusts when swing the sword
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("ICE"));
            }
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            // Add Onfire buff to the NPC for 1 second
            // 60 frames = 1 second
            target.AddBuff(BuffID.Frostburn, 210);
        }

public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 40 + Main.rand.Next(4);
			float rotation = MathHelper.ToRadians(20);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 55f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 40))) * .3f;
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType ("SapphireKnifeProj"), damage, knockBack, player.whoAmI);
			}
			return false;
		}
	}
}
