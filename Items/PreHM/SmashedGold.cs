using Terraria.ID;
using Terraria.ModLoader;

namespace Smashing.Items.PreHM
{
	public class SmashedGold : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Smashed Gold");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 16;
			item.useTime = 20;
			item.value = 25;
			item.rare = 0;
            item.maxStack = 999;
        }
	}
}