using Terraria.ID;
using Terraria.ModLoader;

namespace AvalionLeagacy.Items.Weapons.Prehardmode
{
	public class GelBlister : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Blister");
			Tooltip.SetDefault("'Seems to stick to your hand.'");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 100;
			item.rare = 2;
			item.UseSound = SoundID.Item7;
			item.autoReuse = false;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Gel, 10);
            recipe.AddIngredient(ItemID.CopperShortsword, 1);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
       
        }
    }
}