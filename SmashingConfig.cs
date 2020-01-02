using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace Smashing
{
    public class SmashingConfigPreHM : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int CopperOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int TinOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int IronOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int LeadOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(2)]
        [Range(1, 999)]
        public int SilverOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(2)]
        [Range(1, 999)]
        public int TungstenOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(2)]
        [Range(1, 999)]
        public int GoldOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(2)]
        [Range(1, 999)]
        public int PlatinumOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int MeteoriteToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int DemoniteOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int CrimtaneOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int HellstoneOreToBar { get; set; }
    }

    public class SmashingConfigHM : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int CobaltOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int PalladiumOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int MythrilOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int OrichalcumOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(2)]
        [Range(1, 999)]
        public int AdamantiteOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(2)]
        [Range(1, 999)]
        public int TitaniumOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(3)]
        [Range(1, 999)]
        public int ChlorophyteOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(1)]
        [Range(1, 999)]
        public int LuminiteOreToBar { get; set; }
    }

    public class SmashingConfigCalamity : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [ReloadRequired]
        [DefaultValue(2)]
        [Range(1, 999)]
        public int AerialiteOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(2)]
        [Range(1, 999)]
        public int CryonicOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(2)]
        [Range(1, 999)]
        public int CharredOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(2)]
        [Range(1, 999)]
        public int PerennialOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(2)]
        [Range(1, 999)]
        public int ChaoticOreToBar { get; set; }

        [ReloadRequired]
        [DefaultValue(2)]
        [Range(1, 999)]
        public int UelibloomOreToBar { get; set; }
    }
}
