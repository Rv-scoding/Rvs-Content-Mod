using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tutorial.Content.Items.Weapons
{ 
	
	public class BaseballBat : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.damage = 20;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 50;
			Item.useTime = 18;
			Item.useAnimation = 18;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 1100;
			Item.value = Item.buyPrice(silver: 20);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
