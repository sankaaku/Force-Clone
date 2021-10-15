using MelonLoader;
using VRC;

[assembly: MelonInfo(typeof(ForceClone.Main), "Force Clone", "1", "kaaku")]
[assembly: MelonGame("VRChat", "VRChat")]


namespace ForceClone
{
    class Main : MelonMod
    {
        public override void OnUpdate()
        {
            try
            {
                foreach (var player in PlayerManager.prop_PlayerManager_0.field_Private_List_1_Player_0)
                {
                    if (player.prop_APIUser_0.allowAvatarCopying.Equals(false))
                    {
                        player.prop_APIUser_0.allowAvatarCopying = true;
                    }
                }
            }
            catch (System.NullReferenceException) { };
        }
    }
}