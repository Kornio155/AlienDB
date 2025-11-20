using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using AlienDB.Models;
using ReactiveUI;

namespace AlienDB.ViewModels;

public class CharacterWindowViewModel : ViewModelBase
{
    public ObservableCollection<CharacterModel> Characters { get; } = new()
    {
        new CharacterModel
        {
            Name = "Ellen Louise Ripley",
            Film = "Alien (1979), Aliens (1986), Alien³ (1992), Alien: Resurrection (1997)",
            Role = "Oficer porządkowy, specjalistka ds. bezpieczeństwa",
            Actor = "Sigourney Weaver",
            Race = "Człowiek",
            BirthYear = 2092,
            FunctionCrew = "Odpowiada za bezpieczeństwo załogi oraz przestrzeganie protokołów misji handlowych.",
            Profile = "Zdeterminowana, inteligentna, odporna psychicznie. Symbol siły i walki człowieka z nieznanym.",
            Fate = "Ginęła w Alien³, później sklonowana w Alien: Resurrection.",
            FunFact = "Sigourney Weaver była nominowana do Oscara za rolę w filmie 'Aliens'."
        },

        new CharacterModel
        {
            Name = "Arthur Koblenz Dallas",
            Film = "Alien (1979)",
            Role = "Kapitan statku Nostromo",
            Actor = "Tom Skerritt",
            Race = "Człowiek",
            BirthYear = 2071,
            FunctionCrew = "Dowódca misji, odpowiedzialny za decyzje o lądowaniu i bezpieczeństwie załogi.",
            Profile = "Opanowany, odpowiedzialny, podejmujący trudne decyzje w obliczu zagrożeń.",
            Fate = "Zabity przez obcego w kanałach wentylacyjnych.",
            FunFact = "Planowano alternatywne zakończenie, w którym Dallas przeżywa."
        },

        new CharacterModel
        {
            Name = "Ash",
            Film = "Alien (1979)",
            Role = "Oficer naukowy Nostromo",
            Actor = "Ian Holm",
            Race = "Android (Hyperdyne Systems 120-A/2)",
            BirthYear = 0,
            FunctionCrew = "Analiza sygnałów, badania naukowe.",
            Profile = "Profesjonalny na powierzchni, ukrywa prawdziwe rozkazy korporacji.",
            Fate = "Zniszczony po ujawnieniu swojej misji.",
            FunFact = "Pierwszy android w serii Alien."
        },

        new CharacterModel
        {
            Name = "Bishop",
            Film = "Aliens (1986), Alien³ (1992)",
            Role = "Oficer naukowy, android marines",
            Actor = "Lance Henriksen",
            Race = "Android (Hyperdyne 341-B)",
            BirthYear = 0,
            FunctionCrew = "Analiza danych, wsparcie operacyjne marines.",
            Profile = "Empatyczny, lojalny — przeciwieństwo Asha.",
            Fate = "Uszkodzony przez królową obcych, później dezaktywowany.",
            FunFact = "Bishop zyskał opinię jednego z najbardziej ludzkich androidów w kinie."
        },

        new CharacterModel
        {
            Name = "Jenette Vasquez",
            Film = "Aliens (1986)",
            Role = "Strzelec kolonialnych marines",
            Actor = "Jenette Goldstein",
            Race = "Człowiek",
            BirthYear = 2124,
            FunctionCrew = "Obsługa broni ciężkiej i działań taktycznych.",
            Profile = "Twarda, odważna, zadziorna. Ikona kobiecej siły w sci-fi.",
            Fate = "Poświęca życie, wysadzając korytarz pełen obcych.",
            FunFact = "Postać była inspiracją dla późniejszych bohaterek sci-fi."
        },

        new CharacterModel
        {
            Name = "Rebecca 'Newt' Jorden",
            Film = "Aliens (1986)",
            Role = "Dziecko ocalałe z kolonii",
            Actor = "Carrie Henn",
            Race = "Człowiek",
            BirthYear = 2172,
            FunctionCrew = "Towarzyszka Ripley, pomaga w przetrwaniu.",
            Profile = "Sprytna, odporna psychicznie, mimo młodego wieku.",
            Fate = "Ginęła w katastrofie statku Sulaco (Alien³).",
            FunFact = "Carrie Henn już nigdy więcej nie zagrała w filmie."
        },

        new CharacterModel
        {
            Name = "The Queen Alien",
            Film = "Aliens (1986), Alien: Resurrection (1997)",
            Role = "Królowa ksenomorfów",
            Actor = "Animatronics / efekty praktyczne",
            Race = "Obcy (Xenomorph Queen)",
            BirthYear = 0,
            FunctionCrew = "Matka roju, składanie jaj.",
            Profile = "Inteligentna, agresywna, instynkt macierzyński.",
            Fate = "Zniszczona przez Ripley, później odtworzona z DNA.",
            FunFact = "Model królowej miał ponad 4 metry wysokości."
        },

        new CharacterModel
        {
            Name = "Annalee Call",
            Film = "Alien: Resurrection (1997)",
            Role = "Członkini załogi statku Betty",
            Actor = "Winona Ryder",
            Race = "Android (Auton)",
            BirthYear = 2381,
            FunctionCrew = "Specjalistka ds. technologii i hakowania.",
            Profile = "Empatyczna, z ludzką moralnością.",
            Fate = "Przeżywa i opuszcza Ziemię z Ripley 8.",
            FunFact = "Pierwszy android stworzony przez inne androidy."
        },

        new CharacterModel
        {
            Name = "Ripley 8",
            Film = "Alien: Resurrection (1997)",
            Role = "Klon Ripley z DNA królowej",
            Actor = "Sigourney Weaver",
            Race = "Hybryda człowiek/obcy",
            BirthYear = 2381,
            FunctionCrew = "Pomaga załodze Betty w walce z obcymi.",
            Profile = "Silna, rozdarta między naturą człowieka i obcego.",
            Fate = "Przeżywa, ale nie ufa ludziom ani korporacjom.",
            FunFact = "Ma kwaśną krew i nadludzkie zdolności."
        },

        new CharacterModel
        {
            Name = "The Engineer",
            Film = "Prometheus (2012)",
            Role = "Starożytna istota — stwórca ludzi",
            Actor = "Ian Whyte",
            Race = "Inżynier",
            BirthYear = 0,
            FunctionCrew = "Twórca życia, reprezentant cywilizacji Inżynierów.",
            Profile = "Milczący, majestatyczny, potężny.",
            Fate = "Budzi się i zabija członków misji, potem ginie.",
            FunFact = "Łączy mit stworzenia człowieka z początkiem ksenomorfów."
        },

        new CharacterModel
        {
            Name = "Neomorph",
            Film = "Alien: Covenant (2017)",
            Role = "Forma pośrednia między eksperymentem Davida a ksenomorfem",
            Actor = "CGI",
            Race = "Obcy (mutant)",
            BirthYear = 0,
            FunctionCrew = "Brak — eksperyment Davida.",
            Profile = "Nieprzewidywalny, szybki, biologicznie niestabilny.",
            Fate = "Zabity przez załogę Covenant.",
            FunFact = "Inspirowany 'białym drapieżcą' z natury."
        },

        new CharacterModel
        {
            Name = "Daniels Branson",
            Film = "Alien: Covenant (2017)",
            Role = "Oficer kolonizacyjny",
            Actor = "Katherine Waterston",
            Race = "Człowiek",
            BirthYear = 2100,
            FunctionCrew = "Projektantka kolonii, kieruje terraformacją.",
            Profile = "Odważna, zdeterminowana, pragmatyczna.",
            Fate = "Uśpiona przez Davida podszywającego się pod Waltera.",
            FunFact = "Symbol 'nowego początku' linii bohaterek."
        }

    };

