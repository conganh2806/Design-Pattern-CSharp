namespace DesignPatternPractice.Creational.Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Debug.Log("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Debug.Log(" " + page.GetType().Name);
                }
            }
        }
    }

    abstract class Page { }

    class SkillsPage : Page { }

    class EducationPage : Page { }

    class ExperiencePage : Page { }

    class IntroductionPage : Page { }

    class ResultsPage : Page { }

    class ConclusionPage : Page { }

    class SummaryPage : Page { }

    class BibliographyPage : Page { }

    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method
        public abstract void CreatePages();
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Report : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
