using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace WinUINotes.Models
{
    public class Note
    {
        public string Filename { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;

        public Note()
        {
            Filename = "notes" + DateTime.Now.ToBinary().ToString() + ".txt";
        }

        public async Task SaveAsync()
        {
            var storageFolder = await AppDataHelper.LocalFolder();
            // Save the note to a file.
            StorageFile noteFile = (StorageFile)await storageFolder.TryGetItemAsync(Filename);
            if (noteFile is null)
            {
                noteFile = await storageFolder.CreateFileAsync(Filename, CreationCollisionOption.ReplaceExisting);
            }
            await FileIO.WriteTextAsync(noteFile, Text);
        }

        public async Task DeleteAsync()
        {
            var storageFolder = await AppDataHelper.LocalFolder();
            // Delete the note from the file system.
            StorageFile noteFile = (StorageFile)await storageFolder.TryGetItemAsync(Filename);
            if (noteFile is not null)
            {
                await noteFile.DeleteAsync();
            }
        }
    }
}
