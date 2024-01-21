using System;
using Johns_Useful_Weapons.Content.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Johns_Useful_Weapons.Content.Items
{
	public class ProjectileSpawnerSword : ModItem
	{
        Random rand = new Random();
		public override void SetDefaults()
		{
			Item.damage = 1;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 40;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 0;
			Item.value = 20000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noMelee = false;
            Item.shoot = assignRandomProjectile();
            Item.shootSpeed = 1.0f;
		}
        //use iron/lead bars and a bunch of ammunition in the recipe
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.PoisonDart, 1000);
            recipe.AddIngredient(ItemID.FrostburnArrow, 1000);
            recipe.AddIngredient(ItemID.MusketBall, 1000);
            recipe.AddIngredient(ItemID.BoneJavelin, 300);
            recipe.AddIngredient(ItemID.MolotovCocktail, 100);
            recipe.AddIngredient(ItemID.FallenStar, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

            recipe = CreateRecipe();
 			recipe.AddIngredient(ItemID.LeadBar, 10);
            recipe.AddIngredient(ItemID.PoisonDart, 1000);
            recipe.AddIngredient(ItemID.FrostburnArrow, 1000);
            recipe.AddIngredient(ItemID.MusketBall, 1000);
            recipe.AddIngredient(ItemID.BoneJavelin, 300);
            recipe.AddIngredient(ItemID.MolotovCocktail, 100);
            recipe.AddIngredient(ItemID.FallenStar, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}

        //Changes the weapon's projectile to a new one every time it hits a target
		public int assignRandomProjectile() {
            return rand.Next(1, 1021);
        } 

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) 
		{
			SetDefaults();
			
		}
	}
}