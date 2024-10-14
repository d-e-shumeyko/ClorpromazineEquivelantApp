using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsNet;

namespace NeurolepticAppV3.MVVM.ViewModels
{
    public class Neuroleptics
    {
        //public string medication_Name { get; set; }
        //public string medication_Name_Rus { get; set; }

        //public int Index { get; set; }
        //public int Index_Rus { get; set; }
        //public float Chlorpromazin_Equivelant { get; set; }
        //public int Average_Daily_Dose { get; set; }
        //public int Daily_Dose_Min { get; set; }
        //public int Daily_Dose_Max { get; set; }
        //public int Sedative_Effect { get; set; }
        //public int Antipsychotic_Effect { get; set; }
        //public int Maximum_Dosage { get; set; }


        public static readonly IDictionary<string, float> Neuro = new Dictionary<string, float>
        {
            {"Алимемазин",   3.0f},
             { "Амисульприд", 1.0f },
            { "Арипипразол", 20.0f},
            {"Азенапин", 20.0f},
            {"Хлорпромазин", 1.0f},
            {"Хлорпротиксен", 2.0f},
            {"Клозапин", 2.0f},
            {"Дроперидол", 50.0f},
            {"Флупентиксол", 20.0f},
            {"Флуфеназин", 35.0f},
            {"Галоперидол", 20.0f},
            {"Левомепрозин", 1.5f},
            {"Оланзапин", 30.0f},
            {"Палиперидон", 33.0f},
            {"Перициазин", 1.5f},
            {"Перфеназин", 8.0f},
            {"Кветиапин", 1.0f},
            {"Рисперидон", 75.0f},
            {"Сертиндол", 20.0f},
            {"Сульпирид", 0.5f},
            {"Тиоридазин", 1.0f},
            {"Тиаприд", 1.0f},
            {"Трифлуоперазин", 15.0f},
            {"Зипрасидон", 2.5f},
            {"Зуклопентиксол", 4.0f},

        };

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        



