using Terraria.ID;
using Terraria.ModLoader;

namespace Slime.Items.Materials
{
	public class RimuruGelShy : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Rimuru's shy gel");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
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