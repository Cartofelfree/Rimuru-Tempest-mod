using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slime.Items.Armor.Helmet
{
    [AutoloadEquip(EquipType.Head)]
    public class RimuruHair : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Rimuru hair");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 1;
            item.rare = 4;
            item.defense = 16;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Slime:RimuruGel", 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}