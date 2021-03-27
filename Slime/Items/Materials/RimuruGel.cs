using Terraria.ID;
using Terraria.ModLoader;

namespace Slime.Items.Materials
{
	public class RimuruGel : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Gel from Rimuru");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 13;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
		
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 5);
			recipe.SetResult(this, 999);
			recipe.AddRecipe();
			
		}
	}
}