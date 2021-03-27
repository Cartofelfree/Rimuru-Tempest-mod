using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Slime.Items.Armor.Breastplate
{
	[AutoloadEquip(EquipType.Body)]
	public class RimuruCloak : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Rimuru's cloak");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.value = Item.sellPrice(silver: 24);
			item.rare = ItemRarityID.Blue;
			item.defense = 20;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Slime:RimuruGel", 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}