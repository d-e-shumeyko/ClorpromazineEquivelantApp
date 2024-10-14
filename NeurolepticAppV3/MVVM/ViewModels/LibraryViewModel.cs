﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using NeurolepticAppV3.MVVM.Views;
using CommunityToolkit.Mvvm.Input;


namespace NeurolepticAppV3.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public partial class LibraryViewModel
    {
        private MedLibraryEntry selectedEntry;

        //LibraryService libraryService;

        public ObservableCollection<MedLibraryEntry> LibraryEntries { get; set; }
        public ObservableCollection<MedLibraryEntry> CurrentLibEntry { get; set; }
        public ObservableCollection<string> TestOC { get; set; }
        public MedLibraryEntry SelectedEntry 
        { 
            get => selectedEntry;
            set
            {
                selectedEntry = value;
            }
        }
       public string LibraryName { get; set; }
        public string CurrentMedEntry { get; set; }
        public string CurrentDetail { get; set; }
        public string CurrentAD { get; set; }
        public string CurrentADR { get; set; }
        public string CurrentMR { get; set; }
        public string CurrentSE { get; set; }
        public string CurrentAE { get; set; }
        public LibraryViewModel(string libraryName)
        {
            LibraryName = LibraryName;
             LibraryEntries = new ObservableCollection<MedLibraryEntry>()
            {
                new MedLibraryEntry
                {
                    MedicationName = "Алимемазин",
                    Details = "Производное фенотиазина. Выпускается в таблетках по 5 мг, в растворе для детей. Обладает седативным и легким активизирующим действием. Показан при неразвернутых бредовых, астеноипохондрических, депрессивно-ипохондрических состояниях, используется у детей при навязчивых страхах.",
                    AverageDose = "100 мг/сут",
                    AverageDoseRange = "25-400 мг/сут",
                    MaxDose = "",
                    SE = "++",
                    AE = "+",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Амисульприд",
                    Details = "Производное бензамидов. таблетки по 100, 200 и 400 мг. Применяется при лечении психозов и неврозов. Имеет активирующее действие. Средняя суточная доза – 800 мг. По некоторым классификациям препарат относят к атипическим нейролептикам.",
                    AverageDose = "400 мг/сут",
                    AverageDoseRange = "150-800 мг/сут",
                    MaxDose = "",
                    SE = "-",
                    AE = "+++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Арипипразол",
                    Details = "Арипипразол действует как функциональный антагонист в условиях дофаминергической гиперактивности и как функциональный агонист при дофаминергической гипоактивности. Для него характерен минимальный риск экстрапирамидных побочных эффектов, гиперпролактинемии, отсутствие риска удлинения интервала QT, минимальный риск повышения веса и седации.",
                    AverageDose = "15  мг/сут",
                    AverageDoseRange = "10-30 мг/сут",
                    MaxDose = "",
                    SE = "-",
                    AE = "++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Азенапин",
                    Details = "Атипичное антипсихотическое средство.",
                    AverageDose = "15 мг/сут",
                    AverageDoseRange = "10-20 мг/сут",
                    MaxDose = "",
                    SE = "+",
                    AE = "++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Хлорпромазин",
                    Details = "Производное фенотиазина. Выпускают в ампулах 2,5% – 2 мл (25 мг вещества в 1 мл), в драже по 25, 50, 100 мг, в свечах, каплях, в виде суспензии. Препарат, вводимый в инъекциях, примерно в два с лишним раза действеннее препарата, принимаемого внутрь. Это необходимо учитывать при переводе больного с инъекционного введения на прием внутрь. Хлорпромазин обладает большой антипсихотической активностью и показан при выраженном психомоторном возбуждении, аффективной напряженности, тревоге, страхе, галлюцинаторно-бредовой симптоматике.",
                    AverageDose = "300 мг/сут",
                    AverageDoseRange = "100-800 мг/сут",
                    MaxDose = "",
                    SE = "++++",
                    AE = "+++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Хлорпротиксен",
                    Details = "Производное тиоксантена. Таблетки по 15, 25 и 50 мг. По психотропным свойствам сходен с левомепромазином, обладает выраженным седативным действием, снотворным эффектом. Показан при психомоторном возбуждении, тревожных и тревожно-депрессивных состояниях.",
                    AverageDose = "150 мг/сут",
                    AverageDoseRange = "30-500 мг/сут",
                    MaxDose = "",
                    SE = "+++",
                    AE = "++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Клозапин",
                    Details = "Атипичное антипсихотическое средство. Таблетки по 25 и 100 мг. Нейролептик седативного действия, имеет широкий спектр действия, по структуре близок к атипичным нейролептикам нового поколения. Показан при различных видах психомоторного возбуждения, галлюцинаторно-бредовых состояниях, нейролептический синдром обычно не выражен. Применяется при резистентных состояниях. Высок риск агранулоцитоза, поэтому при его применении необходимо регулярно контролировать показатели крови.",
                    AverageDose = "150 мг/сут",
                    AverageDoseRange = "50-800 мг/сут",
                    MaxDose = "",
                    SE = "++++",
                    AE = "+++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Дроперидол",
                    Details = "Производное бутирофенона.",
                    AverageDose = "6 мг/сут",
                    AverageDoseRange = "2-40 мг/сут",
                    MaxDose = "",
                    SE = "++",
                    AE = "++++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Флупентиксол",
                    Details = "Производное тиоксантена. Таблетки по 0,5, 1 и 5 мг. Обладает активирующим, анксиолитическим и антидепрессивным действием. В дозе менее 3 мг применяется для лечения депрессий легкой и средней степени с тревогой, астенией и отсутствием инициативы, при психосоматических заболеваниях. В дозе 3 мг и более назначается для лечения психозов с преобладанием галлюцинаций, бреда, апатией. Существует пролонгированная форма флюанксол-деканоат.",
                    AverageDose = "12 мг/сут",
                    AverageDoseRange = "3-18 мг/сут",
                    MaxDose = "40 мг/сут",
                    SE = "+",
                    AE = "++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Флуфеназин",
                    Details = "Пиперазиновое производное фенотиазина. Существует пролонгированая форма.",
                    AverageDose = "8 мг/сут",
                    AverageDoseRange = "2-20 мг/сут",
                    MaxDose = "",
                    SE = "+",
                    AE = "++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Галоперидол",
                    Details = "Производное бутирофенона. Выпускаются ампулы – 5 мг в 1 мл, капли – 0,1 мг в 1 капле, драже по 0,5, 1,5, 3 и 5 мг. Был первым представителем этого химического класса. Сходен по антипсихотической активности с трифтазином по силе общего и направленного действия. Избирательное антипсихотическое влияние направлено на галлюцинации и бред. Препарат, так же, как и пиперазиновые фенотиазины, способен быстро обрывать психоз. Галоперидол может вызывать выраженный нейролептический синдром. Начальная доза – 1,5 мг.",
                    AverageDose = "15 мг/сут",
                    AverageDoseRange = "4-45 мг/сут",
                    MaxDose = "",
                    SE = "++",
                    AE = "++++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Левомепрозин",
                    Details = "Производное фенотиазина. Выпускается в ампулах (25 мг вещества в 1 мл) и в драже по 25 мг. Имеет довольно широкий спектр действия – обладает сильным антипсихотическим действием, выраженным седативным, даже в небольших дозах оказывает снотворный эффект (6,5–12,5 мг). Средняя суточная доза – 100–150 мг.",
                    AverageDose = "200 мг/сут",
                    AverageDoseRange = "100-500 мг/сут",
                    MaxDose = "",
                    SE = "++++",
                    AE = "+",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Оланзапин",
                    Details = "Таблетки по 2,5; 5; 7,5; 10 мг, инъекции – 10 мг в 1 мл. Обладает выраженным анксиолитическим и антипсихотическим действием, сравнимым с галоперидолом. Препарат хорошо зарекомендовал себя в связи с положительным действием на аффективные (как маниакальные, так и депрессивные) нарушения. Основным побочным свойством препарата является прибавка в весе, он способен индуцировать метаболические нарушения, приводящие к возникновению ожирения.",
                    AverageDose = "10 мг/сут",
                    AverageDoseRange = "5-20 мг/сут",
                    MaxDose = "",
                    SE = "++",
                    AE = "+++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Палиперидон",
                    Details = "Атипичный антипсихотический препарат. Таблетки пролонгированного действия по 3, 6, 9 и 12 мг для приема 1 раз в сутки. Является активным метаболитом рисперидона. Отсутствие печеночного метаболизма сводит к минимуму риск нежелательных лекарственных взаимодействий с препаратами, метаболизирующимися в печени. Обладает более выраженным, по сравнению с рисперидоном, седативным потенциалом. Пролонгированную форму выпускают в инъекциях 75 и 100 мг.",
                    AverageDose = "9 мг/сут",
                    AverageDoseRange = "6-12 мг/сут",
                    MaxDose = "",
                    SE = "+",
                    AE = "++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Перициазин",
                    Details = "Пиперидиновое производное фенотиазина. Выпускается в капсулах по 10 мг и в каплях по 1 мг в капле. Корректор поведения, показан при психопатических и психопатопо-добных состояниях.",
                    AverageDose = "200 мг/сут",
                    AverageDoseRange = "100-300 мг/сут",
                    MaxDose = "",
                    SE = "+++",
                    AE = "+",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Перфеназин",
                    Details = "Пиперазиновое производное фенотиазина. Выпускается в таблетках, покрытых оболочкой, по 4, 6 и 10 мг. Показан при психотических синдромах с заторможенностью и галлюцинаторно-бредовой симптоматикой. Обладает противорвотным действием.",
                    AverageDose = "36 мг/сут",
                    AverageDoseRange = "12-64 мг/сут",
                    MaxDose = "100мг/сут",
                    SE = "++",
                    AE = "++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Кветиапин",
                    Details = "Производное дибензотиазепина.Таблетки по 25; 100; 200 мг. Кветиапин принимается 2 раза в день. Имеется пролонгированная форма (сероквель пролонг), предназначенная для приема 1 раз в сутки. Обладает выраженным антипсихотическим и анксиолитическим эффектом. Практически не вызывает экстрапирамидных и антихолинергических побочных эффектов. Самыми частыми нежелательными реакциями являются седация, головокружение, сонливость, ортостатическая гипотензия, диспепсия. Помимо высокой эффективности при шизофрении также хорошо зарекомендовал себя как нормотимик.",
                    AverageDose = "400 мг/сут",
                    AverageDoseRange = "50-750мг/сут",
                    MaxDose = "800мг/сут",
                    SE = "+++",
                    AE = "+++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Рисперидон",
                    Details = "Атипичный антипсихотик, принадлежащий к химическому классу производных бензизоксазола. таблетки по 1; 2; 3; 4 мг; инъекции – 1 мг в 1 мл. Также выпускается в каплях и лингвальных таблетках по 2 мг. Имеется пролонгированная форма (в/м, 1 раз в 2 нед.). Имеет выраженное антипсихотическое действие, аналогичное таковому галоперидола. Наиболее эффективен при психотическом возбуждении за счёт присущего ему седативного эффекта. Не обладает антагонизмом к холинорецепторам. Из атипичных антипсихотиков в наибольшей мере способен вызывать нейролептическую депрессию. В большей мере, чем классические антипсихотики, повышает пролактин, чаще других препаратов этого класса вызывает экстрапирамидную симптоматику и поздние дискинезии.",
                    AverageDose = "5 мг/сут",
                    AverageDoseRange = "2-8 мг/сут",
                    MaxDose = "",
                    SE = "+",
                    AE = "+++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Сертиндол",
                    Details = "Атипичный нейролептик, производное фенилиндола. Таблетки по 4, 12, 16 и 20 мг. Принимают внутрь 1 раз/сут. Препарату свойственна умеренная антипсихотическая активность, низкий риск развития экстрапирамидных расстройств, гиперпролактинемии и антихолинергических эффектов. Сертиндол может вызывать серьезные сердечно-сосудистые осложнения, в связи с чем при терапии этим препаратом необходим регулярный контроль ЭКГ. Для сертиндола характерно отсутствие седативного эффекта, что ограничивает его применение при лечении острых состояний с психомоторным возбуждением, но становится преимуществом при применении его в длительной терапии.",
                    AverageDose = "16 мг/сут",
                    AverageDoseRange = "8-20 мг/сут",
                    MaxDose = "",
                    SE = "-",
                    AE = "++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Сульпирид",
                    Details = "Производное бензамидов. таблетки по 200 мг, капсулы по 50 мг, ампулы по 2 мл – 100 мг. Сульпирид лишь с оговоркой можно отнести к нейролептическим препаратам. Сочетает свойства легких нейролептиков и антидепрессантов, применяется при состояниях с вялостью, заторможенностью, ипохондрическими расстройствами. Средняя суточная доза – 200–300 мг. Применяется в гастроэнтерологии в комплексном лечении язвенной болезни.",
                    AverageDose = "250 мг/сут",
                    AverageDoseRange = "200-600 мг/сут",
                    MaxDose = "1200 мг/сут",
                    SE = "-",
                    AE = "+",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Тиоридазин",
                    Details = "Выпускается в таблетках по 10, 25 мг. Обнаруживает сочетание легкого нейролептического и антидепрессивного эффекта. Показан при тревоге, страхах, ипохондрических расстройствах, навязчивостях.",
                    AverageDose = "300 мг/сут",
                    AverageDoseRange = "200-600 мг/сут",
                    MaxDose = "",
                    SE = "++",
                    AE = "+",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Тиаприд",
                    Details = "Производное бензамидов. Выпускается в таблетках по 100 мг, а также в ампулах по 2 мл – 100 мг. Показал хорошие результаты при лечении абстинентных синдромов, поскольку хорошо купирует вегетативные и болевые симптомы, а также психопатоподобное поведение.",
                    AverageDose = "300 мг/сут",
                    AverageDoseRange = "200-600 мг/сут",
                    MaxDose = "",
                    SE = "++",
                    AE = "+",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Трифлуоперазин",
                    Details = "Пиперазиновое производное фенотиазина. Выпускается в ампулах, драже по 1, 5 и 10 мг. Обладает антипсихотическим и легким активирующим действием. Широко используется для лечения бредовых и галлюцинаторно-бредовых состояний. Экстрапирамидные побочные явления вызываются часто и достаточно выражены.",
                    AverageDose = "20 мг/сут",
                    AverageDoseRange = "10-60 мг/сут",
                    MaxDose = "",
                    SE = "++",
                    AE = "+++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Зипрасидон",
                    Details = "Капсулы по 40, 60, 80 мг. Лиофильный порошок 30 мг для приготовления раствора для внутримышечных инъекций. Имеет хорошую переносимость, вызывает удлинение QT на ЭКГ (осторожно применять при ИБС), редко вызывает экстрапирамидную симптоматику, повышение массы тела и метаболические нарушения. Также показал свою эффективность как нормотимик, однако у пациентов, страдающих депрессией, его прием может вызывать инверсию аффекта (развитие мании или гипомании).",
                    AverageDose = "120 мг/сут",
                    AverageDoseRange = "40-160 мг/сут",
                    MaxDose = "",
                    SE = "++",
                    AE = "++",
                },
                new MedLibraryEntry
                {
                    MedicationName = "Зуклопентиксол",
                    Details = "Производное тиоксантена.Существуют пролонгированные формы. Препарат эффективен при бредовых и галлюцинаторных расстройствах, психомоторном возбуждении, при выраженных обсессивно-фобических расстройствах.",
                    AverageDose = "75 мг/сут",
                    AverageDoseRange = "25-150 мг/сут",
                    MaxDose = "",
                    SE = "+++",
                    AE = "+++",
                }
            };
            
        }

        //[RelayCommand]
        //Task Navigate() => Shell.Current.GoToAsync(nameof(DetailPage));

        public ICommand EntryChangedCommand() =>        
            new Command(() => 
            {

                var selectedEntry = SelectedEntry;
                //GetEntry();


            });


        public void GetEntry()
        {
            EntryChangedCommand();
            CurrentLibEntry = new ObservableCollection<MedLibraryEntry>() { SelectedEntry };

            CurrentMedEntry = SelectedEntry.MedicationName;
            CurrentDetail = SelectedEntry.Details;
            CurrentAD = SelectedEntry.AverageDose;
            CurrentADR = SelectedEntry.AverageDoseRange;
            CurrentMR = SelectedEntry.MaxDose;
            CurrentSE = SelectedEntry.SE;
            CurrentAE = selectedEntry.AE;


        }
       
        //public LibraryViewModel(LibraryService libraryService)
        //{
        //    this.libraryService = libraryService;
        //    GetEntriesCommand = new Command(async () => await GetEntriesAsync());
        //    LibraryEntries = new ObservableCollection<MedLibraryEntry>();
        //}
        //public ObservableCollection<MedLibraryEntry> LibraryEntries { get; } = new ObservableCollection<MedLibraryEntry>();
        //public Command GetEntriesCommand { get; }

        //async Task GetEntriesAsync()
        //{
        //    try
        //    {
        //        var entries = await libraryService.GetEntries();

        //        if (LibraryEntries.Count != 0)
        //        {
        //            LibraryEntries.Clear();
        //        }
        //        foreach (var entry in entries)
        //        {
        //            LibraryEntries.Add(entry);

        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //        await Shell.Current.DisplayAlert("Error", "Something went wrong", "OK");
        //    }
        //    finally
        //    {

        //    }



        //}


    }
}