        //info for future use
        /*
            new Neuroleptics() { Index = 1, Index_Rus = 2, medication_Name = "Alimemazine", medication_Name_Rus = "Алимемазин", Chlorpromazin_Equivelant = 3.0f, Average_Daily_Dose = 100, Daily_Dose_Min = 25, Daily_Dose_Max = 400, Sedative_Effect = 2, Antipsychotic_Effect = 1, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 2, Index_Rus = 3, medication_Name = "Amisulpride", medication_Name_Rus = "Амисульприд", Chlorpromazin_Equivelant = 1.0f, Average_Daily_Dose = 400, Daily_Dose_Min = 150, Daily_Dose_Max = 800, Sedative_Effect = 0, Antipsychotic_Effect = 3, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 3, Index_Rus = 4, medication_Name = "Aripiprazole", medication_Name_Rus = "Арипипразол", Chlorpromazin_Equivelant = 20.0f, Average_Daily_Dose = 15, Daily_Dose_Min = 10, Daily_Dose_Max = 30, Sedative_Effect = 0, Antipsychotic_Effect = 2, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 4, Index_Rus = 1, medication_Name = "Asenapine", medication_Name_Rus = "Азенапин", Chlorpromazin_Equivelant = 20.0f, Average_Daily_Dose = 15, Daily_Dose_Min = 10, Daily_Dose_Max = 20, Sedative_Effect = 1, Antipsychotic_Effect = 2, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 5, Index_Rus = 24, medication_Name = "Chlorpromazine", medication_Name_Rus = "Хлорпромазин", Chlorpromazin_Equivelant = 1.0f, Average_Daily_Dose = 300, Daily_Dose_Min = 100, Daily_Dose_Max = 800, Sedative_Effect = 4, Antipsychotic_Effect = 2, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 6, Index_Rus = 25, medication_Name = "Chlorprothixene", medication_Name_Rus = "Хлорпротиксен", Chlorpromazin_Equivelant = 2.0f, Average_Daily_Dose = 150, Daily_Dose_Min = 30, Daily_Dose_Max = 500, Sedative_Effect = 3, Antipsychotic_Effect = 2, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 7, Index_Rus = 10, medication_Name = "Clozapine", medication_Name_Rus = "Клозапин", Chlorpromazin_Equivelant = 2.0f, Average_Daily_Dose = 150, Daily_Dose_Min = 50, Daily_Dose_Max = 800, Sedative_Effect = 4, Antipsychotic_Effect = 3, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 8, Index_Rus = 6, medication_Name = "Droperidol", medication_Name_Rus = "Дроперидол", Chlorpromazin_Equivelant = 50.0f, Average_Daily_Dose = 6, Daily_Dose_Min = 2, Daily_Dose_Max = 40, Sedative_Effect = 2, Antipsychotic_Effect = 4, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 9, Index_Rus = 22, medication_Name = "Flupentixol", medication_Name_Rus = "Флупентиксол", Chlorpromazin_Equivelant = 20.0f, Average_Daily_Dose = 12, Daily_Dose_Min = 3, Daily_Dose_Max = 18, Sedative_Effect = 1, Antipsychotic_Effect = 2, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 10, Index_Rus = 23, medication_Name = "Fluphenazine", medication_Name_Rus = "Флуфеназин", Chlorpromazin_Equivelant = 35.0f, Average_Daily_Dose = 8, Daily_Dose_Min = 2, Daily_Dose_Max = 20, Sedative_Effect = 1, Antipsychotic_Effect = 2, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 11, Index_Rus = 5, medication_Name = "Haloperidol", medication_Name_Rus = "Галоперидол", Chlorpromazin_Equivelant = 20.0f, Average_Daily_Dose = 15, Daily_Dose_Min = 5, Daily_Dose_Max = 100, Sedative_Effect = 2, Antipsychotic_Effect = 4, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 12, Index_Rus = 11, medication_Name = "Levomepromazine", medication_Name_Rus = "Левомепрозин", Chlorpromazin_Equivelant = 1.5f, Average_Daily_Dose = 200, Daily_Dose_Min = 100, Daily_Dose_Max = 500, Sedative_Effect = 4, Antipsychotic_Effect = 1, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 13, Index_Rus = 12, medication_Name = "Olanzapine", medication_Name_Rus = "Оланзапин", Chlorpromazin_Equivelant = 30.0f, Average_Daily_Dose = 10, Daily_Dose_Min = 5, Daily_Dose_Max = 20, Sedative_Effect = 2, Antipsychotic_Effect = 3, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 14, Index_Rus = 13, medication_Name = "Paliperidone", medication_Name_Rus = "Палиперидон", Chlorpromazin_Equivelant = 33.0f, Average_Daily_Dose = 9, Daily_Dose_Min = 6, Daily_Dose_Max = 12, Sedative_Effect = 1, Antipsychotic_Effect = 2, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 15, Index_Rus = 14, medication_Name = "Periciazine", medication_Name_Rus = "Перициазин", Chlorpromazin_Equivelant = 1.5f, Average_Daily_Dose = 200, Daily_Dose_Min = 100, Daily_Dose_Max = 300, Sedative_Effect = 3, Antipsychotic_Effect = 1, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 16, Index_Rus = 15, medication_Name = "Perphenazine", medication_Name_Rus = "Перфеназин", Chlorpromazin_Equivelant = 8.0f, Average_Daily_Dose = 36, Daily_Dose_Min = 12, Daily_Dose_Max = 64, Sedative_Effect = 2, Antipsychotic_Effect = 2, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 17, Index_Rus = 9, medication_Name = "Quetiapine", medication_Name_Rus = "Кветиапин", Chlorpromazin_Equivelant = 1.0f, Average_Daily_Dose = 400, Daily_Dose_Min = 50, Daily_Dose_Max = 750, Sedative_Effect = 3, Antipsychotic_Effect = 3, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 18, Index_Rus = 6, medication_Name = "Risperidone", medication_Name_Rus = "Рисперидон", Chlorpromazin_Equivelant = 75.0f, Average_Daily_Dose = 5, Daily_Dose_Min = 2, Daily_Dose_Max = 8, Sedative_Effect = 1, Antipsychotic_Effect = 3, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 19, Index_Rus = 17, medication_Name = "Sertindole", medication_Name_Rus = "Сертиндол", Chlorpromazin_Equivelant = 20.0f, Average_Daily_Dose = 16, Daily_Dose_Min = 8, Daily_Dose_Max = 20, Sedative_Effect = 0, Antipsychotic_Effect = 2, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 20, Index_Rus = 18, medication_Name = "Sulpiride", medication_Name_Rus = "Сульпирид", Chlorpromazin_Equivelant = 0.5f, Average_Daily_Dose = 600, Daily_Dose_Min = 200, Daily_Dose_Max = 240, Sedative_Effect = 0, Antipsychotic_Effect = 1, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 21, Index_Rus = 20, medication_Name = "Thioridazine", medication_Name_Rus = "Тиоридазин", Chlorpromazin_Equivelant = 1.0f, Average_Daily_Dose = 300, Daily_Dose_Min = 150, Daily_Dose_Max = 800, Sedative_Effect = 3, Antipsychotic_Effect = 1, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 22, Index_Rus = 19, medication_Name = "Tiapride", medication_Name_Rus = "Тиаприд", Chlorpromazin_Equivelant = 1.0f, Average_Daily_Dose = 300, Daily_Dose_Min = 200, Daily_Dose_Max = 600, Sedative_Effect = 2, Antipsychotic_Effect = 1, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 23, Index_Rus = 21, medication_Name = "Trifluoperazine", medication_Name_Rus = "Трифлуоперазин", Chlorpromazin_Equivelant = 15.0f, Average_Daily_Dose = 20, Daily_Dose_Min = 10, Daily_Dose_Max = 60, Sedative_Effect = 2, Antipsychotic_Effect = 3, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 24, Index_Rus = 7, medication_Name = "Ziprasidone", medication_Name_Rus = "Зипрасидон", Chlorpromazin_Equivelant = 2.5f, Average_Daily_Dose = 120, Daily_Dose_Min = 40, Daily_Dose_Max = 160, Sedative_Effect = 2, Antipsychotic_Effect = 2, Maximum_Dosage = 0 };
            new Neuroleptics() { Index = 25, Index_Rus = 8, medication_Name = "Zuclopenthixol", medication_Name_Rus = "Зуклопентиксол", Chlorpromazin_Equivelant = 4.0f, Average_Daily_Dose = 75, Daily_Dose_Min = 25, Daily_Dose_Max = 150, Sedative_Effect = 3, Antipsychotic_Effect = 3, Maximum_Dosage = 0 };
        */

    }
}
