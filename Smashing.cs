using Terraria.ID;
using Terraria.ModLoader;

namespace Smashing
{
	public class Smashing : Mod
	{
		public Smashing()
		{
		}

        public override void AddRecipes()
        {
            RecipeHelper.CreateRecipes(this);
        }
    }
}