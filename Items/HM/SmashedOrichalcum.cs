using Terraria.ID;
using Terraria.ModLoader;

namespace Smashing.Items.HM
{
	public class SmashedOrichalcum : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Smashed Orichalcum");
		}

		public override void SetDefaults() 
		{
			item.width = 14;
			item.height = 14;
			item.useTime = 20;
			item.value = 25;
			item.rare = 3;
            item.maxStack = 999;
        }
	}
}