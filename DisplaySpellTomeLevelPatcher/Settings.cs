using Mutagen.Bethesda.Synthesis.Settings;
using System.Collections.Generic;

namespace DisplaySpellTomeLevelPatcher
{
    public class Settings
    {
        [SynthesisTooltip(@"Specify your own format here! Available variables: <level> (ex. Adept), <spell> (ex. Clairvoyance), <plugin> (ex. ForgottenMagic_Redone), <mod> (name of the mod instead of the plugin name, ex. Forgotten Magic Redone), <school> (ex. Alteration). Default: Spell Tome (<level>): <spell>")]
        public string Format { get; set; } = "Spell Tome (<level>): <spell>";

        [SynthesisTooltip(@"Specify your own format for mod names (<mod>) here! When a plugin name wasn't found here, the patcher will try and automatically convert the plugin name to the mod name - results may vary.")]
        public Dictionary<string, string> PluginModNamePairs { get; set; } = new()
        {
            { "Skyrim.esm", "Skyrim" },
            { "Dawnguard.esm", "Dawnguard" },
            { "Dragonborn.esm", "Dragonborn" },
            { "HearthFires.esm", "HearthFires" },
			{"ccbgssse014-spellpack01.esl": "Arcane Accessories" },
			{"ccbgssse025-advdsgs.esm": "Saints & Seducers" },
			{"ccbgssse010-petdwarvenarmoredmudcrab.esl": "Dwarven Armored Mudcrab" },
			{"ccbgssse035-petnhound.esl": "Nix-Houd" },
			{"cckrtsse001_altar.esl": "Bittercup" },
			{"ccbgssse002-exoticarrows.esl": "Arcane Archer Pack" },
			{"ccVSVSSE003-NecroArts.esl": "Necromantic Grimoire" },
			{"ccbgssse003-zombies.esl": "Plague of the Dead" },
			{"ccbgssse067-daedinv.esm": "The Cause" },
            {"Apocalypse - Magic of Skyrim.esp", "Apocalypse" },
            {"Arcanum.esp", "Arcanum" },
            {"Triumvirate - Mage Archetypes.esp", "Triumvirate" },
            {"ForgottenMagic_Redone.esp", "Forgotten Magic Redone" },
            {"Phenderix Magic Evolved.esp", "Phenderix Magic Evolved" },
            {"ShadowSpellPackage.esp", "Shadow Spell Package" },
            {"PathOfTheAntiMage.esp", "Path of the Anti-Mage" },
			{"Vulcano.esp": "Vulcano" },
			{"Necrotic.esp": "Necrotic" },
			{"Necrom.esp": "Necrom" },
			{"Arcane.esp": "Arcane" },
			{"Bloodmoon.esp": "Bloodmoon" },
			{"Inquisition.esp": "Inquisition" },
			{"Abyss.esp": "Abyss" },
			{"Stellaris.esp": "Stellaris" },
			{"Lunaris.esp": "Lunaris" },
			{"KittySpellPack01.esl": "Obscure Magic" },
			{"Natura.esp": "Natura" },
			{"MysticismMagic.esp": "Mysticism" },
			{"Desecration.esp": "Desecration" },
			{"Arclight.esp": "Arclight" },
			{"Cosmic Spells.esp": "Cosmic" },
			{"Flames of Coldharbour.esp": "Coldharbour" },
			{"Colorful_Magic_SE.esp": "Colorful" },
			{"Ghostlight.esl": "Hierophant" },
			{"WitchhunterPack.esp": "Witchhunter" },
        };

        [SynthesisTooltip(@"These are the level names that will be used for <level>. You can optionally shorten them or replace them with another name here. Default: Novice, Apprentice, Adept, Expert, Master")]
        public List<string> LevelNames { get; set; } = new() {
            "Novice",
            "Apprentice",
            "Adept",
            "Expert",
            "Master"
        };
    }
}
