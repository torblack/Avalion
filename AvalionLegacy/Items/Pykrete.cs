using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace Avalion.Items
{
	public class Pykrete : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A combination of saw wood dust and ice to create a strong ice-like material.");
		}

		public override void SetDefaults()
		{
			item.width = 29;
			item.height = 23;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 2;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.IceBlock, 10);
            recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}