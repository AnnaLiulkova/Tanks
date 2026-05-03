using UnityEngine;

namespace Tanks.Complete
{
    public class LevelSelector : MonoBehaviour
    {
        [Header("Рівні на сцені (Levels)")]
        public GameObject levelJungle;
        public GameObject levelDesert;
        public GameObject levelMoon;

        private static int selectedLevelIndex = 0; 

        private void Start()
        {
            ApplyLevel(selectedLevelIndex);
        }

        public void SetJungle() { selectedLevelIndex = 0; ApplyLevel(0); }
        public void SetDesert() { selectedLevelIndex = 1; ApplyLevel(1); }
        public void SetMoon()   { selectedLevelIndex = 2; ApplyLevel(2); }

        private void ApplyLevel(int index)
        {
            if (levelJungle != null) levelJungle.SetActive(false);
            if (levelDesert != null) levelDesert.SetActive(false);
            if (levelMoon != null) levelMoon.SetActive(false);

            if (index == 0 && levelJungle != null) levelJungle.SetActive(true);
            else if (index == 1 && levelDesert != null) levelDesert.SetActive(true);
            else if (index == 2 && levelMoon != null) levelMoon.SetActive(true);
        }
    }
}