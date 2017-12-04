using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Avalion.Projectiles
{
    public class EmptyDaggers : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Knife");
            Main.projFrames[projectile.type] = 1;
        }	
		public override void SetDefaults()
		{
			projectile.width = 26;
			projectile.height = 19;
			projectile.aiStyle = 1;
            projectile.alpha = 0;
			projectile.timeLeft = 40;
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
			projectile.magic = false;          
			projectile.penetrate = 1;
		}
    }
}