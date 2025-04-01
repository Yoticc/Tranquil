namespace Tranquil.Schema;

public enum ECraftworksAuditAction
{
    k_eInvalid = 0,
    k_eRecipeCrafted = 1,
    k_eMatchRewards = 2,
    k_eMatchRewardsTurbo = 3,
}
public record CMsgCraftworksComponents(List<CMsgCraftworksComponents.ComponentQuantitiesEntry> component_quantities) : DotaPacket
{
    public record ComponentQuantitiesEntry(uint key, uint value);
}
public record CMsgCraftworksQuestReward(uint quest_id, CMsgCraftworksComponents reward_components, uint stat_value) : DotaPacket;
