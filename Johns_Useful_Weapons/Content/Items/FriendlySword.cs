using Johns_Useful_Weapons.Content.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Johns_Useful_Weapons.Content.Items
{
	public class FriendlySword : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 1;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 80;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 0;
			Item.value = 20000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noMelee = false;
		}
		//use iron/lead bars and some plants to the recipe
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.Daybloom, 10);
			recipe.AddIngredient(ItemID.Shiverthorn, 10);
			recipe.AddIngredient(ItemID.Waterleaf, 10);
			recipe.AddIngredient(ItemID.Blinkroot, 10);
			recipe.AddIngredient(ItemID.Moonglow, 10);
			recipe.AddIngredient(ItemID.SkyBlueFlower, 2);
			recipe.AddIngredient(ItemID.YellowMarigold, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.LeadBar, 10);
			recipe.AddIngredient(ItemID.Daybloom, 10);
			recipe.AddIngredient(ItemID.Shiverthorn, 10);
			recipe.AddIngredient(ItemID.Waterleaf, 10);
			recipe.AddIngredient(ItemID.Blinkroot, 10);
			recipe.AddIngredient(ItemID.Moonglow, 10);
			recipe.AddIngredient(ItemID.SkyBlueFlower, 2);
			recipe.AddIngredient(ItemID.YellowMarigold, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}

	 	//infict a debuff to an enemy that makes it friendly
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) 
		{
			target.AddBuff(ModContent.BuffType<FriendlyDebuff>(), 1);
			
		}
	}
}