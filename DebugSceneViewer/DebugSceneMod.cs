using KHMI;
using KHMI.Types;

namespace DebugSceneViewer
{
    public class DebugSceneMod : KHMod
    {
        public DebugSceneMod(ModInterface mi) : base(mi)
        {
            for(int i = 0; i <= 16; i++)
            {
                World currentWorld = new World(modInterface.dataInterface, i);
                Room[] currentRooms = currentWorld.Rooms;
                foreach(Room room in currentRooms)
                {
                    room.SceneID = 25;
                }
            }
        }
    }
}
