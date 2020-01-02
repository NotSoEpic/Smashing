using Terraria.ID;
using Terraria.ModLoader;

namespace Smashing.Items.Calamity
{
	public class SmashedCharred : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Smashed Charred");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 12;
			item.useTime = 20;
			item.value = 25;
			item.rare = 6;
            item.maxStack = 999;
        }
	}
}