using UnityEngine;
namespace Manager {
    public class UIMenuMateri : UIManagers
    {
        [Header("UI")]
        [SerializeField] Transform spawner;

        [Header("References")]
        [SerializeField] MenuMateriScript manager;
        [SerializeField] GameObject prefab;

        protected override void Awake()
        {
            Instance = this;

            InstatiateMenu((int)manager.metode);
        }

        private void InstatiateMenu(int i)
        {
            prefab = manager.materiData[i-1].MenuMateriPrefab;
            GameObject menu = Instantiate(prefab, spawner);
        }
    }
}