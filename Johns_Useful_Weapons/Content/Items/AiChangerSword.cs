using System;
using Johns_Useful_Weapons.Content.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Johns_Useful_Weapons.Content.Items
{
	public class AiChangerSword : ModItem
	{
        Random rand = new Random();
		public override void SetDefaults()
		{
			Item.damage = 1;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 240;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 0;
			Item.value = 20000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noMelee = false;
		}
        //use iron/lead bars and a bunch of enemy drops in the recipe
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.Lens, 5);
            recipe.AddIngredient(ItemID.FlinxFur, 5);
            recipe.AddIngredient(ItemID.Gel, 20);
            recipe.AddIngredient(ItemID.Stinger, 5);
            recipe.AddIngredient(ItemID.AntlionMandible, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LeadBar, 10);
            recipe.AddIngredient(ItemID.Lens, 5);
            recipe.AddIngredient(ItemID.FlinxFur, 5);
            recipe.AddIngredient(ItemID.Gel,20);
            recipe.AddIngredient(ItemID.Stinger,5);
            recipe.AddIngredient(ItemID.AntlionMandible,5);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}

	 	//Changes the target's ai by adding 1 to it, and cycling back to 1 if at the end. Skips over ones that cause issues
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) 
		{   
            int random = rand.Next(0, 121);
            if (random == 33 || random == 34 || random == 98 || random == 99) {
                random += 4;
            }
            else if (random == 27 || random == 28 || random == 35 || random == 46 || random == 52 || random == 78 || random == 81 || random == 98 || random == 100) {
                random += 2;
            }
            else if (random == 11 || random == 24 || random == 29 || random == 36 || random == 47 || random == 50 || random == 53 || random == 59 || random == 64 || 
            random == 70 || random == 72 || random == 79 || random == 82 || random == 88 || random == 92 || random == 99 || random == 101 || random == 104) {
                random += 1;
             }
            target.aiStyle = random;
		}
	}
}