    public ObservableCollection<string> Details { get; } = new();

    
    private CharacterModel? _selectedCharacter;

    public CharacterModel? SelectedCharacter
    {
        get => _selectedCharacter;
        set => this.RaiseAndSetIfChanged(ref _selectedCharacter, value);
    }
    
    public ReactiveCommand<Unit, Unit> ShowDetailsCommand { get; }

    public CharacterWindowViewModel()
    {
        var canShow = this.WhenAnyValue(x => x.SelectedCharacter)
            .Select(game => game != null);
        ShowDetailsCommand = ReactiveCommand.Create(ShowDetails);
    }
    
    private void ShowDetails()
    {
        Details.Clear();

        if (SelectedCharacter == null)
            return;

        Details.Add("Szczegóły postaci:");
        Details.Add(SelectedCharacter.Name);
        Details.Add("");

        Details.Add($"Film: {SelectedCharacter.Film}");
        Details.Add($"Rola: {SelectedCharacter.Role}");
        Details.Add($"Aktor: {SelectedCharacter.Actor}");
        Details.Add($"Rasa / Gatunek: {SelectedCharacter.Race}");
        Details.Add($"Rok urodzenia (fikcyjny): {SelectedCharacter.BirthYear}");
        Details.Add("");

        Details.Add("Funkcja w załodze:");
        Details.Add(SelectedCharacter.FunctionCrew);
        Details.Add("");

        Details.Add("Charakterystyka:");
        Details.Add(SelectedCharacter.Profile);
        Details.Add("");

        Details.Add("Los:");
        Details.Add(SelectedCharacter.Fate);
        Details.Add("");

        Details.Add("Ciekawostka:");
        Details.Add(SelectedCharacter.FunFact);
    }

}