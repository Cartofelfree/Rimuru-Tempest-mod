using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slime.Items.Accessories
{
    [AutoloadEquip(EquipType.Front)]
    public class RimuruHair2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Rabotai");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.accessory = true;
            item.value = 1;
            item.rare = 4;
            item.defense = 16;
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