using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slime.Items.Accessories
{
	[AutoloadEquip(EquipType.Neck)]
	public class RimuruScarf : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Scarf");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 20;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 30);
			item.rare = ItemRarityID.Blue;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Slime:RimuruGel", 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
