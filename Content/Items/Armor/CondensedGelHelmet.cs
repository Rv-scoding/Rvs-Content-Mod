using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using RVScontentmod.Content.Items.Materials;
using RVScontentmod.Content.Players;

namespace RVScontentmod.Content.Items.Armor
{   
    [AutoloadEquip(EquipType.Head)]
    public class CondensedGelHelmet : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 18; 
			Item.height = 18; 
			Item.value = Item.sellPrice(gold: 4); 
			Item.rare = ItemRarityID.Green; 
			Item.defense = 6;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            bool bodyMatch = body.type == ModContent.ItemType<CondensedGelBreastplate>();
            bool legsMatch = legs.type == ModContent.ItemType<CondensedGelLeggings>();
            return bodyMatch && legsMatch;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Enemies are knocked back when they hit you."; 
            player.GetModPlayer<CondensedGelPlayer>().CondensedGelSetBonus = true;
            
            
        }
 
        public override void AddRecipes() 
        {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient<CondensedGel>(15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
        }
        
    }
}