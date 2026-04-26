using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Content.Tools;

/// <summary>
///     Provides a practical example of an axe.
/// </summary>
public class ExampleAxe : ModItem
{
    public override void SetDefaults()
    {
        Item.DamageType = DamageClass.Melee;
                
        Item.damage = 10;
        Item.knockBack = 1f;

        // Indicates melee speed modifiers will only affect the rate at which the item swings as a weapon, but wont increase its mining speed.
        Item.attackSpeedOnlyAffectsWeaponAnimation = true;
        
        Item.autoReuse = true;
        
        // Indicates the item's swing direction will change accordingly to the player's direction.
        Item.useTurn = true;
        
        // Matches the dimensions of the item's texture.
        Item.width = 16;
        Item.height = 16;
        
        // Indicates the power of the axe. This value is multiplied by 5, so setting Item.axe to 10 actually makes it have 50% hammer power.
        Item.axe = 10;

        Item.UseSound = SoundID.Item1;

        // Indicates the item takes 10 frames to be used.
        Item.useTime = 10;
        
        // Indicates the animation of the item lasts 15 frames.
        Item.useAnimation = 15;

        Item.useStyle = ItemUseStyleID.Swing;
    }
}