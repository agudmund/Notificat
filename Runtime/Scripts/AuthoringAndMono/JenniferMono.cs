using Unity.Mathematics;
using Unity.Entities;
using UnityEngine;

namespace Jennifer.Things
{
    public class NotificatTester : MonoBehaviour
    {
        public int testNumber;
    }

    public class JenniferBaker : Baker<NotificatTester>
    {
        public override void Bake(NotificatTester authoring)
        {
            AddComponent(new JenniferProperties
            {
                testNumber = authoring.testNumber,
            });
        }
    }
}
