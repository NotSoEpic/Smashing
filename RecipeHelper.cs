using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Smashing
{
    class RecipeHelper
    {
        public static void CreateRecipes(Mod mod)
        {
            ModRecipe r;
            void QRecipe(short ore, int smashed, short bar, int oreAmt = 1, ushort anvil = TileID.Anvils, ushort furnace = TileID.Furnaces) {
                // ore -> smashed
                r = new ModRecipe(mod);
                r.AddIngredient(ore, oreAmt);
                r.AddTile(anvil);
                r.SetResult(smashed);
                r.AddRecipe();

                // smashed -> bar
                r = new ModRecipe(mod);
                r.AddIngredient(smashed, 1);
                r.AddTile(furnace);
                r.SetResult(bar);
                r.AddRecipe();
            }
            void MRecipe(int ore, int smashed, int bar, int oreAmt = 1, ushort anvil = TileID.Anvils, ushort furnace = TileID.Furnaces) {
                QRecipe((short)ore, smashed, (short)bar, oreAmt, anvil, furnace);
            }

            // PRE HARDMODE //
            int cfgOreAmt = GetInstance<SmashingConfigPreHM>().CopperOreToBar;
            QRecipe(ItemID.CopperOre, mod.ItemType("SmashedCopper"), ItemID.CopperBar, cfgOreAmt);
            cfgOreAmt = GetInstance<SmashingConfigPreHM>().TinOreToBar;
            QRecipe(ItemID.TinOre, mod.ItemType("SmashedTin"), ItemID.TinBar, cfgOreAmt);
            cfgOreAmt = GetInstance<SmashingConfigPreHM>().IronOreToBar;
            QRecipe(ItemID.IronOre, mod.ItemType("SmashedIron"), ItemID.IronBar, cfgOreAmt);
            cfgOreAmt = GetInstance<SmashingConfigPreHM>().LeadOreToBar;
            QRecipe(ItemID.LeadOre, mod.ItemType("SmashedLead"), ItemID.LeadBar, cfgOreAmt);
            cfgOreAmt = GetInstance<SmashingConfigPreHM>().SilverOreToBar;
            QRecipe(ItemID.SilverOre, mod.ItemType("SmashedSilver"), ItemID.SilverBar, cfgOreAmt);
            cfgOreAmt = GetInstance<SmashingConfigPreHM>().TungstenOreToBar;
            QRecipe(ItemID.TungstenOre, mod.ItemType("SmashedTungsten"), ItemID.TungstenBar, cfgOreAmt);
            cfgOreAmt = GetInstance<SmashingConfigPreHM>().GoldOreToBar;
            QRecipe(ItemID.GoldOre, mod.ItemType("SmashedGold"), ItemID.GoldBar, cfgOreAmt);
            cfgOreAmt = GetInstance<SmashingConfigPreHM>().PlatinumOreToBar;
            QRecipe(ItemID.PlatinumOre, mod.ItemType("SmashedPlatinum"), ItemID.PlatinumBar, cfgOreAmt);
            cfgOreAmt = GetInstance<SmashingConfigPreHM>().MeteoriteToBar;
            QRecipe(ItemID.Meteorite, mod.ItemType("SmashedMeteorite"), ItemID.MeteoriteBar, cfgOreAmt);
            cfgOreAmt = GetInstance<SmashingConfigPreHM>().DemoniteOreToBar;
            QRecipe(ItemID.DemoniteOre, mod.ItemType("SmashedDemonite"), ItemID.DemoniteBar, cfgOreAmt);
            cfgOreAmt = GetInstance<SmashingConfigPreHM>().CrimtaneOreToBar;
            QRecipe(ItemID.CrimtaneOre, mod.ItemType("SmashedCrimtane"), ItemID.CrimtaneBar, cfgOreAmt);

            cfgOreAmt = GetInstance<SmashingConfigPreHM>().CrimtaneOreToBar;
            r = new ModRecipe(mod);
            r.AddIngredient(ItemID.Hellstone, cfgOreAmt);
            r.AddTile(TileID.Anvils);
            r.SetResult(mod.ItemType("SmashedHellstone"));
            r.AddRecipe();

            r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("SmashedHellstone"), 1);
            r.AddIngredient(ItemID.Obsidian); // not worth making a whole new function for one thing
            r.AddTile(TileID.Hellforge);
            r.SetResult(ItemID.HellstoneBar);
            r.AddRecipe();

            // HARDMODE //
            cfgOreAmt = GetInstance<SmashingConfigHM>().CobaltOreToBar;
            QRecipe(ItemID.CobaltOre, mod.ItemType("SmashedCobalt"), ItemID.CobaltBar, cfgOreAmt, TileID.Anvils, TileID.Hellforge);
            cfgOreAmt = GetInstance<SmashingConfigHM>().PalladiumOreToBar;
            QRecipe(ItemID.PalladiumOre, mod.ItemType("SmashedPalladium"), ItemID.PalladiumBar, cfgOreAmt, TileID.Anvils, TileID.Hellforge);
            cfgOreAmt = GetInstance<SmashingConfigHM>().MythrilOreToBar;
            QRecipe(ItemID.MythrilOre, mod.ItemType("SmashedMythril"), ItemID.MythrilBar, cfgOreAmt, TileID.Anvils, TileID.Hellforge);
            cfgOreAmt = GetInstance<SmashingConfigHM>().OrichalcumOreToBar;
            QRecipe(ItemID.OrichalcumOre, mod.ItemType("SmashedOrichalcum"), ItemID.OrichalcumBar, cfgOreAmt, TileID.Anvils, TileID.Hellforge);
            cfgOreAmt = GetInstance<SmashingConfigHM>().AdamantiteOreToBar;
            QRecipe(ItemID.AdamantiteOre, mod.ItemType("SmashedAdamantite"), ItemID.AdamantiteBar, cfgOreAmt, TileID.MythrilAnvil, TileID.AdamantiteForge);
            cfgOreAmt = GetInstance<SmashingConfigHM>().TitaniumOreToBar;
            QRecipe(ItemID.TitaniumOre, mod.ItemType("SmashedTitanium"), ItemID.TitaniumBar, cfgOreAmt, TileID.MythrilAnvil, TileID.AdamantiteForge);
            cfgOreAmt = GetInstance<SmashingConfigHM>().ChlorophyteOreToBar;
            QRecipe(ItemID.ChlorophyteOre, mod.ItemType("SmashedChlorophyte"), ItemID.ChlorophyteBar, cfgOreAmt, TileID.MythrilAnvil, TileID.AdamantiteForge);
            cfgOreAmt = GetInstance<SmashingConfigHM>().LuminiteOreToBar;
            QRecipe(ItemID.LunarOre, mod.ItemType("SmashedLuminite"), ItemID.LunarBar, cfgOreAmt, TileID.LunarCraftingStation, TileID.LunarCraftingStation);

            // CALAMITY //
            Mod calamity = ModLoader.GetMod("CalamityMod");
            if (calamity != null) {
                // the calamity wiki doesnt have a list of internal item names >:(
                cfgOreAmt = GetInstance<SmashingConfigCalamity>().AerialiteOreToBar;
                MRecipe(calamity.ItemType("AerialiteOre"), mod.ItemType("SmashedAerialite"), calamity.ItemType("AerialiteBar"), 2);
                cfgOreAmt = GetInstance<SmashingConfigCalamity>().CryonicOreToBar;
                MRecipe(calamity.ItemType("CryonicOre"), mod.ItemType("SmashedCryonic"), calamity.ItemType("VerstaltiteBar"), 3, TileID.MythrilAnvil, TileID.AdamantiteForge);

                cfgOreAmt = GetInstance<SmashingConfigCalamity>().CharredOreToBar;
                r = new ModRecipe(mod);
                r.AddIngredient(calamity.ItemType("CharredOre"), 2);
                r.AddTile(TileID.MythrilAnvil);
                r.SetResult(mod.ItemType("SmashedCharred"));
                r.AddRecipe();

                r = new ModRecipe(mod);
                r.AddIngredient(mod.ItemType("SmashedCharred"), 1);
                r.AddIngredient(ItemID.Hellstone, 2);
                r.AddTile(TileID.AdamantiteForge);
                r.SetResult(calamity.ItemType("UnholyCore"));
                r.AddRecipe();

                cfgOreAmt = GetInstance<SmashingConfigCalamity>().PerennialOreToBar;
                MRecipe(calamity.ItemType("PerennialOre"), mod.ItemType("SmashedPerennial"), calamity.ItemType("DraedonBar"), 3, TileID.MythrilAnvil, TileID.AdamantiteForge);
                cfgOreAmt = GetInstance<SmashingConfigCalamity>().ChaoticOreToBar;
                MRecipe(calamity.ItemType("ChaoticOre"), mod.ItemType("SmashedChaotic"), calamity.ItemType("CruptixBar"), 3, TileID.MythrilAnvil, TileID.AdamantiteForge);
                cfgOreAmt = GetInstance<SmashingConfigCalamity>().UelibloomOreToBar;
                MRecipe(calamity.ItemType("UelibloomOre"), mod.ItemType("SmashedUelibloom"), calamity.ItemType("UeliaceBar"), 3, TileID.MythrilAnvil, TileID.AdamantiteForge);
            }
        }
    }
}
