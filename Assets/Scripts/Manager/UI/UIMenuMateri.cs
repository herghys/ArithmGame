namespace Manager {
    public class UIMenuMateri : UIManagers
    {
        private void OnEnable()
        {
            UpdateUI += UIUpdated;
            UpdateTitle += SetTitle;
        }
        private void OnDisable()
        {
            UpdateUI -= UIUpdated;
            UpdateTitle -= SetTitle;
        }

        private void Start()
        {
            UpdateTitle?.Invoke("Aritmetika Sosial");
        }
    }
}