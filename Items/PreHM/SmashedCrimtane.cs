using Terraria.ID;
using Terraria.ModLoader;

namespace Smashing.Items.PreHM
{
	public class SmashedCrimtane : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Smashed Crimtane");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 16;
			item.useTime = 20;
			item.value = 25;
			item.rare = 1;
            item.maxStack = 999;
        }
	}
}