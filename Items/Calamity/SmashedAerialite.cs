using Terraria.ID;
using Terraria.ModLoader;

namespace Smashing.Items.Calamity
{
	public class SmashedAerialite : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Smashed Aerialite");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 12;
			item.useTime = 20;
			item.value = 25;
			item.rare = 1;
            item.maxStack = 999;
        }
	}
}