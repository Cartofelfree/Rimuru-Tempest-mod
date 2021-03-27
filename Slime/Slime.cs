using Terraria;
using Slime.Items.Materials;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Slime

{
	public class Slime : Mod
	{
		public Slime()
		{
		 }

		

		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " RimuruGel", new int[]
			{
				ItemType("RimuruGel"),
				ItemType("RimuruGelShy")
			});
			RecipeGroup.RegisterGroup("Slime:RimuruGel", group);
		}

		public override void AddRecipes()
		{
			

		
		}
	}
}