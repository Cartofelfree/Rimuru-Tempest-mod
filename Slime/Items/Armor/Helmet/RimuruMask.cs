using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slime.Items.Armor.Helmet
{
    [AutoloadEquip(EquipType.Head)]
    public class RimuruMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Rimuru's mask");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 1;
            item.rare = 4;
            item.defense = 20;
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