using Terraria.ID;
using Terraria.ModLoader;

namespace Smashing.Items.HM
{
	public class SmashedLuminite : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Smashed Luminite");
            Tooltip.SetDefault("'Sand of the heavens'");
		}

		public override void SetDefaults() 
		{
			item.width = 20;
			item.height = 20;
			item.useTime = 20;
			item.value = 25;
			item.rare = 10;
            item.maxStack = 999;
        }
	}
}