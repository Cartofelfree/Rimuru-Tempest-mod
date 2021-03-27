using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slime.Items.Accessories
{
	[AutoloadEquip(EquipType.Front)]
	public class RimuruMask2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Mask");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 30);
			item.rare = ItemRarityID.Blue;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Slime:RimuruGel", 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
