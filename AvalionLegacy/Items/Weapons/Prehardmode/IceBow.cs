using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvalionLeagacy.Items.Weapons.Prehardmode
{
    public class IceBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Absurd Speed.");    //The (English) text shown below your weapon's name
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 24;
            item.damage = 10;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5; // Bow Use Style
            item.noMelee = true; // Doesn't deal damage if an enemy touches at melee range.
            item.value = Item.buyPrice(0, 0, 10, 0); // Another way to handle value of item.
            item.rare = 4;
            item.UseSound = SoundID.Item27; // Sound for Bows
            item.useAmmo = AmmoID.Arrow; // The ammo used with this weapon
            item.shoot = 100;
            item.shootSpeed = 600f;
            item.ranged = true; // For Ranged Weapon
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Pykrete", 9);
            recipe.AddIngredient(ItemID.IceBlock, 8);
            recipe.AddIngredient(ItemID.WoodenBow, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}