namespace SmartKeys.Models
{
    public class KeyVault
    {
        public string VaultName { get; set; } = string.Empty;
        public List<DefaultEntry> Entrys { get; set; } = new List<DefaultEntry>();
    }
}
