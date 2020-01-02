using Terraria.ID;
using Terraria.ModLoader;

namespace Smashing.Items.HM
{
	public class SmashedChlorophyte : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Smashed Chlorophyte");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 14;
			item.useTime = 20;
			item.value = 25;
			item.rare = 7;
            item.maxStack = 999;
        }
	}
}