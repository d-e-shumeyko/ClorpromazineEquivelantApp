using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeurolepticAppV3.MVVM.ViewModels
{
    public class MedLibraryEntry
    {
        
            public string MedicationName { get; set; }
            public string Details { get; set; }
            public string AverageDose { get; set; }
            public string AverageDoseRange { get; set; }
            public string MaxDose { get; set; }
            public string SE { get; set; }
            public string AE { get; set; }
        
    }
}
