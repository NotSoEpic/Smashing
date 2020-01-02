using Terraria.ID;
using Terraria.ModLoader;

namespace Smashing.Items.Calamity
{
	public class SmashedUelibloom : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Smashed Uelibloom");
            Tooltip.SetDefault("Just pretend its turquoise...");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 12;
			item.useTime = 20;
			item.value = 25;
            item.rare = 11;
            item.color = new Microsoft.Xna.Framework.Color(0, 243, 191);
            item.maxStack = 999;
        }
	}
}