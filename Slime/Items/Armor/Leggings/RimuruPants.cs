using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Slime.Items.Armor.Leggings
{
	[AutoloadEquip(EquipType.Legs)]
	public class RimuruPants : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Rimurus pants"
				+ "\n5% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 100;
			item.rare = ItemRarityID.Green;
			item.defense = 15;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.06f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Slime:RimuruGel", 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}