using Terraria.ID;
using Terraria.ModLoader;

namespace Smashing.Items.HM
{
	public class SmashedMythril : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Smashed Mythril");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 16;
			item.useTime = 20;
			item.value = 25;
			item.rare = 3;
            item.maxStack = 999;
        }
	}
}