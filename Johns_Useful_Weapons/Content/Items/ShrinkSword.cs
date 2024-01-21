using Johns_Useful_Weapons.Content.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Johns_Useful_Weapons.Content.Items
{
	public class ShrinkSword : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 1;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 60;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 0;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noMelee = false;
		}
		//use iron/lead bars and some small critters in the recipe
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.Bunny, 5);
			recipe.AddIngredient(ItemID.Goldfish, 5);
			recipe.AddIngredient(ItemID.Squirrel, 5);
			recipe.AddIngredient(ItemID.Worm, 5);
			recipe.AddIngredient(ItemID.Grubby, 5);
			recipe.AddIngredient(ItemID.Firefly, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.LeadBar, 10);
			recipe.AddIngredient(ItemID.Bunny, 5);
			recipe.AddIngredient(ItemID.Goldfish, 5);
			recipe.AddIngredient(ItemID.Squirrel, 5);
			recipe.AddIngredient(ItemID.Worm, 5);
			recipe.AddIngredient(ItemID.Grubby, 5);
			recipe.AddIngredient(ItemID.Firefly, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
		
	 	//infict a debuff to an enemy that makes it smaller
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) 
		{
			target.AddBuff(ModContent.BuffType<ShrinkDebuff>(), 1);
		}
	}
}