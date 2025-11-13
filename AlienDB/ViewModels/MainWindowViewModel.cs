using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using AlienDB.Models;
using ReactiveUI;

namespace AlienDB.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<MovieModel> Movies { get; } = new()
    {
        new MovieModel
        {
            Title = "Alien",
            PolishTitle = "Obcy – ósmy pasażer Nostromo",
            Year = 1979,
            Director = "Ridley Scott",
            Scenario = "Dan O’Bannon",
            Genre = "Sci-Fi / Horror",
            Duration = "117 minut",
            Rating = 8.5,
            MainCharacters = "Ellen Ripley, Dallas, Ash, Lambert, Kane",
            Ship = "USCSS Nostromo",
            Description =
                "Załoga statku handlowego Nostromo odbiera sygnał z nieznanej planety. Po lądowaniu odkrywają obcą formę życia, która zaczyna eliminować członków załogi jeden po drugim.",
            FunFuct =
                "Scena z „wyskakującym potworem” z klatki piersiowej aktora była niespodzianką dla obsady – ich reakcje są autentyczne."
        },
        new MovieModel
        {
            Title = "Aliens",
            PolishTitle = "Obcy – decydujące starcie",
            Year = 1986,
            Director = "James Cameron",
            Scenario = "James Cameron, David Giler, Walter Hill",
            Genre = "Sci-Fi / Akcja / Horror",
            Duration = "137 minut",
            Rating = 8.4,
            MainCharacters = "Ellen Ripley, Hicks, Newt, Bishop, Vasquez",
            Ship = "USS Sulaco",
            Description =
                "Ripley, jedyna ocalała z wcześniejszego ataku obcego, wraca z oddziałem kolonialnych marines na księżyc LV-426, by zbadać utratę kontaktu z kolonią. Wkrótce stają oko w oko z armią obcych.",
            FunFuct =
                "James Cameron napisał scenariusz podczas lotu do Londynu, tworząc tytuł, który jest liczbą mnogą słowa „Alien” – symbolicznie zapowiadając, że tym razem potworów będzie więcej."
        },
        new MovieModel
        {
            Title = "Alien³",
            PolishTitle = "Obcy³",
            Year = 1992,
            Director = "David Fincher",
            Scenario = "David Giler, Walter Hill, Larry Ferguson",
            Genre = "Sci-Fi / Horror",
            Duration = "114 minut",
            Rating = 6.5,
            MainCharacters = "Ellen Ripley, Dillon, Clemens, Morse, Andrews",
            Ship = "E.E.V. z USS Sulaco (katastrofa)",
            Description =
                "Po katastrofie statku Sulaco Ripley trafia na więzienną planetę Fiorina 161, gdzie wkrótce pojawia się obcy. Pozbawiona broni i wsparcia, musi walczyć o życie wśród skazańców i odkrywa, że nosi w sobie embrion królowej obcych.",
            FunFuct =
                "David Fincher zadebiutował tym filmem jako reżyser, jednak miał ograniczoną kontrolę twórczą, a produkcja była pełna konfliktów – reżyser później odciął się od tego projektu."
        },
        new MovieModel
        {
            Title = "Alien: Resurrection",
            PolishTitle = "Obcy: Przebudzenie",
            Year = 1997,
            Director = "Jean-Pierre Jeunet",
            Scenario = "Joss Whedon",
            Genre = "Sci-Fi / Horror",
            Duration = "109 minut",
            Rating = 6.2,
            MainCharacters = "Ellen Ripley (klon), Call, Johner, Christie, Dr. Gediman",
            Ship = "USM Auriga",
            Description =
                "Dwieście lat po śmierci Ripley naukowcy klonują ją, by wydobyć królową obcych z jej ciała. Klonowana Ripley zyskuje niezwykłe zdolności i wraz z grupą kosmicznych najemników musi zapobiec katastrofie, gdy obcy wydostają się na wolność.",
            FunFuct =
                "Postać androidki Call gra Winona Ryder, a film miał początkowo być początkiem nowej trylogii, która jednak nigdy nie powstała."
        },
        new MovieModel
        {
            Title = "Prometheus",
            PolishTitle = "Prometeusz",
            Year = 2012,
            Director = "Ridley Scott",
            Scenario = "Jon Spaihts, Damon Lindelof",
            Genre = "Sci-Fi / Thriller",
            Duration = "124 minuty",
            Rating = 7.0,
            MainCharacters = "Elizabeth Shaw, David, Charlie Holloway, Meredith Vickers",
            Ship = "USCSS Prometheus",
            Description =
                "Ekspedycja naukowa wyrusza na odległą planetę, by odkryć pochodzenie ludzkości. Na miejscu załoga Prometeusza odkrywa ruiny cywilizacji Inżynierów oraz coś, co nigdy nie powinno zostać obudzone.",
            FunFuct =
                "Ridley Scott planował, aby film stanowił zarówno prequel „Obcego”, jak i samodzielną opowieść o powstaniu życia i człowieka – wiele elementów łączy się z mitologią obcych w sposób pośredni."
        },
        new MovieModel
        {
            Title = "Alien: Covenant",
            PolishTitle = "Obcy: Przymierze",
            Year = 2017,
            Director = "Ridley Scott",
            Scenario = "John Logan, Dante Harper",
            Genre = "Sci-Fi / Horror",
            Duration = "122 minuty",
            Rating = 6.4,
            MainCharacters = "Daniels, David, Walter, Oram, Tennessee",
            Ship = "USCSS Covenant",
            Description =
                "Załoga statku kolonizacyjnego Covenant odkrywa nieznaną planetę, idealną do osiedlenia. Na miejscu natrafiają jednak na Davida – syntetyka ocalałego z Prometeusza – oraz nowe formy obcych stworzeń, które mogą zakończyć ludzką ekspansję w kosmosie.",
            FunFuct =
                "Film pierwotnie miał być zatytułowany „Paradise Lost”, a reżyser planował jeszcze jedną część łączącą fabułę z oryginalnym „Obcym” z 1979 roku."
        }

    };


    private MovieModel? _selectedMovie;

    public MovieModel? SelectedMovie
    {
        get => _selectedMovie;
        set => this.RaiseAndSetIfChanged(ref _selectedMovie, value);
    }
    
    
    public MovieModel TMP { get; set;  }
    
    public ReactiveCommand<Unit, Unit> ShowDetailsCommand { get; }

    public MainWindowViewModel()
    {
        var canShow = this.WhenAnyValue(x => x.SelectedMovie)
            .Select(game => game != null);
        ShowDetailsCommand = ReactiveCommand.Create(ShowDetails);
    }

    private void ShowDetails()
    {
        if (TMP != null)
        {
            /*Console.WriteLine($"Film: {SelectedMovie.Title} ({SelectedMovie.PolishTitle}), " +
                              $"rok: {SelectedMovie.Year}, " +
                              $"reżyser: {SelectedMovie.Director}, " +
                              $"scenariusz: {SelectedMovie.Scenario}, " +
                              $"gatunek: {SelectedMovie.Genre}, " +
                              $"czas trwania: {SelectedMovie.Duration}, " +
                              $"ocena: {SelectedMovie.Rating}, " +
                              $"główne postacie: {SelectedMovie.MainCharacters}, " +
                              $"statek: {SelectedMovie.Ship}. " +
                              $"Opis: {SelectedMovie.Description} " +
                              $"Ciekawostka: {SelectedMovie.FunFuct}"*/
           // );
            SelectedMovie.Year =12345;
            
        }
    }
}