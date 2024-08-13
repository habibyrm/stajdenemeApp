namespace stajdenemeApp.Core
{
    public static class MessageBoxHelper
    {
        public static void ShowMessageBoxError(string errorMessage) 
        {
            MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowMessageBoxWarning(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
