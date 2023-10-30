using Terraria.ModLoader;

namespace 新
{
	public partial class 新 : Mod
	{
        internal static ModKeybind qbkey;

        public override void Load()
        {



            qbkey = KeybindLoader.RegisterKeybind(this, "谦卑", "P");

        }



        public override void Unload()
        {


            qbkey = null;

        }
    }
}