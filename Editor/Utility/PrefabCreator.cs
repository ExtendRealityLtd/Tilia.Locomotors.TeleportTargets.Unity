namespace Tilia.Locomotors.TeleportTargets.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Locomotors/TeleportTargets/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.locomotors.teleporttargets.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabTeleportTargetsArea = "Locomotors.TeleportTargets.Area";
        private const string prefabTeleportTargetsPoint = "Locomotors.TeleportTargets.Point";

        [MenuItem(menuItemRoot + prefabTeleportTargetsArea, false, priority)]
        private static void AddTeleportTargetsArea()
        {
            string prefab = prefabTeleportTargetsArea + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabTeleportTargetsPoint, false, priority)]
        private static void AddTeleportTargetsPoint()
        {
            string prefab = prefabTeleportTargetsPoint + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}