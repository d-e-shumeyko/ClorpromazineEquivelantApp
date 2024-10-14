using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NeurolepticAppV3.MVVM.ViewModels
{
    public class LibraryService
    {
        public LibraryService() 
        { 
        
        }

        //    List<MedLibraryEntry> EntryList = new List<MedLibraryEntry>();

        //    public async Task<List<MedLibraryEntry>> GetEntries()
        //    {
        //        if (EntryList.Count > 0)
        //        {
        //            return EntryList;
        //        }

        //        using var stream = await FileSystem.OpenAppPackageFileAsync("Library.json");
        //        using var reader = new StreamReader(stream);
        //        var contents = await reader.ReadToEndAsync();
        //        EntryList = JsonSerializer.Deserialize<List<MedLibraryEntry>>(contents); 
        //        return EntryList;
        //    }

    }
}
