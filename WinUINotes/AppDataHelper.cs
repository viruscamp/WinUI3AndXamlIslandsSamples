using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;

namespace WinUINotes
{
    public static class AppDataHelper
    {
        public static async Task<StorageFolder> LocalFolder()
        {
            try
            {
                // packaged app
                return ApplicationData.Current.LocalFolder;
            }
            catch
            {
                // unpackaged app
                string publisher = "VirusCamp";
                string product = "WinUINotes";

                string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string appDataDirectory = Path.Combine(baseDirectory, $"{publisher}.{product}");
                Directory.CreateDirectory(appDataDirectory);

                return await StorageFolder.GetFolderFromPathAsync(appDataDirectory);
            }
        }
    }
}