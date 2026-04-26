using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Content.Swords;

/// <summary>
///     Provides a practical example of a sword.
/// </summary>
public class ExampleSword : ModItem
{
    public override void SetDefaults()
    {
        Item.DamageType = DamageClass.Melee;
        
        Item.damage = 10;
        Item.knockBack = 1f;

        Item.autoReuse = true;

        // Matches the dimensions of the item's texture.
        Item.width = 16;
        Item.height = 16;
        
        Item.UseSound = SoundID.Item1;

        // Indicates the item takes 20 frames to be used.
        Item.useTime = 20;
        
        // Indicates the animation of the item lasts 20 frames.
        Item.useAnimation = 20;

        Item.useStyle = ItemUseStyleID.Swing;
    }
}