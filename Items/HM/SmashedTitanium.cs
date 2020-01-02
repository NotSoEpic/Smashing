using Terraria.ID;
using Terraria.ModLoader;

namespace Smashing.Items.HM
{
	public class SmashedTitanium : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Smashed Titanium");
		}

		public override void SetDefaults() 
		{
			item.width = 14;
			item.height = 12;
			item.useTime = 20;
			item.value = 25;
			item.rare = 3;
            item.maxStack = 999;
        }
	}
}