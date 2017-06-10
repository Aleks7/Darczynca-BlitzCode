using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
public class Organizations : MonoBehaviour
{

    public Text companyName;
    public Text companyNumber;
    public Text companyLink;
    public Text companyAbout;
    public Image companyImage;
    public Image companyImage2;
    public Image companyImage3;
    public Text popUP;
    public int ShowedPhotoID;

    public static string link;

    private static List<string> Name = new List<string>();
    private static List<string> Link = new List<string>();
    private static List<string> About = new List<string>();
    private static List<string> Price = new List<string>();
    public Sprite[] Image = new Sprite[30];

    private int organization;
    private int org2;
    private int caseSwitch;
    // Use this for initialization
    void Start()
    {
        ShowedPhotoID = 0;
        fillTables();
        Int32.TryParse(Menu.org, out caseSwitch);
        switch (caseSwitch)
        {
            case 0:
                organization = 0;
                org2 = 0;
                break;
            case 1:
                organization = 3;
                org2 = 1;
                break;
            case 2:
                organization = 6;
                org2 = 2;
                break;
            case 3:
                organization = 9;
                org2 = 3;
                break;
            case 4:
                organization = 12;
                org2 = 4;
                break;
            case 5:
                organization = 15;
                org2 = 5;
                break;
            case 6:
                organization = 18;
                org2 = 6;
                break;
            case 7:
                organization = 21;
                org2 = 7;
                break;
            case 8:
                organization = 24;
                org2 = 8;
                break;
            case 9:
                organization = 27;
                org2 = 9;
                break;
            default:
                break;
        }
        Fill();
        popUP.text = "Czy na pewno chcesz wysłać SMS \n(koszt " + Price[org2] + ")?";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToMenu("Menu");
        }
    }

    public void PhotoToRight()
    {
        if (ShowedPhotoID != 2)
        {
            ShowedPhotoID++;
            companyImage.rectTransform.position = new Vector2(companyImage.rectTransform.position.x - 690, companyImage.rectTransform.position.y);
            companyImage2.rectTransform.position = new Vector2(companyImage2.rectTransform.position.x - 690, companyImage2.rectTransform.position.y);
            companyImage3.rectTransform.position = new Vector2(companyImage3.rectTransform.position.x - 690, companyImage3.rectTransform.position.y);

        }
    }

    public void PhotoToLeft()
    {
        if (ShowedPhotoID != 0)
        {
            ShowedPhotoID--;
            companyImage.rectTransform.position = new Vector2(companyImage.rectTransform.position.x + 690, companyImage.rectTransform.position.y);
            companyImage2.rectTransform.position = new Vector2(companyImage2.rectTransform.position.x + 690, companyImage2.rectTransform.position.y);
            companyImage3.rectTransform.position = new Vector2(companyImage3.rectTransform.position.x + 690, companyImage3.rectTransform.position.y);
        }
    }

    public void Fill()
    {
        companyName.text = Name[org2];
        companyLink.text = Link[org2];
        companyAbout.text = About[org2];
        companyImage.sprite = Image[organization];
        companyImage2.sprite = Image[organization + 1];
        companyImage3.sprite = Image[organization + 2];
        link = companyLink.text;
    }

    public void fillTables()
    {
        Name.Add("Fundacja TVN Nie jesteś sam");
        Link.Add("http://fundacja.tvn.pl/");
        About.Add(" „Nie jesteś sam” to hasło, które ma dla nas szczególne znaczenie. To, co robimy, to zespołowa praca darczyńców i Fundacji. Razem możemy czynić wiele dobrego. Wspólnie wsparliśmy do tej pory ok. 20 000 osób, kilkadziesiąt szpitali i instytucji/organizacji pomagających innym. Na pomoc przeznaczyliśmy na łącznie już prawie 224 mln zł.");
        Price.Add("1,23zł");

        Name.Add("Fundacja Polsat Dzieciom");
        Link.Add("http://www.fundacjapolsat.pl/");
        About.Add("Fundacja Polsat, jedna z największych organizacji pozarządowych działających na terenie Polski, od dwudziestu lat kieruje swoją pomoc do chorych dzieci i ich rodziców. Fundacja stworzyła system szybkiej i skutecznej reakcji na prośby o pomoc. Informacje otrzymywane od rodziców są weryfikowane, a następnie ich podania są rozpatrywane według ustalonych kryteriów.Pieniądze przeznaczane są na zabiegi, operacje, terapie i rehabilitacje.Do dziś Fundacja objęła swoją pomocą 30 019 małych pacjentów i wsparła finansowo 1201 szpitali i ośrodków medycznych w całym kraju, które zostały wyremontowane lub wyposażone w nowoczesny sprzęt medyczny.W sumie na cele statutowe Fundacja przekazała dotąd 220 193 624, 11 złotych. Fundusze na prowadzenie działalności pochodzą z ogólnopolskich kampanii, darowizn, dotacji wielu firm i osób prywatnych.");
        Price.Add("6,15zł");

        Name.Add("Europejska Fundacja Honorowego Dawcy Krwi");
        Link.Add("http://krewniacy.pl/");
        About.Add("Krewniacy – Europejska Fundacja Honorowego Dawcy Krwi to organizacja pozarządowa, OPP. Działamy na rzecz promocji idei honorowego krwiodawstwa, transplantologii i zdrowego stylu życia. Twórcami fundacji oraz kampanii Krewniacy są Katarzyna i Marcin Velinov. Każdy z nas może potrzebować krwi, ale nie każdy z nas może krew oddawać. Dlatego KREWNIAK to nie tylko honorowy dawca krwi, to również każdy, kto nie może oddać krwi, a któremu ta idea jest bliska i nieobojętne jest ludzkie życie.To każdy, kto wspiera Honorowe Krwiodawstwo i działania naszej fundacji. Poprzez przekazanie w atrakcyjny sposób właściwej wiedzy o krwiodawstwie i krwiolecznictwie dążymy do stworzenia stabilnego systemu krwiodawstwa, ponieważ stały poziom oddawanej krwi, to bezpieczeństwo nas wszystkich. Krew jest niezastąpionym lekiem, który tylko człowiek może przekazać innemu człowiekowi.");
        Price.Add("2,46zł");

        Name.Add("Unicef Polska");
        Link.Add("http://www.unicef.pl/");
        About.Add("UNICEF to organizacja humanitarna i rozwojowa działająca na rzecz dzieci. Od ratujących życie szczepień, przez budowę szkół, po natychmiastową pomoc w sytuacji klęski humanitarnej - UNICEF robi wszystko, aby dzieciom żyło się lepiej. Pracuje w małych wioskach i z rządami państw, bo uważa, że każde dziecko, niezależnie od miejsca urodzenia, koloru skóry czy religii, ma prawo do zdrowego i bezpiecznego dzieciństwa.");
        Price.Add("2,46zł");

        Name.Add("Mimo wszystko");
        Link.Add("http://www.mimowszystko.org/");
        About.Add("Fundacja Anny Dymnej „Mimo Wszystko” powstała w 2003 r. Posiada status organizacji pożytku publicznego. Głównym naszym celem jest pomoc dorosłym osobom niepełnosprawnym intelektualnie. Wybudowaliśmy i prowadzimy dwa ośrodki terapeutyczno-rehabilitacyjne: „Dolinę Słońca” w podkrakowskich Radwanowicach i Warsztaty Terapii Zajęciowej w nadbałtyckim Lubiatowie. Zajmujemy się także wspieraniem leczenia, rehabilitacji oraz edukacji. Do tej pory pomogliśmy blisko 24 tysiącom osób chorych i niepełnosprawnych w całej Polsce. Funkcję prezesa fundacji Anna Dymna pełni społecznie.");
        Price.Add("4,92zł");

        Name.Add("Fundacja Ewy Błaszczyk \"Akogo ?\"");
        Link.Add("http://www.akogo.pl/");
        About.Add("Fundacja Ewy Błaszczyk „Akogo?”, jest polską organizacją pozarządową, od 15 lat zajmującą się systemowym rozwiązywaniem problemów osób w śpiączce. Gdy rozpoczynaliśmy działalność, w naszym kraju nie istniała systemowa pomoc dla pacjentów po ciężkich urazach mózgu, przebywających w śpiączce. Wybudowaliśmy Klinikę „Budzik” – pierwszy w naszym kraju wzorcowy ośrodek rehabilitacyjny dla dzieci w śpiączce. Mamy tu 15 łóżek dla dzieci w wieku 2-18 lat. Budzik działa od lipca 2013 roku, w tym czasie wybudziło się tu ponad 30 dzieci. Robimy wszystko, aby Klinika świadczyła usługi medyczne na najwyższym, światowym poziomie, z wykorzystaniem rozmaitych, nowatorskich metod leczenia, diagnostyki oraz najszerszego wachlarza metod neurorehabilitacji.");
        Price.Add("6,15zł ");

        Name.Add("Polskie Serce");
        Link.Add("http://polskieserce.pl/");
        About.Add("W 1991 roku profesor Zbigniew Religa powołał do życia Fundację Rozwoju Kardiochirurgii. Dziś - choć Profesora nie ma już wśród nas – kontynuujemy jego dzieło. Nasza Fundacja prowadzi badania, których efektem jest wprowadzanie do praktyki klinicznej najnowocześniejszych metod leczenia, gdy zagrożone jest właśnie serce.");
        Price.Add("2,44zł");

        Name.Add("Ad Gentes");
        Link.Add("http://adgentes.misje.pl/");
        About.Add("Celem Dzieła Pomocy \"Ad Gentes\" jest: \n- wspieranie polskich misjonarzy Kościoła Katolickiego w realizacji ich misji, \n-wspieranie działalności charytatywnej, społecznej i kulturowej na terenach misyjnych w szczególności prowadzonej przez polskich misjonarzy, \n-gromadzenie i upowszechnianie informacji o działalności misjonarzy polskich,\n-animacja misyjna w Polsce,\n-wspieranie działalności na rzecz rozwoju - w szczególności edukacyjnej, w zakresie ochrony zdrowia, służącej redukcji ubóstwa, społecznej i kulturowej na terenach misyjnych, prowadzonej przez polskich misjonarz.");
        Price.Add("2,46zł");

        Name.Add("Fundacja Orange");
        Link.Add("https://fundacja.orange.pl/");
        About.Add("Fundacja Orange działa na rzecz nowoczesnej edukacji dzieci i młodzieży. Poprzez twórcze inicjatywy zachęcamy młodych do zdobywania wiedzy, udziału w kulturze, budowania społeczności przy wykorzystaniu nowych technologii. W ten sposób zyskują liczne kompetencje, w tym kompetencje cyfrowe niezbędne do funkcjonowania w społeczeństwie XXI wieku. Realizujemy autorskie programy oparte na wynikach badań i konsultacjach z ekspertami w danej dziedzinie, takie jak: Bezpiecznie Tu i Tam, MegaMisja, Orange dla Bibliotek, Pracownie Orange i Dźwięki Marzeń. Wspieramy także merytorycznie, organizacyjnie i finansowo projekty innych organizacji. W nasze działania, jako wolontariusze, włączają się pracownicy Orange Polska. ");
        Price.Add("2,46zł");

        Name.Add("Matio Fundacja Pomocy Rodzinom i Chorym na Mukowiscydozę");
        Link.Add("http://www.mukowiscydoza.pl/");
        About.Add("Od 20 lat Fundacja Pomocy Rodzinom i Chorym na Mukowiscydozę opiekuje się chorymi na tą rzadką, nieuleczalną chorobę genetyczną. Mukowiscydoza jest najczęściej występującą chorobą genetyczną u ludzi. Większość z nas nie ma świadomości, że może być nosicielem uszkodzonego genu wywołującego mukowiscydozę. Najczęściej wiedza o tym fakcie przychodzi w momencie urodzenia chorego dziecka. Mukowiscydoza zmienia życia całych rodzin i pozostawia na nich swoje piętno. Fundacja MATIO otacza opieką wszystkich, gdyż wiemy że troska i dobra kondycja psychiczna rodziny ma znaczący wpływ na życie i zdrowie chorego dziecka.");
        Price.Add("2,46zł");
    }

    public void Back()
    {
        ToMenu("Menu");
    }

    public void ToMenu(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
